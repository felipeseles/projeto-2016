using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//necessario
using System.Data.SqlClient;//necessario

namespace Ides.DAL
{
    class ProfessorDAL
    {
        // -------------------- CLASSE CONEXÃO --------------------

        Conexao con = new Conexao();

        // -------------------- MÉTODO CADASTRAR --------------------

        public void Cadastrar(BLL.ProfessorBLL professorBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"INSERT INTO PROFESSOR 
(NOMEPROFESSOR, RG, EMISSAO, DATANASC, CPF, FILIACAOMAE, FILIACAOPAI, CEP, ENDERECO,
NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, TIPOTEL1, TELEFONE1, OBSERVACAOTEL1, 
TIPOTEL2, TELEFONE2, OBSERVACAOTEL2, TIPOTEL3, TELEFONE3, OBSERVACAOTEL3, EMAIL, ESCOLARIDADE, DTADMISSAO, DTDEMISSAO)
VALUES (@NOMEPROFESSOR, @RG, @EMISSAO, @DATANASC, @CPF, @FILIACAOMAE, @FILIACAOPAI,
@CEP, @ENDERECO, @NUMERO, @COMPLEMENTO, @BAIRRO, @CIDADE, @ESTADO,
@TIPOTEL1, @TELEFONE1, @OBSERVACAOTEL1, @TIPOTEL2, @TELEFONE2, @OBSERVACAOTEL2,
@TIPOTEL3, @TELEFONE3, @OBSERVACAOTEL3, @EMAIL, @ESCOLARIDADE, @DTADMISSAO, @DTDEMISSAO)", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@NOMEPROFESSOR", professorBLL.Nomeprofessor);
            cmd.Parameters.AddWithValue("@RG", professorBLL.Rg);
            cmd.Parameters.AddWithValue("@EMISSAO", professorBLL.Emissao);
            cmd.Parameters.AddWithValue("@DATANASC", professorBLL.Datanasc);
            cmd.Parameters.AddWithValue("@CPF", professorBLL.Cpf);
            cmd.Parameters.AddWithValue("@FILIACAOMAE", professorBLL.Filiacaomae);
            cmd.Parameters.AddWithValue("@FILIACAOPAI", professorBLL.Filiacaopai);
            cmd.Parameters.AddWithValue("@CEP", professorBLL.Cep);
            cmd.Parameters.AddWithValue("@ENDERECO", professorBLL.Endereco);
            cmd.Parameters.AddWithValue("@NUMERO", professorBLL.Numero);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", professorBLL.Complemento);
            cmd.Parameters.AddWithValue("@BAIRRO", professorBLL.Bairro);
            cmd.Parameters.AddWithValue("@CIDADE", professorBLL.Cidade);
            cmd.Parameters.AddWithValue("@ESTADO", professorBLL.Estado);
            cmd.Parameters.AddWithValue("@TIPOTEL1", professorBLL.Tipotel1);
            cmd.Parameters.AddWithValue("@TELEFONE1", professorBLL.Telefone1);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL1", professorBLL.Observacaotel1);
            cmd.Parameters.AddWithValue("@TIPOTEL2", professorBLL.Tipotel2);
            cmd.Parameters.AddWithValue("@TELEFONE2", professorBLL.Telefone2);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL2", professorBLL.Observacaotel2);
            cmd.Parameters.AddWithValue("@TIPOTEL3", professorBLL.Tipotel3);
            cmd.Parameters.AddWithValue("@TELEFONE3", professorBLL.Telefone3);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL3", professorBLL.Observacaotel3);
            cmd.Parameters.AddWithValue("@EMAIL", professorBLL.Email);
            cmd.Parameters.AddWithValue("@ESCOLARIDADE", professorBLL.Escolaridade);
            cmd.Parameters.AddWithValue("@DTADMISSAO", professorBLL.Dtadmissao);
            if (professorBLL.Dtdemissao != null)
            {
                cmd.Parameters.AddWithValue("@DTDEMISSAO", professorBLL.Dtdemissao);
            }
            else
            {
                cmd.Parameters.AddWithValue("@DTDEMISSAO", DBNull.Value);
            }


            //executar comando

            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão
        }

        // -------------------- METODO CONSULTAR TODOS --------------------

