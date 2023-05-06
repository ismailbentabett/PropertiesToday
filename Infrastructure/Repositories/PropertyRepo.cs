using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Domain;

namespace Infrastructure.Repositories
{
    public class PropertyRepo : IPropertyRepo
    {
                private 
            readonly
        Contexts.ApplicationDbContext _context;

        public PropertyRepo(Contexts.ApplicationDbContext context)
        {
            _context = context;
        }


        IEnumerable<Property> IPropertyRepo.GetAllProperties()
        {
            return _context.Properties.ToList();

        }

        Property IPropertyRepo.GetPropertyById(int id)
        {
            return _context.Properties.FirstOrDefault(p => p.Id == id);
        }

        void IPropertyRepo.AddProperty(Property property)
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }
            _context.Properties.Add(property);
            _context.SaveChanges();
        }

        void IPropertyRepo.UpdateProperty(Property property)
        {
            _context.Properties.Update(property);
            _context.SaveChanges();
        }

        void IPropertyRepo.DeleteProperty(Property property)
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }
            _context.Properties.Remove(property);
            _context.SaveChanges();
        }

        bool IPropertyRepo.SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}