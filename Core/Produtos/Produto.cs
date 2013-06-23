using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Produtos
{
    public class Produto
    {
        #region Construtores

        public Produto()
        { }

        public Produto(String nome, Double preco, double peso)
        {
            this._nome = nome;
            this._preco = preco;
            this._peso = peso;
        }

        #endregion

        #region Atributos

        private String _nome;
        private Double _preco;
        private Double _peso;

        #endregion

        #region Propriedades

        public Int32 ID { get; set; }

        public String Nome { get; set; }

        public Double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        /// <summary>
        /// Peso do produto com notação em gramas
        /// </summary>
        public Double Peso { get; set; }

        public Categoria Categoria { get; set; }

        #endregion
    }
}
