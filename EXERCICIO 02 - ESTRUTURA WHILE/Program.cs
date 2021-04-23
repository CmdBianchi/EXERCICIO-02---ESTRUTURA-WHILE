using System;
namespace EXERCICIO_02___ESTRUTURA_WHILE{
    class Program{
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("Determine qual o quadrante ao qual pertence o ponto.");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional(){
            Console.Write("DIGITE A COORDENADA X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("DIGITE A COORDENADA Y: ");
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0){
                Console.Write("DIGITE A COORDENADA X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("DIGITE A COORDENADA Y: ");
                y = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("VALOR NULO");
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
