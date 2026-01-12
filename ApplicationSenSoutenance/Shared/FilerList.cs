using ApplicationSenSoutenance.Models;
using System;
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

        public List<ListItem> FillSessions()
        {
            var laListe = new List<ListItem>
            {
                new ListItem { Value = null, Text = "Sélectionner" }
            };

            foreach (var s in bd.sessions.ToList())
            {
                laListe.Add(new ListItem
                {
                    Value = s.IdSession.ToString(),
                    Text = s.LibelleSession
                });
            }
            return laListe;
        }

        public List<ListItem> FillCandidats()
        {
            var laListe = new List<ListItem>
            {
                new ListItem { Value = null, Text = "Sélectionner" }
            };

            foreach (var c in bd.candidats.ToList())
            {
                laListe.Add(new ListItem
                {
                    Value = c.IdUtilisateur.ToString(),
                    Text = $"{c.NomUtilisateur} {c.PrenomUtilisateur}"
                });
            }
            return laListe;
        }

        public List<ListItem> FillProfesseurs()
        {
            var laListe = new List<ListItem>
            {
                new ListItem { Value = null, Text = "Sélectionner" }
            };

            foreach (var p in bd.professeurs.ToList())
            {
                laListe.Add(new ListItem
                {
                    Value = p.IdUtilisateur.ToString(),
                    Text = $"{p.NomUtilisateur} {p.PrenomUtilisateur}"
                });
            }
            return laListe;
        }

        public List<ListItem> FillMemoires()
        {
            var laListe = new List<ListItem>
            {
                new ListItem { Value = null, Text = "Sélectionner" }
            };

            foreach (var m in bd.memoires.ToList())
            {
                var candidat = bd.candidats.Find(m.IdCandidat);
                var sujetCourt = m.SujetMemoire.Length > 40
                    ? m.SujetMemoire.Substring(0, 40) + "..."
                    : m.SujetMemoire;
                laListe.Add(new ListItem
                {
                    Value = m.IdMemoire.ToString(),
                    Text = $"{candidat?.NomUtilisateur} - {sujetCourt}"
                });
            }
            return laListe;
        }
    }
}
