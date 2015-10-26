using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormasGeometricas
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            Console.WriteLine("Para calcular area e perimetro escolha uma opção abaixo:");
            Console.Write("01-Triangulo \n02-Quadrado \n03-Retangulo \n04-Circulo");
            Console.WriteLine("\n05-Losango \n06-Paralelogramo \n07-Trapézio");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case (int)EnumFormasGeometricas.Triangulo:
                    {
                        Triangulo tri = new Triangulo();

                        Console.WriteLine("Informe o tamanho do lado do triangulo:");
                        tri.Lado = decimal.Parse(Console.ReadLine());

                        tri.Area = tri.CalcularArea(tri.Lado);
                        tri.Perimetro = tri.CalcularPerimetro(tri.Lado);

                        Console.WriteLine("\nA área do triangulo é: " + tri.Area);
                        Console.WriteLine("O perímetro do triangulo é: " + tri.Perimetro);
                        break;
                    }
                case (int)EnumFormasGeometricas.Quadrado:
                    {
                        Quadrado quadr = new Quadrado();

                        Console.WriteLine("Informe o tamanho do lado do quadrado:");
                        quadr.Lado = decimal.Parse(Console.ReadLine());

                        quadr.Area = quadr.CalcularArea(quadr.Lado);
                        quadr.Perimetro = quadr.CalcularPerimetro(quadr.Lado);

                        Console.WriteLine("A área do quadrado é:" + quadr.Area);
                        Console.WriteLine("O perímetro do quadrado é:" + quadr.Perimetro);
                        break;
                    }
                case (int)EnumFormasGeometricas.Retangulo:
                    {
                        Retangulo ret = new Retangulo();

                        Console.WriteLine("Informe o tamanho do lado 01 do retangulo:");
                        ret.Lado1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o tamanho do lado 02 do retangulo:");
                        ret.Lado2 = decimal.Parse(Console.ReadLine());

                        ret.Area = ret.CalcularArea(ret.Lado1, ret.Lado2);
                        ret.Perimetro = ret.CalcularPerimetro(ret.Lado1, ret.Lado2);

                        Console.WriteLine("A área do retangulo é:" + ret.Area);
                        Console.WriteLine("O perímetro do retangulo é:" + ret.Perimetro);
                        break;
                    }
                case (int)EnumFormasGeometricas.Circulo:
                    {
                        Circulo circ = new Circulo();

                        Console.WriteLine("Informe o tamanho do raio do circulo:");
                        circ.Raio = decimal.Parse(Console.ReadLine());

                        circ.Area = circ.CalcularArea(circ.Raio);
                        circ.Perimetro = circ.CalcularPerimetro(circ.Raio);

                        Console.WriteLine("A área do circulo é:" + circ.Area);
                        Console.WriteLine("O perímetro do circulo é:" + circ.Perimetro);
                        break;
                    }
                case (int)EnumFormasGeometricas.Losango:
                    {
                        Losango los = new Losango();

                        Console.WriteLine("Informe o tamanho do lado 01 do losango:");
                        los.Lado1 = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o tamanho do lado 02 do losango:");
                        los.Lado2 = decimal.Parse(Console.ReadLine());

                        los.Area = los.CalcularArea(los.Lado1, los.Lado2);
                        los.Perimetro = los.CalcularPerimetro(los.Lado1, los.Lado2);

                        Console.WriteLine("A área do losango é:" + los.Area);
                        Console.WriteLine("O perímetro do losango é:" + los.Perimetro);
                        break;
                    }
                case (int)EnumFormasGeometricas.Paralelogramo:
                    {
                        Paralelogramo parale = new Paralelogramo();

                        Console.WriteLine("Informe o tamanho do lado 01 do Paralelogramo:");
                        parale.Lado1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o tamanho do lado 02 do Paralelogramo:");
                        parale.Lado2 = decimal.Parse(Console.ReadLine());

                        parale.Area = parale.CalcularArea(parale.Lado1, parale.Lado2);
                        parale.Perimetro = parale.CalcularPerimetro(parale.Lado1, parale.Lado2);

                        Console.WriteLine("A área do Paralelogramo é:" + parale.Area);
                        Console.WriteLine("O perímetro do Paralelogramo é:" + parale.Perimetro);
                        break;
                    }
                case (int)EnumFormasGeometricas.Trapézio:
                    {
                        Trapezio tra = new Trapezio();

                        Console.WriteLine("Informe o tamanho da Base Maior do Trapézio:");
                        tra.BaseMaior = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o tamanho da Base Menor do Trapézio:");
                        tra.BaseMenor = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o tamanho da Altura do Trapézio:");
                        tra.Altura = decimal.Parse(Console.ReadLine());

                        tra.Area = tra.CalcularArea(tra.BaseMaior, tra.BaseMenor, tra.Altura);
                        tra.Perimetro = tra.CalcularPerimetro(tra.BaseMaior, tra.BaseMenor, tra.Altura);

                        Console.WriteLine("A área do Paralelogramo é:" + tra.Area);
                        Console.WriteLine("O perímetro do Paralelogramo é:" + tra.Perimetro);
                        break;
                    }
                default:
                    Console.WriteLine("A opção é invalida !");
                    break;
            }
            Console.ReadKey();
        }
    }
}
