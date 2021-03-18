using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SENAI_Requerimento_Padrao.CODE.DAL
{
	class AcessoBancoDados
	{
		private MySqlConnection conn;
		private DataTable data;
		private MySqlDataAdapter da;
		private MySqlDataReader dr;
		private MySqlCommandBuilder cb;

		private String server = "127.0.0.1";
		private String user = "root";
		private String database = "DB_Requerimento_Padrao_Oficial";
		private String port = "3306";
		private String password = "root";

		public void Conectar()
		{
			string connStr = String.Format("server={0}; User Id={1}; database={2}; port={3}; password={4}; pooling=false", server, user, database, port, password);
			try
			{
				if (conn != null)
				{
					conn.Close();
				}
				conn = new MySqlConnection(connStr);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public void ExecutarComandoSQL(string comandoSql)
		{
			try
			{
				conn.Open();
				if (conn.State == ConnectionState.Open)
				{

					MySqlCommand comando = new MySqlCommand(comandoSql, conn);
					comando.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public DataTable RetDataTable(string sql)
		{
			data = new DataTable();
			da = new MySqlDataAdapter(sql, conn);
			cb = new MySqlCommandBuilder(da);
			da.Fill(data);
			return data;
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
