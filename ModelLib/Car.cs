using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ModelLib
{
    public class Car
    {
        public string Model { get; set; }
        public Color Color { get; set; }
        public string RegNo { get; set; }

        public override string ToString()
        {
            return "Model: " + Model + " Color: " + Color + " RegNo: " + RegNo;
        }
    }
}
