using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {    
                try{ //CAUSANDO UM PROBLEMA QUALQUER PARA PARAR O PROGRAMA
                   string[] linhas = File.ReadAllLines("problemagenerico.txt");
                    foreach(string linha in linhas){
                        Console.WriteLine(linha);
                    }
                }            
                catch (Exception semCapacidade)
                {
                    Console.WriteLine($"O numero de hospedes excede a capacidade do quarto: {semCapacidade.Message}");
                    throw;
                }
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes == null ? 0 : Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;
            
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            decimal desconto = 0.10M; 
            int minimoDiasParaDesconto = 10; 
           
            if (DiasReservados >= minimoDiasParaDesconto)
            {
                valor = valor - (valor * desconto);
            }

            return valor;
        }
    }
}