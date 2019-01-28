using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Professeur : Adherant
    {
        public string Departement { get; set; }
    }
}
