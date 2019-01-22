using DependencyInjectionWithCastle.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DependencyInjectionWithCastle.Services
{
    public class GravityServices : IGravityServices
    {
        private readonly MyContext _context;
        private readonly DbSet<IranGravity> _dbSet;
        public GravityServices( MyContext context)
        {
            _context = context;
         _dbSet = context.Set<IranGravity>();
        }
        public string Add(IranGravity entity)
        {
           _dbSet.Add(entity);
            _context.Entry(entity).State = EntityState.Added;
       int commitResult=   _context.SaveChanges();
           
            if (commitResult>0)
            {
                return "New iran gravity record added successfully";
            }
            else

            {
                return "Failed";
            }

        }

        public List<IranGravity> GetAll()
        {
            return _dbSet.ToList();
        }

        public IranGravity GetById(int? id)
        {
            return _dbSet.Find(id);
        }

        public string Remove(int? id)
        {
            var gravity = _dbSet.Find(id);
            if (gravity != null)
            {

                _dbSet.Remove(gravity);
              
            }
            _context.Entry(gravity).State = EntityState.Deleted;
            int commitResult = _context.SaveChanges();
            if (commitResult>0)
            {
                return "Successfully deleted of iran gravity records";
            }
            else
            {
                return "Failed";
            }
        }

        public string Update(IranGravity entity)
        {
            var gravity = _dbSet.Find(entity.Id);
            if (gravity !=null)
            {
                gravity.Title = entity.Title;
                gravity.Location = entity.Location;
                gravity.Description = entity.Description;
                
            }
            _context.Entry(gravity).State = EntityState.Modified;
          int commitResult=  _context.SaveChanges();
            if (commitResult>0)
            {
                return "Iran gravity record updated successfully";
            }
            else
            {
                return "Failed";
            }
                   
        }
    }
}
