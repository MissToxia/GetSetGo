using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GetSetGo;

namespace GetSetGenerator
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            string PropPrefix = PrefixTxtBox.Text;
            string VarFullLine = "";
            string VarModifer = "";
            string VarType = "";
            string VarName = "";
            int VarFirstSpaceIndex = 0;
            int VarSecondSpaceIndex = 0;
            int VarSemiColon = 0;
            string PropOutput = "";

            try
            {
                VarFullLine = InputTxtBox.Text;
                string[] LineList = VarFullLine.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < LineList.Length; i++)
                {
                    VarFirstSpaceIndex = LineList[i].IndexOf(" ");
                    VarSecondSpaceIndex = LineList[i].LastIndexOf(" ");
                    VarSemiColon = LineList[i].LastIndexOf(";");
                    VarModifer = LineList[i].Substring(0, VarFirstSpaceIndex);
                    VarModifer.Trim();
                    VarType = LineList[i].Substring(VarFirstSpaceIndex + 1, (VarSecondSpaceIndex - 1) - VarFirstSpaceIndex);
                    VarType.Trim();
                    VarName = LineList[i].Substring(VarSecondSpaceIndex + 1, (VarSemiColon - 1) - VarSecondSpaceIndex);
                    VarName.Trim();

                    if (CSharpRdBtn.Checked) // for C# properties
                    {
                        if (ReadOnlyChkBox.Checked == false)
                            PropOutput = PropOutput + VarModifer + " " + VarType + " " + PropPrefix + VarName + "\r\n{\r\n\tget { return " + VarName + "; }\r\n\tset { " + VarName + " = value; }\r\n}\r\n";
                        else
                            PropOutput = PropOutput + VarModifer + " " + VarType + " " + PropPrefix + VarName + "\r\n{\r\n\tget { return " + VarName + "; }\r\n}\r\n";
                    }
                    else // for Java get/sets
                    {
                        if (ReadOnlyChkBox.Checked == false)
                            PropOutput = PropOutput + VarModifer + " " + VarType + " get" + VarName + "()\r\n{\r\n\treturn " + VarName + ";\r\n}\r\n\r\n" + VarModifer + " void set" + VarName + "(" + VarType + " value)" + "\r\n{\r\n\t" + VarName + " = value;\r\n}\r\n\r\n";
                        else
                            PropOutput = PropOutput + VarModifer + " " + VarType + " get" + VarName + "()\r\n{\r\n\treturn " + VarName + ";\r\n}\r\n\r\n";
                    }
                }
                PropOutput.Trim();
                OutputTxtBox.Text = PropOutput;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("The instance variables you have entered are invalid, please use the following format (including semicolons): modifer type name;", "Input Error");
            }
        }

        private void JavaRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (JavaRdBtn.Checked)
                PrefixTxtBox.Enabled = false;
        }

        private void CSharpRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CSharpRdBtn.Checked)
                PrefixTxtBox.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AboutFrm aboutForm = new AboutFrm();

            aboutForm.Show();
        }
    }
}
