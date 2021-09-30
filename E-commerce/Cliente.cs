using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce
{
    public class ClienteName
    {
        public string FirsName { get; set; }

        public string LastName { get; set; }
    }

    public class ClienteDocument
    {
        public string Type { get; set; }
        public string Value { get; set; }

    }

    public class PostalAddress
    {
        public string AddressCountry { get; set; }
        public string AddressLocality { get; set; }
        public string AddressRegion { get; set; }
        public string PostalCode { get; set; }
    }

    public class Cliente
    {
        public int Id { get; set; }

        public ClienteName Name { get; set; } = new ClienteName();

        public DateTime Birth { get; set; }

        public List<ClienteDocument> Document { get; set; } = new List<ClienteDocument>();

        public string Gender { get; set; }

        public PostalAddress PostalAddress { get; set; } = new PostalAddress();
    }




}