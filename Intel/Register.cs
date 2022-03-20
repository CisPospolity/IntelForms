using System;
using System.Collections.Generic;
using System.Text;

namespace Intel
{
    class Register
    {
        public string registerName;
        private string hexValue = "00";

        public Register(string name)
        {
            registerName = name;
        }

        public Register(string value, string name)
        {
            SetHexValue(value);
            registerName = name;
        }

        public void SetHexValue(string value)
        {
            if (value.Length == 2)
            {
                hexValue = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public string GetHexValue()
        {
            return hexValue;
        }
    }
}
