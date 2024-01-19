using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteR__1._1
{
    internal class C__:KeywordComune
    {
        public C__()
        {
            AdaugaCuvinte("auto");
            AdaugaCuvinte("bool");
            AdaugaCuvinte("delete");
            AdaugaCuvinte("malloc");
            AdaugaCuvinte("enum");
            AdaugaCuvinte("extern");
            AdaugaCuvinte("inline");
        }
        /// <summary>
        /// Metoda VerificaLista e cruciala pentru implementarea functionalitatii a colorarii
        /// instructiunilor de limbaj de programare, in cazul implementarii altor clase de limbaj
        /// de programare trebuie modificata metoda VerificaLista
        /// </summary>
        /// <param name="Cuvant"></param>
        public bool VerificaLista(string Cuvant)
        {
            Dictionary<string,int> DictionarDeBaza = DictionarDeCuvinte();
            if (DictionarDeBaza.ContainsKey(Cuvant))
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}
