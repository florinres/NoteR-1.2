using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteR__1._1
{
    internal class AlteBaze
    {
        /// <summary>
        /// Metoda transforma textul dat ca si parametru in baza 8
        /// </summary>
        /// <param name="casetaText"></param>
        /// <returns></returns>
        public string ConvertToOctal(string casetaText)
        {
            string TextOctal = String.Empty;
            foreach (char c in casetaText)
            {
                string CuvantOctal = Convert.ToString(c, 8);
                TextOctal += CuvantOctal;
                TextOctal += " ";
            }
            return TextOctal;
        }
        /// <summary>
        /// Metoda transforma textul dat ca si parametru in baza 16
        /// </summary>
        /// <param name="casetaText"></param>
        /// <returns></returns>
        public string ConvertToHexa(string Text)
        {
            string TextHexa = string.Empty;
            byte[] Bytes = Encoding.ASCII.GetBytes(Text);
            string Hexa = BitConverter.ToString(Bytes);
            TextHexa = Hexa;
            return TextHexa;
        }
        public bool EsteText(int index, string Text)
        {
            bool ExistaCuvinte = false;
            for (int i = index; i != Text.Length; i++)
            {
                try
                {
                    if (Text[i] != ' ') { ExistaCuvinte = true; break; }
                }
                catch (IndexOutOfRangeException)
                {
                    return false;
                }
            }
            return ExistaCuvinte;
        }
        
    }
}
