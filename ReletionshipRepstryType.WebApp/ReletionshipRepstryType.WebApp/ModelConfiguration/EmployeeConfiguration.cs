using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReletionshipRepstryType.WebApp.Models;

namespace ReletionshipRepstryType.WebApp.ModelConfiguration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
          builder.ToTable(nameof(Employee));
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Address).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Gender).HasMaxLength(50).IsRequired();
            builder.Property(e => e.JoiningDate).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Ssc).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Hsc).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Bsc).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Msc).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Picture).HasMaxLength(50).IsRequired();
        }
    }
}
