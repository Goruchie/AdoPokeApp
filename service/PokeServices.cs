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
                sqlCommand.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id\r\nFrom POKEMONS P, ELEMENTOS E, ELEMENTOS D\r\nWhere E.Id = P.IdTipo\r\nAnd D.Id = P.IdDebilidad";
                sqlCommand.Connection = conection;

                conection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)reader["Id"];
                    aux.Number = reader.GetInt32(0);
                    aux.Name = (string)reader["Nombre"];
                    aux.Description = (string)reader["Descripcion"];
                    // First way to solve the problem when UrlImage is null

                    //if(!(reader.IsDBNull(reader.GetOrdinal("UrlImagen"))))
                    //aux.UrlImage = (string)reader["UrlImagen"];

                    // Second way to solve the problem when UrlImage is null
                    if (!(reader["UrlImagen"] is DBNull))
                    aux.UrlImage = (string)reader["UrlImagen"];

                    aux.Type = new Element();
                    aux.Type.Id = (int)reader["IdTipo"];
                    aux.Type.Description = (string)reader["Tipo"];
                    aux.Weakness = new Element();
                    aux.Weakness.Id = (int)reader["IdDebilidad"];
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
                data.setQuery("Insert into POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen)values(" + newone.Number + ", '" + newone.Name + "', '" + newone.Description + "', 1, @idTipo, @idDebilidad, @urlImagen)");
                data.setParameter("@idTipo", newone.Type.Id);
                data.setParameter("@idDebilidad", newone.Weakness.Id);
                data.setParameter("@urlImagen", newone.UrlImage);
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
        public void modify(Pokemon poke)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("update POKEMONS set Numero = @number, Nombre = @name, Descripcion = @desc, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDebilidad Where id = @id");
                data.setParameter("@number", poke.Number);
                data.setParameter("@name", poke.Name);
                data.setParameter("@desc", poke.Description);
                data.setParameter("@img", poke.UrlImage);
                data.setParameter("@idTipo", poke.Type.Id);
                data.setParameter("@idDebilidad", poke.Weakness.Id);
                data.setParameter("@id", poke.Id);

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

        public void delete(int id)
        {
            try
            {
                DataAccess data = new DataAccess();
                data.setQuery("delete from POKEMONS where id = @id");
                data.setParameter("@id", id);
                data.runAction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
