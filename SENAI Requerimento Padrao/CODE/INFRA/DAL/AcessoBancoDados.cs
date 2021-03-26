using System;
using System.Data;
using MySql.Data.MySqlClient;
using SENAI_Requerimento_Padrao.CODE.DTO;

namespace SENAI_Requerimento_Padrao.CODE.DAL
{
	class AcessoBancoDados
	{
		private MySqlConnection conn;
		private DataTable data;
		private MySqlDataAdapter da;
		private MySqlDataReader dr;
		private MySqlCommandBuilder cb;

		private String server = "localhost";
		private String user = "root";
		private String database = "TesteCrud";
		private String port = "3306";
		private String password = "root";

		public RetornoDTO Conectar()
		{
			RetornoDTO retorno = new RetornoDTO();

			string connStr = String.Format("server={0}; User Id={1}; database={2}; port={3}; password={4}; pooling=false", server, user, database, port, password);
			try
			{
				if (conn != null)
				{
					conn.Close();
				}
				conn = new MySqlConnection(connStr);

				retorno.codigo = 0;
				retorno.mensagem = "Conexão feita com sucesso!";
			}
			catch (MySqlException exception)
			{
				retorno.codigo = exception.ErrorCode;
				retorno.mensagem = exception.Message;
			}
			finally
			{
				conn.Close();
			}

			return retorno;
		}

		public RetornoDTO ExecutarComandoSQL(string comandoSql)
		{
			RetornoDTO retorno = new RetornoDTO();
			try
			{
				conn.Open();
				if (conn.State == ConnectionState.Open)
				{

					MySqlCommand comando = new MySqlCommand(comandoSql, conn);
					comando.ExecuteNonQuery();
				}

				retorno.codigo = 0;
				retorno.mensagem = "Comando efetuado com sucesso!";
			}
			catch (MySqlException exception)
			{
				retorno.codigo = exception.Number;
				retorno.mensagem = exception.Message;
			}
			finally
			{
				conn.Close();
			}

			return retorno;
		}

		public void Fechar()
		{
			conn.Close();
        }

		public SelecionarRetornoDTO RetDataTable(string sql)
		{
			SelecionarRetornoDTO retorno = new SelecionarRetornoDTO();
			try
			{
				data = new DataTable();
				da = new MySqlDataAdapter(sql, conn);
				cb = new MySqlCommandBuilder(da);
				da.Fill(data);

				retorno.codigo = 0;
				retorno.mensagem = "Leitura feita com sucesso!";
				retorno.tabela = data;
			}
			catch (MySqlException exception)
			{
				retorno.codigo = exception.Number;
				retorno.mensagem = exception.Message;
				retorno.tabela = new DataTable();
			}
			finally
			{
				conn.Close();
			}
			return retorno;
		}

		public MySqlDataReader RetDataReader(string sql)
		{
			MySqlCommand comando = new MySqlCommand(sql, conn);
			MySqlDataReader dr = comando.ExecuteReader();
			dr.Read();
			return dr;
		}
	}
}
