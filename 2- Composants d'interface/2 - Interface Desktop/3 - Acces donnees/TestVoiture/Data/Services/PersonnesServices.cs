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

        public void AddPersonne(PersonnesDTOIn obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            var n = new Personne
            {
                Nom = obj.Nom,
                Prenom = obj.Prenom,
                IdVoiture = obj.IdVoiture,
            };
            _context.Personnes.Add(n);
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
            IEnumerable<Personne> liste= (from e1 in _context.Personnes
                                          join e2 in _context.Voitures
                                          on e1.IdVoiture equals e2.IdVoiture
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
            var n=from e1 in _context.Personnes
                join e2 in _context.Voitures
                on e1.IdVoiture equals e2.IdVoiture
                where e1.Id == id
                select new Personne
                {
                    Id = e1.Id,
                    Nom = e1.Nom,
                    Prenom = e1.Prenom,
                    IdVoiture = e2.IdVoiture,
                    LaVoiture = e2
                };
            return n.FirstOrDefault();
        }

        public void UpdatePersonne(Personne obj)
        {
            
            _context.SaveChanges();
        }


    }
}
