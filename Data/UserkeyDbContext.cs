using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ECNcloud.Data
{
    public class UserkeyDbContext : DbContext
    {
        #region Contructor

        public UserkeyDbContext(DbContextOptions<UserkeyDbContext> options) : base(options)
        {
        }

        #endregion

        #region Public properties

        public DbSet<Userkey> Userkey { get; set; }

        #endregion

        #region Overidden methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Userkey>().HasData(GetUserkeys());
            base.OnModelCreating(modelBuilder);
        }

        #endregion


        #region Private methods

        private List<Userkey> GetUserkeys()
        {
            return new List<Userkey>
            {
                new Userkey
                {
                    Id = 1,
                    Key = "FDC7D9355A9A1F080C05FCE3BBBE30A64974BEBD843CBD14",
                    Subdirectory = "56D79BBB857BEEA73A0376A2539059212F4A579D0050E10A",
                    DisplayName = "Test account"
                }
            };
        }

        #endregion
    }
}