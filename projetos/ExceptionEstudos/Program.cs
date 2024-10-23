using ExceptionEstudos;

Console.Clear();
var arr = new int[3];

try  // Serve para tenta executar o codigo, se o codigo dar ele pega o erro executa um tratamento no catch 
{
    ErroAgora();
    Cadastrar("");
    for (var index = 0; index < 10; index++)
    {
        // IndexOutOfRangeExcepion  <= nome da execeção
        Console.WriteLine(arr[index]);
    }

}//Tratando Erros
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Não encontrei o indice na lista");
}
catch (MinhaException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.QuandoAconteceu.ToString("dd/MM/yyyy HH:mm:ss"));
    Console.WriteLine("Falha ao cadastrar -> exceção Customizada");
}
catch (Exception ex) // A Exception vem sempre por ultimo, pois todas as exception depende delas
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Ops, algo deu errado!");
}

// Disparando exeções
static void Cadastrar(string texto)
{
    if (string.IsNullOrEmpty(texto))
    {
        throw new ArgumentException("O texto não pode ser nulo ou vazio");
    }
}
void ErroAgora()
{
    throw new MinhaException(DateTime.Now);
}
