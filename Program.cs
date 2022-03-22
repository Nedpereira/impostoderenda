using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
           double VD, INSS, RENDB, IR=0, RENDL;
            int ND;
            string NOME;

            Console.WriteLine("Digite seu nome:");
            NOME = Console.ReadLine();

            Console.WriteLine("Digite o rendimento anual bruto em R$:");
            RENDB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do desconto de Inss em R$:");
            INSS = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de dependentes (digite 0 caso não possua): ");
            ND = Convert.ToInt16(Console.ReadLine());

            VD = ND * 2156.52;

            RENDL = RENDB - (INSS + VD);

            if (RENDL <= 21453.24)
            {
                IR = 0;
               
            }
            else
            {
                if ((RENDL > 21453.24) && (RENDL <= 32151.48))
                {
                    IR = (RENDL*0.075)-1608.99;
                }
                    
                else
                {
                    if ((RENDL > 32151.48) && (RENDL <= 42869.16))
                    {
                        IR = (RENDL*0.15)- 4020.35;

                    }

                    else
                    {
                        if ((RENDL > 42869.16) && (RENDL <= 53565.72))
                        {
                            IR =(RENDL*0.225)- 7235.54;

                        }

                        else
                        {
                            IR = (RENDL *0.275)- 9913.83;
                        }
                    }
                }

                
            }

            Console.WriteLine("Nome: {0}\n Numero de dependentes: {1}\nInss:{2}\nSalario Bruto:{3}\nSalario Liquido:{4}\nValor a pagar ao Imposto de Renda:{5}", NOME, ND, INSS, RENDB, RENDL, IR);
            Console.ReadKey();
        }
    }
}
