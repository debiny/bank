using bank.Employees;
using bank.Sistemas;
using System;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
   
        }

        public static void SystemInternal()
        {
            SystemInternal systemInternal = new SystemInternal();
            Director director = new Director("22211212121");

            director.Name = "Teste";
            director.password = "1234546";

            Manager manager = new Manager("22211212121");

            manager.Name = "Teste manager";
            manager.password = "12345777";
        }

        public static void aula1()
        {
            ContaCorrente cc = new ContaCorrente();
            cc.titular = "Jhonny";
            cc.agencia = 1234;
            cc.conta = 37163;
            cc.saldo = 500;

            ContaCorrente cc2 = new ContaCorrente();
            cc2.titular = "Debiny";
            cc2.agencia = 4321;
            cc2.conta = 18372;
            cc2.saldo = 800;


            Console.WriteLine("Nome do titular da primeira conta: " + cc.titular);
            Console.WriteLine("Número da agência: " + cc.agencia);
            Console.WriteLine("Número da conta: " + cc.conta);
            Console.WriteLine("Saldo da conta é: " + cc.saldo);

            Console.WriteLine("Nome do titular da segunda conta: " + cc2.titular);
            Console.WriteLine("Número da agência: " + cc2.agencia);
            Console.WriteLine("Número da conta: " + cc2.conta);
            Console.WriteLine("Saldo da conta é: " + cc2.saldo);

        }
    }
}
