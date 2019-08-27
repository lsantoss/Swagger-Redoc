using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swagger_Redoc.Commands.Pessoa.Input;
using Swagger_Redoc.Commands.Pessoa.QueryResult;
using Swagger_Redoc.Interfaces;

namespace Swagger_Redoc.Controllers.Servicos
{
    [Route("[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        /// <summary>
        /// Health Check
        /// </summary>        
        /// <remarks><h2><b><i>Afere a resposta deste contexto do serviço.</i></b></h2></remarks>
        /// <response code="200">OK Request</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("v1/HealthCheck")]
        public String PessoaHealthCheck()
        {
            return "Health Check bem sucedido!";
        }

        /// <summary>
        /// Pessoas
        /// </summary>                
        /// <remarks><h2><b><i>Lista todos os clientes.</i></b></h2></remarks>
        /// <response code="200">OK Request</response>
        /// <response code="204">Not Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("v1/Pessoas")]
        public IEnumerable<PessoaQueryResult> Pessoas()
        {
            return null;
        }

        /// <summary>
        /// Pessoa
        /// </summary>                
        /// <remarks><h2><b>Lista todas pessoas.</b></h2></remarks>
        /// <param name="Id">Parâmetro requerido: id da Pessoa</param>
        /// <response code="200">OK Request</response>
        /// <response code="204">Not Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("v1/Pessoa/{Id:int}")]
        public PessoaQueryResult Pessoa(int Id)
        {
            return null;
        }

        // CRUD
        /// <summary>
        /// Incluir Pessoa 
        /// </summary>                
        /// <remarks><h2><b>Incluia nova Pessoa na base de dados.</b></h2></remarks>
        /// <param name="command" >Parâmetro requerido: command de Insert</param>
        /// <response code="200">OK Request</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("v1/PessoaNovo")]
        public ICommandResult PessoaNovo([FromBody]PessoaAdicionarCommand command)
        {
            return null;
        }

        /// <summary>
        /// Alterar Pessoa
        /// </summary>        
        /// <remarks><h2><b>Altera a Pessoa na base de dados.</b></h2></remarks>        
        /// <param name="command" >Parâmetro requerido: command de Update</param>
        /// <response code="200">OK Request</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut]
        [Route("v1/PessoaAlterar")]
        public ICommandResult PessoaAlterar([FromBody]PessoaAtualizarCommand command)
        {
            return null;
        }

        /// <summary>
        /// Excluir Pessoa
        /// </summary>                
        /// <remarks><h2><b>Exclui a Pessoa na base de dados.</b></h2></remarks>
        /// <param name="command" >Parametro requerido: command de Delete</param>
        /// <response code="200">OK Request</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal Server Error</response>
        [HttpDelete]
        [Route("v1/PessoaExcluir")]
        public ICommandResult PessoaExcluir([FromBody]PessoaDeletarCommand command)
        {
            return null;
        }
    }
}