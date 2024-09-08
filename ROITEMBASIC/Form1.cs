using System.IO;
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
            cb2.Text = "1";
            tb3.Text = "0";
            tb4.Text = "0";
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
                    label11.Text = "Status : accessoryid.txt and accname.txt Generating Success.";
                }
                catch (IOException ex1)
                {
                    MessageBox.Show("Error: " + ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void func2()
        {
            string itemInfoFilePath = Path.Combine(Application.StartupPath, "generated", "itemInfo.lua");
            using (StreamWriter C = new StreamWriter(itemInfoFilePath))
            {
                int idnum = Convert.ToInt32(tb2.Text);
                try
                {
                    string[] itemDescriptions = t3.Text.Split(new[] { "###" }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < itemDescriptions.Length; i++)
                    {
                        int idnum2 = idnum + i;
                        C.WriteLine("[" + idnum2 + "] = {");
                        C.WriteLine("    unidentifiedDisplayName = \"Unidentified Mask\",");
                        C.WriteLine("    unidentifiedResourceName = \"마스크\",");
                        C.WriteLine("    unidentifiedDescriptionName = { \"Can be identified by using a ^990099Magnifier ^000000.\" },");

                        if (ch1.Checked)
                        {
                            C.WriteLine("    identifiedDisplayName = \"Costume " + t2.Lines[i] + "\",");
                        }
                        else
                        {
                            C.WriteLine("    identifiedDisplayName = \"" + t2.Lines[i] + "\",");
                        }
                        C.WriteLine("    identifiedDescriptionName = {");
                        string[] descriptionLines = itemDescriptions[i].Trim().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string line in descriptionLines)
                        {
                            C.WriteLine("        \"" + line.Trim() + "\",");
                        }
                        C.WriteLine("        \"^0000CCType: ^000000 Costume\",");
                        C.WriteLine("        \"^0000CCDefense: ^000000 " + tb3.Text + "\",");
                        switch (postb.Lines[i])
                        {
                            case "U":
                                C.WriteLine("        \"^0000CCPosition: ^000000 Upper" + "\",");
                                break;
                            case "M":
                                C.WriteLine("        \"^0000CCPosition: ^000000 Middle" + "\",");
                                break;
                            case "L":
                                C.WriteLine("        \"^0000CCPosition: ^000000 Lower" + "\",");
                                break;
                            case "UM":
                            case "MU":
                                C.WriteLine("        \"^0000CCPosition: ^000000 Upper & Middle" + "\",");
                                break;
                            case "UL":
                            case "LU":
                                C.WriteLine("        \"^0000CCPosition: ^000000 Upper & Lower" + "\",");
                                break;
                            case "ML":
                            case "LM":
                                C.WriteLine("        \"^0000CCPosition: ^000000 Middle & Lower" + "\",");
                                break;
                            case "UML":
                            case "LMU":
                            case "MLU":
                                C.WriteLine("        \"^0000CCPosition: ^000000 Upper, Middle & Lower" + "\",");
                                break;
                            default:
                                C.WriteLine("        \"^0000CCPosition: ^000000 Upper" + "\",");
                                break;
                        }
                        C.WriteLine("        \"^0000CCWeight: ^000000 " + tb4.Text + "\",");

                        if (!ch1.Checked)
                        {
                            C.WriteLine("        \"^0000CCArmor Level: ^000000 " + cb2.Text + "\",");
                            C.WriteLine(ch2.Checked ? "        \"^0000CCRefineable: ^000000 Yes\"," : "        \"^0000CCRefineable: ^000000 No\",");
                        }

                        C.WriteLine("        \"_______________________\",");
                        C.WriteLine("        \"^0000CCRequirement: ^000000 None\"");
                        C.WriteLine("    },");
                        C.WriteLine("    slotCount = " + slottb.Lines[i] + ",");
                        C.WriteLine("    ClassNum = 0,");
                        C.WriteLine(ch1.Checked ? "    costume = true" : "    costume = false");
                        C.WriteLine("},");
                    }
                    label11.Text = "Status : itemInfo.lua Generating Success.";
                }
                catch (IOException ex2)
                {
                    MessageBox.Show("Error: " + ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    if (int.TryParse(slottb.Lines[i], out int slotNumber) && slotNumber > 0 && slotNumber <= 4)
                    {
                        D.WriteLine("    Slots: " + slottb.Lines[i]);
                    }

                    D.WriteLine("    Locations:");
                    if (ch1.Checked)
                    {
                        switch (postb.Lines[i])
                        {
                            case "U":
                                D.WriteLine("      Costume_Head_Top: true");
                                break;
                            case "M":
                                D.WriteLine("      Costume_Head_Mid: true");
                                break;
                            case "L":
                                D.WriteLine("      Costume_Head_Low: true");
                                break;
                            case "UM":
                            case "MU":
                                D.WriteLine("      Costume_Head_Top: true");
                                D.WriteLine("      Costume_Head_Mid: true");
                                break;
                            case "UL":
                            case "LU":
                                D.WriteLine("      Costume_Head_Top: true");
                                D.WriteLine("      Costume_Head_Low: true");
                                break;
                            case "ML":
                            case "LM":
                                D.WriteLine("      Costume_Head_Mid: true");
                                D.WriteLine("      Costume_Head_Low: true");
                                break;
                            case "UML":
                            case "LMU":
                            case "MLU":
                                D.WriteLine("      Costume_Head_Top: true");
                                D.WriteLine("      Costume_Head_Mid: true");
                                D.WriteLine("      Costume_Head_Low: true");
                                break;
                            default:
                                D.WriteLine("      Costume_Head_Top: true");
                                break;
                        }
                    }
                    else
                    {
                        switch (postb.Lines[i])
                        {
                            case "U":
                                D.WriteLine("      Head_Top: true");
                                break;
                            case "M":
                                D.WriteLine("      Head_Mid: true");
                                break;
                            case "L":
                                D.WriteLine("      Head_Low: true");
                                break;
                            case "UM":
                            case "MU":
                                D.WriteLine("      Head_Top: true");
                                D.WriteLine("      Head_Mid: true");
                                break;
                            case "UL":
                            case "LU":
                                D.WriteLine("      Head_Top: true");
                                D.WriteLine("      Head_Low: true");
                                break;
                            case "ML":
                            case "LM":
                                D.WriteLine("      Head_Mid: true");
                                D.WriteLine("      Head_Low: true");
                                break;
                            case "UML":
                            case "LMU":
                            case "MLU":
                                D.WriteLine("      Head_Top: true");
                                D.WriteLine("      Head_Mid: true");
                                D.WriteLine("     Head_Low: true");
                                break;
                            default:
                                D.WriteLine("      Head_Top: true");
                                break;
                        }
                    }
                    if (ch2.Checked)
                    {
                        D.WriteLine("    Refineable: true");
                    }
                    D.WriteLine("    ArmorLevel: " + cb2.Text);
                    D.WriteLine("    View: " + vid);
                    D.WriteLine("    Script: |");
                    for (int i4 = 0; i4 < t5.Lines.Length; i4++)
                    {
                        D.WriteLine("      " + t5.Lines[i4]);
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
            }
            else
            {
                label8.Show();
                cb2.Show();
                cb2.Text = "1";
                ch2.Show();
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

                string exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                string generatedFolderPath = Path.Combine(exeDirectory, "generated");
                Process.Start("explorer.exe", generatedFolderPath);
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

                // for clear [Dantoki]
                t1.Text = "";
                t2.Text = "";
                postb.Text = "";
                slottb.Text = "";
                t3.Text = "";

                for (int i = 0; i < bmpFiles.Length; i++)
                {
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(bmpFiles[i]);
                    t1.AppendText(fileNameWithoutExtension);
                    t2.AppendText(fileNameWithoutExtension);
                    postb.AppendText("U");
                    slottb.AppendText("0");
                    if (i == 0)
                    {
                        t3.AppendText("###\n" + fileNameWithoutExtension + "\nPLEASE ADD DESCRIPTION\n###");
                    }
                    else
                    {
                        t3.AppendText(fileNameWithoutExtension + "\nPLEASE ADD DESCRIPTION\n###");
                    }
                    if (i < bmpFiles.Length - 1)
                    {
                        t1.AppendText(Environment.NewLine);
                        t2.AppendText(Environment.NewLine);
                        postb.AppendText(Environment.NewLine);
                        slottb.AppendText(Environment.NewLine);
                        t3.AppendText(Environment.NewLine);
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void postb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}