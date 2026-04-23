using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//necessario
using System.Data.SqlClient;//necessario

namespace Ides.DAL
{
    class MatriculaDAL
    {

        //referencias para as classes
        BLL.CursoBLL cBLL = new BLL.CursoBLL();
        DAL.CursoDAL cDAL = new DAL.CursoDAL();

        BLL.AlunoBLL aBLL = new BLL.AlunoBLL();
        DAL.AlunoDAL aDAL = new DAL.AlunoDAL();


        // -------------------- CLASSE CONEXÃO --------------------

        Conexao con = new Conexao();

        // -------------------- MÉTODO CADASTRAR --------------------

        public void Cadastrar(BLL.MatriculaBLL matriculaBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"INSERT INTO MATRICULA (MATRICULANUMERO, DATAMATRICULA, CODALUNO, CODTURMA, CODUSUARIO)
            VALUES (@MATRICULANUMERO, @DATAMATRICULA, @CODALUNO, @CODTURMA, @CODUSUARIO)", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@MATRICULANUMERO", matriculaBLL.Matriculanumero);
            cmd.Parameters.AddWithValue("@DATAMATRICULA", matriculaBLL.Datamatricula);
            cmd.Parameters.AddWithValue("@CODALUNO", matriculaBLL.Codaluno);
            cmd.Parameters.AddWithValue("@CODTURMA", matriculaBLL.Codturma);
            cmd.Parameters.AddWithValue("@CODUSUARIO", matriculaBLL.Codusuario);
            
            //executar comando

            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão
        }


        // -------------------- METODO CONSULTAR TODOS --------------------

        public DataTable ConsultarTodos()
        {
//            //passamos comando SQL de consulta

//            SqlDataAdapter da = new SqlDataAdapter(@"SELECT M.MATRICULANUMERO AS Matricula, M.DATAMATRICULA AS [Data da matricula], A.NOMEALUNO AS Aluno, C.NOMECURSO AS Curso, U.NOME AS Usuario
//            FROM MATRICULA M
//            JOIN ALUNO A ON M.CODALUNO = A.CODALUNO
//            JOIN CURSO C ON C.CODCURSO = C.CODCURSO
//			JOIN USUARIO U ON M.CODUSUARIO = U.CODUSUARIO", con.Conectar());
//            DataTable dt = new DataTable(); //tabela
//            da.Fill(dt); // preencher tabela
//            con.Desconectar();
//            return dt; // retornando tabela preenchida

            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT M.MATRICULANUMERO AS Matricula, A.NOMEALUNO AS Aluno, P.NOMEPROFESSOR AS Professor,
		    C.NOMECURSO AS Curso, T.DIASEMANA AS [Dia da Semana], T.HORAENTRADA AS [Horário de Entrada],
		    T.HORASAIDA AS [Horário de Saída], T.DATAINICIO AS Inicio, T.DATACONCLUSAO AS Conclusão
            FROM MATRICULA M
            JOIN ALUNO A ON M.CODALUNO = A.CODALUNO
            JOIN TURMA T ON M.CODTURMA = T.CODTURMA
			JOIN CURSO C ON C.CODCURSO = T.CODCURSO
			JOIN PROFESSOR P ON P.CODPROFESSOR = T.CODPROFESSOR
            ORDER BY M.MATRICULANUMERO", con.Conectar());
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }

        // -------------------- METODO CONSULTAR POR NUMERO DA MATRICULA --------------------

        public DataTable ConsultarPorNumeroMatricula(BLL.MatriculaBLL mBLL)
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT M.MATRICULANUMERO AS Matricula, M.DATAMATRICULA AS [Data da matricula], A.NOMEALUNO AS Aluno, C.NOMECURSO AS Curso, U.NOME AS Usuario
            FROM MATRICULA M
            JOIN ALUNO A ON M.CODALUNO = A.CODALUNO
            JOIN CURSO C ON C.CODCURSO = C.CODCURSO
			JOIN USUARIO U ON M.CODUSUARIO = U.CODUSUARIO
            WHERE MATRICULANUMERO LIKE @MATRICULANUMERO ORDER BY MATRICULANUMERO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@MATRICULANUMERO", mBLL.Matriculanumero + "%");
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }

        // -------------------- METODO CONSULTAR POR NOME DO ALUNO --------------------

        public DataTable ConsultarPorNomeAluno(BLL.MatriculaBLL mBLL)
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT M.MATRICULANUMERO AS Matricula, M.DATAMATRICULA AS [Data da matricula], A.NOMEALUNO AS Aluno, C.NOMECURSO AS Curso, U.NOME AS Usuario
            FROM MATRICULA M
            JOIN ALUNO A ON M.CODALUNO = A.CODALUNO
            JOIN CURSO C ON C.CODCURSO = C.CODCURSO
			JOIN USUARIO U ON M.CODUSUARIO = U.CODUSUARIO
            WHERE NOMEALUNO LIKE @NOMEALUNO ORDER BY NOMEALUNO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOMEALUNO", aBLL.Nome + "%");
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }


        // -------------------- METODO ATUALIZAR/ EDITAR --------------------

        public void Alterar(BLL.MatriculaBLL matriculaBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"UPDATE MATRICULA SET MATRICULANUMERO = @MATRICULANUMERO, DATAMATRICULA = @DATAMATRICULA, CODALUNO = @CODALUNO,
            CODTURMA = @CODTURMA, CODUSUARIO = @CODUSUARIO
            WHERE CODMATRICULA = @CODMATRICULA", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@MATRICULANUMERO", matriculaBLL.Matriculanumero);
            cmd.Parameters.AddWithValue("@DATAMATRICULA", matriculaBLL.Datamatricula);
            cmd.Parameters.AddWithValue("@CODALUNO", matriculaBLL.Codaluno);
            cmd.Parameters.AddWithValue("@CODTURMA", matriculaBLL.Codturma);
            cmd.Parameters.AddWithValue("@CODUSUARIO", matriculaBLL.Codusuario);
            cmd.Parameters.AddWithValue("@CODMATRICULA", matriculaBLL.Codmatricula);

            //executar comando
            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão
        }

        public BLL.MatriculaBLL RetornarDados(BLL.MatriculaBLL matriculaBLL)
        {

            SqlCommand cmd = new SqlCommand(@"SELECT * FROM MATRICULA WHERE CODMATRICULA = @CODMATRICULA", con.Conectar());
            cmd.Parameters.AddWithValue("@CODMATRICULA", matriculaBLL.Codmatricula);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())//conseguiu ler?
            {
                //preenchendo objeto
                matriculaBLL.Matriculanumero = dr["MATRICULANUMERO"].ToString();
                matriculaBLL.Matriculanumero = dr["DATAMATRICULA"].ToString();
                matriculaBLL.Codaluno = int.Parse(dr["CODALUNO"].ToString());
                matriculaBLL.Codturma = int.Parse(dr["CODTURMA"].ToString());
                matriculaBLL.Codmatricula = int.Parse(dr["CODMATRICULA"].ToString());
                
            }
            dr.Close();
            con.Desconectar();
            return matriculaBLL;//retorna objeto preenchido
        }

        public void Excluir(BLL.MatriculaBLL matriculaBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TURMA WHERE CODMATRICULA = @CODMATRICULA", con.Conectar());
            cmd.Parameters.AddWithValue("@CODTURMA", matriculaBLL.Codmatricula);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}
