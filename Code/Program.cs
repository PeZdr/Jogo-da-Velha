using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class Program
    {
        static string j1 = "o", j2 = "o", jAtual, msg="";
        static char c1 = '1', c2 = '2', c3 = '3', c4 = '4', c5 = '5', c6 = '6', c7 = '7', c8 = '8', c9 = '9';
        static bool endGame = false, verificaRespostaVar = false;
        static int resposta, count = 0;
        static void Main(string[] args)
        {
            JogoInicio();
        }
        static void JogoInicio()
        {
            InputJogadores();
            while(endGame != true)
            {
                //Jogada 1
                jAtual = j1;
                
                while (verificaRespostaVar != true)
                {
                    DesignJogo();
                    resposta = Resposta(jAtual);
                    verificaRespostaVar = VerificaResposta(resposta, jAtual);
                    Console.Clear();
                }
                count++;
                verificaRespostaVar = false;
                endGame = VerificaVencedor();
                if (endGame)
                {
                    msg = $"Parabéns{jAtual}, você venceu!";
                }
                Console.Clear();
                if (endGame)
                {
                    break;
                }
                if (count == 9 && endGame != true)
                {
                    msg = "O jogo terminou em empate!";
                    break;
                }

                //Jogada 2
                jAtual = j2;
                while (verificaRespostaVar != true)
                {
                    DesignJogo();
                    resposta = Resposta(jAtual);
                    verificaRespostaVar = VerificaResposta(resposta, jAtual);
                    Console.Clear();
                }
                count++;
                verificaRespostaVar = false;
                endGame = VerificaVencedor();
                if (endGame)
                {
                    msg = $"Parabéns {jAtual}, você venceu!";
                }
                Console.Clear();
                
            }
            DesignJogo();
            Console.WriteLine(msg);
            
        }
        static void InputJogadores()
        {
            do
            {
                j1 = InputJogador();
                j2 = InputJogador();
                Console.Clear();
                if (j1 == j2)
                {
                    Console.WriteLine("Inválido, os nicknames são iguais.");
                    Console.WriteLine("Pressione uma tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (j1 == j2);

        }
        static string InputJogador()
        {
            Console.Write("Informe um nickname para o jogador: ");
            return Console.ReadLine();
        }
        static void DesignJogo() 
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {c1}  |  {c2}  |  {c3}  ");
            Console.WriteLine("- - -|- - -|- - -");
            Console.WriteLine($"  {c4}  |  {c5}  |  {c6}  ");
            Console.WriteLine("- - -|- - -|- - -");
            Console.WriteLine($"  {c7}  |  {c8}  |  {c9}  ");
            Console.WriteLine("     |     |     ");
        }
        static int Resposta(string jAtual)
        {
            if (jAtual == j1)
            {
                Console.Write($"Escolha uma casa para marcar {jAtual} (X): ");
                return Convert.ToInt16(Console.ReadLine());
            }
            else
            {
                Console.Write($"Escolha uma casa para marcar {jAtual} (O): ");
                return Convert.ToInt16(Console.ReadLine());
            }
            
        }
        static bool VerificaResposta(int resposta, string jAtual)
        {
            if(jAtual == j1)
            {
                if (resposta == 1 && c1 == '1')
                {
                    c1 = 'X';
                    return true;
                }
                else if (resposta == 2 && c2 == '2')
                {
                    c2 = 'X';
                    return true;
                }
                else if (resposta == 3 && c3 == '3')
                {
                    c3 = 'X';
                    return true;
                }
                else if (resposta == 4 && c4 == '4')
                {
                    c4 = 'X';
                    return true;
                }
                else if (resposta == 5 && c5 == '5')
                {
                    c5 = 'X';
                    return true;
                }
                else if (resposta == 6 && c6 == '6')
                {
                    c6 = 'X';
                    return true;
                }
                else if (resposta == 7 && c7 == '7')
                {
                    c7 = 'X';
                    return true;
                }
                else if (resposta == 8 && c8 == '8')
                {
                    c8 = 'X';
                    return true;
                }
                else if (resposta == 9 && c9 == '9')
                {
                    c9 = 'X';
                    return true;
                }
            }
            else
            {
                if (resposta == 1 && c1 == '1')
                {
                    c1 = 'O';
                    return true;
                }
                else if (resposta == 2 && c2 == '2')
                {
                    c2 = 'O';
                    return true;
                }
                else if (resposta == 3 && c3 == '3')
                {
                    c3 = 'O';
                    return true;
                }
                else if (resposta == 4 && c4 == '4')
                {
                    c4 = 'O';
                    return true;
                }
                else if (resposta == 5 && c5 == '5')
                {
                    c5 = 'O';
                    return true;
                }
                else if (resposta == 6 && c6 == '6')
                {
                    c6 = 'O';
                    return true;
                }
                else if (resposta == 7 && c7 == '7')
                {
                    c7 = 'O';
                    return true;
                }
                else if (resposta == 8 && c8 == '8')
                {
                    c8 = 'O';
                    return true;
                }
                else if (resposta == 9 && c9 == '9')
                {
                    c9 = 'O';
                    return true;
                }
            }
            return false;
           
        }
        static bool VerificaVencedor()
        {
            if (c1 == c2 && c2 == c3)
            {
                return true;
            }
            else if (c4 == c5 && c5 == c6)
            {
                return true;
            }
            else if (c7 == c8 && c8 == c9)
            {
                return true;
            }
            else if (c1 == c4 && c4 == c7)
            {
                return true;
            }
            else if (c2 == c5 && c5 == c8)
            {
                return true;
            }
            else if (c3 == c6 && c6 == c9)
            {
                return true;
            }
            else if (c1 == c5 && c5 == c9)
            {
                return true;
            }
            else if (c7 == c5 && c5 == c3)
            {
                return true;
            }

            return false;
        }
    }
}
