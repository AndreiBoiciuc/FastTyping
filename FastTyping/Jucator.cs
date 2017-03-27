using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastTyping
{
    public class Jucator
    {
        string nume;
        string scor;
        string dificultate;
        public static string[] vdif = new string[4] {"-","Mica", "Medie", "Mare" };

        public Jucator()
        {

        }

        public Jucator(string _nume, string _scor, string _dif)
        {
            nume = _nume;
            scor = _scor;
            dificultate = _dif;
        }

        public string Nume
        {
            get
            {
                return nume;
            }

            set
            {
                nume = value;
            }
        }

        public string Scor
        {
            get
            {
                return scor;
            }

            set
            {
                scor = value;
            }
        }

        public string Dificultate
        {
            get
            {
                return dificultate;
            }

            set
            {
                dificultate = value;
            }
        }


        public string this[string camp]
        {
            get
            {
                if (camp.Equals("Nume"))
                    return nume;
                else if (camp.Equals("Scor"))
                    return scor;
                else if (camp.Equals("Dificultate"))
                    return dificultate;
                else
                    return null;
            }

            set
            {
                if (camp.Equals("Nume"))
                    nume = value;
                else if (camp.Equals("Scor"))
                    scor = value;
                else if (camp.Equals("Dificultate"))
                    dificultate = value;
            }

        }

    }
}
