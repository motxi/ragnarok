
namespace Ragnarok {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpBeatmap = new System.Windows.Forms.GroupBox();
            this.tabBeatmapInfo = new System.Windows.Forms.DataGridView();
            this.txtBeatmapPath = new System.Windows.Forms.TextBox();
            this.btnBrowseBeatmap = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkRateLimit = new System.Windows.Forms.CheckBox();
            this.chkScoreLimit = new System.Windows.Forms.CheckBox();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.lblRateTitle = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.btnCalculatePP = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPP = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBeatmap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabBeatmapInfo)).BeginInit();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPP.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBeatmap
            // 
            this.grpBeatmap.Controls.Add(this.tabBeatmapInfo);
            this.grpBeatmap.Controls.Add(this.txtBeatmapPath);
            this.grpBeatmap.Controls.Add(this.btnBrowseBeatmap);
            this.grpBeatmap.Location = new System.Drawing.Point(6, 6);
            this.grpBeatmap.Name = "grpBeatmap";
            this.grpBeatmap.Size = new System.Drawing.Size(424, 254);
            this.grpBeatmap.TabIndex = 0;
            this.grpBeatmap.TabStop = false;
            this.grpBeatmap.Text = "Beatmap";
            // 
            // tabBeatmapInfo
            // 
            this.tabBeatmapInfo.AllowUserToAddRows = false;
            this.tabBeatmapInfo.AllowUserToDeleteRows = false;
            this.tabBeatmapInfo.AllowUserToResizeColumns = false;
            this.tabBeatmapInfo.AllowUserToResizeRows = false;
            this.tabBeatmapInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabBeatmapInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabBeatmapInfo.Location = new System.Drawing.Point(6, 53);
            this.tabBeatmapInfo.Name = "tabBeatmapInfo";
            this.tabBeatmapInfo.ReadOnly = true;
            this.tabBeatmapInfo.RowHeadersWidth = 40;
            this.tabBeatmapInfo.RowTemplate.Height = 25;
            this.tabBeatmapInfo.Size = new System.Drawing.Size(412, 195);
            this.tabBeatmapInfo.TabIndex = 2;
            // 
            // txtBeatmapPath
            // 
            this.txtBeatmapPath.Location = new System.Drawing.Point(87, 23);
            this.txtBeatmapPath.Name = "txtBeatmapPath";
            this.txtBeatmapPath.Size = new System.Drawing.Size(331, 23);
            this.txtBeatmapPath.TabIndex = 1;
            this.txtBeatmapPath.Text = "Select a valid .osu beatmap file...";
            // 
            // btnBrowseBeatmap
            // 
            this.btnBrowseBeatmap.Location = new System.Drawing.Point(6, 22);
            this.btnBrowseBeatmap.Name = "btnBrowseBeatmap";
            this.btnBrowseBeatmap.Size = new System.Drawing.Size(75, 25);
            this.btnBrowseBeatmap.TabIndex = 0;
            this.btnBrowseBeatmap.Text = "Browse";
            this.btnBrowseBeatmap.UseVisualStyleBackColor = true;
            this.btnBrowseBeatmap.Click += new System.EventHandler(this.BrowseBeatmap_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkRateLimit);
            this.grpOptions.Controls.Add(this.chkScoreLimit);
            this.grpOptions.Controls.Add(this.numRate);
            this.grpOptions.Controls.Add(this.numScore);
            this.grpOptions.Controls.Add(this.lblRateTitle);
            this.grpOptions.Controls.Add(this.lblScoreTitle);
            this.grpOptions.Location = new System.Drawing.Point(6, 266);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(424, 75);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkRateLimit
            // 
            this.chkRateLimit.AutoSize = true;
            this.chkRateLimit.Location = new System.Drawing.Point(148, 48);
            this.chkRateLimit.Name = "chkRateLimit";
            this.chkRateLimit.Size = new System.Drawing.Size(114, 19);
            this.chkRateLimit.TabIndex = 5;
            this.chkRateLimit.Text = "Disable rate limit";
            this.chkRateLimit.UseVisualStyleBackColor = true;
            this.chkRateLimit.CheckedChanged += new System.EventHandler(this.RateLimit_CheckedChanged);
            // 
            // chkScoreLimit
            // 
            this.chkScoreLimit.AutoSize = true;
            this.chkScoreLimit.Location = new System.Drawing.Point(148, 19);
            this.chkScoreLimit.Name = "chkScoreLimit";
            this.chkScoreLimit.Size = new System.Drawing.Size(122, 19);
            this.chkScoreLimit.TabIndex = 4;
            this.chkScoreLimit.Text = "Disable score limit";
            this.chkScoreLimit.UseVisualStyleBackColor = true;
            this.chkScoreLimit.CheckedChanged += new System.EventHandler(this.ScoreLimit_CheckedChanged);
            // 
            // numRate
            // 
            this.numRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numRate.DecimalPlaces = 2;
            this.numRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numRate.Location = new System.Drawing.Point(48, 46);
            this.numRate.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            this.numRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(94, 23);
            this.numRate.TabIndex = 3;
            this.numRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRate.ThousandsSeparator = true;
            this.numRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // numScore
            // 
            this.numScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numScore.Location = new System.Drawing.Point(48, 17);
            this.numScore.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numScore.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(94, 23);
            this.numScore.TabIndex = 2;
            this.numScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numScore.ThousandsSeparator = true;
            this.numScore.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // lblRateTitle
            // 
            this.lblRateTitle.AutoSize = true;
            this.lblRateTitle.Location = new System.Drawing.Point(6, 48);
            this.lblRateTitle.Name = "lblRateTitle";
            this.lblRateTitle.Size = new System.Drawing.Size(30, 15);
            this.lblRateTitle.TabIndex = 1;
            this.lblRateTitle.Text = "Rate";
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.Location = new System.Drawing.Point(6, 19);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(36, 15);
            this.lblScoreTitle.TabIndex = 0;
            this.lblScoreTitle.Text = "Score";
            // 
            // btnCalculatePP
            // 
            this.btnCalculatePP.Enabled = false;
            this.btnCalculatePP.Location = new System.Drawing.Point(6, 348);
            this.btnCalculatePP.Name = "btnCalculatePP";
            this.btnCalculatePP.Size = new System.Drawing.Size(424, 38);
            this.btnCalculatePP.TabIndex = 2;
            this.btnCalculatePP.Text = "Calculate Performance Points";
            this.btnCalculatePP.UseVisualStyleBackColor = true;
            this.btnCalculatePP.Click += new System.EventHandler(this.CalculatePP_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPP);
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(445, 425);
            this.tabControl.TabIndex = 3;
            // 
            // tabPP
            // 
            this.tabPP.Controls.Add(this.grpBeatmap);
            this.tabPP.Controls.Add(this.btnCalculatePP);
            this.tabPP.Controls.Add(this.grpOptions);
            this.tabPP.Location = new System.Drawing.Point(4, 24);
            this.tabPP.Name = "tabPP";
            this.tabPP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPP.Size = new System.Drawing.Size(437, 397);
            this.tabPP.TabIndex = 0;
            this.tabPP.Text = "PP";
            this.tabPP.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.label1);
            this.tabAbout.Location = new System.Drawing.Point(4, 24);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(437, 397);
            this.tabAbout.TabIndex = 1;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(399, 175);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 449);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Ragnarok (v1.0.0 Alpha)";
            this.grpBeatmap.ResumeLayout(false);
            this.grpBeatmap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabBeatmapInfo)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPP.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBeatmap;
        private System.Windows.Forms.DataGridView tabBeatmapInfo;
        private System.Windows.Forms.TextBox txtBeatmapPath;
        private System.Windows.Forms.Button btnBrowseBeatmap;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkRateLimit;
        private System.Windows.Forms.CheckBox chkScoreLimit;
        private System.Windows.Forms.NumericUpDown numRate;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.Label lblRateTitle;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Button btnCalculatePP;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPP;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label label1;
    }
}

