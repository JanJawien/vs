using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab2 {
    class Osoba {
        private string imie;
        private string nazwisko;
        private int numer;
        private static readonly Regex replreg = new Regex(@"(?![0-9]).");

        private Osoba(string i, string n, int num) {
            imie = i;
            nazwisko = n;
            numer = num;
        }

        public string getImie() { return imie; }
        public string getNazwisko() { return nazwisko; }
        public int getNumer() { return numer; }



        public static Osoba newOsoba(string i, string n, string num) {
            int tel = 0;

            try {
                tel = int.Parse( replreg.Replace(num, "") );
                if(tel < 100000000 || tel > 999999999) throw new OverflowException();
                if(i.Equals("") || n.Equals("")) throw new ArgumentNullException();

            } catch (ArgumentNullException e) {
                MsgBox.OK("Parsing error", "Niektóre wartości są puste");
                return null;
            } catch (FormatException e) {
                MsgBox.OK("Parsing error", "Telefon nie jest liczbą");
                return null;
            } catch (OverflowException e) {
                MsgBox.OK("Parsing error", "Telefon nie ma 9 cyfr");
                return null;
            }

            return new Osoba(i, n, tel);
        }

        public void edit(string i,string n,string num) {
            Osoba newos = Osoba.newOsoba(i, n, num);
            if(newos == null) return;

            imie = i;
            nazwisko = n;
            numer = newos.numer;
            newos = null;
        }
    }

    
}
