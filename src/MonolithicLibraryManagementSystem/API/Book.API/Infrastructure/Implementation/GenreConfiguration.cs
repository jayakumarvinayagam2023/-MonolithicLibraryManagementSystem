using LibraryManagement.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Infrastructure;

public static class GenreConfiguration
{
    public static void Configure(EntityTypeBuilder<Genre> endityBuilder)
    {
        endityBuilder.HasKey(x=>x.Id);           
    }
}