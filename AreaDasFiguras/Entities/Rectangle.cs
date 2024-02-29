using AreaDasFiguras.Entities;
using AreaDasFiguras.Entities.Enums;

namespace AreaDasFiguras.Entities
{
    //A classe Rectangle estende a classe Shape (Herança)
    internal class Rectangle : Shape
    {
        //Declara-se os atributos:
        //A propriedade Width(largura) é um atributo do tipo double.
        public double Width { get; set; }

        //A propriedade Height(Altura) é um atributo do tipo double.
        public double Height { get; set; }

        //O construtor Rectangle declara as variaveis width do tipo double, height do tipo double, e a variavel color do tipo Color. logo em seguida atraves da palavra chave base, o construtor recebe as informaçoes recebidas
        //pela variavel color que foi declarada na classe Color. (Herança)
        public Rectangle(double width, double height, Color color) : base(color)
        { 
            //As propriedades Width e Height recebem respectivamente as variaveis width e height.
            Width = width;
            Height = height;
        }

        //Nesse construtor atraves do modificador override, transcreve-se uma nova função para a propriedade denominada Area.
        //Area passa a conter a operação ( largura vezes altura).
        public override double Area()
        {
            return Width * Height;
        }
    }
}



