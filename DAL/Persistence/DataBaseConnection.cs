using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL.Persistence
{
    public class DataBaseConnection
	{
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        protected void OpenConnection()
        {
            
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["desafio"].ConnectionString);
            
            Con.Open();
        }

        protected void CloseConnection()
        {
            Con.Close();
        }
	}





    //public class DataBaseConnection : DbContext
    //{
    //    public DataBaseConnection()
    //        : base(ConfigurationManager.ConnectionStrings["desafio"].ConnectionString)
    //    {

    //    }
    //    public DbSet<Attraction> Attractions { get; set; }
    //    public DbSet<FormPayment> FormPayments { get; set; }
    //    public DbSet<Payment> Payments { get; set; }
    //    public DbSet<SystemUser> SystemUsers { get; set; }
    //    public DbSet<Ticket> Tickets { get; set; }


    //}
}
