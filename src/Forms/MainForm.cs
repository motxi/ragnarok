using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Ragnarok.src.Beatmap;

namespace Ragnarok {
    public partial class MainForm : Form {
        private Parser parser;
        private string beatmapPath;
        private string beatmapFile;

        public MainForm() {
            InitializeComponent();
        }

        private void BrowseBeatmap_Click(object sender, EventArgs e) {
            string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "osu!");

            OpenFileDialog openBeatmap = new OpenFileDialog {
                Title = "Select a beatmap file",
                Multiselect = false,
                InitialDirectory = defaultPath,
                Filter = "osu file (*.osu)|*.osu"
            };

            if (openBeatmap.ShowDialog() == DialogResult.OK) {
                beatmapPath = openBeatmap.FileName;
                beatmapFile = openBeatmap.SafeFileName;

                txtBeatmapPath.Text = beatmapPath;

                parser = new(beatmapPath);

                tabBeatmapInfo.DataSource = new BindingSource(parser.ParseMetadata(), null);
                btnCalculatePP.Enabled = true;
                this.Text += $" - {beatmapFile}";
            }
        }

        private void ScoreLimit_CheckedChanged(object sender, EventArgs e) {
            if (chkScoreLimit.Checked) {
                numScore.Minimum = 0;
                numScore.Maximum = int.MaxValue;
            }

            else {
                numScore.Minimum = 500_000;
                numScore.Maximum = 1_000_000;
            }
        }

        private void RateLimit_CheckedChanged(object sender, EventArgs e) {
            if (chkRateLimit.Checked) {
                numRate.Minimum = 0.1M;
                numRate.Maximum = decimal.MaxValue;
            }

            else {
                numRate.Minimum = 0.5M;
                numRate.Maximum = 2.0M;
            }
        }

        private void CalculatePP_Click(object sender, EventArgs e) {
            Calculator calculator = new(
                file: beatmapPath,
                score: (int)numScore.Value,
                mod: null,
                rate: (double)numRate.Value
            );

            // Basic functionality
            MessageBox.Show(calculator.CalculatePP().ToString());
        }

    }
}
