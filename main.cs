using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

       
        if (!string.IsNullOrWhiteSpace(frase))
        {
           
            string[] palavras = frase.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

           
            int quantidadePalavras = palavras.Length;

            
            Console.WriteLine($"A frase contém {quantidadePalavras} palavra(s).");
        }
        else
        {
            Console.WriteLine("A frase está vazia ou contém apenas espaços.");
        }
    }
}
