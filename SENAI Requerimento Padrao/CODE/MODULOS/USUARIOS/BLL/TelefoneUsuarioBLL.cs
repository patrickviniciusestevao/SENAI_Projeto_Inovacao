using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class TelefoneUsuarioBLL
    {
		Querys querys = new Querys();
		public void Inserir(TelefoneUsuarioDTO telefoneUsuarioDTO)
		{

			querys.Inserir($"TELEFONE_USUARIO", "id_usuario, numero_telefone, whatsapp, categoria_telefone", 
				$"' {telefoneUsuarioDTO.IdUsuario} '," +
				$"' {telefoneUsuarioDTO.NumeroTelefone}  '," +
				$"' {telefoneUsuarioDTO.Whatsapp} '," +
				$"' {telefoneUsuarioDTO.CategoriaTelefone} " +
				$"')");
			
				
		}
		public void Excluir(TelefoneUsuarioDTO telefoneUsuarioDTO)
		{
			querys.Inserir("TELEFONE_USUARIO" , "id_funcao" , "'"+ telefoneUsuarioDTO.IdTelefoneUsuario + "'");	
		}

		public void Alterar(TelefoneUsuarioDTO telefoneUsuarioDTO)
		{


			querys.Alterar(" TELEFONE_USUARIO ", "," +
				"id_usuario = '" + telefoneUsuarioDTO.IdUsuario + "'," +
				"numero_telefone = '" + telefoneUsuarioDTO.NumeroTelefone + "'," +
				"whatsapp = '" + telefoneUsuarioDTO.Whatsapp + "'," +
				"categoria_telefone = '" + telefoneUsuarioDTO.CategoriaTelefone,
				"id_telefone_usuario ", "'" + telefoneUsuarioDTO.IdTelefoneUsuario + "'");

		}
		public DataTable SelecionarTodos()
		{
				return querys.SelecionarTodos("TELEFONE_USUARIO");
		}

		public DataTable SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("TELEFONE_USUARIO where ", condicao);
			
		}
	}
}
