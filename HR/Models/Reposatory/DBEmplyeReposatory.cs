using HR.IBaseInterFace;
using HR.Models.DataCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models.Reposatory
{
    public class DBEmplyeReposatory : IBase1<Emplye>
    {
        DbSetsOfHR db;

        public DBEmplyeReposatory(DbSetsOfHR _db)
        {
            db = _db;
        }

        public void Add(Emplye? entity)
        {
            db.emplyes.Add(entity);
        }

        public void Delete(int? Id)
        {
            var emp = Find(Id);
            db.emplyes.Remove(emp);
        }

        public Emplye Find(int? Id)
        {
            var emp = db.emplyes.SingleOrDefault(x => x.Id == Id);

            return emp;
        }

        public IList<Emplye> List()
        {
            return db.emplyes.ToList();
        }

        public List<Emplye> Search(string trem)
        {
            var Result = db.emplyes.Where(x =>
            x.F_Name.Contains(trem)
            || x.L_Name.Contains(trem)).ToList();
            return Result;
        }

        public void Update(int id, Emplye model)
        {
            db.emplyes.Update(model);
        }
    }
}
