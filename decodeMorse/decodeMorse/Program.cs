using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decodeMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            string morseToDecode = string.Empty;
            if (args.Length > 0)
            {
                morseToDecode = args[0];
            }
            MorseUtil morseUtil = new MorseUtil();
            Console.Write(morseUtil.Decode(morseToDecode));
        }
    }
}
