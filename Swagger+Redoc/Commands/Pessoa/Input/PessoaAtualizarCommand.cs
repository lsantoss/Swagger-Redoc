using System;

namespace Swagger_Redoc.Commands.Pessoa.Input
{
    public class PessoaAtualizarCommand
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}