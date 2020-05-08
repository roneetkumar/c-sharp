using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreLoginEfDbFirst.Models.DB
{
    public partial class db_coreloginContext : DbContext
    {
        public db_coreloginContext()
        {
        }

        public db_coreloginContext(DbContextOptions<db_coreloginContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Login> Login { get; set; }

        ////protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  
        ////{  
        ////    if (!optionsBuilder.IsConfigured)  
        ////    {  
        ////        optionsBuilder.UseSqlServer("Server=SQL SERVER;Database=DATABASE;User id=SQL USERNAME;Password=SQL PASSWORD;Trusted_Connection=True;");  
        ////    }  
        ////}  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////modelBuilder.Entity<Login>(entity =>  
            ////{  
            ////    entity.Property(e => e.Id).HasColumnName("id");  

            ////    entity.Property(e => e.Password)  
            ////        .IsRequired()  
            ////        .HasColumnName("password")  
            ////        .HasMaxLength(50)  
            ////        .IsUnicode(false);  

            ////    entity.Property(e => e.Username)  
            ////        .IsRequired()  
            ////        .HasColumnName("username")  
            ////        .HasMaxLength(50)  
            ////        .IsUnicode(false);  
            ////});  

            // [Asma Khalid]: Query for store procedure.  
            modelBuilder.Query<LoginByUsernamePassword>();
        }

        #region Login by username and password store procedure method.  

        /// <summary>  
        /// Login by username and password store procedure method.  
        /// </summary>  
        /// <param name="usernameVal">Username value parameter</param>  
        /// <param name="passwordVal">Password value parameter</param>  
        /// <returns>Returns - List of logins by username and password</returns>  
        public async Task<List<LoginByUsernamePassword>> LoginByUsernamePasswordMethodAsync(string usernameVal, string passwordVal)
        {
            // Initialization.  
            List<LoginByUsernamePassword> lst = new List<LoginByUsernamePassword>();

            try
            {
                // Settings.  
                SqlParameter usernameParam = new SqlParameter("@username", usernameVal ?? (object)DBNull.Value);
                SqlParameter passwordParam = new SqlParameter("@password", passwordVal ?? (object)DBNull.Value);

                // Processing.  
                string sqlQuery = "EXEC [dbo].[LoginByUsernamePassword] " +
                                    "@username, @password";

                lst = await this.Query<LoginByUsernamePassword>().FromSql(sqlQuery, usernameParam, passwordParam).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Info.  
            return lst;
        }

        #endregion
    }
}