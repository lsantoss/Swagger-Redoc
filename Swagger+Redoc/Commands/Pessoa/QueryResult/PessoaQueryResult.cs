using System;

namespace Swagger_Redoc.Commands.Pessoa.QueryResult
{
    public class PessoaQueryResult
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}