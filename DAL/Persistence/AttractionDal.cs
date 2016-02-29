using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using System.Data.Entity;
using System.Data.SqlClient;


namespace DAL.Persistence 
{
    public class AttractionDal : DataBaseConnection
    {
        //inserir atração no banco
        public void Insert(Attraction a)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("insert into Attraction(AttractionName,AttractionDate,AttractionDescription,AttractionAddress,AttractionImage,TicketPriceQuantity) values(@v1,@v2,@v3,@v4,@v5,@v5@v6,@v7)", Con);

                Cmd.Parameters.AddWithValue("@v1", a.AttractionName);
                Cmd.Parameters.AddWithValue("@v2", a.AttractionDate);
                Cmd.Parameters.AddWithValue("@v3", a.AttractionDescription);
                Cmd.Parameters.AddWithValue("@v4", a.AttractionAddress);
                Cmd.Parameters.AddWithValue("@v5", a.AttractionImage);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar Evento. " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        //busca evento por nome
        public Attraction Find(int AttractionName)
        {
            try
            {
                OpenConnection();

                Cmd = new SqlCommand("select * from Attraction where AttractionName = @v1 ", Con);

                Cmd.Parameters.AddWithValue("@v1", AttractionName);

                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Attraction f = new Attraction();
                    f.PkAttraction = Convert.ToInt32(Dr["PkAttraction"]);
                    f.AttractionName = Convert.ToString(Dr["AttractionName"]);

                    return f;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao obter Eventos. " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        //lista todos os eventos
            public List<Attraction> FindAll()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("select * from Attraction order by AttractionName");
                Cmd.Connection = Con;
                Dr = Cmd.ExecuteReader();
                List<Attraction> list = new List<Attraction>();
                while (Dr.Read())
                {
                    Attraction f = new Attraction();
                    f.PkAttraction = Convert.ToInt32(Dr["PkAttraction"]);
                    f.AttractionName = Convert.ToString(Dr["AttractionName"]);
                    f.AttractionDate = Convert.ToString(Dr["AttractionDate"]);
                    f.AttractionAddress = Convert.ToString(Dr["AttractionAddress"]);
                    f.AttractionDescription = Convert.ToString(Dr["AttractionDescription"]);
                    f.AttractionImage = Convert.ToString(Dr["AttractionImage"]);

                    list.Add(f);
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
        //Listar todos os Eventor do banco
        public List<Attraction> FindAll()
        {
            try
            {
                using (DataBaseConnection Con = new DataBaseConnection())
                {
                    return Con.Attractions.OrderBy(a => a.AttractionName).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar Eventor: " + ex.Message);
            }
        }

        //Metoto para obter 1 unico evento por ID
        public Attraction FindById(int PkAttraction)
        {
            try
            {
                using (DataBaseConnection Con = new DataBaseConnection())
                {
                    return Con.Attractions.Find(PkAttraction);
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao obter Evento: " + ex.Message);
            }
        }
        */
    }
}
