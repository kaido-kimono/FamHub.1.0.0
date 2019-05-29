using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Projectlibrary;

namespace FamHub._1._0._0.Models
{
    public class GestionUtilisateur
    {
        List<Utilisateur> utilisateurs = new List<Utilisateur>();

        public void EregisterUtilisateur(Utilisateur utilisateur)
        {

            var chemin = $"{Directory.GetCurrentDirectory()}\\{"Utilisateur"}";
            this.utilisateurs.Add(utilisateur);
            Serialisation<Utilisateur>.Srialisation(chemin, utilisateurs);
        }
    }
}
