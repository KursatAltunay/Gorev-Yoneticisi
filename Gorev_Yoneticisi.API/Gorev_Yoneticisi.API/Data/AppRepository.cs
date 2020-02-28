using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gorev_Yoneticisi.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Gorev_Yoneticisi.API.Data
{
    public class AppRepository : IAppRepository
    {
        private DataContext _context;

        public AppRepository(DataContext context)
        {
            _context = context;
        }


        public void Add<T>(T entity) where T : class
        {
            _context.Add((entity));
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

        public List<Work> GetWorksByUser(int userId)
        {
            var works = _context.Works.Where(w=>w.UserId==userId).Include(w=>w.WorkType).ToList();
            return works;
        }

        public Work GetWork(int workId)
        {
            var work = _context.Works.Include(w=>w.WorkType).FirstOrDefault(w=>w.Id==workId);
            return work;
        }

        public List<WorkType> GetWorkTypes()
        {
            var workTypes = _context.WorkTypes.ToList();
            return workTypes;
        }
    }
}
