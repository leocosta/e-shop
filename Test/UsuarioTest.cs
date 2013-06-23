using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Core;
using Core.Produtos;

namespace Test
{

    [TestFixture]
    public class UsuarioTest
    {
        public UsuarioTest()
        { 

        }

        [TestFixtureSetUp]
        public void UsuarioSetUp()
        { 
            //
            // Centralizar aqui rotinas em comum que os testes necessitam antes de rodar
            //
        }

        // => Compras acima de 160, usuário tem 10% de desconto;
        [Test]
        public void Testa_Se_Compra_Acima_De_160_Usuario_Deve_Receber_10_Porcento_De_Desconto()
        {
            var usuario = new Usuario();

            var compra = new Compra();
            compra.AdicionarProduto(new Produto("Livro TDD", 90D, 900D));
            compra.AdicionarProduto(new Produto("Relógio", 120D, 70D));

            usuario.AdicionarCompra(compra);

            var valorCompra = usuario.RetornarCompras().First().ObterTotal();

            Assert.AreEqual(189D, valorCompra);
        }

        [Test]
        public void Testa_Se_Compra_Abaixo_De_160_Usuario_Nao_Deve_Receber_Desconto()
        {
            var usuario = new Usuario();

            var compra = new Compra();
            compra.AdicionarProduto(new Produto("Agenda", 20D, 200D));
            compra.AdicionarProduto(new Produto("Caneta", 2D, 10D));

            usuario.AdicionarCompra(compra);

            var valorCompra = usuario.RetornarCompras().First().ObterTotal();

            Assert.AreEqual(22D, valorCompra);
        }

        [Test]
        [Ignore("Teste ainda não implementado")]
        public void Testa_Se_Compra_Sem_Nenhum_Produto_Deve_Retornar_Zero_De_Desconto()
        {

        }

        /*
         * => Compras acima de 160, usuário tem 10 de desconto;
         * => Compras ainda sem nenhum produto, devem retornar zero de desconto;
         * => Usuários compradores pela terceira vez, ganham desconto
         *    de 20% caso o valor da compra seja maior que 250;
         * => Caso haja três produtos da mesma categoria em uma compra,
         *    conceder 5% de desconto em cima do produto mais caro entre esses três
         *    
         * => **Cálculo estimado de frete, de acordo com o somatório do
         *      peso dos produtos em uma compra
         */

    }

}
