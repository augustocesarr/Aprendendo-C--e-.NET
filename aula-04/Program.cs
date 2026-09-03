// aprendendo sobre operadores, laços de repetição, swith

namespace aula04;

public class Program
{
    public static void Main()
    {
        
        // Definindo a variavel para iniciar o while
        bool Cond = true;
        
        while (Cond)
        {
            Console.Clear();

            // Definindo Login e senha para calculadora
            string LoginUsuario = "usuario";
            string SenhaUsuario = "usuario123";

            Console.WriteLine("--------------Calculadora--------------");

            // Recebendo os Dados do usuario
            Console.WriteLine("Informe o login: ");
            string Login = Console.ReadLine();

            Console.WriteLine("Informe a senha: ");
            string Senha = Console.ReadLine();
            
            // Fazendo interação de Processando...
            for(int i = 0; i <= 3; i++)
            {
                Console.Clear();
                Console.WriteLine("Processando" + new string('.', i));
                Thread.Sleep(800);    
            }

            // Apagando o processando que fica no terminal
            Console.Clear();

            // Verificando se login e senha estão corretos
            if (Login == LoginUsuario && Senha == SenhaUsuario)
            {
                // Informando que o login foi realizado
                Console.WriteLine("Login realizado com sucesso!");
                Thread.Sleep(2000);
                Console.Clear();
    
                while (Cond)
                {
                    // Interação com o usuário mostrando as opções do sistema
                    Console.WriteLine("--------------Calculadora--------------");    
                    Console.WriteLine("1 - Adição \n2 - Subtração \n3 - Multiplicação \n4 - Divição \n5 - Resto da divisão\n0 - Sair");

                    // Recebendo a opção selecionada pelo usuário
                    Console.WriteLine("Informe a opção desejada: ");
                    int Opcao = Convert.ToInt16(Console.ReadLine());
                    
                    // Fazendo interação de Processando...
                    for(int c = 0; c <= 3; c++)
                    {
                        Console.Clear();
                        Console.WriteLine("Processando" + new string('.', c));
                        Thread.Sleep(800);
                    }
                    
                    // Apagando o processando que fica no terminal
                    Console.Clear();

                    // Verificando se Opcao é igual a 0, e altera a Cond para false para sair dos laços
                    if (Opcao == 0)
                    {
                        // Interação com o usuário agradecendo o usuário e ecerrando o programa
                        Console.Clear();
                        Console.WriteLine("Obrigado por ultilizar a nossa calculadora!");    
                        Thread.Sleep(2800);
                        Console.Clear();
                        Cond = false;
                    }

                    // Verificando se Opcao está entre as opções fornecidas
                    else if (Opcao <= 5)
                    {
                        
                        // Recebendo os números do usuário para realizar os calculos
                        Console.WriteLine("Digite o primeiro número: ");
                        double Numero1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número: ");
                        double Numero2  = Convert.ToDouble(Console.ReadLine());

                        // Definindo/Redefinindo a variável para fazer a conta dentro da case
                        double Resultado = 0.0;

                        Thread.Sleep(800);
                        Console.Clear();
                        
                        // fazendo a verificação da opção selecionada pelo usuário e realizando as contas e informando o resultado
                        switch (Opcao)
                        {
                            case 1:
                                Resultado = Numero1 + Numero2;
                                Console.WriteLine($"{Numero1} + {Numero2} = {Resultado}");
                                break;   
                            case 2:
                                Resultado = Numero1 - Numero2;
                                Console.WriteLine($"{Numero1} - {Numero2} = {Resultado}");
                                break;
                            case 3:
                                Resultado = Numero1 * Numero2;
                                Console.WriteLine($"{Numero1} x {Numero2} = {Resultado}");
                                break;
                            case 4:
                                Resultado = Numero1 / Numero2;
                                Console.WriteLine($"{Numero1} ÷ {Numero2} = {Resultado}");
                                break;
                            case 5:
                                Resultado = Numero1 % Numero2;
                                Console.WriteLine($"{Numero1} % {Numero2} = {Resultado}");
                                break;
                        }

                        // Interação para o terminal parar e o usuario consiga ver o resultado e consiga retornar ao fluxo a hora que quiser
                        Console.WriteLine("\n\nPrecione qualquer tecla para retorna ao menu");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Opção inválida, Tente novamente!");
                        Console.WriteLine("\n\nPrecione qualquer tecla para retorna ao menu");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }

            // Caso usuário ou senha incorretos, imprime que estão errados e volta ao loop de login
            else
            {
                Console.Clear();
                Console.WriteLine("Usuário ou senha incorretos, Tente novamente!");
                Console.WriteLine("\n\nPrecione qualquer tecla para retorna ao menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}