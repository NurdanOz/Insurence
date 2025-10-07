using Insurence.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Insurence.Models
{
    public class InsuranceDbContext:DbContext
    {

        public InsuranceDbContext() : base("name=InsuranceDbEntities")
        { 
        }
        public DbSet<TblAbout> TblAbouts { get; set; }
        public DbSet<TblContact> TblContacts { get; set; }
        public DbSet<TblService> TblServices { get; set; }
        public DbSet<TblSSS> TblSSSes { get; set; }
        public DbSet<TblEmploye> TblEmployes { get; set; }
        public DbSet<TblFeature> TblFeatures { get; set; }
        public DbSet<TblSocialMedia> TblSocialMedias { get; set; }
        public DbSet<TblTestimonial> TblTestimonials { get; set; }

    }
}