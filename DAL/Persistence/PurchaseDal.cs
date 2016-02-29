using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    class PurchaseDal :DataBaseConnection
    {

        //inserir pagamento no banco
        public void Insert(Purchase p)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand
                    ("insert into Purchase(PkUser,PkTicket,QuantityTicket,PurchaseDate) values(@v1,@v2,@v3,@v4)");
                Cmd.Parameters.AddWithValue("@v1", p.PkUser);
                Cmd.Parameters.AddWithValue("@v2", p.PkTicket);
                Cmd.Parameters.AddWithValue("@v3", p.QuantityPurchase);
                Cmd.Parameters.AddWithValue("@v4", p.PurchaseDate);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gerar Compra. " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}
