using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cac41a6e-a7bb-4448-baad-1add414ccbbf",
                    UserId = "acb23a7e-b4cc-3724-bccd-3bdd229cc882",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "bac44a6e-b7cc-4448-badf-1cdd267badde",
                    UserId = "bac32a2e-b4aa-2437-baad-5bee229bb228",
                }
            );
        }
    }
}