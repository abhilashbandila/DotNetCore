using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.Core.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public Client ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Role RoleId { get; set; }
        public bool IsActive { get; set; }
        public DateTime ModifiedDate { get; set; }
       // public User ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        //public User CreatedBy { get; set; }

    }
}
