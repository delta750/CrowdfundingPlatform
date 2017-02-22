using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CrowdfundingPlatform.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {   
        public DbSet<ProjectCategoryDto> Categories { get; set; }
        public DbSet<ProjectDTO> Project { get; set; }
        public DbSet<AttachmentDto> Attachment { get; set; }
        public DbSet<FundingPackageDto> FundingPackage { get; set; }
        public DbSet<ProjectCommentDto> ProjectComment { get; set; }
        public DbSet<ProjectStatsDto> ProjectStats { get; set; }
        public DbSet<ProjectUpdateDto> ProjectUpdate { get; set; }
        public DbSet<UserFundingDTO> UserFunding { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}