using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Pen : WritingTools
    {

        public override void Write(StringBuilder stringBuilder, char[] array)
        {
            foreach (char c in array)
            {
                stringBuilder.Append(c);
                Remainder -= 1.15;
                
            }
        }
        public override void Erase(StringBuilder stringBuilder)
        {
            if (stringBuilder.Length > 0)
            {
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
                Remainder += 1.15;

            }
        }

       
    }
}
