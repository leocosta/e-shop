using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Usuario
    {
        #region Construtores

        public Usuario()
        { }

        #endregion

        #region Atributos

        private Int32 _id;
        private String _nome;
        private List<Compra> _compras;

        #endregion


        #region Propriedades

        public Int32 ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public String Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }


        public List<Compra> Compras
        {
            get
            {
                if (_compras == null)
                    _compras = new List<Compra>();

                return _compras;

            }
            set
            {
                _compras = value;
            }
        }



        #endregion

        public void AdicionarCompra(Compra compra)
        {
            Compras.Add(compra);
        }

        public List<Compra> RetornarCompras()
        {
            return Compras;
        }
    }
}
