using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok.src.Beatmap {
    class Utils {
        private static double timeMultiplier = 1.0;
        private static double scoreMultiplier = 1.0;
        private static double ppMultiplier = 0.8;
        // private static double odMultiplier = 1.0;

        public static dynamic CalculateTimeMultiplier(int? mod, double? rate) {
            if ((mod == null && rate != null) || (mod != null && rate != null))
                Utils.timeMultiplier = rate ?? 1.0;
            else {
                if (mod == 64)
                    Utils.timeMultiplier = 1.5;
                else if (mod == 256)
                    Utils.timeMultiplier = 0.75;
                else
                    Utils.timeMultiplier = 1.0;

                return Utils.timeMultiplier;
            }

            return Utils.timeMultiplier;
        }

        public static int CalculateScoreMultiplier(int? mod, int score) {
            if (mod == 1 || mod == 2 || mod == 256)
                Utils.scoreMultiplier = 0.5;
            else
                Utils.scoreMultiplier = 1.0;

            return (int)(score / Utils.scoreMultiplier);
        }

        public static double CalculatePPMultiplier(int? mod) {
            if (mod == 1)
                Utils.ppMultiplier *= 0.9;
            else if (mod == 2)
                Utils.ppMultiplier *= 0.5;
            else
                Utils.ppMultiplier = 0.8;

            return Utils.ppMultiplier;
        }

        public static string ReadLine(string[] lines, string key) {
            string keyLine = lines.First(k => k.Contains($"{key}:"));
            string keyValue = keyLine.Split(':')[1];

            return keyValue;
        }
    }
}
