using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ECNcloud.Data
{
    public class UserkeyServices
    {
        #region Private members

        private UserkeyDbContext dbContext;

        #endregion

        #region Constructor

        public UserkeyServices(UserkeyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// This method returns the list of Userkey
        /// </summary>
        /// <returns></returns>
        public async Task<List<Userkey>> GetUserkeyAsync()
        {
            return await dbContext.Userkey.ToListAsync();
        }

        /// <summary>
        /// This method add a new Userkey to the DbContext and saves it
        /// </summary>
        /// <param name="Userkey"></param>
        /// <returns></returns>
        public async Task<Userkey> AddUserkeyAsync(Userkey userkey)
        {
            try
            {
                dbContext.Userkey.Add(userkey);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return userkey;
        }

        /// <summary>
        /// This method update and existing Userkey and saves the changes
        /// </summary>
        /// <param name="Userkey"></param>
        /// <returns></returns>
        public async Task<Userkey> UpdateUserkeyAsync(Userkey userKey)
        {
            try
            {
                var userKeyExist = dbContext.Userkey.FirstOrDefault(p => p.Id == userKey.Id);
                if (userKeyExist != null)
                {
                    dbContext.Update(userKey);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return userKey;
        }

        /// <summary>
        /// This method removes and existing Userkey from the DbContext and saves it
        /// </summary>
        /// <param name="Userkey"></param>
        /// <returns></returns>
        public async Task DeleteUserkeyAsync(Userkey userkey)
        {
            try
            {
                dbContext.Userkey.Remove(userkey);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}