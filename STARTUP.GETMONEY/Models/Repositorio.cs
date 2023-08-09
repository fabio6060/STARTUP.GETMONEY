
namespace GETMONEY.Models
{
    public static class Repositorio
    {
       
        private static List<Despesa> despesas = new List<Despesa>();
        private static List<ContaBancaria> contaBancarias = new List<ContaBancaria>();

        //Ações Contas Bancarias
        public static List<ContaBancaria> ContasBancarias
        {
            get { return contaBancarias; }
        }

        public static void AdicionarContaBancaria(ContaBancaria novacontaBancaria)
        {
            contaBancarias.Add(novacontaBancaria);
        }

        public static void RemoverContasBancarias() { 
            contaBancarias.Clear(); 
        }


        //Ações Despesas
        public static List<Despesa> Despesas { 
            get { return despesas; } 
        }

       public static void AdicionarDespesa(Despesa novaDespesa)
        {
            despesas.Add(novaDespesa);
        }

        public static void RemoverDespesas()
        {
            despesas.Clear();
        }



    }
}
