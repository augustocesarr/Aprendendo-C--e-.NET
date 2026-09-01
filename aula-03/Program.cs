namespace aula03;

public class Program
{
    public static void Main()
    {
        // Limpando o terminal
        Console.Clear();

        // Aprendedo sobre input, output e condicionais
        Console.WriteLine("-----------Cadastro-----------");
        
        //Solicitando os dados
        Console.WriteLine("Informe seu nome: ");
        string Nome = Console.ReadLine();

        Console.WriteLine("Digite seu login: ");
        string Login = Console.ReadLine();

        Console.WriteLine("Digite sua senha: ");
        string Senha = Console.ReadLine();    

        Console.Clear();

        Console.WriteLine($"Confirme seus dados\n------------------------- \nNome : {Nome} \nLogin: {Login} \nSenha: {Senha} \n-------------------------");

        Console.WriteLine("As informações estão corretas S/N: ");
        string Confirmacao = Console.ReadLine().ToUpper();
        
        // Não foi feito nenhum laço de repetição, pois o intuito é ver sobre as condicionais
        // Verificando se os dados estão certos
        if (Confirmacao == "N")
        {
            Main();
        }
        else if (Confirmacao == "S")
        {
            Console.WriteLine($"Cadastro Realizado. \nBem-vindo {Nome}");
        }
        else
        {
            Console.WriteLine($"O comando ({Confirmacao}) não foi encontrado, tente fazer o cadastro novamente");
        }
    }
}