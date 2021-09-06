using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LSTDICT = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, dynamic>>;
using STRDICT = System.Collections.Generic.Dictionary<string, dynamic>;

#nullable enable

namespace Ragnarok.src.Beatmap {
    class Calculator : Utils {
        private readonly Parser parser;
        private readonly string file;
        private readonly int score;
        private readonly int? mod;
        private readonly double? rate;

        public Calculator(
            string file,
            int score,
            int? mod = null,
            double? rate = null
        ) {
            this.parser = new(file);
            this.file = @file;
            this.score = score;
            this.mod = mod;
            this.rate = rate;
        }

        public double CalculateStars() {
            short keys = short.Parse(this.parser.ParseMetadata()?["cs"]);
            double timeMultiplier = Utils.CalculateTimeMultiplier(this.mod, this.rate);
            double strainStep = 400 * timeMultiplier;

            const double weightDecayBase = 0.90;
            const double individualDecayBase = 0.125;
            const double overallDecayBase = 0.30;
            const double starScalingFactor = 0.018;

            double[] heldUntil = Enumerable.Repeat<double>(0, 7).ToArray();
            STRDICT? previousNote = null;
            LSTDICT objects = this.parser.ParseObjects();

            foreach (STRDICT note in objects) {
                if (previousNote == null)
                    previousNote = note;

                double timeElapsed = (note["start_time"] - previousNote["start_time"]) / timeMultiplier / 1_000;
                double individualDecay = Math.Pow(individualDecayBase, timeElapsed);
                double overallDecay = Math.Pow(overallDecayBase, timeElapsed);

                const int addition = 1;
                double holdFactor = 1;
                double holdAddition = 0;

                for (var i = 0; i < keys; i++) {
                    if (note["start_time"] < heldUntil[i] && note["end_time"] > heldUntil[i])
                        holdAddition = 1;
                    else if (note["end_time"] == heldUntil[i])
                        holdAddition = 0;
                    else if (note["end_time"] < heldUntil[i])
                        holdFactor = 1.25;

                    note["individual_strain"][i] = previousNote["individual_strain"][i] * individualDecay;
                }

                heldUntil[note["column"]] = note["end_time"];
                note["individual_strain"][note["column"]] += 2 * holdFactor;
                note["overall_strain"] = previousNote["overall_strain"] * overallDecay + (addition + holdAddition) * holdFactor;

                previousNote = note;
            }

            List<double> strainTable = new();
            double maxStrain = 0;
            double intervalEndTime = strainStep;

            previousNote = null;

            foreach (STRDICT note in objects) {
                while (note["start_time"] > intervalEndTime) {
                    strainTable.Add(maxStrain);

                    if (previousNote == null)
                        maxStrain = 0;
                    else {
                        double individualDecay = Math.Pow(individualDecayBase, (intervalEndTime - previousNote["start_time"]) / 1_000);
                        double overallDecay = Math.Pow(overallDecayBase, (intervalEndTime - previousNote["start_time"]) / 1_000);
                        maxStrain = previousNote["individual_strain"][previousNote["column"]] * individualDecay + previousNote["overall_strain"] * overallDecay;
                    }

                    intervalEndTime += strainStep;
                }

                double strain = note["individual_strain"][note["column"]] + note["overall_strain"];

                if (strain > maxStrain)
                    maxStrain = strain;

                previousNote = note;
            }

            double difficulty = 0;
            double weight = 1;

            strainTable.Sort();
            strainTable.Reverse();

            foreach (var strain in strainTable) {
                difficulty += strain * weight;
                weight *= weightDecayBase;
            }

            return difficulty * starScalingFactor;
        }

        public double CalculatePP() {
            const int KKK = 100_000;

            int scoreMultiplier = Utils.CalculateScoreMultiplier(this.mod, this.score);
            double ppMultiplier = Utils.CalculatePPMultiplier(this.mod);

            double strainValue = Math.Pow(5.0 * Math.Max(1.0, this.CalculateStars() / 0.2) - 4.0, 2.2) / 135.0;
            strainValue *= 1 + 0.1 * Math.Min(1.0, this.parser.ParseObjects().Count / 1500.0);

            switch (scoreMultiplier) {
                case <= 500_000:
                    strainValue = 0;
                    break;
                case <= 600_000:
                    strainValue *= (scoreMultiplier - 500_000) / KKK * 0.3;
                    break;
                case <= 700_000:
                    strainValue *= 0.3 + (scoreMultiplier - 600_000) / KKK * 0.25;
                    break;
                case <= 800_000:
                    strainValue *= 0.55 + (scoreMultiplier - 700_000) / KKK * 0.20;
                    break;
                case <= 900_000:
                    strainValue *= 0.75 + (scoreMultiplier - 800_000) / KKK * 0.15;
                    break;
                default:
                    strainValue *= 0.90 + (scoreMultiplier - 900_000) / KKK * 0.1;
                    break;
            }

            double perfectWindow = 34 + 3 * Math.Min(10, Math.Max(0, 10 - short.Parse(this.parser.ParseMetadata()?["od"])));
            double accuracyValue;

            if (perfectWindow <= 0)
                accuracyValue = 0;
            else {
                accuracyValue = Math.Max(0.0, 0.2 - ((perfectWindow - 34) * 0.006667)) * strainValue;
                accuracyValue *= Math.Pow(Math.Max(0.0, scoreMultiplier - 960_000) / 40_000.0, 1.1);
            }

            double totalValue = Math.Pow(Math.Pow(strainValue, 1.1) + Math.Pow(accuracyValue, 1.1), 1 / 1.1) * ppMultiplier;

            return totalValue;
        }
    }
}
