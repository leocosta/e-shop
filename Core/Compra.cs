using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Produtos;

namespace Core
{
    public class Compra
    {
        public Compra()
        {

        }


        #region Atributos

        private List<Produto> _produtos;

        #endregion

        #region Propriedades

        public Int32 ID { get; set; }
        public DateTime Data { get; set; }
        public Usuario Usuario { get; set; }
        public List<Produto> Produtos
        {
            get
            {
                if (_produtos == null)
                    _produtos = new List<Produto>();

                return _produtos;
            }

            set
            {
                _produtos = value;
            }
        }

        #endregion

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        private double retornarPrecoProduto(Produto produto)
        {
            return produto.Preco; 
        }

        /// <summary>
        /// Retorna o total a ser pago pela compra,
        /// já com os possíveis descontos adicionados
        /// </summary>
        /// <returns></returns>
        public double ObterTotal()
        {
            //
            // Caso não haja produtos, retorna total zero
            //
            if (!Produtos.Any())
                return 0D;

            //
            // Fazendo somatório do valor da Compra
            //
            var valorCompra = _produtos.Select(produto => produto.Preco).Sum();

            //
            // Valor a ser pago incialmente é o valor da Compra
            //
            var valorASerPago = valorCompra;

            //
            // Desconto de 10%
            //
            if (valorCompra > 160) 
            {
                var descontoDezPorcento = (valorCompra / 100) * 10;
                valorASerPago = valorCompra - descontoDezPorcento;
            }

            return valorASerPago;
        }

        public void RemoverProduto(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
