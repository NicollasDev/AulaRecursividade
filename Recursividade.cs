using System;

namespace Aula25Recursividade
{
    public class Recursividade
    {
        
        //GerarSequenciaFibonacci( 0, 1, 15 )
        //GerarSequenciaFibonacci( 1, 1, 14 )
        //GerarSequenciaFibonacci( 1, 2, 13 )
        //GerarSequenciaFibonacci( 2, 3, 13 )
        public void GerarSequenciaFibonacci( int num1, int num2, int vezes ){


            // Condição crucial de parada de recurividade
            if(vezes >= 0){
                Console.WriteLine(num1);
                GerarSequenciaFibonacci(num2, num1 + num2, vezes - 1);
            }

        }

        // 5! = 5 x 4 x 3 x 2 x 1
           public int GerarFatorial(int numero){
               if(numero == 1){
                   return 1;
               }else{
                   return numero * GerarFatorial(numero - 1);
               }
           }
    }
}