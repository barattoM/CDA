using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVoiture.Data.Dtos;
using TestVoiture.Data.Models;

namespace TestVoiture.Data.Services
{
    public class VoituresServices
    {

        private readonly MyDbContext _context;

        public VoituresServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddVoiture(Voiture v)
        {
            if (v == null)
            {
                throw new ArgumentNullException(nameof(v));
            }

            _context.Voitures.Add(v);
            _context.SaveChanges();
        }

        public void DeleteVoiture(Voiture v)
        {
            if (v == null)
            {
                throw new ArgumentNullException(nameof(v));
            }
            _context.Voitures.Remove(v);
            _context.SaveChanges();
        }

        public IEnumerable<Voiture> GetAllVoitures()
        {
            //IEnumerable<Voiture> liste = (from e2 in _context.Voitures
            //                               select new Voiture
            //                               {
            //                                   IdVoiture= e2.IdVoiture,
            //                                   Marque = e2.Marque,
            //                                   Modele = e2.Modele,
            //                                   LesPersonnes= _context.Personnes.Where(p => p.IdVoiture==e2.IdVoiture).ToList()
            //                               }).ToList();
            return _context.Voitures.Include("LesPersonnes").ToList();
        }

        public Voiture GetVoitureById(int id)
        {
            //var n = from e1 in _context.Personnes
            //        join e2 in _context.Voitures
            //        on e1.IdVoiture equals e2.IdVoiture
            //        where e2.IdVoiture == id
            //        select new Voiture
            //        {
            //            IdVoiture = e2.IdVoiture,
            //            Marque = e2.Marque,
            //            Modele = e2.Modele,
            //            LesPersonnes = _context.Personnes.Where(p => p.IdVoiture == e2.IdVoiture).ToList()
            //        };
            return _context.Voitures.Include("LesPersonnes").FirstOrDefault(obj => obj.IdVoiture == id);
        }

        public void UpdateVoiture(Voiture v)
        {
            _context.SaveChanges();
        }


    }
}
