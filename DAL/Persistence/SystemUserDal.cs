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
    public class SystemUserDal : DataBaseConnection
    {
        //inserir usuario no banco
        public void InsertUser(SystemUser u)
        {
            try
            {
                OpenConnection();
                //Cmd.Connection = Con;
                Cmd = new SqlCommand("insert into SystemUser(UserName,UserCpf,UserBirth,UserGender,AddressCep,AddressStreet,AddressNumber,AddressComplement,AddressCity,AddressState,AddressDistrict,UserLogin,UserPassword) values(@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13)");
                Cmd.Parameters.AddWithValue("@v1", u.UserName);
                Cmd.Parameters.AddWithValue("@v2", u.UserCpf);
                Cmd.Parameters.AddWithValue("@v3", u.UserBirth);
                Cmd.Parameters.AddWithValue("@v4", u.UserGender);
                Cmd.Parameters.AddWithValue("@v5", u.AddressCep);
                Cmd.Parameters.AddWithValue("@v6", u.AddressStreet);
                Cmd.Parameters.AddWithValue("@v7", u.AddressNumber);
                Cmd.Parameters.AddWithValue("@v8", u.AddressComplement);
                Cmd.Parameters.AddWithValue("@v9", u.AddressCity);
                Cmd.Parameters.AddWithValue("@v10", u.AddressState);
                Cmd.Parameters.AddWithValue("@v11", u.AddressDistrict);
                Cmd.Parameters.AddWithValue("@v12", u.UserLogin);
                Cmd.Parameters.AddWithValue("@v13", u.UserPassword);
                
                Cmd.Connection = Con;
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar Usuario. " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        //inserir instantbuykey no banco
        public void InsertInstantBuyKey(SystemUser u)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand
                    ("insert into SystemUser(InstantBuyKey) values(@v1)");
                Cmd.Parameters.AddWithValue("@v1", u.UserPassword);
             Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar InstantBuyKey. " + ex.Message);
            }
            finally
            {
                CloseConnection();
            
            }
        }     
                
                
                
                //Verifica se Login existe
        public bool HasLogin(string UserLogin)
        {
            try
            {
                OpenConnection();
               
                
                Cmd = new SqlCommand("select count(*) from SystemUser where UserLogin = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", UserLogin);

                int qtd = Convert.ToInt32(Cmd.ExecuteScalar());

                if (qtd > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao obter Login." + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        //busca usuario por login e senha
        public SystemUser Find(string UserLogin, string UserPassword)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("select * from SystemUser where UserLogin = @v1 and UserPassword = @v2", Con);

                Cmd.Parameters.AddWithValue("@v1", UserLogin);
                Cmd.Parameters.AddWithValue("@v2", UserPassword);

                Dr = Cmd.ExecuteReader();
                if (Dr.Read())
                {
                    SystemUser u = new SystemUser();

                    u.PkUser = Convert.ToInt32(Dr["PkUser"]);
                    u.UserName = Convert.ToString(Dr["UserName"]);
                    u.UserLogin = Convert.ToString(Dr["UserLogin"]);

                    return u;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao obter usuario. " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        //Verifica se Cpf existe
        public bool HasCpf(string UserCpf)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("select count(*) from SystemUser where UserCpf = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", UserCpf);

                int qtd = Convert.ToInt32(Cmd.ExecuteScalar());

                if (qtd > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao obter Cpf." + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }



        

        /*
        public DataBaseConnection Con = new DataBaseConnection();

        //metoto para inserir um usuario no banco
        public void Insert(SystemUser u)
        {
            try
            {
                Con.SystemUsers.Add(u);
                Con.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir Usuario: " + ex.Message);
            }
        }

        //metodo para verificar de login ja existe
        public bool HasLogin(string UserLogin)
        {
            try
            {
                return Con.SystemUsers.Where(u => u.UserLogin.Equals(UserLogin)).Count() > 0;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao ober Login: " + ex.Message);
            }
        }

        //metodo para buscar 1 usuario por login e senha
        public SystemUser Find(string UserLogin, string UserPassword)
        {
            try
            {
                return Con.SystemUsers.Where(u => u.UserLogin.Equals(UserLogin) && u.UserPassword.Equals(UserPassword)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter Usuario e Senha: " + ex.Message);
            }
        }

        //verificar de CPF já existe
        public bool HasCpf(string UserCpf)
        {
            try
            {
                return Con.SystemUsers.Where(u => u.UserCpf.Equals(UserCpf)).Count() > 0;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao ober Cpf: " + ex.Message);
            }
        }

        //metodo para buscar 1 InstantBuyKey
        public SystemUser Find(string InstantBuyKey)
        {
            try
            {
                return Con.SystemUsers.Where(u => u.InstantBuyKey.Equals(InstantBuyKey)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter InstantBuyKey: " + ex.Message);
            }
        }
        */
    }
}
