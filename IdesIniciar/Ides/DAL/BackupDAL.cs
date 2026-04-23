using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ides.DAL
{
    class BackupDAL
    {
        Conexao con = new Conexao();

        public void GerarBackup(string caminho)
        {
            SqlCommand cmd = new SqlCommand("USE MASTER;BACKUP DATABASE [BDSECRETARIAIDES] TO DISK=@CAMINHO", con.Conectar());
            cmd.Parameters.AddWithValue(@"CAMINHO", caminho);
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public void RestaurarBackup(string caminho)
        {
            SqlCommand cmd = new SqlCommand("USE MASTER;RESTORE DATABASE [BDSECRETARIAIDES] FROM DISK=@CAMINHO", con.Conectar());
            cmd.Parameters.AddWithValue(@"CAMINHO", caminho);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}
