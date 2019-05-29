using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamHub._1._0._0.Models
{
    [Serializable]
    public class Utilisateur
    {
        public string Nom { get; set; }
        public string PostNom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string Pseudo { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public string NumeroDeTelephone { get; set; }
        public string IdFamille { get; set; }
    }
}
