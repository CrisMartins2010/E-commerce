using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E_commerce
{
    public class Produto
    {
        public int Id { get; set; }
      

        public string ProdutoNome { get; set; } = new ProdutoNome();

   

    }
    public class ProdutoNome
    {
        public static implicit operator string(ProdutoNome v)
        {
            throw new NotImplementedException();
        }
    }

    public class MarcaProduto
    {
         public string Marca { get; set; }


    public class ValorProduto
    {
        public Double Valor { get; set; } = new ValorProduto();

        public static implicit operator double(ValorProduto v)
        {
            throw new NotImplementedException();
        }
    }
    public class EstoqueProduto
    {
        public int Estoque { get; set; } = new EstoqueProduto();

            public static implicit operator int(EstoqueProduto v)
            {
                throw new NotImplementedException();
            }
        }
}

    }




        

             
    


