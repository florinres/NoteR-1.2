using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteR__1._1
{
    internal class KeywordComune {
        private Dictionary<string, int> CuvinteCheie = new Dictionary<string, int>();
        private List<Color> Culori;
        public KeywordComune()
        {
            //declarare lista de culori
            //indecsi sunt folositi pentru
            //a selecta o culoare potrivita
            Culori = new List<Color>
            {
                Color.Blue, //tipuri de date 1
                Color.DarkViolet, //bucle 2
                Color.DarkViolet, //instr control 3
                Color.Blue, //structuri, clase, uniuni 4
                Color.BlueViolet, //alte tipuri 5
                Color.Green //definit de utilizator 6
            };

            //tipuri de date 
            CuvinteCheie.Add("int", 0);
            CuvinteCheie.Add("float", 0);
            CuvinteCheie.Add("double", 0);
            CuvinteCheie.Add("short", 0);
            CuvinteCheie.Add("byte", 0);
            CuvinteCheie.Add("char", 0);
            //bucle 
            CuvinteCheie.Add("do", 1);
            CuvinteCheie.Add("while", 1);
            CuvinteCheie.Add("for", 1);
            CuvinteCheie.Add("switch", 1);
            CuvinteCheie.Add("case", 1);
            CuvinteCheie.Add("catch", 1);
            //instructiuni de control a programului
            CuvinteCheie.Add("if", 2);
            CuvinteCheie.Add("else", 2);
            CuvinteCheie.Add("break", 2);
            CuvinteCheie.Add("continue", 2);
            CuvinteCheie.Add("default", 2);
            CuvinteCheie.Add("goto", 2);
            CuvinteCheie.Add("try", 2);
            //structuri,clase,uniuni
            CuvinteCheie.Add("class", 3);
            CuvinteCheie.Add("private", 3);
            CuvinteCheie.Add("protected", 3);
            CuvinteCheie.Add("public", 3);
            //alte tipuri
            CuvinteCheie.Add("const", 4);
            CuvinteCheie.Add("false", 4);
            CuvinteCheie.Add("true", 4);
            CuvinteCheie.Add("new", 4);
            CuvinteCheie.Add("static", 4);
            //operatori
            CuvinteCheie.Add(";", 1);
            CuvinteCheie.Add(",", 1);
            CuvinteCheie.Add("(", 1);
            CuvinteCheie.Add(")", 1);
            CuvinteCheie.Add("{", 1);
            CuvinteCheie.Add("}", 1);
            CuvinteCheie.Add("//", 5);
            CuvinteCheie.Add("/*", 5);
            CuvinteCheie.Add("=", 0);
            CuvinteCheie.Add("==", 0);
            CuvinteCheie.Add("++", 0);
            CuvinteCheie.Add("*", 0);
        }
        /// <summary>
        /// Metoda e folosita pentru clasele derivate pentru a adauga alte cuvinte cheie,
        /// in viitorul apropriat utilizatorul ar putea sa adauge propriile lui cuvinte de programare
        /// </summary>
        /// <param name="cuvant"></param>
        public void AdaugaCuvinte(string Cuvant, int Index = 1)
        {
            CuvinteCheie.Add(Cuvant, Index);
        }
        /// <summary>
        /// Metoda are rolul de reintoarce culoarea potrivita pentru cuvantul cheie selectat
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public Color CuloarePotrivita(string Cuvant)
        {
            int IndexCuloare;
            CuvinteCheie.TryGetValue(Cuvant, out IndexCuloare);
            Color C = Culori.ElementAt(IndexCuloare);
            return C;
        }
        /// <summary>
        /// Metoda returneaza dictionarul de cuvinte cheie 
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> DictionarDeCuvinte()
        {
            return CuvinteCheie;
        }
        public string[] CuvinteDinDictionar()
        {
            string []Cuvinte = CuvinteCheie.Keys.ToArray();
            return Cuvinte;
        }
    }
}
