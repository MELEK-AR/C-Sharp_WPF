using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TannenBaum
{
    internal class Model
    {
        public string Up(int zahl)
        {
            string ergebniss = "";
            string stern = "*";
            for (int i = 0; i < zahl; i++)
            {
                string lucke = new string(' ', zahl - i);
                ergebniss += lucke + stern + "\n";
                stern += "*";
            }
            return ergebniss;
        }

        public string Down(int zahl)
        {
            string ergebniss = "";
            string stern = "*";
            for (int i = 0; i < zahl; i++)
            {
                ergebniss += stern + "\n";
                stern += "*";
            }
            return ergebniss;
        }

        public string TannenBaum(int zahl)
        {
            string ergebniss = "";
            string stern = "*";
            string stern2 = new string('*', zahl/4);

            for (int i = 0; i < zahl; i++)
            {
                string lucke = new string(' ', zahl - i -1  );

                ergebniss += lucke + stern + stern + "\n";
                stern += "*";
            }

            for (int i = 0; i < zahl / 4; i++)
            {
                string lucke2 = new string(' ', zahl + zahl/5);
                ergebniss += lucke2 + stern2 + "\n";
            }
            return ergebniss;
        }


    }
}
