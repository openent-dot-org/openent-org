// <auto-generated />
using ECNcloud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECNcloud.Migrations
{
    [DbContext(typeof(UserkeyDbContext))]
    partial class UserkeyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("ECNcloud.Data.Userkey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subdirectory")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Userkey");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayName = "Test account",
                            Key = "FDC7D9355A9A1F080C05FCE3BBBE30A64974BEBD843CBD14",
                            Subdirectory = "56D79BBB857BEEA73A0376A2539059212F4A579D0050E10A"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
