using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FFXIV_Savedata_Editor
{
    public partial class frmMain : Form
    {
        private string CommonFilePath;
        Random rnd = new Random();

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\");
            openFileDialog1.Filter = "FFXIV Common File|COMMON.DAT";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CommonFilePath = openFileDialog1.FileName;
            }

            //Fuck adding these one by one. VS PLEASE.
            cmbSelectChatType.Items.Add("Say");
            cmbSelectChatType.Items.Add("Shout");
            cmbSelectChatType.Items.Add("Tell");
            cmbSelectChatType.Items.Add("Party");
            cmbSelectChatType.Items.Add("Alliance");
            cmbSelectChatType.Items.Add("LS1");
            cmbSelectChatType.Items.Add("LS2");
            cmbSelectChatType.Items.Add("LS3");
            cmbSelectChatType.Items.Add("LS4");
            cmbSelectChatType.Items.Add("LS5");
            cmbSelectChatType.Items.Add("LS6");
            cmbSelectChatType.Items.Add("LS7");
            cmbSelectChatType.Items.Add("LS8");
            cmbSelectChatType.Items.Add("FCompany");
            cmbSelectChatType.Items.Add("PvPGroup");
            cmbSelectChatType.Items.Add("PvPGroupAnnounce");
            cmbSelectChatType.Items.Add("Beginner");
            cmbSelectChatType.Items.Add("EmoteUser");
            cmbSelectChatType.Items.Add("Emote");
            cmbSelectChatType.Items.Add("Yell");
            cmbSelectChatType.Items.Add("BeginnerAnnounce");
            cmbSelectChatType.Items.Add("CWLS");
            cmbSelectChatType.Items.Add("CWLS2");
            cmbSelectChatType.Items.Add("CWLS3");
            cmbSelectChatType.Items.Add("CWLS4");
            cmbSelectChatType.Items.Add("CWLS5");
            cmbSelectChatType.Items.Add("CWLS6");
            cmbSelectChatType.Items.Add("CWLS7");
            cmbSelectChatType.Items.Add("CWLS8");
            cmbSelectChatType.Items.Add("AttackSuccess");
            cmbSelectChatType.Items.Add("AttackFailure");
            cmbSelectChatType.Items.Add("Action");
            cmbSelectChatType.Items.Add("Item");
            cmbSelectChatType.Items.Add("CureGive");
            cmbSelectChatType.Items.Add("BuffGive");
            cmbSelectChatType.Items.Add("DebuffGive");
            cmbSelectChatType.Items.Add("Echo");
            cmbSelectChatType.Items.Add("SysMsg");
            cmbSelectChatType.Items.Add("FCAnnounce");
            cmbSelectChatType.Items.Add("SysBattle");
            cmbSelectChatType.Items.Add("SysGathering");
            cmbSelectChatType.Items.Add("SysErr");
            cmbSelectChatType.Items.Add("NpcSay");
            cmbSelectChatType.Items.Add("ItemNotice");
            cmbSelectChatType.Items.Add("Growup");
            cmbSelectChatType.Items.Add("Loot");
            cmbSelectChatType.Items.Add("Craft");
            cmbSelectChatType.Items.Add("Gathering");
            cmbSelectChatType.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectColorAndSave("ColorSay");
        }

        public string GetValueFromCommon(string ValueToGet)
        {
            using (StreamReader reader = new StreamReader(new FileStream(CommonFilePath, FileMode.Open)))
            {
                string CurrentLine;
                while ((CurrentLine = reader.ReadLine()) != null)
                {
                    if (CurrentLine.Contains(ValueToGet))
                    {
                        string[] CurrentLineSplit = CurrentLine.Split('\t');
                        return CurrentLineSplit[1];
                    }
                }
            }
            return "ERROR";
        }

        public void SelectColorAndSave(string ValueToReplace)
        {
            DialogResult result = CD1.ShowDialog();
            // See if user pressed ok.

            if (result != DialogResult.OK) { return; }
            // Set form background to the selected color.
            //this.BackColor = colorDialog1.Color;
            string HexColorCode = (CD1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            int DecimalColorCode = Convert.ToInt32(HexColorCode, 16);
            string CurrentCommonFile = "";
            using (StreamReader reader = new StreamReader(new FileStream(CommonFilePath, FileMode.Open)))
            {
                string CurrentLine;
                while ((CurrentLine = reader.ReadLine()) != null)
                {
                    if (CurrentLine.Contains(ValueToReplace))
                    {
                        CurrentCommonFile += ValueToReplace + "\t" + DecimalColorCode + Environment.NewLine;
                    }
                    else
                    {
                        CurrentCommonFile += CurrentLine + Environment.NewLine;
                    }
                }
            }
            File.WriteAllText(CommonFilePath, CurrentCommonFile);
        }

        private void cmbSelectChatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(int.Parse(GetValueFromCommon("Color" + cmbSelectChatType.Text)).ToString());
            long number = Convert.ToInt64((GetValueFromCommon("Color" + cmbSelectChatType.Text)));
            string hex = number.ToString("x");

            Color WTF = ColorTranslator.FromHtml("#" + hex.ToUpper());
            txtPreview.ForeColor = Color.FromArgb(WTF.R, WTF.G, WTF.B); ;
            //txtPreview.ForeColor = ColorTranslator.FromHtml("#" + hex.ToUpper());
            if (cmbSelectChatType.Text != "Tell")
            {
                switch(rnd.Next(0,7))
                {
                    case 0:
                        txtPreview.Text = "Aida Enna: " + "Never mind...";
                        break;
                    case 1:
                        txtPreview.Text = "Aida Enna: " + "Aeriiiiith!";
                        break;
                    case 2:
                        txtPreview.Text = "Aida Enna: " + "Can someone give me some gil?";
                        break;
                    case 3:
                        txtPreview.Text = "Aida Enna: " + "Where is everybody?";
                        break;
                    case 4:
                        txtPreview.Text = "Aida Enna: " + "Can I invite my friend, Zack?";
                        break;
                    case 5:
                        txtPreview.Text = "Aida Enna: " + "You guys seen Hojo anywhere?";
                        break;
                    case 6:
                        txtPreview.Text = "Aida Enna: " + "Do I have time to grab my gunblade?";
                        break;
                    case 7:
                        txtPreview.Text = "Aida Enna: " + "Follow me.";
                        break;
                }                
            }
            else
            {
                txtPreview.Text = ">> Cloud Strife: Nice Shirt." + Environment.NewLine + "Aida Enna >> Eyes up here, Cloud.";
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            SelectColorAndSave("Color" + cmbSelectChatType.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\");
            openFileDialog1.Filter = "FFXIV Data File|*.DAT";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ArrayList openArray = new ArrayList();
                ArrayList closeArray = new ArrayList();

                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))

                {
                    using (StreamReader sr = new StreamReader(fs))

                    {
                        while (!sr.EndOfStream)

                        {
                            openArray.Add(sr.ReadLine());
                        }

                        sr.Close();
                    }

                    fs.Close();
                }

                //==========================END OPEN FILE FUNCTION================================

                //==========================Encrypt and add to second array=======================

                foreach (string line2 in openArray)

                {
                    closeArray.Add(EncryptDecrypt(line2, 0x73));
                }

                //==========================END Encrypt and add to second array===================

                //==========================Save Encrypted Array To File==========================

                TextWriter tw = new StreamWriter("temp.txt");

                foreach (string encoded in closeArray)

                {
                    tw.WriteLine(encoded);
                }

                tw.Close();

                Process.Start("temp.txt");
            }
        }

        public string EncryptDecrypt(string szPlainText, int szEncryptionKey)
        {
            StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            char Textch;
            for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }
    }
}