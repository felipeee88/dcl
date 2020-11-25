namespace TesteFelipeValenteFrancisco.Models
{
    public class ContaTelefoneViewModel
    {
        public decimal ValorMinuto { get; set; }
        public int DuracaoChamadaSegundos { get; set; }
        public decimal ValorChamada { get; set; }

        public void CalcularValorChamada()
        {
            this.ValorChamada = this.ValorMinuto;

            if (this.DuracaoChamadaSegundos > 60)
            {
                this.DuracaoChamadaSegundos -= 60;

                var restoDivisao = this.DuracaoChamadaSegundos % 6;

                var quantidadePulsos = (restoDivisao > 0) ? 1 : 0;

                this.DuracaoChamadaSegundos -= restoDivisao;

                quantidadePulsos += this.DuracaoChamadaSegundos / 6;

                var valorPulso = this.ValorMinuto / 10;

                this.ValorChamada += (quantidadePulsos * valorPulso);
            }

            this.ValorChamada /= 100;
        }
    }
}
