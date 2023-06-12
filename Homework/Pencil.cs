using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Pencil : WritingTools
    {
        public override void Write(StringBuilder stringBuilder, char[] array)
        {
            foreach (var c in array)
            {
                stringBuilder.Append(c);
                Remainder -= 0.95;

                SharpenCount++;

                if (SharpenCount == 20)
                {
                    Remainder -= 3;
                }
            }
        }

        public override void Erase(StringBuilder stringBuilder)
        {
            if (stringBuilder.Length > 0)
            {
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
                Remainder += 0.95;

            }
        }

      
    }
}
