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
        static List<Register> memory = new List<Register>();
        static char[] avaibleChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        public string[] TempHexValues = new string[8];
        private Register selectedRegister1 = null;
        private Register selectedRegister2 = null;
        private Register singleSelectedRegister = null;

        public bool useMemory = false;
        public Form1()
        {
            InitializeComponent();

            for(int i =0; i<=0xFFFF; i++)
            {
                Register newRegister = new Register(Convert.ToString(i, 16).ToUpper());
                while (newRegister.registerName.Length != 4)
                {
                    newRegister.registerName = newRegister.registerName.Insert(0, "0");
                }
                memory.Add(newRegister);
            }

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

            RegisterSelect2.SelectedItem = RegisterSelect2.Items[0];
            MemoryAddress.Text = "0000";

        }

        private Register FindRegisterByName(List<Register> list, string name)
        {
            foreach(Register r in list)
            {
                if(r.registerName == name)
                {
                    return r;
                }
            }
            return null;
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
                TempHexValues[i] = CheckSavedNumber(TempHexValues[i],2);
            }
            for (int i = 0; i < registers.Count; i++)
            {
                registers[i].SetHexValue(TempHexValues[i].ToUpper());
            }
            UpdateRegisters();

        }

        public string CheckSavedNumber(string number, int maxLength)
        {
            if (number == "" || number == null)
            {
                number = "00";
            }
            while(number.Length < maxLength)
            {
                number = number.Insert(0, "0");
            }
            foreach (char t in number)
            {
                char capitalizedChar = char.ToUpper(t);
                if (!avaibleChars.Contains(capitalizedChar))
                {
                    MessageBox.Show("One of the fields contains wrong value");
                    return null;
                }
            }
            return number;
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

        private void RegisterSelect1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FindRegisterByName(registers, RegisterSelect1.SelectedItem.ToString()) != null)
            {
               selectedRegister1 = FindRegisterByName(registers, RegisterSelect1.SelectedItem.ToString());
            }
        }

        private void RegisterSelect2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (useMemory) return;
            if (FindRegisterByName(registers, RegisterSelect2.SelectedItem.ToString()) != null)
            {
                selectedRegister2 = FindRegisterByName(registers, RegisterSelect2.SelectedItem.ToString());
            }
        }

        private void SelectRegisterFromMemory()
        {
            if (!useMemory) return;
            string memAdress = CheckSavedNumber(MemoryAddress.Text.ToUpper(), 4);
            if(FindRegisterByName(memory, memAdress) != null)
            {
                selectedRegister2 = FindRegisterByName(memory, memAdress);
            } else
            {
                selectedRegister2 = null;
            }
        }

        private void MoveRegisters(Register register1, Register register2)
        {
            if(register1 == null || register2 == null)
            {
                MessageBox.Show("Cannot mov registers. One of the values is empty.");
                return;
            }
            register2.SetHexValue(register1.GetHexValue());
            UpdateRegisters();
        }

        private void Move1To2_Click(object sender, EventArgs e)
        {
            SelectRegisterFromMemory();
            MoveRegisters(selectedRegister1, selectedRegister2);
        }

        private void Move2To1_Click(object sender, EventArgs e)
        {
            SelectRegisterFromMemory();
            MoveRegisters(selectedRegister2, selectedRegister1);

        }

        private void ExchangeRegisters_Click(object sender, EventArgs e)
        {
            string tempValue = selectedRegister1.GetHexValue();
            selectedRegister1.SetHexValue(selectedRegister2.GetHexValue());
            selectedRegister2.SetHexValue(tempValue);
            UpdateRegisters();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateRegisters();
        }

        private void SingleRegisterSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FindRegisterByName(registers, SingleRegisterSelection.SelectedItem.ToString()) != null)
            {
                singleSelectedRegister = FindRegisterByName(registers, SingleRegisterSelection.SelectedItem.ToString());
            }
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            if(singleSelectedRegister == null) { return; }
            int value = int.Parse(singleSelectedRegister.GetHexValue(), System.Globalization.NumberStyles.HexNumber);
            value++;
            if(value > 255)
            {
                value = 0;
            }
            singleSelectedRegister.SetHexValue(CheckSavedNumber(Convert.ToString(value, 16),2).ToUpper());
            UpdateRegisters();
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            if (singleSelectedRegister == null) { return; }

            int value = int.Parse(singleSelectedRegister.GetHexValue(), System.Globalization.NumberStyles.HexNumber);
            value--;
            if (value < 0)
            {
                value = 255;
            }
            singleSelectedRegister.SetHexValue(CheckSavedNumber(Convert.ToString(value, 16),2).ToUpper());
            UpdateRegisters();
        }

        private void NotButton_Click(object sender, EventArgs e)
        {
            if (singleSelectedRegister == null) { return; }
            int value = int.Parse(singleSelectedRegister.GetHexValue(), System.Globalization.NumberStyles.HexNumber);
            value = 255 - value;
            singleSelectedRegister.SetHexValue(CheckSavedNumber(Convert.ToString(value, 16),2).ToUpper());
            UpdateRegisters();
        }

        private void NegationButton_Click(object sender, EventArgs e)
        {
            if (singleSelectedRegister == null) { return; }
            int value = int.Parse(singleSelectedRegister.GetHexValue(), System.Globalization.NumberStyles.HexNumber);
            value = 255 - value;
            value++;
            if (value > 255)
            {
                value = 0;
            }
            singleSelectedRegister.SetHexValue(CheckSavedNumber(Convert.ToString(value, 16),2).ToUpper());
            UpdateRegisters();
        }

        private void ANDButton_Click(object sender, EventArgs e)
        {
            SelectRegisterFromMemory();
            AND_Register(selectedRegister1, selectedRegister2);
        }

        private void AND_Register(Register register1, Register register2)
        {
            if (register1 == null || register2 == null)
            {
                MessageBox.Show("Cannot modify registers. One of the values is incorrect.");
                return;
            }
            int value = int.Parse(register1.GetHexValue(), System.Globalization.NumberStyles.HexNumber) & int.Parse(register2.GetHexValue(), System.Globalization.NumberStyles.HexNumber);
            register1.SetHexValue(CheckSavedNumber(Convert.ToString(value, 16),2).ToUpper());
            UpdateRegisters();
        }

        private void ORButton_Click(object sender, EventArgs e)
        {
            SelectRegisterFromMemory();
            OR_Register(selectedRegister1, selectedRegister2);
        }

        private void OR_Register(Register register1, Register register2)
        {
            if (register1 == null || register2 == null)
            {
                MessageBox.Show("Cannot modify registers. One of the values is incorrect.");
                return;
            }
            int value = int.Parse(register1.GetHexValue(), System.Globalization.NumberStyles.HexNumber) | int.Parse(register2.GetHexValue(), System.Globalization.NumberStyles.HexNumber);
            register1.SetHexValue(CheckSavedNumber(Convert.ToString(value, 16),2).ToUpper());
            UpdateRegisters();
        }

        private void XORButton_Click(object sender, EventArgs e)
        {
            SelectRegisterFromMemory();
            XOR_Register(selectedRegister1, selectedRegister2);
        }

        private void XOR_Register(Register register1, Register register2)
        {
            if (register1 == null || register2 == null)
            {
                MessageBox.Show("Cannot modify registers. One of the values is incorrect.");
                return;
            }
            int value = int.Parse(register1.GetHexValue(), System.Globalization.NumberStyles.HexNumber) ^ int.Parse(register2.GetHexValue(), System.Globalization.NumberStyles.HexNumber);
            register1.SetHexValue(CheckSavedNumber(Convert.ToString(value, 16),2).ToUpper());
            UpdateRegisters();
        }

        private void ADDButton_Click(object sender, EventArgs e)
        {
            SelectRegisterFromMemory();
            ADD_Registers(selectedRegister1, selectedRegister2);
        }

        private void ADD_Registers(Register register1, Register register2)
        {
            if (register1 == null || register2 == null)
            {
                MessageBox.Show("Cannot modify registers. One of the values is incorrect.");
                return;
            }
            int value = int.Parse(register1.GetHexValue(), System.Globalization.NumberStyles.HexNumber) + int.Parse(register2.GetHexValue(), System.Globalization.NumberStyles.HexNumber);
            while(value >= 256)
            {
                value -= 256;
            }
            register1.SetHexValue(CheckSavedNumber(Convert.ToString(value, 16),2).ToUpper());
            UpdateRegisters();
        }

        private void SUBButton_Click(object sender, EventArgs e)
        {
            SelectRegisterFromMemory();
            SUB_Registers(selectedRegister1, selectedRegister2);
        }

        private void SUB_Registers(Register register1, Register register2)
        {
            if (register1 == null || register2 == null)
            {
                MessageBox.Show("Cannot modify registers. One of the values is incorrect.");
                return;
            }
            int value = int.Parse(register1.GetHexValue(), System.Globalization.NumberStyles.HexNumber) - int.Parse(register2.GetHexValue(), System.Globalization.NumberStyles.HexNumber);
            while (value < 0)
            {
                value += 256;
            }
            register1.SetHexValue(CheckSavedNumber(Convert.ToString(value, 16),2).ToUpper());
            UpdateRegisters();
        }

        private void GetControlType()
        {
            if(registerRadio.Checked)
            {
                useMemory = false;
                RegisterSelect2.Enabled = true;
                MemoryAddress.Enabled = false;
                RegisterSelect2_SelectedIndexChanged(this, null);
            } else if(memoryRadio.Checked)
            {
                useMemory = true;
                RegisterSelect2.Enabled = false;
                MemoryAddress.Enabled = true;
                SelectRegisterFromMemory();
            }
            else
            {
                useMemory = false;
            }
        }

        private void MemoryAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerRadio_CheckedChanged(object sender, EventArgs e)
        {
            GetControlType();
        }

        private void memoryRadio_CheckedChanged(object sender, EventArgs e)
        {
            GetControlType();

        }
    }
}
