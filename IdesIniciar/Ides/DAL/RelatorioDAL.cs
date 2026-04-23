using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Ides.DAL
{
    class RelatorioDAL
    {
        Conexao con = new Conexao();

        public SqlDataAdapter RelatorioAlunos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT NOMEALUNO, RG, EMISSAO, DATANASC, TELEFONE1, TELEFONE2, TELEFONE3 FROM ALUNO ORDER BY NOMEALUNO", con.Conectar());
            con.Desconectar();
            return da;
        }

        public SqlDataAdapter RelatorioCurso()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM CURSO", con.Conectar());
            con.Desconectar();
            return da;
        }

        public SqlDataAdapter RelatorioProfessor()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT NOMEPROFESSOR, RG, EMISSAO, DATANASC, CPF, CEP, ENDERECO, NUMERO, BAIRRO, CIDADE, ESTADO,
 TELEFONE1, TELEFONE2, TELEFONE3, ESCOLARIDADE, DTADMISSAO, DTDEMISSAO FROM PROFESSOR ORDER BY NOMEPROFESSOR", con.Conectar());
            con.Desconectar();
            return da;
        }

        public SqlDataAdapter RelatorioTurma()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT C.NOMECURSO, T.DIASEMANA, T.HORAENTRADA, T.HORASAIDA, T.DATAINICIO, T.DATACONCLUSAO, P.NOMEPROFESSOR, T.QTDVAGAS
        FROM TURMA T
	    JOIN PROFESSOR P ON T.CODPROFESSOR = P.CODPROFESSOR
        JOIN CURSO C ON T.CODCURSO = C.CODCURSO ORDER BY C.NOMECURSO", con.Conectar());
            con.Desconectar();
            return da;
        }

        public SqlDataAdapter ReletorioUsuario()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT NOME, SOBRENOME, CPF, SEXO, EMAIL, NOMEUSUARIO, SENHA, ACESSO FROM USUARIO", con.Conectar());
            con.Desconectar();
            return da;
        }

        public SqlDataAdapter RelatorioMatricula()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT M.MATRICULANUMERO, M.DATAMATRICULA, A.NOMEALUNO, P.NOMEPROFESSOR, C.NOMECURSO, T.DIASEMANA, T.HORAENTRADA, T.HORASAIDA, T.DATAINICIO, T.DATACONCLUSAO
FROM MATRICULA M
JOIN ALUNO A ON A.CODALUNO = M.CODALUNO
JOIN TURMA T ON T.CODTURMA = M.CODTURMA
JOIN CURSO C ON C.CODCURSO = T.CODCURSO
JOIN PROFESSOR P ON P.CODPROFESSOR = T.CODCURSO", con.Conectar());
            con.Desconectar();
            return da;
        }
    }
}
