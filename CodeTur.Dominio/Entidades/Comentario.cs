﻿using CodeTur.Comum.Entidades;
using System;
using Flunt.Validations;
using CodeTur.Comum.Enum;

namespace CodeTur.Dominio.Entidades
{
    class Comentario : Entidade
    {
        public Comentario(string texto, string sentimento, Guid idUsuario, Guid idPacote, EnStatusComentario status)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(Texto, "Texto", "Informe o texto do comentário")
                .IsNotNullOrEmpty(Sentimento, "Sentimento", "Informe o sentimento do comentário")
                .AreNotEquals(IdUsuario, Guid.Empty, "IdUsuario", "Informe o Id do Usuário do comentário")
                .AreNotEquals(IdPacote, Guid.Empty, "IdPacote", "Informe o Id do pacote do comentário")
                );

            Texto      = texto;
            Sentimento = sentimento;
            IdUsuario  = idUsuario;
            IdPacote   = idPacote;
            Status     = status;
        }

        public string Texto { get; private set; }
        public string Sentimento { get; private set; }
        public EnStatusComentario Status { get; private set; }
        public Guid IdUsuario { get; private set; }
        public virtual Usuario Usuario { get; private set; }
        public Guid IdPacote { get; private set; }
        public virtual Pacote Pacote { get; private set; }

    }
}
