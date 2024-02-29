using System;
using AreaDasFiguras.Entities.Enums;


namespace AreaDasFiguras.Entities
{
    //A classe Circle estende a classe Shape. ou seja, utiliza o metodo de herança.
    class Circle : Shape
    {
        //Declara-se a propriedade Radius do tipo double que alocará as informaçoes referente ao raio do circulo.
        public double Radius { get; set; }

        //Construtor Circle declara a variavel radius do tipo double e a variavel color do tipo Color como parametros. em seguida, atraves da palavra chave base, o construtor tem acesso as informaçoes alocas na variavel color da classe Color. 
        public Circle(double radius, Color color) : base(color)
        {
            //A propriedade Radius recebe os valores da variavel radius.
            Radius = radius;
        }

        //Esse construtor transcreve um novo sentido para a propriedade Area.
        //Em outras palavras, a propriedade Area recebe pi vezes raio ao quadrado.
        //qualquer comando que usar a palavra chave Area, irá naturalmente executar essa formula.
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

}
