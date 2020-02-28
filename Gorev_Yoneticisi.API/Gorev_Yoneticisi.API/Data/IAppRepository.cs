using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gorev_Yoneticisi.API.Model;

namespace Gorev_Yoneticisi.API.Data
{
  public  interface IAppRepository
  {
      void Add<T>(T entity) where T:class;
      void Delete<T>(T entity) where T : class;
      bool SaveAll();

      List<Work> GetWorksByUser(int userId);
      Work GetWork(int workId);
      List<WorkType> GetWorkTypes();

  }
}
