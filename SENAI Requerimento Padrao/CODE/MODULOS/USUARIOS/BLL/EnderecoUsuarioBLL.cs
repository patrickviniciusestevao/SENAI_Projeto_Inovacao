﻿using System;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class EnderecoUsuarioBLL
    {
		Querys querys = new Querys();
		public void Inserir(EnderecoUsuarioDTO enderecoUsuarioDTO)
		{
			querys.Inserir("ENDERECO_USUARIO", "id_usuario, logradouro, numero, cep, bairro, complemento, cidade, uf, categoria_endereco",
				$"'{enderecoUsuarioDTO.IdUsuario}', " +
				$"'{enderecoUsuarioDTO.Logradouro}', " +
				$"'{enderecoUsuarioDTO.Numero}', " +
				$"'{enderecoUsuarioDTO.Cep}', " +
				$"'{enderecoUsuarioDTO.Bairro}', " +
				$"'{enderecoUsuarioDTO.Complemento}', " +
				$"'{enderecoUsuarioDTO.Cidade}', " +
				$"'{enderecoUsuarioDTO.Uf}', " +
				$"'{enderecoUsuarioDTO.CategoriaEndereco}'"
			);
		}

		public void Excluir(EnderecoUsuarioDTO enderecoUsuarioDTO)
		{
			querys.Excluir("ENDERECO_USUARIO", "id_endereco_usuario", enderecoUsuarioDTO.IdEnderecoUsuario.ToString());
		}

		public void Alterar(EnderecoUsuarioDTO enderecoUsuarioDTO)
		{
			querys.Alterar("ENDERECO_USUARIO",
				$"id_usuario = '{enderecoUsuarioDTO.IdUsuario}', " +
				$"logradouro = '{enderecoUsuarioDTO.Logradouro}', " +
				$"numero = '{enderecoUsuarioDTO.Numero}', " +
				$"cep = '{enderecoUsuarioDTO.Cep}', " +
				$"bairro = '{enderecoUsuarioDTO.Bairro}', " +
				$"complemento = '{enderecoUsuarioDTO.Complemento}', " +
				$"cidade = '{enderecoUsuarioDTO.Cidade}', " +
				$"uf = '{enderecoUsuarioDTO.Uf}', " +
				$"categoria_endereco = '{enderecoUsuarioDTO.CategoriaEndereco}'",
				"id_endereco_usuario", enderecoUsuarioDTO.IdEnderecoUsuario.ToString()
			);
		}

		public DataTable SelecionarTodos()
		{
			return querys.SelecionarTodos("ENDERECO_USUARIO");
		}

		public DataTable SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("ENDERECO_USUARIO", condicao);
		}
	}
}
