using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Entity;
using System.Data.SqlClient;


namespace DAL.Persistence
{
    public class PaymentDal : DataBaseConnection
    {
        //inserir Pagamento no banco
        public void Insert(Payment a)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("insert into Payment(PkPurchase,Portion,PurchaseDate) values(@v1,@v2,@v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", a.Portion);
                Cmd.Parameters.AddWithValue("@v2", a.Portion);
                Cmd.Parameters.AddWithValue("@v3", a.PurchaseDate);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gerar Pagamento. " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
