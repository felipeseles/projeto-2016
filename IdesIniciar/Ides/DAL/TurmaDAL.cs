using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//necessario
using System.Data.SqlClient;//necessario

namespace Ides.DAL
{
    class TurmaDAL
    {
        //referencias para as classes
        BLL.CursoBLL cBLL = new BLL.CursoBLL();
        DAL.CursoDAL cDAL = new DAL.CursoDAL();

        BLL.ProfessorBLL pBLL = new BLL.ProfessorBLL();
        DAL.ProfessorDAL pDAL = new DAL.ProfessorDAL();

        


        // -------------------- CLASSE CONEXÃO --------------------

        Conexao con = new Conexao();

        // -------------------- MÉTODO CADASTRO COMPLETO --------------------

        public void Cadastrar(BLL.TurmaBLL turmaBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"INSERT INTO TURMA (QTDVAGAS, DIASEMANA, HORAENTRADA, HORASAIDA, DATAINICIO,
    DATACONCLUSAO, CODPROFESSOR, CODCURSO)
    VALUES (@QTDVAGAS, @DIASEMANA, @HORAENTRADA, @HORASAIDA, @DATAINICIO, @DATACONCLUSAO, @CODPROFESSOR, @CODCURSO)", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@QTDVAGAS", turmaBLL.Qtdvagas);
            cmd.Parameters.AddWithValue("@DIASEMANA", turmaBLL.Diasemana);
            cmd.Parameters.AddWithValue("@HORAENTRADA", turmaBLL.Horaentrada);
            cmd.Parameters.AddWithValue("@HORASAIDA", turmaBLL.Horasaida);
            cmd.Parameters.AddWithValue("@DATAINICIO", turmaBLL.Datainicio);
            cmd.Parameters.AddWithValue("@DATACONCLUSAO", turmaBLL.Dataconclusao);
            cmd.Parameters.AddWithValue("@CODPROFESSOR", turmaBLL.Codprofessor);
            cmd.Parameters.AddWithValue("@CODCURSO", turmaBLL.Codcurso);

