using System;

namespace NoteR__1._1
{
    internal class TabelaDeCautare : KeywordComune
    {
        private string[] cuvant_cheie = new string[256];
        private int[] pozitie = new int[256];
        private int[] lungime = new int[256];
        private int elemente_totale = 0;
        /// <summary>
        /// Constructor():Adauga in tabela cuvantul cheie, pozitie si lungimea acestuia
        /// </summary>
        /// <param name="Text"></param>
        public TabelaDeCautare(string Text, string[] CuvinteCheie)
        {
            string cuvant = String.Empty;
            bool Prima = true;
            int PrimulCaracter = 0;
            for (int c = 0; Text.Length != c; c++)
            {
                if (Text[c] != ' ')
                {
                    cuvant += Text[c];
                    if (Prima) { PrimulCaracter = c; Prima = false; }
                }
                else { cuvant = String.Empty; Prima = true; }
                {
                    if (Contains(cuvant, CuvinteCheie))
                    {
                        //adaug lungimea, pozitia lui in text si lungimea 
                        Add(cuvant, cuvant.Length, PrimulCaracter, elemente_totale);
                        cuvant = String.Empty;
                        Prima = true;
                    }
                }
            }
        }
        /// <summary>
        /// Adauga elemente in tabela
        /// </summary>
        /// <param name="cuv"></param>
        /// <param name="lungime"></param>
        /// <param name="pozitie"></param>
        /// <param name="index"></param>
        private void Add(string cuv, int lungime, int pozitie, int index)
        {
            this.cuvant_cheie[index] = cuv;
            this.lungime[index] = lungime;
            this.pozitie[index] = pozitie;
            elemente_totale++;
        }
        /// <summary>
        /// Metoda returneaza cuvantul, lungimea si pozitia in text
        /// </summary>
        /// <param name="cuv"></param>
        /// <param name="lungime"></param>
        /// <param name="pozitie"></param>
        public void ReturnData(out string cuv, out int lungime, out int pozitie, int index)
        {
            cuv = this.cuvant_cheie[index];
            lungime = this.lungime[index];
            pozitie = this.pozitie[index];
        }
        /// <summary>
        /// Metoda verifica daca cuvantul dat este cuvant cheie
        /// </summary>
        /// <param name="Cuvant"></param>
        /// <param name="CuvinteCheie"></param>
        /// <returns></returns>
        private bool Contains(string Cuvant, string[] CuvinteCheie)
        {
            foreach (string c in CuvinteCheie)
            {
                if (Cuvant.Equals(c)) { return true; }
            }
            return false;
        }
        /// <summary>
        /// Metoda reurneaza totalul elementelor din lista
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return elemente_totale;
        }
    }
}
