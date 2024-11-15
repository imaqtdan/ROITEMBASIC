﻿using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace ROITEMBASIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cb1.Text = "Upper";
            cb2.Text = "1";
            cb3.Text = "0";
            tb3.Text = "0";
            tb4.Text = "0";
            t4.Hide();
            t5.Hide();
        }

        private void func1()
        {
            string directoryPath = Path.Combine(Application.StartupPath, "generated");

            // Check if the directory exists, if not, create it
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Now, create StreamWriter instances for the files
            string accessoryFilePath = Path.Combine(directoryPath, "accessoryid.txt");
            string accnameFilePath = Path.Combine(directoryPath, "accname.txt");

            using (StreamWriter A = new StreamWriter(accessoryFilePath))
            using (StreamWriter B = new StreamWriter(accnameFilePath))
            {
                int inum = Convert.ToInt32(tb1.Text);

                try
                {
                    for (int i = 0; i < t1.Lines.Length; i++)
                    {
                        int vid = inum + i;
                        A.WriteLine("    ACCESSORY_" + t1.Lines[i].TrimStart('_') + " = " + vid + ",");
                        B.WriteLine("    [ACCESSORY_IDs.ACCESSORY_" + t1.Lines[i].TrimStart('_') + "] = \"_" + t1.Lines[i].TrimStart('_') + "\",");
                    }

                    //MessageBox.Show(
                    //    "accessoryid.txt and accname.txt Generating Success.",
                    //    "Generating Complete.",
                    //    MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
                    label11.Text = "Status : accessoryid.txt and accname.txt Generating Success.";
                }
                catch (IOException ex1)
                {
                    // Handle IOException
                    MessageBox.Show("Error: " + ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void func2()
        {
            StreamWriter C = new StreamWriter(Application.StartupPath + "\\generated\\" + "itemInfo.lua");
            int idnum = Convert.ToInt32(tb2.Text);


            try
            {
                for (int i = 0; i < t2.Lines.Length; i++)
                {
                    int idnum2 = idnum + i;
                    C.WriteLine("[" + idnum2 + "] = {");
                    C.WriteLine("		unidentifiedDisplayName = \"Unidentified Mask\",");
                    C.WriteLine("		unidentifiedResourceName = \"마스크\",");
                    C.WriteLine("		unidentifiedDescriptionName = { \"Can be identified by using a ^990099Magnifier ^ 000000.\" },");
                    if (ch1.Checked)
                    {
                        C.WriteLine("		identifiedDisplayName = \"Costume " + t2.Lines[i] + "\",");
                    }
                    else
                    {
                        C.WriteLine("		identifiedDisplayName = \"" + t2.Lines[i] + "\",");
                    }
                    C.WriteLine("		identifiedResourceName = \"" + t1.Lines[i] + "\",");
                    C.WriteLine("		identifiedDescriptionName = {");
                    for (int i2 = 0; i2 < t3.Lines.Length; i2++)
                    {
                        C.WriteLine("			\"" + t3.Lines[i2] + "\",");
                    }
                    if (ch3.Checked)
                    {
                        C.WriteLine("			\"_______________________\",");
                        for (int i3 = 0; i3 < t4.Lines.Length; i3++)
                        {
                            C.WriteLine("			\"" + t4.Lines[i3] + "\",");
                        }
                    }
                    C.WriteLine("			\"_______________________\",");
                    if (ch1.Checked)
                    {
                        C.WriteLine("			\"^0000CCType: ^000000 Costume\",");
                    }
                    else
                    {
                        C.WriteLine("			\"^0000CCType: ^000000 Headgear\",");
                    }
                    C.WriteLine("			\"^0000CCDefense: ^000000 " + tb3.Text + "\",");
                    C.WriteLine("			\"^0000CCPosition: ^000000 " + cb1.Text + "\",");
                    C.WriteLine("			\"^0000CCWeight: ^000000 " + tb4.Text + "\",");
                    if (!ch1.Checked)
                    {
                        C.WriteLine("			\"^0000CCArmor Level: ^000000 " + cb2.Text + "\",");
                        if (ch2.Checked)
                        {
                            C.WriteLine("			\"^0000CCRefineable: ^000000 Yes\",");
                        }
                        else
                        {
                            C.WriteLine("			\"^0000CCRefineable: ^000000 No\",");
                        }
                    }
                    C.WriteLine("			\"_______________________\",");
                    C.WriteLine("			\"^0000CCRequirement: ^000000 None\"");
                    C.WriteLine("		},");
                    C.WriteLine("		slotCount = " + cb3.Text + ",");
                    C.WriteLine("		ClassNum = 0,");
                    if (ch1.Checked)
                    {
                        C.WriteLine("		costume = true");
                    }
                    else
                    {
                        C.WriteLine("		costume = false");
                    }
                    C.WriteLine("	},");

                }
                C.Close();
                label11.Text = "Status : itemInfo.lua Generating Success.";
            }
            catch (IOException ex2)
            {
                MessageBox.Show(
                "Error",
                "Error Error Error Error Error Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void func3()
        {
            StreamWriter D = new StreamWriter(Application.StartupPath + "\\generated\\" + "item_db_equip.yml");
            int idnum = Convert.ToInt32(tb2.Text);
            int inum = Convert.ToInt32(tb1.Text);
            try
            {
                for (int i = 0; i < t2.Lines.Length; i++)
                {
                    int idnum2 = idnum + i;
                    int vid = inum + i;
                    D.WriteLine("  - Id: " + idnum2);
                    if (ch1.Checked)
                    {
                        D.WriteLine("    AegisName: Costume " + t2.Lines[i]);
                        D.WriteLine("    Name: Costume " + t2.Lines[i]);
                    }
                    else
                    {
                        D.WriteLine("    AegisName: " + t2.Lines[i]);
                        D.WriteLine("    Name: " + t2.Lines[i]);
                    }
                    D.WriteLine("    Type: Armor");
                    if (tb4.Text != "0")
                    {
                        D.WriteLine("    Weight: " + tb4.Text + 0);
                    }
                    if (tb3.Text != "0")
                    {
                        D.WriteLine("    Defense: " + tb3.Text);
                    }
                    if (cb3.Text != "0")
                    {
                        D.WriteLine("    Slots: " + cb3.Text);
                    }
                    D.WriteLine("    Locations:");
                    if (ch1.Checked)
                    {
                        if (cb1.Text == "Upper")
                        {
                            D.WriteLine("      Costume_Head_Top: true");
                        }
                        else if (cb1.Text == "Middle")
                        {
                            D.WriteLine("      Costume_Head_Mid: true");
                        }
                        else if (cb1.Text == "Lower")
                        {
                            D.WriteLine("      Costume_Head_Low: true");
                        }
                        else if (cb1.Text == "Upper, Middle")
                        {
                            D.WriteLine("      Costume_Head_Top: true");
                            D.WriteLine("      Costume_Head_Mid: true");
                        }
                        else if (cb1.Text == "Middle, Lower")
                        {
                            D.WriteLine("      Costume_Head_Mid: true");
                            D.WriteLine("      Costume_Head_Low: true");
                        }
                        else if (cb1.Text == "Upper, Lower")
                        {
                            D.WriteLine("      Costume_Head_Top: true");
                            D.WriteLine("      Costume_Head_Low: true");
                        }
                        else if (cb1.Text == "Upper, Middle, Lower")
                        {
                            D.WriteLine("      Costume_Head_Top: true");
                            D.WriteLine("      Costume_Head_Mid: true");
                            D.WriteLine("      Costume_Head_Low: true");
                        }
                    }
                    else
                    {
                        if (cb1.Text == "Upper")
                        {
                            D.WriteLine("      Head_Top: true");
                        }
                        else if (cb1.Text == "Middle")
                        {
                            D.WriteLine("      Head_Mid: true");
                        }
                        else if (cb1.Text == "Lower")
                        {
                            D.WriteLine("      Head_Low: true");
                        }
                        else if (cb1.Text == "Upper, Middle")
                        {
                            D.WriteLine("      Head_Top: true");
                            D.WriteLine("      Head_Mid: true");
                        }
                        else if (cb1.Text == "Middle, Lower")
                        {
                            D.WriteLine("      Head_Mid: true");
                            D.WriteLine("      Head_Low: true");
                        }
                        else if (cb1.Text == "Upper, Lower")
                        {
                            D.WriteLine("      Head_Top: true");
                            D.WriteLine("      Head_Low: true");
                        }
                        else if (cb1.Text == "Upper, Middle, Lower")
                        {
                            D.WriteLine("      Head_Top: true");
                            D.WriteLine("      Head_Mid: true");
                            D.WriteLine("      Head_Low: true");
                        }
                    }
                    if (ch2.Checked)
                    {
                        D.WriteLine("    Refineable: true");
                    }
                    D.WriteLine("    ArmorLevel: " + cb2.Text);
                    D.WriteLine("    View: " + vid);
                    if (ch4.Checked)
                    {
                        D.WriteLine("    Script: |");
                        for (int i4 = 0; i4 < t5.Lines.Length; i4++)
                        {
                            D.WriteLine("      " + t5.Lines[i4]);
                        }
                    }
                }
                D.Close();
                label11.Text = "Status : Generating Success.";
                label11.ForeColor = Color.Green;
            }
            catch (IOException ex3)
            {
                MessageBox.Show(
                "Error",
                "Error Error Error Error Error Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            func1();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            func2();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ch1.Checked)
            {
                label8.Hide();
                cb2.Hide();
                cb2.Text = "1";
                ch2.Checked = false;
                ch2.Hide();
                label9.Hide();
                cb3.Hide();
                cb3.Text = "0";
            }
            else
            {
                label8.Show();
                cb2.Show();
                cb2.Text = "1";
                ch2.Show();
                label9.Show();
                cb3.Show();
                cb3.Text = "1";
            }

        }

        private void ch3_CheckedChanged(object sender, EventArgs e)
        {
            if (ch3.Checked)
            {
                t4.Text = "";
                t4.Show();
            }
            else
            {
                t4.Text = "";
                t4.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            func3();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb1.Text) || string.IsNullOrEmpty(tb2.Text))
            {
                label11.Text = string.IsNullOrEmpty(tb1.Text) ? "Status : Add value for View Id Start." : "Status : Add value for Item Id Start.";
                label11.ForeColor = Color.Red;
            }
            else if (t1.Lines.Length != t2.Lines.Length)
            {
                MessageBox.Show("Error: The number of lines in Sprite Names and Display Name does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                func1();
                func2();
                func3();

                // Get the directory where the executable is located
                string exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);

                // Construct the path to the "generated" folder
                string generatedFolderPath = Path.Combine(exeDirectory, "generated");

                // Open the "generated" folder using the default file explorer
                Process.Start("explorer.exe", generatedFolderPath);
            }
        }


        private void ch4_CheckedChanged(object sender, EventArgs e)
        {
            if (ch4.Checked)
            {
                t5.Text = "";
                t5.Show();
            }
            else
            {
                t5.Text = "";
                t5.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Folder";
            openFileDialog.Filter = "Bitmap Files|*.bmp";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = false;
            openFileDialog.FileName = "Select Folder";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(openFileDialog.FileName);
                string[] bmpFiles = Directory.GetFiles(folderPath, "*.bmp");

                // Clear existing text in t1.Text and t2.Text
                t1.Text = "";
                t2.Text = "";

                for (int i = 0; i < bmpFiles.Length; i++)
                {
                    // Append each BMP file name (without extension) on a new line in t1.Text
                    t1.AppendText(Path.GetFileNameWithoutExtension(bmpFiles[i]));

                    // Append each BMP file name (without extension) on a new line in t2.Text
                    t2.AppendText(Path.GetFileNameWithoutExtension(bmpFiles[i]));

                    // Add a newline if it's not the last file name
                    if (i < bmpFiles.Length - 1)
                    {
                        t1.AppendText(Environment.NewLine);
                        t2.AppendText(Environment.NewLine);
                    }
                }
            }
        }


        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

    }
}