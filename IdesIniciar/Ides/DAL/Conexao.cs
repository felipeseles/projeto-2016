using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//necessário
using System.Data.SqlClient;//necessário

namespace Ides.DAL
{
    class Conexao
    {
        //string de conexão
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BDSECRETARIAIDES;Integrated Security=True;");

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }

        public SqlConnection Desconectar()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}
