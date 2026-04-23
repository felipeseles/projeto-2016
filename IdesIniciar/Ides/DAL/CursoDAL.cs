using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//necessario
using System.Data.SqlClient;//necessario

namespace Ides.DAL
{
    class CursoDAL
    {
        // -------------------- CLASSE CONEXÃO --------------------

        Conexao con = new Conexao();

        // -------------------- MÉTODO CADASTRAR --------------------

        public void Cadastrar(BLL.CursoBLL cursoBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"INSERT INTO CURSO (NOMECURSO) VALUES (@NOMECURSO)", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@NOMECURSO", cursoBLL.Nomecurso);

            //executar comando

            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão
        }

        // -------------------- METODO CONSULTAR TODOS --------------------

        public DataTable ConsultarTodos()
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT
CODCURSO AS Código, NOMECURSO AS Curso FROM CURSO ORDER BY NOMECURSO", con.Conectar());
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }

        // -------------------- METODO CONSULTAR POR NOME --------------------

        public DataTable ConsultarPorNome(BLL.CursoBLL cursoBLL)
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT 
CODCURSO AS Código, NOMECURSO AS Curso FROM CURSO
WHERE NOMECURSO LIKE @NOMECURSO ORDER BY NOMECURSO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOMECURSO", cursoBLL.Nomecurso + "%");
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }

        // -------------------- METODO ATUALIZAR/ EDITAR --------------------

        public void Alterar(BLL.CursoBLL cursoBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"UPDATE CURSO SET NOMECURSO = @NOMECURSO
    WHERE CODCURSO = @CODCURSO", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@NOMECURSO", cursoBLL.Nomecurso);
            cmd.Parameters.AddWithValue("@CODCURSO", cursoBLL.Codcurso);

            //executar comando
            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão
        }

        // -------------------- METODO RETORNAR DADOS --------------------

        public BLL.CursoBLL RetornarDados(BLL.CursoBLL cursoBLL)
        {

            SqlCommand cmd = new SqlCommand(@"SELECT * FROM CURSO WHERE CODCURSO = @CODCURSO", con.Conectar());
            cmd.Parameters.AddWithValue("@CODCURSO", cursoBLL.Codcurso);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())//conseguiu ler?
            {
                //preenchendo objetos
                cursoBLL.Codcurso = int.Parse(dr["CODCURSO"].ToString());
                cursoBLL.Nomecurso = dr["NOMECURSO"].ToString();
            }
            dr.Close();
            con.Desconectar();
            return cursoBLL;//retorna objeto preenchido
        }

        // -------------------- METODO EXCLUIR --------------------

        public void Excluir(BLL.CursoBLL cursoBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM CURSO WHERE CODCURSO = @CODCURSO", con.Conectar());
            cmd.Parameters.AddWithValue("@CODCURSO", cursoBLL.Codcurso);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

    }
}
