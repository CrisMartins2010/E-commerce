using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce
{ 

    [Route("Produto")]


    public class ProdutoController: ControllerBase
    {
        public static List<Produto> ProdutoList = new List<Produto>();

        [HttpGet("get")]
        public List<Produto> Get()
        {
            return ProdutoList;
        }

        [HttpGet("getbyid")]
        public Produto Get([FromQuery] int id)
        {
            return ProdutoList.Where(x => x.Id == id).First();
        }

        [HttpPost("upsert")]
        public Produto Upsert([FromBody] Produto Produto)
        {
            if (Produto.Id == 0)
            {
                Produto.Id = ProdutoList.Count + 1;
                ProdutoList.Add(Produto);
            }
            else
            {
                var existProduto = ProdutoList.Where(x => x.Id == Produto.Id).First();

                existProduto.ProdutoNome = Produto.ProdutoNome;
                
            }

            return Produto;
        }

        [HttpDelete("delete")]
        public void Delete(int id)
        {
            var existProduto = ProdutoList.Where(x => x.Id == id).First();
            ProdutoList.Remove(existProduto);
        }
    }
}
