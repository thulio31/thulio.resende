
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace sistema
{
    internal class Trabalho
    {
        public int linhas = 0;
        public string[,] BancoDados = new string[1, 11];
        //0- Nome da pessoa
        //1- Idade
        //2- Peso


        public void ExibirMenu()//metodo
        {
            Console.WriteLine("Seja bem vindo ao sistema");
            Console.WriteLine("1-cadastro");
            Console.WriteLine("2-Visualizar");
            Console.WriteLine("3-Editar");
            Console.WriteLine("4-Excluir");
            Console.WriteLine("0-Sair do programa");
            Console.WriteLine("Digite qual ação deseja realizar");
        }

        public void cadastrar()//metodo
        {
            bool sucess = false;


            if (linhas > 0)
            {
                BancoDados = AdicionarNovaLinhaMatriz();
            }

            Console.Write("Nome: ");
            BancoDados[linhas, 0] = Console.ReadLine();

            while (sucess != true)
            {
                Console.WriteLine("Digite sua altura");

                double altura = 0;

                sucess = double.TryParse(Console.ReadLine(), out altura);

                if (sucess == true)
                {
                    BancoDados[linhas, 1] = altura.ToString();
                }
                else
                {
                    Console.WriteLine("Digite uma altura valida");
                }

            }

            sucess = false;

            while (sucess != true)
            {
                Console.WriteLine("Digite seu Peso");

                int idade = 0;

                sucess = int.TryParse(Console.ReadLine(), out idade);

                if (sucess == true)
                {
                    BancoDados[linhas, 2] = idade.ToString();
                }
                else
                {
                    Console.WriteLine("Digite um Peso valido");
                }

            }

            //cadastro idade
            sucess = false;

            while (sucess != true)
            {
                Console.WriteLine("Digite sua idade");

                int idade = 0;

                sucess = int.TryParse(Console.ReadLine(), out idade);

                if (sucess == true)
                {
                    BancoDados[linhas, 3] = idade.ToString();
                }
                else
                {
                    Console.WriteLine("Digite uma idade valida");
                }

            }
            //fim cadastro idade


            sucess = false;

            while (sucess != true)
            {
                Console.WriteLine("Horario do treino");

                int horariotreino = 0;

                sucess = int.TryParse(Console.ReadLine(), out horariotreino);

                if (sucess == true)
                {
                    BancoDados[linhas, 4] = horariotreino.ToString();
                }
                else
                {
                    Console.WriteLine("Digite um horario valido");
                }

            }

            sucess = false;

            while (sucess != true)
            {
                Console.Write("Ficha de treino: ");

                string digitadoPeloUsuario = Console.ReadLine();

                if (Regex.IsMatch(digitadoPeloUsuario, @"^[a-zA-Z]+$"))
                {
                    BancoDados[linhas, 5] = digitadoPeloUsuario;
                    sucess = true;
                }
                else
                {
                    Console.WriteLine("Ficha de treino não possui números");
                }
            }

            sucess = false;

            while (sucess != true)
            {
                Console.WriteLine("Intervalo (em minutos): ");

                int intervalo = 0;

                sucess = int.TryParse(Console.ReadLine(), out intervalo);

                if (sucess == true)
                {
                    BancoDados[linhas, 6] = intervalo.ToString();
                }
                else
                {
                    Console.WriteLine("digite um intervalo valido");
                }

            }

            sucess = false;

            while (sucess != true)
            {
                Console.WriteLine("Número de séries: ");

                int intervalo = 0;

                sucess = int.TryParse(Console.ReadLine(), out intervalo);

                if (sucess == true)
                {
                    BancoDados[linhas, 7] = intervalo.ToString();
                }
                else
                {
                    Console.WriteLine("Número de series nao contem letras");
                }

            }

            sucess = false;

            while (sucess != true)
            {
                Console.WriteLine("Número de repetições por série: ");

                int intervalo = 0;

                sucess = int.TryParse(Console.ReadLine(), out intervalo);

                if (sucess == true)
                {
                    BancoDados[linhas, 8] = intervalo.ToString();
                }
                else
                {
                    Console.WriteLine("Número de repetições por series nao contem letras");
                }

            }

            Console.Write("Endereço: ");
            BancoDados[linhas, 9] = (Console.ReadLine());

            Console.Write("Cpf: ");
            BancoDados[linhas, 10] = (Console.ReadLine());


            linhas++;

        }

        public void Visualizar(int registroId = -1)//metodo
        {
            for (int l = 0; l < linhas; l++)
            {
                if (BancoDados.GetLength(0) > 0)
                {
                    if (registroId == -1 || l == registroId)
                    {
                        Console.WriteLine("------------------Visualização dos Dados cadastrais------------------");
                        Console.WriteLine($"id:{l}");
                        Console.WriteLine($"Nome:{BancoDados[l, 0]}");
                        Console.WriteLine($"Alturae:{BancoDados[l, 1]}");
                        Console.WriteLine($"Peso:{BancoDados[l, 2]}");
                        Console.WriteLine($"Idade:{BancoDados[l, 3]}");
                        Console.WriteLine($"Horario do treino:{BancoDados[l, 4]}");
                        Console.WriteLine($"Ficha de treino:{BancoDados[l, 5]}");
                        Console.WriteLine($"Intervalo:{BancoDados[l, 6]}");
                        Console.WriteLine($"Número de series:{BancoDados[l, 7]}");
                        Console.WriteLine($"Número de repetições:{BancoDados[l, 8]}");
                        Console.WriteLine($"Endereço:{BancoDados[l, 9]}");
                        Console.WriteLine($"Cpf:{BancoDados[l, 10]}");
                        Console.WriteLine("------------------------------------------------------------------------");
                    }

                }
            }
        }

        public void Editar()//metodo
        {

            Visualizar();

            Console.WriteLine("Digite o numero do registro que deseja alterar");
            int registroID = int.Parse(Console.ReadLine());

            Visualizar(registroID);

            Console.WriteLine("Digite o número do campo que deseja Alterar no campo?");
            Console.WriteLine("0-Nome");
            Console.WriteLine("1-Altura");
            Console.WriteLine("2-Peso");
            Console.WriteLine("3-Idade");
            Console.WriteLine("4-Horario do treino");
            Console.WriteLine("5-Ficha de treino");
            Console.WriteLine("6-Intervalo");
            Console.WriteLine("7-Número de series");
            Console.WriteLine("8-Número de repetições por serie");
            Console.WriteLine("9-Endereço");
            Console.WriteLine("10-CPF");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual valor Deseja colocar no campo?");
            string campo = Console.ReadLine();
            BancoDados[registroID, opcao] = campo;
        }
        public void Excluir()//metodo
        {
            Visualizar();

            Console.WriteLine("Digite o ID do registro que deseja excluir");
            int registroID = int.Parse(Console.ReadLine());

            BancoDados = RemoverLinhaMatriz(registroID);
        }

        public string[,] AdicionarNovaLinhaMatriz()
        {
            int linha = BancoDados.GetLength(0);
            int coluna = BancoDados.GetLength(1);

            string[,] bancoDadosAux = new string[linha + 1, coluna];

            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    bancoDadosAux[l, c] = BancoDados[l, c];
                }
            }

            return bancoDadosAux;
        }//Adicionar nova linha na matriz

        public string[,] RemoverLinhaMatriz(int linhaExcluir)
        {
            int linha = BancoDados.GetLength(0);
            int coluna = BancoDados.GetLength(1);

            string[,] bancoDadosAux = new string[linha - 1, coluna];

            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    if (l > linhaExcluir)
                    {
                        bancoDadosAux[l - 1, c] = BancoDados[l, c];
                    }
                    else if (linhaExcluir != l)
                    {
                        bancoDadosAux[l, c] = BancoDados[l, c];
                    }
                }
            }
            linhas = linhas - 1;
            return bancoDadosAux;
        }
    }
}