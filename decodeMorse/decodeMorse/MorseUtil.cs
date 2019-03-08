using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decodeMorse
{
    public class MorseUtil
    {
        Dictionary<string, string> _morse = new Dictionary<string, string>();
        public MorseUtil()
        {

        }

        public bool isLoad()
        {
            if (_morse.Count > 0)
                return true;
            else
                return false;
        }
    }
}
