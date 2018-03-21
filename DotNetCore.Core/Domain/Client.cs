using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.Core.Domain
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int EIN { get; set; }
        public DateTime ModifiedDate { get; set; }
       // public User ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
       // public User CreatedBy { get; set; }

    }
}
