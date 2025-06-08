using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Pedidos_Loja_virtual
{
    public class Produto
    {
        public int Id { get; }
        public string Nome { get; }
        public double Preco { get; }
        public string Categoria { get; }

        public Produto(int id, string nome, double preco, string categoria)
        {
            if (preco <= 0) throw new ArgumentException("Preço inválido.");

            Id = id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }
    }
}
