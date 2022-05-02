using System;

namespace sistema_que_diz_o_primeiro_e_ultimo_nome_do_usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string PrimeiroNome;
            string SegundoNome;
            string TerceiroNome;

            Console.WriteLine("Digite seu primeiro nome");
            PrimeiroNome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite seu segundo nome");
            SegundoNome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite seu terceiro nome");
            TerceiroNome = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Seu primeiro nome é: " + PrimeiroNome);
            Console.WriteLine("Seu ultimo nome é: " + TerceiroNome);

           
        }
    }
}
