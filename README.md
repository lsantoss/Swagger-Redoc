# Swagger + Redoc

<h3>Aplicação:</h3>
<p>Essa aplicação contém um exemplo de documentação de api, usando Swagger e Redoc.</p>

<br/>

<p>Biblioteca: Swashbuckle.AspNetCore</p>
<p>Biblioteca: Redoc</p>

<br/>

<h3>Como fazer:</h3>

<ol type="number">
 <li>Baixar a biblioteca Swashbuckle.AspNetCore via NuGet</li>
 
 <br>
 
 <li>Em <b>Startup.cs</b>:<br/>
    <blockquote>
      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSwaggerGen(x =>
            {
                x.IncludeXmlComments(GetXmlCommentsPath());
                x.SwaggerDoc("v1", new Info
                {
                    Title = "Swagger + Redoc",
                    Version = "v1",
                    Description = "Exemplo de projeto utlizando Swagger + Redoc",
                    //TermsOfService = "Nenhum",
                    Contact = new Contact
                    {
                        Name = "Desenvolvido por Lucas Santos",
                        Email = "l_santos@hotmail.com.br",
                        Url = "https://github.com/lsantoss"
                    }
                });
            });
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger+Redoc");
            });

            app.UseMvc();
        }
        
        protected static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\Swagger.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    
   </blockquote>
  </li>
  
  <br>
 
  <li>Na pasta <b>/wwwroot/scripts/</b> salvar o arquivo <b>redoc.js</b></li>
    
  <br>
 
  <li>Na <b>View</b> principal:<br/>
    <blockquote>
      
    <!DOCTYPE html>
    <html>
        <head>
            <link rel="shortcut icon" type="image/x-icon" href="~/img/icone.png" />
            <title>Doc's Swagger + Redoc</title>
            <meta charset="utf-8" />
            <meta name="viewport" content="width=device-width, initial-scale=1">
            <link href="https://fonts.googleapis.com/css?family=Montserrat:300,400,700|Roboto:300,400,700" rel="stylesheet">

            <style>
                body {
                    margin: 0;
                    padding: 0;
                }
            </style>
        </head>

        <body>
            <redoc spec-url='/swagger/v1/swagger.json'></redoc>
            <script src="~/scripts/redoc.js"></script>
        </body>
    </html>
    
   </blockquote>
  </li>
  
  <br>
  
  <li>Em <b>Propriedades do projeto</b>:<br>
      <ol>
         <li>Adicionar em <b>Suprimir Avisos</b> o código 1591</li>
         <li>Marcar a opção <b>Arquivo de documentação XML</b></li>
         <li>Adicionar caminho para o <b>Arquivo de documentação XML</b> ---> bin\Debug\netcoreapp2.0\Swagger.xml</li>
      </ol>
  </li>
  
  <br>
  
  <li>Nas <b>Controllers</b>: (exemplo de documentação)<br/>
    <blockquote>
      
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
    
   </blockquote>
  </li>
</ol>
