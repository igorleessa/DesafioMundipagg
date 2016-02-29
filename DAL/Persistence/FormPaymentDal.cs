using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using System.Data.SqlClient;


namespace DAL.Persistence
{
    public class FormPaymentDal : DataBaseConnection
    {
        //inserir Pagamento no banco
        public void Insert(FormPayment a)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("insert into FormPayment(PkPayemnt,Plots,ExpirationDate,ValuePlots) values(@v1,@v2,@v3,@v4)", Con);

                Cmd.Parameters.AddWithValue("@v1", a.PkPayment);
                Cmd.Parameters.AddWithValue("@v2", a.Plots);
                Cmd.Parameters.AddWithValue("@v3", a.ExpirationDate);
                Cmd.Parameters.AddWithValue("@v4", a.ValuePlots);

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
