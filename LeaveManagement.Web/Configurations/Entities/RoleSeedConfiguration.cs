using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "cac41a6e-a7bb-4448-baad-1add414ccbbf",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "bac44a6e-b7cc-4448-badf-1cdd267badde",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
           );
        }
    }
}