using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//necessario
using System.Data.SqlClient;//necessario

namespace Ides.DAL
{
    class UsuarioDAL
    {
        // referenciar a classe de conexão
        Conexao con = new Conexao();

        //metodo cadastrar
        public void Cadastrar(BLL.UsuarioBLL usuarioBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"INSERT INTO USUARIO
(NOME, SOBRENOME, CPF, SEXO, EMAIL, NOMEUSUARIO, SENHA, ACESSO)
VALUES (@NOME, @SOBRENOME, @CPF, @SEXO, @EMAIL, @NOMEUSUARIO, @SENHA, @ACESSO)", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@NOME", usuarioBLL.Nome);
            cmd.Parameters.AddWithValue("@SOBRENOME", usuarioBLL.Sobrenome);
            cmd.Parameters.AddWithValue("@CPF", usuarioBLL.Cpf);
            cmd.Parameters.AddWithValue("@SEXO", usuarioBLL.Sexo);
            cmd.Parameters.AddWithValue("@EMAIL", usuarioBLL.Email);
            cmd.Parameters.AddWithValue("@NOMEUSUARIO", usuarioBLL.Nomeusuario);
            cmd.Parameters.AddWithValue("@SENHA", usuarioBLL.Senha);
            cmd.Parameters.AddWithValue("@ACESSO", usuarioBLL.Acesso);
            
            //executar comando

            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão

        }


        //metodo consultar
        public DataTable ConsultarTodos()
        {
            //passamos comando SQL de consulta
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CODUSUARIO AS CÓDIGO,
    NOMEUSUARIO AS USUÁRIO, SENHA, ACESSO
    FROM USUARIO ORDER BY NOMEUSUARIO", con.Conectar());
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }


        public DataTable ConsultarPorNome(BLL.UsuarioBLL usuarioBLL)
        {
            //passamos comando SQL de consulta
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CODUSUARIO AS CÓDIGO,
    NOMEUSUARIO AS USUÁRIO, SENHA, ACESSO
    FROM USUARIO
    WHERE NOMEUSUARIO LIKE @NOMEUSUARIO ORDER BY NOMEUSUARIO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOMEUSUARIO", usuarioBLL.Nomeusuario + "%");
            DataTable dt = new DataTable(); //tabela
            da.Fill(dt); // preencher tabela
            con.Desconectar();
            return dt; // retornando tabela preenchida
        }


        //metodo excluir
        public void Excluir(BLL.UsuarioBLL usuarioBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM USUARIO WHERE CODUSUARIO = @CODUSUARIO", con.Conectar());
            cmd.Parameters.AddWithValue("@CODUSUARIO", usuarioBLL.Codusuario);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }


