using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using System.Data;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class TelefoneUsuarioBLL
    {
		Querys querys = new Querys();
		public RetornoDTO Inserir(TelefoneUsuarioDTO telefoneUsuarioDTO)
		{
			return querys.Inserir("TELEFONE_USUARIO", "id_usuario, numero_telefone, whatsapp, categoria_telefone", 
				$"' {telefoneUsuarioDTO.IdUsuario} '," +
				$"' {telefoneUsuarioDTO.NumeroTelefone}  '," +
				$" {telefoneUsuarioDTO.Whatsapp} ," +
				$"' {telefoneUsuarioDTO.CategoriaTelefone}'");	
		}
		public RetornoDTO Excluir(TelefoneUsuarioDTO telefoneUsuarioDTO)
		{
			return querys.Excluir("TELEFONE_USUARIO" , "id_telefone_usuario", telefoneUsuarioDTO.IdTelefoneUsuario);	
		}
		public RetornoDTO Alterar(TelefoneUsuarioDTO telefoneUsuarioDTO)
		{
			return querys.Alterar("TELEFONE_USUARIO",
				$"id_usuario = '{telefoneUsuarioDTO.IdUsuario}', " +
				$"numero_telefone = '{telefoneUsuarioDTO.NumeroTelefone}', " +
				$"whatsapp = {telefoneUsuarioDTO.Whatsapp}, " +
				$"categoria_telefone = '{telefoneUsuarioDTO.CategoriaTelefone}' ",
				"id_telefone_usuario", telefoneUsuarioDTO.IdTelefoneUsuario);
		}
		public SelecionarRetornoDTO SelecionarTodos()
		{
			return querys.SelecionarTodos("TELEFONE_USUARIO");
		}

		public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("TELEFONE_USUARIO", condicao);
			
		}
	}
}
