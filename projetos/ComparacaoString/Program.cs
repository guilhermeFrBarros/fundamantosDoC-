var texto = "Este texto é um Test";
// Retorna um inteiro => 0 se for exatemamente igual
Console.WriteLine(texto.CompareTo("Este texto é um Test")); // r: 0
Console.WriteLine(texto.CompareTo("Este texto é um test")); // r: 1
Console.WriteLine(texto.CompareTo("test123"));// r: -1

// Ve se contem a sequencia de caracteres dentro da string
Console.WriteLine(texto.Contains("test")); // r: False
Console.WriteLine(texto.Contains("Test")); // r: True
Console.WriteLine(texto.Contains("test", StringComparison.OrdinalIgnoreCase)); // r: True
