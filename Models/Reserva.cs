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
            // Implementado: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Implementado: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                
                throw new Exception($"A capacidade da suíte, {Suite.Capacidade} lugar(es) não suporta o número solicitado de {hospedes.Count} hóspedes.");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado: Retorna a quantidade de hóspedes (propriedade Hospedes)
            
            int quantidadeDeHospedes = Hospedes.Count();
            return quantidadeDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;


            // Implementado: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            
            if (DiasReservados >= 10)
            {
                decimal valordoDesconto = valor - (valor * 0.9m); // Aplicando 10% de desconto ;
                valor = valor - valordoDesconto;
            }
            // Retorno do valor total
            return valor;
        }
    }
}