
using AreaDasFiguras.Entities.Enums;

namespace AreaDasFiguras.Entities
{
    abstract class Shape
    {
        //Declaração da propriedade(atributo) Color do tipo Color(objeto)
        public Color Color { get; set; }

        //Contrutor do objeto Shape que recebe como parametros a variavel color do tipo Color(objeto).
        public Shape(Color color)
        {
            //A propriedade Color recebe o valor da variavel color.
            Color = color;
        }

        //Para declarar esse construtor como abstrato, é obrigatorio declarar a classe inteira como abstrata.
        public abstract double Area();
    }
}
