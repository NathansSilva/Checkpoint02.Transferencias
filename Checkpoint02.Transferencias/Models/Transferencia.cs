using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Checkpoint02.Transferencias.Models
{
    public class Transferencia
    {
        [HiddenInput]
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public decimal Valor { get; set; }
        public string? Origem { get; set; }
        public string? Destino { get; set; }
        public Posicao? Posicao { get; set; }
        [Display(Name = "Data da Venda")]
        public DateTime DataVenda { get; set; }
        [Display(Name = "Definitivo")]
        public bool Definitivo { get; set; }
    }
    public enum Posicao
    {
        Goleiro, Defesa, [Display(Name = "Meio Campo")] MeioCampo, Ataque
    }
}
