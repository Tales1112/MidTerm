using MidTerm;
using System.Text.Json;

var path = Path.Combine(@"C:\Users\user\source\", "midterm.txt");
string content = File.ReadAllText(path);

ErrorClass? errorClass = JsonSerializer.Deserialize<ErrorClass>(content);

Console.WriteLine($"Details: {errorClass?.Details}");
Console.WriteLine($"Message: {errorClass?.Message}");
var count = 1;
foreach (var erro in errorClass.ValidationErrors)
{   
    Console.WriteLine($"Erro #:{count}");
    Console.WriteLine($"Is Valid: {erro.IsValid}");
    Console.WriteLine($"Restriction Type: {erro.RestrictionType}");
    Console.WriteLine($"Rule Name: {erro.RuleName}");
    count ++;
}


