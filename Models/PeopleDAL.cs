
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithReactAspNetCore.Models
{
    public class PeopleDAL
    {
        people_dbContext db = new people_dbContext();

        //this method will get all the student record
        public IEnumerable<Peoples> GetAllPeoples()
        {
            return db.Peoples.ToList();
        }

        

    }
}