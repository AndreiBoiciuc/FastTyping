using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FastTyping
{
     public class Clasament
    {
        Jucator[] cls = new Jucator[11];
         
        public Clasament()
        {
            int i;

            for ( i = 0; i < 11; i++)
            cls[i] = new Jucator("-", "0", "0");
            

            String[] clas_f = File.ReadAllLines(@"clasament_f.txt");

            string[] line = new string[3];

            char[] separator = new char[] { '\t' };

            i = 0;

            foreach (string s in clas_f)
            {
                line = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                if(line[2]=="Mica")
                    cls[i++] = new Jucator(line[0], line[1], "1");
                else if (line[2] == "Medie")
                    cls[i++] = new Jucator(line[0], line[1], "2");
                else if (line[2] == "Mare")
                    cls[i++] = new Jucator(line[0], line[1], "3"); 
            }
          
        }

        public void AdaugaJ(Jucator x)
        {
            
            cls[10] = x;
            SortareCls();
            cls[10] = new Jucator("-", "0", "0");
            
            int i;

            //scriu clasamentl intr-un fisier
             StreamWriter cls_file = new StreamWriter(@"clasament_f.txt");
            
            for ( i = 0; i < 10; i++)
                cls_file.WriteLine(cls[i].Nume + "\t\t" + cls[i].Scor + "\t\t" + Jucator.vdif[Convert.ToInt32(cls[i].Dificultate)]);
                cls_file.Close();
        }

        private void SortareCls()
        {
            Jucator aux = new Jucator();

            for (int i = 0; i<10; i++)
                for (int j = i + 1; j < 11; j++)
                {
                    if (Convert.ToInt32(cls[i].Scor) < Convert.ToInt32(cls[j].Scor))
                    {
                        aux = cls[i];
                        cls[i] = cls[j];
                        cls[j] = aux;
                    }
                    else if (Convert.ToInt32(cls[i].Scor) == Convert.ToInt32(cls[j].Scor))
                    {
                        if (cls[i].Nume == "-" && cls[j].Nume != "-")
                        {
                            aux = cls[i];
                            cls[i] = cls[j];
                            cls[j] = aux;
                        }
                    }
                }
        }

        public string ToString()
        {

            //afisez din fisier -->> adaugaJ
            string nl = Environment.NewLine;

            string s = "  Nume\t\tScor\t\tDificultate" + nl;

            for (int i = 0; i < 10; i++)
                s += nl + (i + 1) + ".  " + cls[i].Nume + "\t\t" + cls[i].Scor + "\t\t" + Jucator.vdif[Convert.ToInt32(cls[i].Dificultate)];// +cls[i].Dificultate;

                return s;
        }
    }
}
