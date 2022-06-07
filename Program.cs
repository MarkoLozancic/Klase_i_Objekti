
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_Objekti
{
    class Zrakoplov
    {
        private string naziv;
        private int snagaMotora;
        private int dosegLeta;

        public override string ToString()
        {
            string ispis = "\nNaziv: " + naziv + "\nSnaga: " + snagaMotora + "kW"
                + "\nDoseg leta: " + dosegLeta + "km";
            return ispis;
        }
        public Zrakoplov()
        {

        }

        public Zrakoplov(string naziv, int snagaMotora, int dosegLeta)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.dosegLeta = dosegLeta;
        }

        public Zrakoplov(string naziv, int snagaMotora)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
        }

        public string getNaziv()
        {
            return naziv;
        }
        public void setNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public int getSnagaMotora()
        {
            return snagaMotora;
        }
        public void setSnagaMotora(int snagaMotora)
        {
            this.snagaMotora = snagaMotora;
        }
        public int getDosegLeta()
        {
            return dosegLeta;
        }
        public void setDosegLeta(int dosegLeta)
        {
            this.dosegLeta = dosegLeta;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov();
            x380.setNaziv("Airbus");
            x380.setDosegLeta(6000);
            x380.setSnagaMotora(2000);

            Console.WriteLine("\nNaziv: " + x380.getNaziv() + "\nSnaga: " + x380.getSnagaMotora() + "kW"
                + "\nDoseg leta: " + x380.getDosegLeta() + "km");

            Zrakoplov PU123RO = new Zrakoplov("Cessna", 350, 125);
            Console.WriteLine(PU123RO.ToString());

            Zrakoplov x328 = new Zrakoplov("MeanMachine", 5000);
            Console.WriteLine(x328.ToString());
            string unos;
            int domet;

            try
            {
                Console.WriteLine("\nUpiši doseg leta aviona " + x328.getNaziv() + " :");
                // varijanta 1
                unos = Console.ReadLine();
                domet = Convert.ToInt32(unos);
                x328.setDosegLeta(domet);
                // varijanta 2
                x328.setDosegLeta(Convert.ToInt32(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Nisi upisao brojčanu vrijednost!");

            }
            Console.WriteLine(x328.ToString());

            Console.ReadKey();
        }
    }
}
