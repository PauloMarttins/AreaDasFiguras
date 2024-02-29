using System;
using AreaDasFiguras.Entities;
using AreaDasFiguras.Entities.Enums;
using System.Globalization;

namespace AreaDasFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia-se o ArrayList utilizando a variavel listShapes.
            List<Shape> listShapes = new List<Shape>();

            //O Console irá escrever um texto informando para o usurário que ele deverá informar a quantidade de corpos geometricos que serão analisados.
            Console.Write("Enter the number of shape: ");
            //A variavel n do tipo inteiro irá alocar essa informaçao.
            int n = int.Parse(Console.ReadLine());

            //Condiçao
            //A variavel i do tipo inteiro recebe a posição inicial igual a 0.
            //Enquanto a posição contida em i for menor que o valor total de objetos informado pelo usuario no inicio do programa,
            //O loop da operação continuará executando.
            //Através do (i++) cada vez que o loop conclui um ciclo, acrescenta-se mais uma posição à variavel i. 
            for (int i = 0; i < n; i++)
            {
                //Interpolação
                //O (i + 1) acrescenta uma posição a mais a variavel i.
                Console.WriteLine($"Shape #{i + 1} data: ");
                Console.Write("Rectangulo of circle (r/c)? ");
                
                //utiliza-se o metodo ( .ToUpper() ) após o ( Console.ReadLine() ) para que o caractere enviado pelo usuario seja convertido para caixa alta, com o fito de evitar erros.
                char ch = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Color (Black, Blue, Red): ");
                //utiliza-se o metodo ( .ToUpper() ) após o ( Console.ReadLine() ) para que o texto enviado pelo usuario seja convertido para caixa alta, com o fito de evitar erros.
                Color color = Enum.Parse<Color>(Console.ReadLine().ToUpper());

                //Ao utilizar o metodo ToUpper, passa a nao ser mais necessario criar uma condição que reconheça termos minusculos e maiusculos. 
                //tendo em vista que todos os termos serão convertidos automaticamento para maiusculo.
                //Entretanto, pra fins educativos. manterei as duas formas de solucionar tal problema.
                if (ch == 'r' || ch == 'R')
                {
                    //largura
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Altura
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Comando para adcionar os valores das variaveis no ArrayList denominado (ListShapes).
                    //As variaveis são informadas como parametro.
                    listShapes.Add(new Rectangle(width, height, color));
                }
                //Cria-se uma nova condição para o caso da resposta ser não.
                //Também nao seria necessario, mas a fim de fazer uma tratativa caso o usuario digite algum outro caractere que nao seja s/n, utilizamos o if mais uma vez.
                if (ch == 'n' || ch == 'N')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    // os valores recebidos pela variavel radius tambem será alocada no ArrayList denominado (ListShapes).
                    // que recebe como parametro o radius e color.
                    listShapes.Add(new Circle(radius, color));
                }
                //O else neste caso está funcionando como uma tratativa caso o usuario digite algum outro caractere que nao seja s/n.
                else
                {
                    Console.WriteLine("INVALID CARACTERE");
                } 

            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");

            //Para cada corpo geometrico alocado no ArrayList (ListShapes) faça:
            foreach (Shape shape in listShapes)
            {
                //O console irá escrever o valor referente a area do corpo geometrico utilizando ponto para separar as casas decimais ao invés da virgula.
                //"Fn" indica quantas casas deverão aparecer após a virgula. Ou seja, refere-se às casas decimais.
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}



