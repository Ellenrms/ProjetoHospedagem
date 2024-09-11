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
            // Verificar se a capacidade é maior ou igual ao número de hóspedes
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Lança uma exception caso a capacidade seja menor que o número de hóspedes
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Calcula o valor da diária
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Conceder desconto de 10% se o número de dias reservados for maior ou igual a 10
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10m;
            }

            return valor;
        }
    }
}
