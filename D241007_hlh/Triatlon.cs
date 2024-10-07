using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D241007_hlh
{
    internal class Triatlon
    {
        public string Nev { get; set; }
        public int SzulEv { get; set; }
        public int RajtSzam { get; set; }
        public string Nem { get; set; }
        public string KorKategoria { get; set; }
        public DateTime Uszas {  get; set; }
        public DateTime Depo { get; set; }
        public DateTime Kerekpar { get; set; }
        public DateTime MasoDepo { get; set; }
        public DateTime Futas { get; set; }
        public DateTime Ossz {  get; set; }

        public override string ToString()
        {
            return $"{Nev}, {SzulEv}, {RajtSzam}, {Nem}, {KorKategoria}, {Uszas}, {Depo}, {Kerekpar}, {MasoDepo}, {Futas}";
        }

        //public void Osszeg()
        //{
        //    int Osszegd = Uszas + Depo + Kerekpar + MasoDepo + Futas;
        //}

        public Triatlon(string row)
        {
            var v = row.Split(';');
            Nev = v[0];
            SzulEv = Convert.ToInt32(v[1]);
            RajtSzam = Convert.ToInt32(v[2]);
            Nem = v[3];
            KorKategoria = v[4];
            Uszas = Convert.ToDateTime(v[5]);
            Depo = Convert.ToDateTime(v[6]);
            Kerekpar = Convert.ToDateTime(v[7]);
            MasoDepo = Convert.ToDateTime(v[8]);
            Futas = Convert.ToDateTime(v[9]);
        }
    }
}
