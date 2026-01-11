using ApplicationSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace ApplicationSenSoutenance.Shared
{
    public class FilerList
    {
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();
        /// <summary>
        /// remplir la liste des annees academiques
        /// </summary>
        /// <returns></returns>

        public List<ListItem> FillAnneeAcademique()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = bd.anneeAcademiques.ToList();
            laListe.Add(new ListItem
            {
                Value = null,
                Text = "Sélectionner"
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.IdAnneeAcademique.ToString(),
                    Text = t.LibelleAnneeAcademique.ToString()
                };
                laListe.Add(item);
            }
            return laListe;
        }
    }
}
