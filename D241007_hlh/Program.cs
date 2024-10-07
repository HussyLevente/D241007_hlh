using D241007_hlh;
using System.Linq;
using System.Text;

List<Triatlon> versenyzok = [];

using StreamReader sr = new(@"forras.txt", Encoding.UTF8);

while (!sr.EndOfStream)
{
    versenyzok.Add(new(sr.ReadLine()));
}

Console.WriteLine($"Ennyi versenyző fejezte be a versenyt: {versenyzok.Count()}");


var f1 = versenyzok.Count(r => r.KorKategoria == "elit junior");
Console.WriteLine($"A versenyzők száma elit junior kategóriában: {f1}");


var f2 = versenyzok.Where(p => p.Nem == "f").Average(p => DateTime.Now.Year - p.SzulEv);
Console.WriteLine($"Férfi versenyzők átlag életkora: {f2:0.00} év");


int f3 = versenyzok.Sum(r => r.Futas);
Console.WriteLine($"A versenyzők futással töltött összideje órában: {f3:0.00}");


int f4 = versenyzok.Where(p => p.KorKategoria == "20-24").Average(r => r.Uszas);
Console.WriteLine($"Átlagos úszási idő 20-24 kategóriában: {f4}");


var f5 = versenyzok.Where(p => p.Nem == "n").Min(p => p.Uszas);
Console.WriteLine($"Női győztes: {f5} ");


var f6 = versenyzok.GroupBy(r => r.Nem);
Console.WriteLine("Nemenként a versenyt befejezők száma:");
foreach (var sextypesGroup in f6)
{
    Console.WriteLine($"\t{sextypesGroup.Key} {sextypesGroup.Count()} db");
}