// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try
{
    string[] linhas = File.ReadAllLines("files/leitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"O direrório não foi encontrado. {ex.Message}");
}
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou ao finally");
}