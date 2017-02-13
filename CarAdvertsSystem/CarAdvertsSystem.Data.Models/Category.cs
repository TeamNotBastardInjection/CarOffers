﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CarAdvertsSystem.Data.Models.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarAdvertsSystem.Data.Models
{
    public class Category : ICategory
    {
        private ICollection<VehicleModel> vethicleModel;

        public Category()
        {
            this.vethicleModel = new HashSet<VehicleModel>();
        }

        [Key]
        public int Id { get; set; }
        
        [Required]
        [Index(IsUnique = true)]
        public CategoryType Name { get; set; }

        public virtual ICollection<VehicleModel> VethicleModels
        {
            get
            {
                return this.vethicleModel;
            }

            set
            {
                this.vethicleModel = value;
            }
        }
    }
}
