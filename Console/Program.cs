using Data;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque bib1 = new Bibliotheque() { BibliothequeId = 1, NbrDocuments = 8 };
            Context ctx = new Context();
            ctx.Bibliotheques.Add(bib1);
            ctx.SaveChanges();
            System.Console.WriteLine( "ok");
            System.Console.ReadKey();
        }
    }
}
