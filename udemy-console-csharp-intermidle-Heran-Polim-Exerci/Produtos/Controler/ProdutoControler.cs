namespace udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Controler
{
    class ProdutoControler
    {
        public int NumeroProdutosCadastrados()
        {
            System.Console.WriteLine("Informe o número de produtos para cadastro: ");
            return int.Parse(System.Console.ReadLine());
        }

        

    }
}
