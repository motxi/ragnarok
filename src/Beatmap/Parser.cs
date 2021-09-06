using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

using LSTDICT = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, dynamic>>;
using STRDICT = System.Collections.Generic.Dictionary<string, dynamic>;

#nullable enable

namespace Ragnarok.src.Beatmap {
    class Parser : Utils {
        private readonly string file;

        public Parser(string file) => this.file = file;

        public STRDICT? ParseMetadata() {
            string[] lines = File.ReadAllLines(@file);

            if (short.Parse(ReadLine(lines, "Mode")) == 3) {
                STRDICT data = new() {
                    { "audio_filename", Utils.ReadLine(lines, "AudioFilename") },
                    { "mode", Utils.ReadLine(lines, "Mode") },
                    { "title", Utils.ReadLine(lines, "Title") },
                    { "artist", Utils.ReadLine(lines, "Artist") },
                    { "title_unicode", Utils.ReadLine(lines, "TitleUnicode") },
                    { "artist_unicode", Utils.ReadLine(lines, "ArtistUnicode") },
                    { "mapper", Utils.ReadLine(lines, "Creator") },
                    { "difficulty", Utils.ReadLine(lines, "Version") },
                    { "cs", Utils.ReadLine(lines, "CircleSize") },
                    { "hp", Utils.ReadLine(lines, "HPDrainRate") },
                    { "od", Utils.ReadLine(lines, "OverallDifficulty") },
                };

                return data;
            }

            return null;
        }

        public LSTDICT ParseObjects() {
            LSTDICT objects = new();

            short keys = short.Parse(this.ParseMetadata()?["cs"]);
            string[] lines = File.ReadAllLines(@file);
            string section = "";

            for (int i = 0; i < lines.Length; i++) {
                if (lines[i].StartsWith("[") && lines[i].EndsWith("]"))
                    section = lines[i];

                else if (section.Equals("[HitObjects]")) {
                    Regex expression = new(@"(\d+),\d+,(\d+),\d+,\d+,(\d+)");
                    Match match = expression.Match(lines[i]);

                    long startTime = long.Parse(match.Groups[2].Value);
                    long endTime;

                    if (long.Parse(match.Groups[3].Value) <= 0)
                        endTime = startTime;
                    else
                        endTime = long.Parse(match.Groups[3].Value);

                    STRDICT objectDict = new() {
                        { "column", long.Parse(match.Groups[1].Value) * keys / 512 },
                        { "start_time", startTime },
                        { "end_time", endTime },
                        { "overall_strain", 1 },
                        { "individual_strain", Enumerable.Repeat<double>(0, keys).ToArray() }
                    };

                    objects.Add(objectDict);
                }
            }

            return objects;
        }
    }
}