        public DataTable ConsultarTodos()
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT
CODPROFESSOR AS Código, NOMEPROFESSOR AS Professor, TIPOTEL1 AS [Tipo Telefone],
TELEFONE1 AS Telefone, OBSERVACAOTEL1 AS Observação, EMAIL AS [E-Mail], DTADMISSAO AS Admissão FROM PROFESSOR ORDER BY NOMEPROFESSOR", con.Conectar());
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }

        // -------------------- METODO CONSULTAR POR NOME --------------------

        public DataTable ConsultarPorNome(BLL.ProfessorBLL professorBLL)
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT
CODPROFESSOR AS Código, NOMEPROFESSOR AS Professor, TIPOTEL1 AS [Tipo Telefone],
TELEFONE1 AS Telefone, OBSERVACAOTEL1 AS Observação, EMAIL AS [E-Mail], DTADMISSAO AS Admissão FROM PROFESSOR
WHERE NOMEPROFESSOR LIKE @NOMEPROFESSOR ORDER BY NOMEPROFESSOR", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOMEPROFESSOR", professorBLL.Nomeprofessor + "%");
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }

        // -------------------- METODO ATUALIZAR/ EDITAR --------------------

        public void Alterar(BLL.ProfessorBLL professorBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"UPDATE PROFESSOR SET NOMEPROFESSOR = @NOMEPROFESSOR,
RG = @RG, EMISSAO = @EMISSAO, DATANASC = @DATANASC, CPF = @CPF, FILIACAOMAE = @FILIACAOMAE,
    FILIACAOPAI = @FILIACAOPAI, CEP = @CEP, ENDERECO = @ENDERECO, NUMERO = @NUMERO,
    COMPLEMENTO = @COMPLEMENTO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, ESTADO = @ESTADO,
    TIPOTEL1 = @TIPOTEL1, TELEFONE1 = @TELEFONE1, OBSERVACAOTEL1 = @OBSERVACAOTEL1,
    TIPOTEL2 = @TIPOTEL2, TELEFONE2 = @TELEFONE2, OBSERVACAOTEL2 = @OBSERVACAOTEL2,
    TIPOTEL3 = @TIPOTEL3, TELEFONE3 = @TELEFONE3, OBSERVACAOTEL3 = @OBSERVACAOTEL3,
    EMAIL = @EMAIL, ESCOLARIDADE = @ESCOLARIDADE, DTADMISSAO = @DTADMISSAO, DTDEMISSAO = @DTDEMISSAO
    WHERE CODPROFESSOR = @CODPROFESSOR", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@NOMEPROFESSOR", professorBLL.Nomeprofessor);
            cmd.Parameters.AddWithValue("@RG", professorBLL.Rg);
            cmd.Parameters.AddWithValue("@EMISSAO", professorBLL.Emissao);
            cmd.Parameters.AddWithValue("@DATANASC", professorBLL.Datanasc);
            cmd.Parameters.AddWithValue("@CPF", professorBLL.Cpf);
            cmd.Parameters.AddWithValue("@FILIACAOMAE", professorBLL.Filiacaomae);
            cmd.Parameters.AddWithValue("@FILIACAOPAI", professorBLL.Filiacaopai);
            cmd.Parameters.AddWithValue("@CEP", professorBLL.Cep);
            cmd.Parameters.AddWithValue("@ENDERECO", professorBLL.Endereco);
            cmd.Parameters.AddWithValue("@NUMERO", professorBLL.Numero);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", professorBLL.Complemento);
            cmd.Parameters.AddWithValue("@BAIRRO", professorBLL.Bairro);
            cmd.Parameters.AddWithValue("@CIDADE", professorBLL.Cidade);
            cmd.Parameters.AddWithValue("@ESTADO", professorBLL.Estado);
            cmd.Parameters.AddWithValue("@TIPOTEL1", professorBLL.Tipotel1);
            cmd.Parameters.AddWithValue("@TELEFONE1", professorBLL.Telefone1);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL1", professorBLL.Observacaotel1);
            cmd.Parameters.AddWithValue("@TIPOTEL2", professorBLL.Tipotel2);
            cmd.Parameters.AddWithValue("@TELEFONE2", professorBLL.Telefone2);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL2", professorBLL.Observacaotel2);
            cmd.Parameters.AddWithValue("@TIPOTEL3", professorBLL.Tipotel3);
            cmd.Parameters.AddWithValue("@TELEFONE3", professorBLL.Telefone3);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL3", professorBLL.Observacaotel3);
            cmd.Parameters.AddWithValue("@EMAIL", professorBLL.Email);
            cmd.Parameters.AddWithValue("@ESCOLARIDADE", professorBLL.Escolaridade);
            cmd.Parameters.AddWithValue("@DTADMISSAO", professorBLL.Dtadmissao);
            if (professorBLL.Dtdemissao != null)
            {
                cmd.Parameters.AddWithValue("@DTDEMISSAO", professorBLL.Dtdemissao);
            }
            else
            {
                cmd.Parameters.AddWithValue("@DTDEMISSAO", DBNull.Value);
            }
            cmd.Parameters.AddWithValue("@CODPROFESSOR", professorBLL.Codprofessor);

            //executar comando
            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão
        }

        // -------------------- METODO RETORNAR DADOS --------------------

        public BLL.ProfessorBLL RetornarDados(BLL.ProfessorBLL professorBLL)
        {

            SqlCommand cmd = new SqlCommand(@"SELECT * FROM PROFESSOR WHERE CODPROFESSOR = @CODPROFESSOR", con.Conectar());
            cmd.Parameters.AddWithValue("@CODPROFESSOR", professorBLL.Codprofessor);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())//conseguiu ler?
            {
                //preenchendo objetos
                professorBLL.Codprofessor = int.Parse(dr["CODPROFESSOR"].ToString());
                professorBLL.Nomeprofessor = dr["NOMEPROFESSOR"].ToString();
                professorBLL.Rg = dr["RG"].ToString();
                professorBLL.Emissao = dr["EMISSAO"].ToString();
                professorBLL.Datanasc = DateTime.Parse(dr["DATANASC"].ToString());
                professorBLL.Cpf = dr["CPF"].ToString();
                professorBLL.Filiacaomae = dr["FILIACAOMAE"].ToString();
                professorBLL.Filiacaopai = dr["FILIACAOPAI"].ToString();
                professorBLL.Cep = dr["CEP"].ToString();
                professorBLL.Endereco = dr["ENDERECO"].ToString();
                professorBLL.Numero = dr["NUMERO"].ToString();
                professorBLL.Complemento = dr["COMPLEMENTO"].ToString();
                professorBLL.Bairro = dr["BAIRRO"].ToString();
                professorBLL.Cidade = dr["CIDADE"].ToString();
                professorBLL.Estado = dr["ESTADO"].ToString();
                professorBLL.Tipotel1 = dr["TIPOTEL1"].ToString();
                professorBLL.Telefone1 = dr["TELEFONE1"].ToString();
                professorBLL.Observacaotel1 = dr["OBSERVACAOTEL1"].ToString();
                professorBLL.Tipotel2 = dr["TIPOTEL2"].ToString();
                professorBLL.Telefone2 = dr["TELEFONE2"].ToString();
                professorBLL.Observacaotel2 = dr["OBSERVACAOTEL2"].ToString();
                professorBLL.Tipotel3 = dr["TIPOTEL3"].ToString();
                professorBLL.Telefone3 = dr["TELEFONE3"].ToString();
                professorBLL.Observacaotel3 = dr["OBSERVACAOTEL3"].ToString();
                professorBLL.Email = dr["EMAIL"].ToString();
                professorBLL.Escolaridade = dr["ESCOLARIDADE"].ToString();
                professorBLL.Dtadmissao = DateTime.Parse(dr["DTADMISSAO"].ToString());
                if (professorBLL.Dtdemissao != null)
                {
                    professorBLL.Dtdemissao = DateTime.Parse(dr["DTDEMISSAO"].ToString());
                }
                else
                {
                    //professorBLL.Dtdemissao = DateTime.Parse(dr["DTDEMISSAO"].ToString());
                    //cmd.Parameters.AddWithValue("@DTDEMISSAO", DBNull.Value);
                }
                
                

            }
            dr.Close();
            con.Desconectar();
            return professorBLL;//retorna objeto preenchido
        }

        // -------------------- METODO VERIFICAR CPF --------------------
        public int VerificaCpf(BLL.ProfessorBLL professorBLL)
        {

            SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) AS QTD FROM PROFESSOR WHERE CPF = @CPF", con.Conectar());
            int qtd = 0;
            cmd.Parameters.AddWithValue("@CPF", professorBLL.Cpf);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())//conseguiu ler?
            {
                //preenchendo objetos
                qtd = int.Parse(dr["QTD"].ToString());

            }
            dr.Close();
            con.Desconectar();
            return qtd;//retorna objeto preenchido
        }

        // -------------------- METODO EXCLUIR --------------------

        public void Excluir(BLL.ProfessorBLL professorBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM PROFESSOR WHERE CODPROFESSOR = @CODPROFESSOR", con.Conectar());
            cmd.Parameters.AddWithValue("@CODPROFESSOR", professorBLL.Codprofessor);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

    }
}
