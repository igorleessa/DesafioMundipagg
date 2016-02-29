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
    public class TicketDal : DataBaseConnection
    {
        //atualiza quantidade de ingressos para o evento
        public void Update(Ticket a)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("update Ticket set QuantityTicket = @v2 where PkAttraction = @v1", Con);
                Cmd.Parameters.AddWithValue("@v2", a.QuantityTicket);
                Cmd.Parameters.AddWithValue("@v1", a.PkAttraction);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar quantidade de ingressos. " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        //lista todos os ingressos
        public List<Ticket> FindAll()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("select * from Ticket order by PkAttraction");
                Dr = Cmd.ExecuteReader();
                List<Ticket> list = new List<Ticket>();
                while (Dr.Read())
                {
                    Ticket t = new Ticket();
                    t.PkAttraction = Convert.ToInt32(Dr["PkAttraction"]);
                    t.PkTicket = Convert.ToInt32(Dr["PkTicket"]);

                    list.Add(t);
                }
                return list;
            }
            catch
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }


        /*
        public DataBaseConnection Con = new DataBaseConnection();


        //metoto para inserir ticket
        public void Insert(Ticket t)
        {
            try
            {
                Con.Tickets.Add(t);
                Con.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //buscar Ticket por ID
        public Ticket FindById(int PkTicket)
        {
            try
            {
                    return Con.Tickets.Find(PkTicket);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao obter Ingresso: " + ex.Message);
            }
        }
        */
    }
}
