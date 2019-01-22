using DependencyInjectionWithCastle.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithCastle.Services
{
    public  interface IGravityServices 
    {
        string Add(IranGravity entity);
        string Remove(int? id);
        string Update(IranGravity entity);
        List<IranGravity> GetAll();
        IranGravity GetById(int? id);

    }
}
