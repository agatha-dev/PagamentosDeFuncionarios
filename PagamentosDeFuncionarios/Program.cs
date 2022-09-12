using PagamentosDeFuncionarios.Entities;
using System.Globalization;

Console.WriteLine("Digite o número de funcionários:");
int nFuncionarios = int.Parse(Console.ReadLine());
List<Funcionarios> lista = new List<Funcionarios>();

for (int i = 0; i < nFuncionarios; i++)
{
    Console.WriteLine($"Dados do funcionário #{i}:");

    Console.Write("Tercerizados S/N ?");
    char valorSorN = char.Parse(Console.ReadLine());

    if (valorSorN == 'S')
    {
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Horas Trabalhadas: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine());

        Console.WriteLine("Valor das horas trabalhadas: ");
        double valorDasHorasTrabalhadas = double.Parse(Console.ReadLine());

        Console.WriteLine("Cobranca adicional: ");
        double cobrancaAdicional = double.Parse(Console.ReadLine());

        lista.Add(new Tercerizados(nome, horasTrabalhadas, valorDasHorasTrabalhadas, cobrancaAdicional));
    }
    else if (valorSorN == 'N')
    {
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Horas Trabalhadas: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine());

        Console.WriteLine("Valor das horas trabalhadas: ");
        double valorDasHorasTrabalhadas = double.Parse(Console.ReadLine());

        lista.Add(new Funcionarios(nome, horasTrabalhadas, valorDasHorasTrabalhadas));

    }

    Console.WriteLine("");
    Console.WriteLine("Pagamentos na lista: ");

    foreach (Funcionarios funcionarios in lista)
    {
        Console.WriteLine(funcionarios.Nome + " - $ " + funcionarios.Pagamento().ToString("F2", CultureInfo.InvariantCulture));

    }

}



