using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class FeltPen : WritingTools
    {


        public override void Write(StringBuilder stringBuilder, char[] array)
        {
            foreach (var c in array)
            {
                stringBuilder.Append(c);
                Remainder -= GetInkConsumption();

                characterCount++;
            }
        }

        public int characterCount;

        public FeltPen()
        {
            characterCount = 0;
            Remainder = 100;
        }


        private double GetInkConsumption()
        {
            if (characterCount < 20)
            {
                return 1;
            }
            else if (characterCount < 40)
            {
                return 1.09;
            }
            else
            {
                return 1.21;
            }


        }
        public override void Erase(StringBuilder stringbuilder)
        {
            if(stringbuilder .Length > 0) 
            {
            stringbuilder.Remove(stringbuilder.Length - 1, 1);
                Remainder += GetInkConsumption();
            
            }
        }
    }
}