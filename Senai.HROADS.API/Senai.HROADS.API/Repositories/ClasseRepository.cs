using System;
using Senai.HROADS.API.Domains;
using Senai.HROADS.API.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Senai.HROADS.API.Repositories
{
    public class ClasseRepository : IClasseRepository
    {
        private string stringConexao = "Data Source=DESKTOP-9VU6KVN\\SQLEXPRESS; intial catalog=SENAI_HROADSAPI_TARDE; integrated security=true";

        public void atualizar(int Id, ClasseDomain ClasseAtualizada)
        {
            throw new NotImplementedException();
        }

        public ClasseDomain BuscarPorId()
        {
            throw new NotImplementedException();
        }

        public object BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ClasseDomain NovaClasse)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int Id)
        {
 
        }

        public List<ClasseDomain> Listar()
        {
            List<ClasseDomain> listaClasses = new List<ClasseDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "Select NomeClasse, Nome FROM Classe";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                   rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        ClasseDomain classe = new ClasseDomain()
                        {
                            IdClasse = Convert.ToInt32(rdr[0]),
                            nomeClasse = rdr[1].ToString()
                        };

                        listaClasses.Add(classe);

                        
                    }
                }
            }

            return listaClasses;
        }
    }
}
