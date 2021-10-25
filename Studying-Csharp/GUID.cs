using System;

namespace Studying_Csharp
{
    public class GUID
    {
        /* output
         * s	"98d57df3-43f2-4279-88f9-8ec2b4c2f547"
         * d	"ae9629ab-1aa3-4a22-b872-fdf0ac6fa4a9"
         * n	"bacf5f4a96f641e482dab8b538005252"
         * b	"{73ec5827-a0f5-4a88-8936-a62b98a6e4ab}"
         * p	"(650d588b-a9cc-4e68-9418-7949ada15f76)"
         * x	"{0x581c7de8,0x9f9c,0x4ce4,{0xad,0xde,0x88,0x2c,0x45,0xea,0x09,0x5d}}"
         */

        public string Print
        {
            get
            {
                return Guid.NewGuid().ToString();
            }
        }

        public string Format_D
        {
            get
            {
                return Guid.NewGuid().ToString("D");
            }
        }

        public string Format_N
        {
            get
            {
                return Guid.NewGuid().ToString("N");
            }
        }

        public string Format_B
        {
            get
            {
                return Guid.NewGuid().ToString("B");
            }
        }

        public string Format_P
        {
            get
            {
                return Guid.NewGuid().ToString("P");
            }
        }

        public string Format_X
        {
            get
            {
                return Guid.NewGuid().ToString("X");
            }
        }
    }
}
