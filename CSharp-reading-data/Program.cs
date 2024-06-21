Console.WriteLine("Validando entrada de inteiros.");

string? readResult;
bool validEntry = false;

Console.WriteLine("Digite um número entre 5 e 10");

do
{

    readResult = Console.ReadLine();

    bool isValidNumber = false;
    int readResultParsed = 0;

    isValidNumber = int.TryParse(readResult, out readResultParsed);

    if (!isValidNumber)
    {
        Console.WriteLine("Digite um número valido entre 5 e 10. Tente novamente.");
        continue;
    }

    if (readResultParsed > 5 && readResultParsed < 10)
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine("Digite um número entre 5 e 10. Tente novamente.");
    }

} while (validEntry == false);

Console.WriteLine("=========================================");
