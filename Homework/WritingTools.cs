using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public abstract class WritingTools
    {
        public double Remainder { get; set; }
        public double SharpenCount { get; set; }
        public WritingTools()
        {
            Remainder = 100;
            SharpenCount = 0;
        }
        public abstract void Erase(StringBuilder stringBuilder);


        public abstract void Write(StringBuilder stringBuilder, char[] array);
        
    }


}
