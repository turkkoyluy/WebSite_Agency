using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcunMedyaAkademiAgency.Entities;
using System.Data.Entity;

namespace AcunMedyaAkademiAgency.Context
{
    public class AgencyContext:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature>Features { get; set; }
        public DbSet<Project>Projects { get; set; }
        public DbSet<Service>Services { get; set; }
        public DbSet<Team>Teams { get; set; }
        public DbSet<ProjectDetails> ProjectDetails { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

    }
}