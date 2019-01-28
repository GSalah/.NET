using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Adherant
    {
        public int AdherantId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public int NbrAvertissement { get; set; }
        public virtual ICollection<Document> ListDoc { get; set; }
        public virtual ICollection<Document> ListDocComm{ get; set; }
        public virtual ICollection<Document> ListDocNote { get; set; }



    }
}
