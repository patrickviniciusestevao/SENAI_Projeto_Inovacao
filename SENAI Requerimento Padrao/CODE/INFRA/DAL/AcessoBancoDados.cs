﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SENAI_Requerimento_Padrao.CODE.DAL
{
	class AcessoBancoDados
	{
		private MySqlConnection conn;
		private DataTable data;
		private MySqlDataAdapter da;
		private MySqlDataReader dr;
		private MySqlCommandBuilder cb;

		private String server = "https://mysql743.umbler.com";
		private String user = "devsenai";
		private String database = "db_requerimento";
		private String port = "41890";
		private String password = "JQAU_57l_B#ob";

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
