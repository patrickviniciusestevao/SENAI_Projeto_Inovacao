using System;
using System.Collections.Generic;
using System.Text;

namespace SENAI_Requerimento_Padrao.CODE.DTO
{
	class ClienteDTO
	{
		private int id;
		private string nome;
		private string email;

		public int Id { get => id; set => id = value; }
		public string Nome { get => nome; set => nome = value; }
		public string Email { get => email; set => email = value; }
	}
}
