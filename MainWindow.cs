using System;
using System.IO;
using System.Text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using iTextSharp.text.pdf.parser;
using System.Speech.Synthesis;
using System.Drawing;

namespace Notes_to_Audio_Converter
{
    public partial class MainWindow : Form
    {
        private SpeechSynthesizer speaker = new SpeechSynthesizer();
        public MainWindow()
        {
            InitializeComponent();

            speaker.SpeakProgress += Speaker_SpeakProgress;
            speaker.SpeakCompleted += Speaker_SpeakCompleted;

            InitialiseCombos();
        }

        private void Speaker_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                lblStatus.ForeColor = Color.Lime;
                if (rdbtnFile.Checked)
                {
                    lblStatus.Text = "Status: Writing Completed! Check Location for File";
                }
                else
                {
                    lblStatus.Text = "Status: Reading Completed Successfully";
                }
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Status: Reading was Cancelled";
            }
            EnableControls();
            btnStop.Enabled = false;
            btnStart.Text = "Start Reading";
        }

        private void InitialiseCombos()
        {
            foreach (var voice in speaker.GetInstalledVoices())
            {
                if (!cmbName.Items.Contains(voice.VoiceInfo.Name))
                    cmbName.Items.Add(voice.VoiceInfo.Name);
            }
            if (cmbName.Items.Count > 0)
                cmbName.SelectedIndex = 0;
            if (cmbReadRate.Items.Count > 0)
                cmbReadRate.SelectedIndex = 2;
        }

        private void Speaker_SpeakProgress(object sender, SpeakProgressEventArgs e)
        {
            txtData.Focus();
            lblStatus.ForeColor = Color.SkyBlue;
            if (rdbtnFile.Checked)
            {
                lblStatus.Text = "Status: Writing in Progress! Please Wait";
            }
            else
            {
                lblStatus.Text = "Status: Reading in Progress! Please Wait";
            }
            DisableControls();
            txtData.Select(e.CharacterPosition, e.CharacterCount);
        }

        void DisableControls()
        {
            panInput.Enabled = false;
            panOutput.Enabled = false;
            panRdbtns.Enabled = false;
            panSettings.Enabled = false;
        }

        void EnableControls()
        {
            panInput.Enabled = true;
            panOutput.Enabled = true;
            panRdbtns.Enabled = true;
            panSettings.Enabled = true;
        }

        private void btnInputBrowse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputFile.Text))
                Height = 310;
            OpenFileDialog brw = new OpenFileDialog();
            brw.Filter = "Supported Files|*.pdf;*.rtf;*.txt";
            brw.Title = "Select File";
            if (brw.ShowDialog().Equals(DialogResult.OK))
            {
                FileInfo file = new FileInfo(brw.FileName);
                ReadFile(file);
                Height = 600;
                txtInputFile.Text = file.Name;
            }
        }

        private void ReadFile(FileInfo fileInfo)
        {
            string content = string.Empty;
            if (fileInfo.Extension.Equals(".pdf"))
            {
                content = ProcessPDF(fileInfo.FullName);
            }
            else if (fileInfo.Extension.Equals(".rtf"))
            {
                content = ProcessRTF(fileInfo.FullName);
            }
            else
            {
                content = ProcessOther(fileInfo.FullName);
            }

            txtData.Text = content;
        }

        private string ProcessOther(string fullName)
        {
            return File.ReadAllText(fullName);
        }

        private string ProcessPDF(string fullName)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using(PdfReader reader =new PdfReader(fullName))
            {
                for(int i = 1; i <= reader.NumberOfPages; i++)
                {
                    stringBuilder.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }
            return stringBuilder.ToString();
        }

        private string ProcessRTF(string fullName)
        {
            RichTextBox rch = new RichTextBox();
            rch.LoadFile(fullName);
            return rch.Text;
        }

        private void btnOutputBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog sav = new SaveFileDialog();
            sav.Title = "Save Here";
            sav.Filter = "Audio File|*.wav";
            if (sav.ShowDialog().Equals(DialogResult.OK))
            {
                txtOutput.Text = sav.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text.Equals("Start Reading"))
            {
                if (string.IsNullOrEmpty(txtData.Text))
                {
                    speaker.Speak("Nothing to Speak! Specify data please");
                }
                else
                {
                    if (rdbtnFile.Checked)
                    {
                        if (!string.IsNullOrEmpty(txtOutput.Text))
                        {
                            FileStream fs = File.Create(txtOutput.Text);
                            fs.Close();
                            speaker.SetOutputToWaveFile(txtOutput.Text);
                            speaker.SpeakAsync(txtData.Text);
                            btnStop.Enabled = true;

                            btnStart.Text = "Pause Reading";
                        }
                        else
                            MessageBox.Show("Select a File to save to!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        speaker.SetOutputToDefaultAudioDevice();
                        speaker.SpeakAsync(txtData.Text);
                        btnStop.Enabled = true;

                        btnStart.Text = "Pause Reading";
                    }
                }
            }
            else if (btnStart.Text.Equals("Pause Reading"))
            {
                btnStart.Text = "Resume Reading";
                speaker.Pause();
            }
            else
            {
                btnStart.Text = "Pause Reading";
                speaker.Resume();
            }
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            speaker.SelectVoice(cmbName.Text);
        }

        private void cmbReadRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            speaker.Rate = cmbReadRate.SelectedIndex;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            speaker.SpeakAsyncCancelAll();
            btnStop.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtData.Find(txtSearch.Text);
            txtData.Focus();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }
    }
}
