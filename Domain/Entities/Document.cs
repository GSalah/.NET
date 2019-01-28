using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public enum Etat
    {
        Disponible,Emprunte
    }


    public class Document
    {
        public int DocumentId { get; set; }
        public Etat Etat { get; set; }
        public string Titre { get; set; }
        public string categorie { get; set; }
        public virtual ICollection<Auteur> ListAuteur { get; set; }
        public virtual Bibliotheque Bib { get; set; }
        public virtual ICollection<Emprunt> Emprunt { get; set; }
        public virtual ICollection<Adherant> ListAdherant{ get; set; }
        public virtual ICollection<Adherant> ListAdh { get; set; }




    }
}
