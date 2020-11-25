using TesteFelipeValenteFrancisco.Enum;

namespace TesteFelipeValenteFrancisco.Models
{
    public class ComissaoViewModel
    {
        public int QuantidadeCarros { get; set; }
        public decimal ValorVendas { get; set; }
        public decimal SalarioFixo { get; set; }
        public decimal BonusVenda { get; set; }
        public decimal ComissaoVenda { get; set; }
        public decimal SalarioFinal { get; set; }

        public void CalculoSalario(eComissao comissao)
        {
            this.ComissaoVenda = (int)comissao / 100;

            this.SalarioFinal = this.ValorVendas * this.ComissaoVenda +
                                this.QuantidadeCarros * this.BonusVenda +
                                this.SalarioFixo;
        }
    }
}
