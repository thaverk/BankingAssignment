using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAssignment.Models
{
    public class Client
    {
        [PrimaryKey,AutoIncrement]
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string ClientContactnumber { get; set; }
        public string ClientAddress { get; set; }
        public DateTime CLient_DateOfBirth { get; set; }
        public string ClientBio { get; set; }
    }
}
