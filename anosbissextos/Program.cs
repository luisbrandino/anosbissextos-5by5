using anosbissextos;
int inputInteger(string message, int? min = null, int? max = null)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());

    while (true)
    {
        bool correctValue = (min != null ? value >= min : true) && (max != null ? value <= max : true);

        if (correctValue)
            break;

        string invalid = min != null ? $"Valor precisa ser maior ou igual a {min}" : "";
        invalid += invalid == "" ? "Valor precisa ser " : max != null ? " e " : "";
        invalid += max != null ? $"menor ou igual a {max}" : "";
        invalid += ": ";

        Console.Write(invalid);
        value = int.Parse(Console.ReadLine());
    }

    return value;
}

void waitForAnyKey()
{
    Console.WriteLine("\nPressione qualquer tecla para continuar.");
    Console.ReadKey();
}

Person createPerson()
{
    Console.Write("Digite o nome: ");
    string name = Console.ReadLine();

    Console.Write("Digite a profissão: ");
    string profession = Console.ReadLine();

    int age = inputInteger("Digite a idade: ", min: 0);

    return new Person(name, profession, age);
}

while (true)
{
    Console.Clear();
    Console.WriteLine("[ 1 ] Criar nova pessoa\n[ 0 ] Sair");
    int option = inputInteger("Sua opção: ", min: 0, max: 1);

    if (option == 0)
        break;

    Console.Clear();
    Person person = createPerson();

    Console.WriteLine(person);
    Console.WriteLine($"Idade em anos bissextos: {person.GetAgeInLeapYears()}");

    waitForAnyKey();
}