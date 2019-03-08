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
            Load();
        }
        private void Load()
        {
            _morse.Clear();
            _morse.Add(".-", "A");
            _morse.Add("-...", "B");
            _morse.Add("-.-.", "C");
            _morse.Add("-..", "D");
            _morse.Add(".", "E");
            _morse.Add("..-.", "F");
            _morse.Add("--.", "G");
            _morse.Add("....", "H");
            _morse.Add("..", "I");
            _morse.Add(".---", "J");
            _morse.Add("-.-", "K");
            _morse.Add(".-..", "L");
            _morse.Add("--", "M");
            _morse.Add("-.", "N");
            _morse.Add("---", "O");
            _morse.Add(".--.", "P");
            _morse.Add("--.-", "Q");
            _morse.Add(".-.", "R");
            _morse.Add("...", "S");
            _morse.Add("-", "T");
            _morse.Add("..-", "U");
            _morse.Add("...-", "V");
            _morse.Add(".--", "W");
            _morse.Add("-..-", "X");
            _morse.Add("-.--", "Y");
            _morse.Add("--..", "Z");

            _morse.Add(".----", "1");
            _morse.Add("..---", "2");
            _morse.Add("...--", "3");
            _morse.Add("....-", "4");
            _morse.Add(".....", "5");
            _morse.Add("-....", "6");
            _morse.Add("--...", "7");
            _morse.Add("---..", "8");
            _morse.Add("----.", "9");
            _morse.Add("-----", "0");

            //Special service code
            _morse.Add("···−−−···", "SOS");
            //...
        }
        public bool isLoad()
        {
            if (_morse.Count > 0)
                return true;
            else
                return false;
        }

        public string Decode(string morseInput)
        {
            StringBuilder sb = new StringBuilder();
            morseInput = morseInput.Trim();
            if (!string.IsNullOrEmpty(morseInput))
            {
                var words = morseInput.Split(new[] { "   " }, StringSplitOptions.None);
                foreach (var word in words)
                {
                    var characters = word.Split(' ');
                    foreach (var character in characters)
                    {
                        string morsecode = string.Empty;
                        if (_morse.TryGetValue(character, out morsecode))
                        {
                            sb.Append(morsecode);
                        }
                    }
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }
    }
}
