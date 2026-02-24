namespace ControleDeGastos.Models
{
    public class Despesas
    {
        public int DespesasId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public bool Pago { get; set; }
        public int CategoriaId { get; set; }
        public int FormasPagamentoId { get; set; }
        
    }
}