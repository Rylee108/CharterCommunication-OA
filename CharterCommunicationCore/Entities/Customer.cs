using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterCommunicationCore.Entities
{
    public class Customer
    {
        public int CCCustomerId { get; set; }
        public string CCFirstName { get; set; }
        public string CCLastName { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
