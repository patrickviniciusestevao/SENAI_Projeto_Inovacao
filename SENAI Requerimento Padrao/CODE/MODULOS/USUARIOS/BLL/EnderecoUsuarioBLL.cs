using System;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class EnderecoUsuarioBLL
    {
		AcessoBancoDados bd;
		public void Inserir(EnderecoUsuarioDTO enderecoUsuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				string comando = "INSERT INTO ENDERECO_USUARIO (id_usuario, logradouro, numero, cep, bairro, complemento, cidade, uf, categoria_endereco) values (" +
					"'" + enderecoUsuarioDTO.IdUsuario + "'," +
					"'" + enderecoUsuarioDTO.Logradouro + "'," +
					"'" + enderecoUsuarioDTO.Numero + "'," +
					"'" + enderecoUsuarioDTO.Cep + "'," +
					"'" + enderecoUsuarioDTO.Bairro + "'," +
					"'" + enderecoUsuarioDTO.Complemento + "'," +
					"'" + enderecoUsuarioDTO.Cidade + "'," +
					"'" + enderecoUsuarioDTO.Uf + "'," +
					"'" + enderecoUsuarioDTO.CategoriaEndereco + "')";
				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao tentar inserir: " + excecao.ToString());
			}
			finally
			{
				bd = null;
			}
		}

		public void Excluir(EnderecoUsuarioDTO enderecoUsuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				string comando = "DELETE FROM ENDERECO_USUARIO where id_endereco_usuario = '" +
					enderecoUsuarioDTO.IdEnderecoUsuario + "'";
				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao tentar Excluir: " + excecao.ToString());
			}
			finally
			{
				bd = null;
			}
		}

		public void Alterar(EnderecoUsuarioDTO enderecoUsuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				string comando = "UPDATE ENDERECO_USUARIO set " +
					"id_usuario = '" + enderecoUsuarioDTO.IdUsuario + "'," +
					"logradouro = '" + enderecoUsuarioDTO.Logradouro + "'," +
					"numero = '" + enderecoUsuarioDTO.Numero + "'," +
					"cep = '" + enderecoUsuarioDTO.Cep + "'," + 
					"bairro = '" + enderecoUsuarioDTO.Bairro + "'," + 
					"complemento = '" + enderecoUsuarioDTO.Complemento+ "'," + 
					"cidade = '" + enderecoUsuarioDTO.Cidade + "'," + 
					"uf = '" + enderecoUsuarioDTO.Uf + "'," + 
					"categoria_endereco = '" + enderecoUsuarioDTO.CategoriaEndereco + "'" +
					"where id_endereco_usuario = '" + enderecoUsuarioDTO.IdEnderecoUsuario + "'";

				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao alterar: " + excecao.ToString());
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
				dt = bd.RetDataTable("Select * from ENDERECO_USUARIO");
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao selecionar:" + excecao.ToString());
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
				dataTable = bd.RetDataTable("Select * from ENDERECO_USUARIO where " + condicao);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao listar com condição: " + excecao.ToString());
			}

			return dataTable;
		}
	}
}
