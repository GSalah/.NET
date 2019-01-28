using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Emprunt
    {
        public int EmpruntId { get; set; }
        public DateTime Date { get; set; }
        public virtual Document Document { get; set; }
        public virtual Adherant Adherent { get; set; }
    }
}
