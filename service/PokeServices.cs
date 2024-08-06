using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using domain;

namespace service
{
    public class PokeServices
    {
        public List<Pokemon> list()
        {
            List<Pokemon> list = new List<Pokemon>();
            SqlConnection conection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader reader;

            try
            {
                conection.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad\r\nFrom POKEMONS P, ELEMENTOS E, ELEMENTOS D\r\nWhere E.Id = P.IdTipo\r\nAnd D.Id = P.IdDebilidad";
                sqlCommand.Connection = conection;

                conection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Number = reader.GetInt32(0);
                    aux.Name = (string)reader["Nombre"];
                    aux.Description = (string)reader["Descripcion"];
                    aux.UrlImage = (string)reader["UrlImagen"];
                    aux.Type = new Element();
                    aux.Type.Description = (string)reader["Tipo"];
                    aux.Weakness = new Element();
                    aux.Weakness.Description = (string)reader["Debilidad"];

                    list.Add(aux);
                }
                conection.Close();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void add(Pokemon newone)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("Insert into POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad)values(" + newone.Number + ", '" + newone.Name + "', '" + newone.Description + "', 1, @idTipo, @idDebilidad)");
                data.setParameter("@idTipo", newone.Type.Id);
                data.setParameter("@idDebilidad", newone.Weakness.Id);
                data.runAction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.closeConnection();
            }
        }
        public void modify(Pokemon modified)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("Update POKEMONS set Nombre = '" + modified.Name + "', Descripcion = '" + modified.Description + "' where Numero = " + modified.Number);
                data.runReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.closeConnection();
            }
        }
    }
}
