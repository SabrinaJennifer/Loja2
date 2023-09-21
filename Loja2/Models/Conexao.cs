using MySqlConnector;
using System.Dynamic;

namespace Loja2.Models
{
    public class Conexao : IDisposable
    {
        public MySqlConnection conn;
        private readonly string host = "";
        private readonly string port = "";
        private readonly string db = "";
        private readonly string user = "";
        private readonly string pass = "";

        public Conexao()
        {
            Conectar();
        }
        private void Conectar()
        {
            string StrConn = "";
            StrConn = "Server=" + host + ";Port=" + port + ";Database=" + db + ";Uid=" + user + ";Pwd=" +
           pass + ";";
            conn = new MySqlConnection(StrConn);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void Dispose()
        {
            conn?.Close();
            conn.Dispose();
        }
    }
}
