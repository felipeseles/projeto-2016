using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//necessario
using System.Data.SqlClient;//necessario

namespace Ides.DAL
{
    class AlunoDAL
    {
        // -------------------- CLASSE CONEXÃO --------------------
        
        Conexao con = new Conexao();

        // -------------------- MÉTODO CADASTRO SIMPLES --------------------
        
        public void CadastrarSimples(BLL.AlunoBLL alunoBLL)
        {
            //passando comando sql para cadastrar
            
            SqlCommand cmd = new SqlCommand(@"INSERT INTO ALUNO 
(NOMEALUNO, RG, EMISSAO, DATANASC, TIPOTEL1, TELEFONE1, OBSERVACAOTEL1)
VALUES (@NOMEALUNO, @RG, @EMISSAO, @DATANASC, @TIPOTEL1, @TELEFONE1, @OBSERVACAOTEL1)", con.Conectar());
            
            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@NOMEALUNO", alunoBLL.Nome);
            cmd.Parameters.AddWithValue("@RG", alunoBLL.Rg);
            cmd.Parameters.AddWithValue("@EMISSAO", alunoBLL.Emissao);
            cmd.Parameters.AddWithValue("@DATANASC", alunoBLL.Datanasc);
            cmd.Parameters.AddWithValue("@TIPOTEL1", alunoBLL.Tipotel1);
            cmd.Parameters.AddWithValue("@TELEFONE1", alunoBLL.Telefone1);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL1", alunoBLL.Observacaotel1);

            //executar comando

            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão
        }

        // -------------------- MÉTODO CADASTRO COMPLETO --------------------

        public void Cadastrar(BLL.AlunoBLL alunoBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"INSERT INTO ALUNO (NOMEALUNO, RG, EMISSAO, DATANASC,
    CPF, FILIACAOMAE, FILIACAOPAI, CEP, ENDERECO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE,
    ESTADO, TIPOTEL1, TELEFONE1, OBSERVACAOTEL1, TIPOTEL2, TELEFONE2, OBSERVACAOTEL2,
    TIPOTEL3, TELEFONE3, OBSERVACAOTEL3, EMAIL)
    VALUES (@NOMEALUNO, @RG, @EMISSAO, @DATANASC, @CPF, @FILIACAOMAE, @FILIACAOPAI, @CEP,
    @ENDERECO, @NUMERO, @COMPLEMENTO, @BAIRRO, @CIDADE, @ESTADO, @TIPOTEL1, @TELEFONE1,
    @OBSERVACAOTEL1, @TIPOTEL2, @TELEFONE2, @OBSERVACAOTEL2, @TIPOTEL3, @TELEFONE3,
    @OBSERVACAOTEL3, @EMAIL)", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@NOMEALUNO", alunoBLL.Nome);
            cmd.Parameters.AddWithValue("@RG", alunoBLL.Rg);
            cmd.Parameters.AddWithValue("@EMISSAO", alunoBLL.Emissao);
            cmd.Parameters.AddWithValue("@DATANASC", alunoBLL.Datanasc);
            cmd.Parameters.AddWithValue("@CPF", alunoBLL.Cpf);
            cmd.Parameters.AddWithValue("@FILIACAOMAE", alunoBLL.Filiacaomae);
            cmd.Parameters.AddWithValue("@FILIACAOPAI", alunoBLL.Filiacaopai);
            cmd.Parameters.AddWithValue("@CEP", alunoBLL.Cep);
            cmd.Parameters.AddWithValue("@ENDERECO", alunoBLL.Endereco);
            cmd.Parameters.AddWithValue("@NUMERO", alunoBLL.Numero);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", alunoBLL.Complemento);
            cmd.Parameters.AddWithValue("@BAIRRO", alunoBLL.Bairro);
            cmd.Parameters.AddWithValue("@CIDADE", alunoBLL.Cidade);
            cmd.Parameters.AddWithValue("@ESTADO", alunoBLL.Estado);
            cmd.Parameters.AddWithValue("@TIPOTEL1", alunoBLL.Tipotel1);
            cmd.Parameters.AddWithValue("@TELEFONE1", alunoBLL.Telefone1);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL1", alunoBLL.Observacaotel1);
            cmd.Parameters.AddWithValue("@TIPOTEL2", alunoBLL.Tipotel2);
            cmd.Parameters.AddWithValue("@TELEFONE2", alunoBLL.Telefone2);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL2", alunoBLL.Observacaotel2);
            cmd.Parameters.AddWithValue("@TIPOTEL3", alunoBLL.Tipotel3);
            cmd.Parameters.AddWithValue("@TELEFONE3", alunoBLL.Telefone3);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL3", alunoBLL.Observacaotel3);
            cmd.Parameters.AddWithValue("@EMAIL", alunoBLL.Email);

