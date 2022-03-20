using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel
{
    public partial class Form1 : Form
    {
        static List<Register> registers = new List<Register>();
        static char[] avaibleChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        public string[] TempHexValues = new string[8];
        public Form1()
        {
            InitializeComponent();
            Register AL = new Register("AL");
            Register AH = new Register("AH");
            Register BL = new Register("BL");
            Register BH = new Register("BH");
            Register CL = new Register("CL");
            Register CH = new Register("CH");
            Register DL = new Register("DL");
            Register DH = new Register("DH");

            registers.Add(AL);
            registers.Add(AH);
            registers.Add(BL);
            registers.Add(BH);
            registers.Add(CL);
            registers.Add(CH);
            registers.Add(DL);
            registers.Add(DH);
            UpdateRegisters();

        }
        private void ALValue_TextChanged(object sender, EventArgs e)
        {
            TempHexValues[0] = ALValue.Text;
        }
        private void AHValue_TextChanged(object sender, EventArgs e) 
        {
            TempHexValues[1] = AHValue.Text;
        }

        private void BLValue_TextChanged(object sender, EventArgs e)
        {
            TempHexValues[2] = BLValue.Text;
        }

        private void BHValue_TextChanged(object sender, EventArgs e)
        {
            TempHexValues[3] = BHValue.Text;
        }
        private void CLValue_TextChanged(object sender, EventArgs e)
        {
            TempHexValues[4] = CLValue.Text;
        }
        private void CHValue_TextChanged(object sender, EventArgs e)
        {
            TempHexValues[5] = CHValue.Text;
        }

        private void DLValue_TextChanged(object sender, EventArgs e)
        {
            TempHexValues[6] = DLValue.Text;
        }
        private void DHValue_TextChanged(object sender, EventArgs e)
        {
            TempHexValues[7] = DHValue.Text;
        }


        private void Save_Click(object sender, EventArgs e)
        {
             //Check Values
            for(int i = 0; i < TempHexValues.Length; i++)
            {
                if(TempHexValues[i] == "" || TempHexValues[i] == null)
                {
                    TempHexValues[i] = "00";
                }

                if(TempHexValues[i].Length == 1)
                {
                    TempHexValues[i] = TempHexValues[i].Insert(0, "0");
                }
                foreach (char t in TempHexValues[i])
                {
                    char capitalizedChar = char.ToUpper(t);
                    if (!avaibleChars.Contains(capitalizedChar))
                    {
                        MessageBox.Show("One of the fields contains wrong value");
                        return;
                    }
                }
            }
            for (int i = 0; i < registers.Count; i++)
            {
                registers[i].SetHexValue(TempHexValues[i].ToUpper());
            }
            UpdateRegisters();

        }

        private void UpdateRegisters()
        {
            ALShow.Text = registers[0].GetHexValue();
            AHShow.Text = registers[1].GetHexValue();
            BLShow.Text = registers[2].GetHexValue();
            BHShow.Text = registers[3].GetHexValue();
            CLShow.Text = registers[4].GetHexValue();
            CHShow.Text = registers[5].GetHexValue();
            DLShow.Text = registers[6].GetHexValue();
            DHShow.Text = registers[7].GetHexValue();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
