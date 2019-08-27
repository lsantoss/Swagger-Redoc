namespace Swagger_Redoc.Commands.Pessoa.Output
{
    public class PessoaDeletarCommandResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public PessoaDeletarCommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }
    }
}