            //executar comando

            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão
        }

        // -------------------- METODO CONSULTAR TODOS --------------------
       
        public DataTable ConsultarTodos()
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT
CODALUNO AS Código, NOMEALUNO AS Aluno, RG, EMISSAO AS UF, TIPOTEL1 AS [Tipo Telefone],
TELEFONE1 AS Telefone, OBSERVACAOTEL1 AS Observação, EMAIL AS [E-Mail] FROM ALUNO ORDER BY NOMEALUNO", con.Conectar());
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }

        // -------------------- METODO CONSULTAR POR NOME --------------------

        public DataTable ConsultarPorNome(BLL.AlunoBLL alunoBLL)
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT 
CODALUNO AS Código, NOMEALUNO AS Aluno, RG, EMISSAO AS UF, TIPOTEL1 AS [Tipo Telefone],
TELEFONE1 AS Telefone, OBSERVACAOTEL1 AS Observação, EMAIL AS [E-Mail] FROM ALUNO
WHERE NOMEALUNO LIKE @NOMEALUNO ORDER BY NOMEALUNO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOMEALUNO", alunoBLL.Nome + "%");
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }

        // -------------------- METODO CONSULTAR POR RG --------------------

        public DataTable ConsultarPorRg(BLL.AlunoBLL alunoBLL)
        {
            //passamos comando SQL de consulta

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT
CODALUNO AS Código, NOMEALUNO AS Aluno, RG, EMISSAO AS UF, TIPOTEL1 AS [Tipo Telefone],
TELEFONE1 AS Telefone, OBSERVACAOTEL1 AS Observação, EMAIL AS [E-Mail] FROM ALUNO 
WHERE RG LIKE @RG ORDER BY NOMEALUNO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@RG", alunoBLL.Rg + "%");
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }

        // -------------------- METODO ATUALIZAR/ EDITAR SIMPLES --------------------

        public void AlterarSimples(BLL.AlunoBLL alunoBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"UPDATE ALUNO SET NOMEALUNO = @NOMEALUNO, RG = @RG,
    EMISSAO = @EMISSAO, DATANASC = @DATANASC, TIPOTEL1 = @TIPOTEL1, TELEFONE1 = @TELEFONE1, OBSERVACAOTEL1 = @OBSERVACAOTEL1,
    WHERE CODALUNO = @CODALUNO", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@NOMEALUNO", alunoBLL.Nome);
            cmd.Parameters.AddWithValue("@RG", alunoBLL.Rg);
            cmd.Parameters.AddWithValue("@EMISSAO", alunoBLL.Emissao);
            cmd.Parameters.AddWithValue("@DATANASC", alunoBLL.Datanasc);
            cmd.Parameters.AddWithValue("@TIPOTEL1", alunoBLL.Tipotel1);
            cmd.Parameters.AddWithValue("@TELEFONE1", alunoBLL.Telefone1);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL1", alunoBLL.Observacaotel1);
            cmd.Parameters.AddWithValue("@CODALUNO", alunoBLL.Codaluno);

            //executar comando
            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão
        }

        // -------------------- METODO ATUALIZAR/ EDITAR COMPLETO --------------------

        public void Alterar(BLL.AlunoBLL alunoBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"UPDATE ALUNO SET NOMEALUNO = @NOMEALUNO, RG = @RG,
    EMISSAO = @EMISSAO, DATANASC = @DATANASC, CPF = @CPF, FILIACAOMAE = @FILIACAOMAE,
    FILIACAOPAI = @FILIACAOPAI, CEP = @CEP, ENDERECO = @ENDERECO, NUMERO = @NUMERO,
    COMPLEMENTO = @COMPLEMENTO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, ESTADO = @ESTADO,
    TIPOTEL1 = @TIPOTEL1, TELEFONE1 = @TELEFONE1, OBSERVACAOTEL1 = @OBSERVACAOTEL1,
    TIPOTEL2 = @TIPOTEL2, TELEFONE2 = @TELEFONE2, OBSERVACAOTEL2 = @OBSERVACAOTEL2,
    TIPOTEL3 = @TIPOTEL3, TELEFONE3 = @TELEFONE3, OBSERVACAOTEL3 = @OBSERVACAOTEL3, EMAIL = @EMAIL
    WHERE CODALUNO = @CODALUNO", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@NOMEALUNO", alunoBLL.Nome);
            cmd.Parameters.AddWithValue("@RG", alunoBLL.Rg);
            cmd.Parameters.AddWithValue("@EMISSAO", alunoBLL.Emissao);
            cmd.Parameters.AddWithValue("@DATANASC", alunoBLL.Datanasc);
            cmd.Parameters.AddWithValue("@CPF", alunoBLL.Cpf);
            cmd.Parameters.AddWithValue("@FILIACAOMAE", alunoBLL.Filiacaomae);
            cmd.Parameters.AddWithValue("@FILIACAOPAI", alunoBLL.Filiacaopai);
            cmd.Parameters.AddWithValue("@CEP", alunoBLL.Cep);
            cmd.Parameters.AddWithValue("@ENDERECO", alunoBLL.Endereco);
            cmd.Parameters.AddWithValue("@NUMERO", alunoBLL.Numero);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", alunoBLL.Complemento);
            cmd.Parameters.AddWithValue("@BAIRRO", alunoBLL.Bairro);
            cmd.Parameters.AddWithValue("@CIDADE", alunoBLL.Cidade);
            cmd.Parameters.AddWithValue("@ESTADO", alunoBLL.Estado);
            cmd.Parameters.AddWithValue("@TIPOTEL1", alunoBLL.Tipotel1);
            cmd.Parameters.AddWithValue("@TELEFONE1", alunoBLL.Telefone1);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL1", alunoBLL.Observacaotel1);
            cmd.Parameters.AddWithValue("@TIPOTEL2", alunoBLL.Tipotel2);
            cmd.Parameters.AddWithValue("@TELEFONE2", alunoBLL.Telefone2);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL2", alunoBLL.Observacaotel2);
            cmd.Parameters.AddWithValue("@TIPOTEL3", alunoBLL.Tipotel3);
            cmd.Parameters.AddWithValue("@TELEFONE3", alunoBLL.Telefone3);
            cmd.Parameters.AddWithValue("@OBSERVACAOTEL3", alunoBLL.Observacaotel3);
            cmd.Parameters.AddWithValue("@EMAIL", alunoBLL.Email);
            cmd.Parameters.AddWithValue("@CODALUNO", alunoBLL.Codaluno);

            //executar comando
            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão
        }

        // -------------------- METODO RETORNAR DADOS COMPLETO --------------------

        public BLL.AlunoBLL RetornarDados(BLL.AlunoBLL alunoBLL)
        {

            SqlCommand cmd = new SqlCommand(@"SELECT * FROM ALUNO WHERE CODALUNO = @CODALUNO", con.Conectar());
            cmd.Parameters.AddWithValue("@CODALUNO", alunoBLL.Codaluno);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())//conseguiu ler?
            {
                //preenchendo objetos
                alunoBLL.Codaluno = int.Parse(dr["CODALUNO"].ToString());
                alunoBLL.Nome = dr["NOMEALUNO"].ToString();
                alunoBLL.Rg = dr["RG"].ToString();
                alunoBLL.Emissao = dr["EMISSAO"].ToString();
                alunoBLL.Datanasc = DateTime.Parse(dr["DATANASC"].ToString());
                alunoBLL.Cpf = dr["CPF"].ToString();
                alunoBLL.Filiacaomae = dr["FILIACAOMAE"].ToString();
                alunoBLL.Filiacaopai = dr["FILIACAOPAI"].ToString();
                alunoBLL.Cep = dr["CEP"].ToString();
                alunoBLL.Endereco = dr["ENDERECO"].ToString();
                alunoBLL.Numero = dr["NUMERO"].ToString();
                alunoBLL.Complemento = dr["COMPLEMENTO"].ToString();
                alunoBLL.Bairro = dr["BAIRRO"].ToString();
                alunoBLL.Cidade = dr["CIDADE"].ToString();
                alunoBLL.Estado = dr["ESTADO"].ToString();
                alunoBLL.Tipotel1 = dr["TIPOTEL1"].ToString();
                alunoBLL.Telefone1 = dr["TELEFONE1"].ToString();
                alunoBLL.Observacaotel1 = dr["OBSERVACAOTEL1"].ToString();
                alunoBLL.Tipotel2 = dr["TIPOTEL2"].ToString();
                alunoBLL.Telefone2 = dr["TELEFONE2"].ToString();
                alunoBLL.Observacaotel2 = dr["OBSERVACAOTEL2"].ToString();
                alunoBLL.Tipotel3 = dr["TIPOTEL3"].ToString();
                alunoBLL.Telefone3 = dr["TELEFONE3"].ToString();
                alunoBLL.Observacaotel3 = dr["OBSERVACAOTEL3"].ToString();
                alunoBLL.Email = dr["EMAIL"].ToString();
            }
            dr.Close();
            con.Desconectar();
            return alunoBLL;//retorna objeto preenchido
        }

        // -------------------- METODO VERIFICAR CPF --------------------
        public int VerificaCpf(BLL.AlunoBLL alunoBLL)
        {

            SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) AS QTD FROM ALUNO WHERE CPF = @CPF", con.Conectar());
            int qtd = 0;
            cmd.Parameters.AddWithValue("@CPF", alunoBLL.Cpf);
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

        // -------------------- METODO VERIFICAR RG --------------------
        public int VerificaRg(BLL.AlunoBLL alunoBLL)
        {

            SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) AS QTD FROM ALUNO WHERE RG = @RG AND EMISSAO = @EMISSAO", con.Conectar());
            int qtd = 0;
            cmd.Parameters.AddWithValue("@RG", alunoBLL.Rg);
            cmd.Parameters.AddWithValue("@EMISSAO", alunoBLL.Emissao);
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

        public void Excluir(BLL.AlunoBLL alunoBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM ALUNO WHERE CODALUNO = @CODALUNO", con.Conectar());
            cmd.Parameters.AddWithValue("@CODALUNO", alunoBLL.Codaluno);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        // -------------------- METODO MOSTRAR CÓDIGO DO ALUNO --------------------

        public int RetornaCodaluno()
        {

            SqlCommand cmd = new SqlCommand(@"SELECT IDENT_CURRENT( 'ALUNO' ) +1 AS CODALUNO", con.Conectar());
            SqlDataReader dr = cmd.ExecuteReader();
            int codaluno = 1;
            if (dr.Read())//conseguiu ler?
            {
                //preenchendo objetos
                codaluno = int.Parse(dr["CODALUNO"].ToString());

            }
            dr.Close();
            con.Desconectar();
            return codaluno;//retorna objeto preenchido
        }

    }
}
