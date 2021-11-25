using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVoiture.Data.Dtos;
using TestVoiture.Data.Models;

namespace TestVoiture.Data.Services
{
    public class PersonnesServices
    {

        private readonly MyDbContext _context;

        public PersonnesServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddPersonne(Personne obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Personnes.Add(obj);
            _context.SaveChanges();
        }

        public void DeletePersonne(Personne obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Personnes.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Personne> GetAllPersonnes()
        {
            //      return _context.Personnes.ToList();
            //            IEnumerable<Personne> liste = _context.Personnes.Select(pers => new Personne()
            //            {
            //                Id = pers.Id,
            //                Nom = pers.Nom,
            //                Prenom = pers.Prenom,
            //                IdVoiture = pers.IdVoiture,
            ////                LaVoiture = pers.LaVoiture,
            //                }).ToList();
            IEnumerable<Personne> liste= (from e1 in _context.Personnes
                                          join e2 in _context.Voitures
                                          on new { e1.IdVoiture } equals new { e2.IdVoiture }
                                          select new Personne
                                          {
                                              Id = e1.Id,
                                              Nom = e1.Nom,
                                              Prenom= e1.Prenom,
                                              IdVoiture = e2.IdVoiture,
                                              LaVoiture = e2
                                          }).ToList();
            return liste;
        }

        public Personne GetPersonneById(int id)
        {
            return _context.Personnes.FirstOrDefault(obj => obj.Id == id);
        }

        public void UpdatePersonne(Personne obj)
        {
            _context.SaveChanges();
        }


    }
}
