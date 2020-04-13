using udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Repository;
using udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Enumeradores;
using udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Domain;
using System.Collections;
using System.Collections.Generic;

namespace udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Controler
{
    class ProdutoControler
    {
        public enum enumtipoOperacao 
        {
            cadastro = 1,
            consulta = 2
        }

        public enumtipoOperacao Operacao { get; set; }
        public List<Produto> ListaProduto { get; set; }

        public ProdutoControler()
        {
            
        }

                              
        public void DefineOperacao()
        {
            System.Console.WriteLine("OPERAÇÃO: Cadastro[1]/Consulta[2]");
            Operacao = (enumtipoOperacao)int.Parse(System.Console.ReadLine());

        }


        public int NumeroProdutosCadastrados()
        {
            System.Console.WriteLine("Informe o número de produtos para cadastro: ");
            return int.Parse(System.Console.ReadLine());
        }


        public void executaOperacao()
        {
            if (Operacao.Equals(enumtipoOperacao.cadastro))
            {
                CadastraListaProdutos();
                ImpressaoLista();
            }
            else
            {
                ImpressaoLista();
            }

        }

        public void ImpressaoLista()
        {
            foreach (Produto obj in ListaProduto)
            {
                obj.ImpressaoEtiqueta();
                System.Console.WriteLine();
            }
        }

        public void CadastraListaProdutos()
        {
            System.Console.WriteLine("Nome do produto: ");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Preço:");
            double preco = double.Parse(System.Console.ReadLine());
            AdicionaItensParaLista(name, preco);

        }

        private void AdicionaItensParaLista(string name, double preco)
        {
            System.Console.WriteLine("Tipo Produto:[1-comum/2-importado/3-usado]: ");
            EnumTipoProduto tipo = (EnumTipoProduto)int.Parse(System.Console.ReadLine());

            switch (tipo)
            {
                case EnumTipoProduto.Comum:
                    InstaciaProdutoComum(name, preco);
                    break;
                case EnumTipoProduto.Importado:
                    InstaciaProdutoImportado(name, preco);
                    break;
                case EnumTipoProduto.Usado:
                    InstaciaProdutoUsado(name, preco);
                    break;
                default:
                    System.Console.Clear();
                    System.Console.WriteLine("Tipo incorreto");
                    System.Console.WriteLine("");
                    AdicionaItensParaLista(name, preco);
                    break;
            }
        }

        public void InstaciaProdutoComum(string nome, double preco)
        {
            ListaProduto.Add(new Produto(nome, preco, EnumTipoProduto.Comum));
        }

        public void InstaciaProdutoImportado(string nome, double preco)
        {
            System.Console.WriteLine("Taxa Alfandega:");
            double taxa = double.Parse(System.Console.ReadLine());
            ListaProduto.Add(new ProdutoImportado(nome, preco, EnumTipoProduto.Comum,taxa));
        }
        public void InstaciaProdutoUsado(string nome, double preco)
        {
            System.Console.WriteLine("Data Fabricação: ");
            System.DateTime dataFabricacao = System.DateTime.Now;
            
            ListaProduto.Add(new ProdutoUsado(nome, preco, EnumTipoProduto.Comum, dataFabricacao));
        }




    }
}