        //metodo atualizar/editar
        public void Alterar(BLL.UsuarioBLL usuarioBLL)
        {
            //passando comando sql para cadastrar

            SqlCommand cmd = new SqlCommand(@"UPDATE USUARIO SET NOME = @NOME, SOBRENOME = @SOBRENOME, CPF = @CPF, 
            SEXO = @SEXO, EMAIL = @EMAIL, NOMEUSUARIO = @NOMEUSUARIO, SENHA = @SENHA,  ACESSO = @ACESSO 
            WHERE CODUSUARIO = @CODUSUARIO", con.Conectar());

            //Passar valor aos parametros

            cmd.Parameters.AddWithValue("@NOME", usuarioBLL.Nome);
            cmd.Parameters.AddWithValue("@SOBRENOME", usuarioBLL.Sobrenome);
            cmd.Parameters.AddWithValue("@CPF", usuarioBLL.Cpf);
            cmd.Parameters.AddWithValue("@SEXO", usuarioBLL.Sexo);
            cmd.Parameters.AddWithValue("@EMAIL", usuarioBLL.Email);
            cmd.Parameters.AddWithValue("@NOMEUSUARIO", usuarioBLL.Nomeusuario);
            cmd.Parameters.AddWithValue("@SENHA", usuarioBLL.Senha);
            cmd.Parameters.AddWithValue("@ACESSO", usuarioBLL.Acesso);
            //cmd.Parameters.AddWithValue("@FOTO", usuarioBLL.Foto);
            cmd.Parameters.AddWithValue("@CODUSUARIO", usuarioBLL.Codusuario);


            //executar comando

            cmd.ExecuteNonQuery();
            con.Desconectar();//fechando a conexão

        }


        //retornar dados
        public BLL.UsuarioBLL RetornarDados(BLL.UsuarioBLL usuarioBLL)
        {

            SqlCommand cmd = new SqlCommand(@"SELECT * FROM USUARIO WHERE CODUSUARIO = @CODUSUARIO", con.Conectar());
            cmd.Parameters.AddWithValue("@CODUSUARIO", usuarioBLL.Codusuario);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())//conseguiu ler?
            {
                //preenchendo objetos
                usuarioBLL.Codusuario = int.Parse(dr["CODUSUARIO"].ToString());
                usuarioBLL.Nome = dr["NOME"].ToString();
                usuarioBLL.Sobrenome = dr["SOBRENOME"].ToString();
                usuarioBLL.Cpf = dr["CPF"].ToString();
                usuarioBLL.Sexo = dr["SEXO"].ToString();
                usuarioBLL.Email = dr["EMAIL"].ToString();
                usuarioBLL.Nomeusuario = dr["NOMEUSUARIO"].ToString();
                usuarioBLL.Senha = dr["SENHA"].ToString();
                usuarioBLL.Acesso = dr["ACESSO"].ToString();
                //usuarioBLL.Foto = dr["FOTO"].ToString();
            }
            dr.Close();
            con.Desconectar();
            return usuarioBLL;//retorna objeto preenchido
        }

        // -------------------- METODO VERIFICAR CPF --------------------

        public int VerificaCpf(BLL.UsuarioBLL usuarioBLL)
        {

            SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) AS QTD FROM USUARIO WHERE CPF = @CPF", con.Conectar());
            int qtd = 0;
            cmd.Parameters.AddWithValue("@CPF", usuarioBLL.Cpf);
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



        //metodo efetuar Login
        public BLL.UsuarioBLL Logar(BLL.UsuarioBLL usuarioBLL)
        {

            SqlCommand cmd = new SqlCommand(@"SELECT * FROM USUARIO WHERE NOMEUSUARIO = @NOMEUSUARIO AND SENHA = @SENHA", con.Conectar());
            cmd.Parameters.AddWithValue("@NOMEUSUARIO", usuarioBLL.Nomeusuario);
            cmd.Parameters.AddWithValue("@SENHA", usuarioBLL.Senha);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())//conseguiu ler?
            {
                //preenchendo objetos
                usuarioBLL.Codusuario = int.Parse(dr["CODUSUARIO"].ToString());
                BLL.UsuarioBLL.nomeusu = dr["NOME"].ToString();
                BLL.UsuarioBLL.sobrenomeusu = dr["SOBRENOME"].ToString();
                BLL.UsuarioBLL.sexousu = dr["SEXO"].ToString();
                BLL.UsuarioBLL.codigousu = int.Parse(dr["CODUSUARIO"].ToString());
                usuarioBLL.Senha = dr["SENHA"].ToString();
                BLL.UsuarioBLL.acessousu = dr["ACESSO"].ToString();
                //usuarioBLL.Acesso = dr["ACESSO"].ToString();
            }
            else //não conseguiu logar
            {
                //zerar variáveis do objeto
                usuarioBLL.Codusuario = 0;
                usuarioBLL.Nomeusuario = null;
                usuarioBLL.Senha = null;
                usuarioBLL.Acesso = null;
            }
            dr.Close();
            con.Desconectar();
            return usuarioBLL;//retorna objeto preenchido
        }
    }
}
