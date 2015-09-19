using Penyia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Penyia.DataAccess
{
    public class PenyiaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PenyiaContext>
    {
        protected override void Seed(PenyiaContext context)
        {
            var users = new List<User>
            {
            new User{FirstName="Carson",LastName="Alexander",Email = "car@live.dk",UserName = "carbo",Password = "123XCV"},
            new User{FirstName="Arun",LastName="Sivagnanam",Email = "Arun.s@live.dk",UserName = "a-run",Password = "1234"},
            new User{FirstName="Kim",LastName="Hansen",Email = "kimie@live.dk",UserName = "lilleKim",Password = "1234"},
            new User{FirstName="Hans",LastName="Mongo",Email = "mongo@live.dk",UserName = "Mongo",Password = "1234"}
          
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            
        }

    }
}