            //executar comando

            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão
        }

        // -------------------- METODO CONSULTAR TODOS --------------------

        public DataTable ConsultarTodos()
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT T.CODTURMA AS Código, C.NOMECURSO AS Curso, T.DIASEMANA AS [Dia da Semana],
        T.HORAENTRADA AS Entrada, T.HORASAIDA AS Saída, T.DATAINICIO AS Inicio, T.DATACONCLUSAO AS Conclusão,
        P.NOMEPROFESSOR AS Professor, T.QTDVAGAS AS Vagas
        FROM TURMA T
	    JOIN PROFESSOR P ON T.CODPROFESSOR = P.CODPROFESSOR
        JOIN CURSO C ON T.CODCURSO = C.CODCURSO ORDER BY C.NOMECURSO", con.Conectar());
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }

        public DataTable ConsultarCursoAluno()
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT C.NOMECURSO AS Curso
        FROM TURMA T
        JOIN CURSO C ON T.CODCURSO = C.CODCURSO ORDER BY C.NOMECURSO", con.Conectar());
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }

        // -------------------- METODO CONSULTAR POR NOME --------------------

        public DataTable ConsultarPorCurso(BLL.CursoBLL cBLL)
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT T.CODTURMA AS Código, C.NOMECURSO AS Curso, T.DIASEMANA AS [Dia da Semana],
        T.HORAENTRADA AS Entrada, T.HORASAIDA AS Saída, T.DATAINICIO AS Inicio, T.DATACONCLUSAO AS Conclusão,
        P.NOMEPROFESSOR AS Professor, T.QTDVAGAS AS Vagas
        FROM TURMA T
	    JOIN PROFESSOR P ON T.CODPROFESSOR = P.CODPROFESSOR
        JOIN CURSO C ON T.CODCURSO = C.CODCURSO
        WHERE NOMECURSO LIKE @NOMECURSO ORDER BY NOMECURSO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOMECURSO", cBLL.Nomecurso + "%");
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }

        public DataTable ConsultarPorProfessor(BLL.ProfessorBLL pBLL)
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT T.CODTURMA AS Código, C.NOMECURSO AS Curso, T.DIASEMANA AS [Dia da Semana],
        T.HORAENTRADA AS Entrada, T.HORASAIDA AS Saída, T.DATAINICIO AS Inicio, T.DATACONCLUSAO AS Conclusão,
        P.NOMEPROFESSOR AS Professor, T.QTDVAGAS AS Vagas
        FROM TURMA T
	    JOIN PROFESSOR P ON T.CODPROFESSOR = P.CODPROFESSOR
        JOIN CURSO C ON T.CODCURSO = C.CODCURSO
        WHERE NOMEPROFESSOR LIKE @NOMEPROFESSOR ORDER BY NOMEPROFESSOR", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOMEPROFESSOR", pBLL.Nomeprofessor + "%");
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }


        // -------------------- METODO ATUALIZAR/ EDITAR --------------------

        public void Alterar(BLL.TurmaBLL turmaBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"UPDATE TURMA SET QTDVAGAS = @QTDVAGAS, DIASEMANA = @DIASEMANA,
    HORAENTRADA = @HORAENTRADA, HORASAIDA = @HORASAIDA, DATAINICIO = @DATAINICIO, DATACONCLUSAO = @DATACONCLUSAO,
    CODPROFESSOR = @CODPROFESSOR, CODCURSO = @CODCURSO
    WHERE CODTURMA = @CODTURMA", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@QTDVAGAS", turmaBLL.Qtdvagas);
            cmd.Parameters.AddWithValue("@DIASEMANA", turmaBLL.Diasemana);
            cmd.Parameters.AddWithValue("@HORAENTRADA", turmaBLL.Horaentrada);
            cmd.Parameters.AddWithValue("@HORASAIDA", turmaBLL.Horasaida);
            cmd.Parameters.AddWithValue("@DATAINICIO", turmaBLL.Datainicio);
            cmd.Parameters.AddWithValue("@DATACONCLUSAO", turmaBLL.Dataconclusao);
            cmd.Parameters.AddWithValue("@CODPROFESSOR", turmaBLL.Codprofessor);
            cmd.Parameters.AddWithValue("@CODCURSO", turmaBLL.Codcurso);
            cmd.Parameters.AddWithValue("@CODTURMA", turmaBLL.Codturma);

            //executar comando
            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão
        }


        // -------------------- METODO RETORNAR DADOS --------------------

        public BLL.TurmaBLL RetornarDados(BLL.TurmaBLL turmaBLL)
        {

            SqlCommand cmd = new SqlCommand(@"SELECT * FROM TURMA WHERE CODTURMA = @CODTURMA", con.Conectar());
            cmd.Parameters.AddWithValue("@CODTURMA", turmaBLL.Codturma);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())//conseguiu ler?
            {
                //preenchendo objetos
                turmaBLL.Codturma = int.Parse(dr["CODTURMA"].ToString());
                turmaBLL.Qtdvagas = dr["QTDVAGAS"].ToString();
                turmaBLL.Diasemana = dr["DIASEMANA"].ToString();
                turmaBLL.Horaentrada = DateTime.Parse(dr["HORAENTRADA"].ToString());
                turmaBLL.Horasaida = DateTime.Parse(dr["HORASAIDA"].ToString());
                turmaBLL.Datainicio = DateTime.Parse(dr["DATAINICIO"].ToString());
                turmaBLL.Dataconclusao = DateTime.Parse(dr["DATACONCLUSAO"].ToString());
                turmaBLL.Codprofessor = int.Parse(dr["CODPROFESSOR"].ToString());
                turmaBLL.Codcurso = int.Parse(dr["CODCURSO"].ToString());
                
            }
            dr.Close();
            con.Desconectar();
            return turmaBLL;//retorna objeto preenchido
        }

        // -------------------- METODO EXCLUIR --------------------

        public void Excluir(BLL.TurmaBLL turmaBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TURMA WHERE CODTURMA = @CODTURMA", con.Conectar());
            cmd.Parameters.AddWithValue("@CODTURMA", turmaBLL.Codturma);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}
