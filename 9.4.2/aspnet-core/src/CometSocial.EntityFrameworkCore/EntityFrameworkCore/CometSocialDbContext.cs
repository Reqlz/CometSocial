using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CometSocial.Authorization.Roles;
using CometSocial.Authorization.Users;
using CometSocial.MultiTenancy;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Data;
using CometSocial.CometUsers;
using CometSocial.CometGroups;
using CometSocial.CometFollowers;
using CometSocial.CometPosts;
using CometSocial.CometInteractionTypes;
using CometSocial.CometUsersGroups;
using CometSocial.CometPostsInteractions;
using CometSocial.CometInteractions;

namespace CometSocial.EntityFrameworkCore
{
    public class CometSocialDbContext : AbpZeroDbContext<Tenant, Role, User, CometSocialDbContext>
    {
        public DbSet<CometUser> CometUsers { get; set; }
        public DbSet<CometGroup> CometGroups { get; set; }
        public DbSet<CometFollower> CometFollowers { get; set; }
        public DbSet<CometPost> CometPosts { get; set; }
        public DbSet<CometInteraction> CometInteractions { get; set; }
        public DbSet<CometInteractionType> CometInteractionTypes { get; set; }
        public DbSet<CometUsersGroup> CometUsersGroups { get; set; }
        public DbSet<CometPostsInteraction> CometPostInteractions { get; set; }

        public CometSocialDbContext(DbContextOptions<CometSocialDbContext> options)
            : base(options)
        {
        }
    }
}
