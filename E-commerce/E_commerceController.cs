using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce
{
    [Route("Cliente")]
    public class ClienteController : ControllerBase
    {
        public static List<Cliente> ClienteList = new List<Cliente>();
        private Cliente existCliente;

        [HttpGet("get")]
        public List<Cliente> Get()
        {
            return ClienteList;
        }

        [HttpGet("getbyid")]
        public Cliente Get([FromQuery] int id)
        {
            return ClienteList.Where(x => x.Id == id).First();
        }

        [HttpPost("upsert")]
        public Cliente Upsert([FromBody] Cliente cliente)
        {
            if (cliente.Id == 0)
            {
                cliente.Id = ClienteList.Count + 1;
                ClienteList.Add(cliente);
            }
            else
            {
                var existCliente = ClienteList.Where(x => x.Id == cliente.Id).First();

                existCliente.Name = cliente.Name;
                existCliente.PostalAddress = cliente.PostalAddress;
                existCliente.Birth = cliente.Birth;
            }

            return cliente;
        }

        [HttpDelete("delete")]
        public void Delete(int id)
        {
            var existPerson = ClienteList.Where(x => x.Id == id).First();
            ClienteList.Remove(existCliente);
        }
    }
}