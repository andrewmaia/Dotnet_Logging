//Importante: para este código foi necessario adicionar as libs Microsoft.Extensions.Logging e Microsoft.Extensions.Logging.Console
//Mas para aplicacoes que usam hosts do ASP.NET Core, essas libs já estão presentes nativamente
//E ILogger já está presente no DI para ser injetado no construtor de classes


using Microsoft.Extensions.Logging;
using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());

//A string passada como parametro "Program"
//é o category name, ele é usado para identificar a origem da mensagem de log
//Por convenção, o nome da classe é usado como category name
//Assim poderia se usar ILogger<Program> logger para se ter o mesmo resultado
ILogger logger = factory.CreateLogger("Program");


//Repare que o método LogInformation é chamado com uma string simalar a interpolação
//de string, mas não é uma interpolação de string
//O método LogInformation aceita o que chamamos de message template
//O message template é recomendado ao invés de usar interpolação de string 
//porque ele permite que {adjetivo} seja indexado como um campo a parte ao salvar a log 
//e nao como uma string concatenada. Isso permite pesquisas mais performáticas sobre o valor de {adjetivo}
logger.LogInformation("Olá! Logs são {adjetivo}.", "legais");