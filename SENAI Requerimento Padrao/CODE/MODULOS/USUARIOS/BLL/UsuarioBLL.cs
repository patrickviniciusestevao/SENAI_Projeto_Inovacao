using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
	class UsuarioBLL
	{
		AcessoBancoDados bd;
		Querys querys = new Querys();

		public void Inserir(UsuarioDTO usuarioDTO)
		{

			string nome_completo = querys.TrocarAspas(usuarioDTO.NomeCompleto);
		
			querys.Inserir("USUARIO", "id_funcao, url_foto_usuario, nome_completo, matricula, email_institucional, senha, situacao",
				usuarioDTO.IdFuncao + "," +
				"'C:/foto.jpeg'," +
				"'" + nome_completo + "'," +
				"'" + usuarioDTO.Matricula + "'," +
				"'" + usuarioDTO.EmailInstitucional + "'," +
				"'123'," +
				"'" + usuarioDTO.Situacao + "'");
		}
		
		public void Excluir(UsuarioDTO usuarioDTO)
		{
			string comando = "" +
				"DELETE FROM USUARIO where id_cliente = '" + usuarioDTO.IdUsuario + "'";


		}
		
		public void Alterar(UsuarioDTO usuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				// Se houver aspas, coloque mais uma para evitar possíveis erros no banco
				string nome_completo = this.TrocarAspas(usuarioDTO.NomeCompleto);

				string comando =
					"UPDATE USUARIO set " +
					" id_funcao = '" + usuarioDTO.IdFuncao + "'," +
					" url_foto_usuario = '" + usuarioDTO.UrlFotoUsuario + "'," +
					" nome_completo = '" + nome_completo + "'," +
					" matricula = '" + usuarioDTO.Matricula + "'," +
					" email_institucional = '" + usuarioDTO.EmailInstitucional + "'," +
					" senha = '" + usuarioDTO.Senha + "'," +
					" situacao = '" + usuarioDTO.Situacao+
					"' where id = '" + usuarioDTO.IdUsuario + "'";

				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao alterar: " + excecao);
			}
			finally
			{
				bd = null;
			}
		}

		public DataTable SelecionarTodos()
		{
			DataTable dt = new DataTable();
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dt = bd.RetDataTable("Select * from USUARIO");
			}
			catch (Exception excecao)
			{
				Console.WriteLine("Erro ao tentar selecionar todos os usuários: " + excecao);
			}
			finally
            {
				bd = null;
            }

			return dt;
		}

		public DataTable SelecionarComCondicao(string condicao)
		{
			DataTable dataTable = new DataTable();

			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dataTable = bd.RetDataTable("Select * from USUARIO where " + condicao);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao listar com condição" + ex.ToString());
			}
			finally
			{
				bd = null;
			}

			return dataTable;
		}
	}
}
