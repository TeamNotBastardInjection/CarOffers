﻿using System.Data.Entity;
using CarAdvertsSystem.Data.Contracts;
using CarAdvertsSystem.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CarAdvertsSystem.Data
{
    public class CarAdvertsSystemDbContext : IdentityDbContext<User>, ICarAdvertsSystemDbContext
    {
        public CarAdvertsSystemDbContext()
            : base("CarAdvertsDb")
        {
        }

        public virtual IDbSet<Advert> Adverts { get; set; }
        public virtual IDbSet<City> Cities { get; set; }
        public virtual IDbSet<Category> Categories { get; set; }
        public virtual IDbSet<Manufacturer> Manufacturers { get; set; }
        public virtual IDbSet<VethicleModel> VethicleModels { get; set; }

        //public virtual IDbSet<CategoryType> CategoryTypes { get; set; }

       

        public static CarAdvertsSystemDbContext Create()
        {
            return new CarAdvertsSystemDbContext();
        }
    }
}
