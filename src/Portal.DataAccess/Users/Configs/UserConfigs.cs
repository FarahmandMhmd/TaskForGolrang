using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Users;

namespace Portal.DataAccess.Users.Configs;

public class UserConfigs : IEntityTypeConfiguration<User>
{

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.UserName).IsRequired();
        builder.Property(x => x.Password).IsRequired();
        builder.Property(x => x.Country).IsRequired();
    }
}
