using CodeTur.Comum.Entidades;
using CodeTur.Comum.Enum;
using Flunt.Validations;
using System;

namespace CodeTur.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public Usuario(string nome, string email, string senha, EnTipoUsuario tipoUsuario)
        {
            //if (string.IsNullOrEmpty(nome))
            //  AddNotification("Nome", "Informe o nome");

            //if (string.IsNullOrEmpty(email))
            //  AddNotification("Email", "Informe o email");

            //if (string.IsNullOrEmpty(senha))
            //  AddNotification("Senha", "Informe a senha");

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(nome, 3, "Nome", "O nome deve ter pelo menos 3 caracteres")
                .HasMaxLen(nome, 40, "Nome", "O nome deve ter no máximo 40 caracteres")
                .IsEmail(email, "Email", "Informe um e-mail válido")
                .HasMinLen(senha, 6, "Senha", "A senha deve ter pelo menos 6 caracteres")
                .HasMaxLen(senha, 12, "Senha", "A senha deve ter no máximo 12 caracteres")     
            );

            Nome = nome;
            Email = email;
            Senha = senha;
            TipoUsuario = tipoUsuario;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Telefone { get; private set; }
        public EnTipoUsuario TipoUsuario { get; private set; }
       
    }
}
