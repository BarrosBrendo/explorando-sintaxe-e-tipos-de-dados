using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace explorando_sintaxe_e_tipos_de_dados
{
    public class CadastroPessoa
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public CadastroPessoa(string email, string nome, string senha)
        {   
            Email = email;
            Nome = nome;
            Senha = senha;
        }

        public override string ToString()
        {
            return $"{Nome}, verifique o email:\n {Email} para ativar";
        }

    }
}