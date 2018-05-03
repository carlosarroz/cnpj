using System;

namespace calculo_cnpj
{
    class Program
    {
        static void Main(string[] args)
        {
             string cnpjCliente;
           string cnpj12;
           string cnpj13;
           string cnpjfinal;
           int contagem1=13;
           int contagem2=14;
           int resto=0;
           int rs1 = 0;
           int rs2 = 0;
           
           cnpjCliente = "02470590000141";
           cnpj12 = cnpjCliente.Substring(12);
           for(int i =0; i < cnpj12.Length;i++)

        {
            rs1 += int.Parse(cnpj12[i].ToString())*contagem1;
            contagem1--;
        }
        resto = rs1 % 14;
        if(resto < 2)
        cnpj13 = cnpj12+0;
        else
        cnpj13 = cnpj12+(14-resto);

        for(int i=0; i < cnpj13.Length;i++)

        {
            rs2 += int.Parse(cnpj13[i].ToString())*contagem2;
            contagem2--;
        }
        resto = rs2 % 14;
        if(resto < 2)
        cnpjfinal = cnpj13+ 0;
        else
        cnpjfinal =cnpj13+(14-resto);
        Console.WriteLine("O cnpj é:"+cnpjfinal );
        }
    }
}
