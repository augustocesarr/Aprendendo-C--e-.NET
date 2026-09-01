namespace aula02;

public class Program
{
    public static void Main()
    {
        // tipos de dados variável
        string Nome = "Augusto"; 
        int Numero = 10;
        double NumeroQuebrado = 20.32;
        char Caracter = 'a';
        bool Boolean = true;

        // constante não é alterada posteriormente
        const string Constante = "cos";

        //dynamic ele aceita varios tipos de dados, mas ele não mantém o dado passado
        dynamic Variavel = 32;

        // Apresentando os dados
        Console.WriteLine($"string: {Nome} \nint: {Numero} \ndouble: {NumeroQuebrado} \nchar: {Caracter} \nbool: {Boolean}");
        Console.WriteLine($"A seguir uma constante {Constante}");
        Console.WriteLine($"A seguir um dynamic {Variavel}");
    
    }
}
