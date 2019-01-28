using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Auteur 
    {
        public int AuteurId { get; set; }
        public string Nom { get; set; }
        public string prenom { get; set; }
        public virtual ICollection<Document> ListDocument { get; set; }
    }
}
