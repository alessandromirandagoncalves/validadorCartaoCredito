using ValidatorCard;

Console.Write("Número cartão: ");
var input = Console.ReadLine() ?? string.Empty;
var valid = CreditCardValidator.Validate(input, out var issuer);
Console.WriteLine($"Válido: {valid} | Emissor: {issuer}");
