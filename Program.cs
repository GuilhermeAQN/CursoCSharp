using System.Globalization;

class Program {
    static void Main(){
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;


        Console.WriteLine($"{produto1}, cuja o preço é $ {preco1}\n{produto2}, cuja o preço é $ {preco2}\n");
        
        Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero {genero}\n");

        Console.WriteLine($"Medida com oito casas decimais: {medida:F8}\nArredondado(três casas decimais): {medida:F3}");

        Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
    }
}
