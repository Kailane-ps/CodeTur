﻿namespace CodeTur.Comum.Commands
{
    public class GenericCommandResult
    {
        public GenericCommandResult(bool sucesso, string mensagem, object data)
        {
            Sucesso  = sucesso;
            Mensagem = mensagem;
            Data     = data;
        }

        public bool Sucesso { get; private set; }
        public string Mensagem { get; private set; }
        public object Data { get; private set; }
    }
}
