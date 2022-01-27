using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMulticouche.Data.Models;

namespace TestMulticouche.Data.Services
{
    public class TextesServices
    {

        private readonly MyDbContext _context;

        public TextesServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddTexte(Texte obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Textes.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteTexte(Texte obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Textes.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Texte> GetAllTextes()
        {
            return _context.Textes.ToList();
        }

        public Texte GetTexteById(int id)
        {
            return _context.Textes.FirstOrDefault(obj => obj.IdTexte == id);
        }

        public void UpdateTexte(Texte obj)
        {
            _context.SaveChanges();
        }


    }
}
