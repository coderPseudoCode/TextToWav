namespace Notes_to_Audio_Converter
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label5 = new System.Windows.Forms.Label();
            this.rdbtnFile = new System.Windows.Forms.RadioButton();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panRdbtns = new System.Windows.Forms.Panel();
            this.rdbtnLoud = new System.Windows.Forms.RadioButton();
            this.panFloorControls = new System.Windows.Forms.Panel();
            this.panControls = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbReadRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panSettings = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOutputBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panOutput = new System.Windows.Forms.Panel();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.btnInputBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panInput = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnPrev = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.panRdbtns.SuspendLayout();
            this.panFloorControls.SuspendLayout();
            this.panControls.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panSettings.SuspendLayout();
            this.panOutput.SuspendLayout();
            this.panInput.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(574, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Select Read Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbtnFile
            // 
            this.rdbtnFile.AutoSize = true;
            this.rdbtnFile.Location = new System.Drawing.Point(231, 3);
            this.rdbtnFile.Name = "rdbtnFile";
            this.rdbtnFile.Size = new System.Drawing.Size(204, 24);
            this.rdbtnFile.TabIndex = 1;
            this.rdbtnFile.TabStop = true;
            this.rdbtnFile.Text = "Read Text into Audio File";
            this.rdbtnFile.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(259, 81);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(136, 32);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop Reading";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.Lime;
            this.btnStart.Location = new System.Drawing.Point(401, 81);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(170, 32);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start Reading";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Location = new System.Drawing.Point(0, 49);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(574, 20);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panRdbtns
            // 
            this.panRdbtns.Controls.Add(this.rdbtnFile);
            this.panRdbtns.Controls.Add(this.rdbtnLoud);
            this.panRdbtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panRdbtns.Location = new System.Drawing.Point(0, 20);
            this.panRdbtns.Name = "panRdbtns";
            this.panRdbtns.Size = new System.Drawing.Size(574, 29);
            this.panRdbtns.TabIndex = 5;
            // 
            // rdbtnLoud
            // 
            this.rdbtnLoud.AutoSize = true;
            this.rdbtnLoud.Checked = true;
            this.rdbtnLoud.Location = new System.Drawing.Point(36, 3);
            this.rdbtnLoud.Name = "rdbtnLoud";
            this.rdbtnLoud.Size = new System.Drawing.Size(145, 24);
            this.rdbtnLoud.TabIndex = 0;
            this.rdbtnLoud.TabStop = true;
            this.rdbtnLoud.Text = "Read Text Aloud";
            this.rdbtnLoud.UseVisualStyleBackColor = true;
            // 
            // panFloorControls
            // 
            this.panFloorControls.Controls.Add(this.btnStop);
            this.panFloorControls.Controls.Add(this.btnStart);
            this.panFloorControls.Controls.Add(this.lblStatus);
            this.panFloorControls.Controls.Add(this.panRdbtns);
            this.panFloorControls.Controls.Add(this.label5);
            this.panFloorControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFloorControls.Location = new System.Drawing.Point(0, 2);
            this.panFloorControls.Name = "panFloorControls";
            this.panFloorControls.Size = new System.Drawing.Size(574, 116);
            this.panFloorControls.TabIndex = 4;
            // 
            // panControls
            // 
            this.panControls.Controls.Add(this.panel1);
            this.panControls.Controls.Add(this.panFloorControls);
            this.panControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panControls.Location = new System.Drawing.Point(5, 148);
            this.panControls.Name = "panControls";
            this.panControls.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panControls.Size = new System.Drawing.Size(574, 118);
            this.panControls.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 51);
            this.panel3.TabIndex = 3;
            // 
            // cmbName
            // 
            this.cmbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(0, 20);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(346, 28);
            this.cmbName.TabIndex = 2;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Reader Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbReadRate
            // 
            this.cmbReadRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbReadRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReadRate.FormattingEnabled = true;
            this.cmbReadRate.Items.AddRange(new object[] {
            "Slower",
            "Slow",
            "Normal",
            "Fast",
            "Faster"});
            this.cmbReadRate.Location = new System.Drawing.Point(10, 20);
            this.cmbReadRate.Name = "cmbReadRate";
            this.cmbReadRate.Size = new System.Drawing.Size(218, 28);
            this.cmbReadRate.TabIndex = 3;
            this.cmbReadRate.SelectedIndexChanged += new System.EventHandler(this.cmbReadRate_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Reading Rate";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbReadRate);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(346, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(228, 51);
            this.panel4.TabIndex = 4;
            // 
            // panSettings
            // 
            this.panSettings.Controls.Add(this.panel3);
            this.panSettings.Controls.Add(this.panel4);
            this.panSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSettings.Location = new System.Drawing.Point(5, 97);
            this.panSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panSettings.Name = "panSettings";
            this.panSettings.Size = new System.Drawing.Size(574, 51);
            this.panSettings.TabIndex = 6;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.ForeColor = System.Drawing.Color.Silver;
            this.txtOutput.Location = new System.Drawing.Point(0, 20);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(496, 26);
            this.txtOutput.TabIndex = 2;
            // 
            // btnOutputBrowse
            // 
            this.btnOutputBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutputBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOutputBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutputBrowse.Location = new System.Drawing.Point(496, 20);
            this.btnOutputBrowse.Name = "btnOutputBrowse";
            this.btnOutputBrowse.Size = new System.Drawing.Size(78, 26);
            this.btnOutputBrowse.TabIndex = 1;
            this.btnOutputBrowse.Text = "Browse";
            this.btnOutputBrowse.UseVisualStyleBackColor = true;
            this.btnOutputBrowse.Click += new System.EventHandler(this.btnOutputBrowse_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Path to Save File";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panOutput
            // 
            this.panOutput.Controls.Add(this.txtOutput);
            this.panOutput.Controls.Add(this.btnOutputBrowse);
            this.panOutput.Controls.Add(this.label2);
            this.panOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panOutput.Location = new System.Drawing.Point(5, 51);
            this.panOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panOutput.Name = "panOutput";
            this.panOutput.Size = new System.Drawing.Size(574, 46);
            this.panOutput.TabIndex = 5;
            // 
            // txtInputFile
            // 
            this.txtInputFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtInputFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputFile.ForeColor = System.Drawing.Color.Silver;
            this.txtInputFile.Location = new System.Drawing.Point(0, 20);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(496, 26);
            this.txtInputFile.TabIndex = 2;
            // 
            // btnInputBrowse
            // 
            this.btnInputBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInputBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInputBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputBrowse.Location = new System.Drawing.Point(496, 20);
            this.btnInputBrowse.Name = "btnInputBrowse";
            this.btnInputBrowse.Size = new System.Drawing.Size(78, 26);
            this.btnInputBrowse.TabIndex = 1;
            this.btnInputBrowse.Text = "Browse";
            this.btnInputBrowse.UseVisualStyleBackColor = true;
            this.btnInputBrowse.Click += new System.EventHandler(this.btnInputBrowse_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Path to Read File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panInput
            // 
            this.panInput.Controls.Add(this.txtInputFile);
            this.panInput.Controls.Add(this.btnInputBrowse);
            this.panInput.Controls.Add(this.label1);
            this.panInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panInput.Location = new System.Drawing.Point(5, 5);
            this.panInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panInput.Name = "panInput";
            this.panInput.Size = new System.Drawing.Size(574, 46);
            this.panInput.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 0);
            this.panel1.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSearch,
            this.btnPrev,
            this.btnNext});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Size = new System.Drawing.Size(574, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Location = new System.Drawing.Point(0, 33);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(574, 0);
            this.txtData.TabIndex = 7;
            this.txtData.Text = "";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 23);
            this.txtSearch.ToolTipText = "Search";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPrev
            // 
            this.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrev.Image = global::Notes_to_Audio_Converter.Properties.Resources.prev;
            this.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(23, 20);
            this.btnPrev.Text = "toolStripButton7";
            this.btnPrev.ToolTipText = "Previous Search";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = global::Notes_to_Audio_Converter.Properties.Resources.next;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 20);
            this.btnNext.Text = "toolStripButton8";
            this.btnNext.ToolTipText = "Next Search";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(584, 271);
            this.Controls.Add(this.panControls);
            this.Controls.Add(this.panSettings);
            this.Controls.Add(this.panOutput);
            this.Controls.Add(this.panInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Opacity = 0.97D;
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes to Audio Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.panRdbtns.ResumeLayout(false);
            this.panRdbtns.PerformLayout();
            this.panFloorControls.ResumeLayout(false);
            this.panControls.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panSettings.ResumeLayout(false);
            this.panOutput.ResumeLayout(false);
            this.panOutput.PerformLayout();
            this.panInput.ResumeLayout(false);
            this.panInput.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbtnFile;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panRdbtns;
        private System.Windows.Forms.RadioButton rdbtnLoud;
        private System.Windows.Forms.Panel panFloorControls;
        private System.Windows.Forms.Panel panControls;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbReadRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panSettings;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOutputBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panOutput;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Button btnInputBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnPrev;
        private System.Windows.Forms.ToolStripButton btnNext;
    }
}

