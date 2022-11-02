using System;
using System.IO;
using System.Linq;

class DIO 
{

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        string[] v = new string[2];
        
        for (int i = 0; i < qt; ++i)
        {
          v = Console.ReadLine().Split(' ');
            string va = v[0];
            string vb = v[1];

            if (vb.Length > va.Length){
                Console.WriteLine("nao encaixa");
            }
            else if (va.EndsWith(vb)){
                Console.WriteLine("encaixa");
            }
            else
                Console.WriteLine("nao encaixa");

        }

    }

}