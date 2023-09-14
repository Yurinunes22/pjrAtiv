using pjrAtiv.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace pjrAtiv
{
    public static class UsuarioLogado
    {
        public static int IdCliente { get; set; }
        public static string? Nome { get; set; }
        public static string? CpfCliente { get; set; }
        public static string? Celular { get; set; }
        public static string? Email { get; set; }
        public static string? Logradouro { get; set; }
        public static string? Numero { get; set; }
        public static string? Complemento { get; set; }
        public static string? Cidade { get; set; }
        public static string? Estado { get; set; }
        public static string? Cep { get; set; }
        public static string? Genero { get; set; }
        public static DateTime? DataNascimento { get; set; }
        public static string? SenhaLogin{ get; set; }
        public static int ContaLogada { get; set; }



        public static List<Conta> Contas = new List<Conta>();



        public static void Deslogar()
        {
            UsuarioLogado.IdCliente = 0;
            UsuarioLogado.Nome = String.Empty;
            UsuarioLogado.DataNascimento = null;
            UsuarioLogado.Logradouro = String.Empty;
            UsuarioLogado.Numero = String.Empty;
            UsuarioLogado.Complemento = null;
            UsuarioLogado.Cidade = String.Empty;
            UsuarioLogado.Estado = String.Empty;
            UsuarioLogado.CpfCliente = String.Empty;
            UsuarioLogado.Celular = String.Empty;
            UsuarioLogado.SenhaLogin = String.Empty;
            UsuarioLogado.Contas.Clear();
            UsuarioLogado.ContaLogada = 0;
            
        }
    }
}
    

