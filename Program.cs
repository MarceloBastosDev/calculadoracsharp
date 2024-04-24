using System;

class Program
{
    static void Main()
    {
        string nome;
        int idade;
        double altura, peso, imc;
        string categoriaIMC, faixaEtaria;
        string continuar;

        do
        {
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine()!;

            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            // Cálculo do IMC
            imc = peso / (altura * altura);

            // Determinação da categoria de IMC
            
            if (imc < 18.5)
            {
                categoriaIMC = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                categoriaIMC = "Normal";
            }
            else if (imc < 30)
            {
                categoriaIMC = "Sobrepeso";
            }
            else
            {
                categoriaIMC = "Obeso";
            }

            // Determinação da faixa etária
            
            if (idade < 12)
            {
                faixaEtaria = "Criança";
            }
            else if (idade < 18)
            {
                faixaEtaria = "Adolescente";
            }
            else if (idade < 60)
            {
                faixaEtaria = "Adulto";
            }
            else
            {
                faixaEtaria = "Idoso";
            }

            // Relatório
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"IMC: {imc} - {categoriaIMC}");
            Console.WriteLine($"Faixa etária: {faixaEtaria}");

            Console.WriteLine("Deseja realizar uma nova consulta? (S/N)? ");
            continuar = Console.ReadLine()!.ToUpper(); // Convertendo para maiúsculas
        }
        while (continuar == "S");
    }
}
