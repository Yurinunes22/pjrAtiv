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
        public static int idCliente { get; set; }
        public static string? nome { get; set; }
        public static string? cpfCliente { get; set; }
        public static string? celular { get; set; }
        public static string? email { get; set; }
        public static string? Logradouro { get; set; }
        public static string? numero { get; set; }
        public static string? complemento { get; set; }
        public static string? cidade { get; set; }
        public static string? estado { get; set; }
        public static int? cep { get; set; }
        public static string? genero { get; set; }
        public static DateTime? dataNascimento { get; set; }
        public static string? senhaLogin{ get; set; }



        public static List<Conta> Contas = new List<Conta>();



        public static void Deslogar()
        {
            UsuarioLogado.idCliente = 0;
            UsuarioLogado.nome = String.Empty;
            UsuarioLogado.dataNascimento = null;
            UsuarioLogado.Logradouro = String.Empty;
            UsuarioLogado.numero = String.Empty;
            UsuarioLogado.complemento = null;
            UsuarioLogado.cidade = String.Empty;
            UsuarioLogado.estado = String.Empty;
            UsuarioLogado.cpfCliente = String.Empty;
            UsuarioLogado.celular = String.Empty;
            UsuarioLogado.senhaLogin = String.Empty;
            UsuarioLogado.Contas.Clear();
        }
    }
}
    

