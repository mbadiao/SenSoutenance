using ApplicationSenSoutenance.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationSenSoutenance.Shared
{
    public class FilerList
    {
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();

        public List<ListItem> FillAnneeAcademique()
        {
            var laListe = new List<ListItem>
            {
                new ListItem { Value = null, Text = "Sélectionner" }
            };

            foreach (var t in bd.anneeAcademiques.ToList())
            {
                laListe.Add(new ListItem
                {
                    Value = t.IdAnneeAcademique.ToString(),
                    Text = t.LibelleAnneeAcademique
                });
            }
            return laListe;
        }
    }
}
