using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace WpfDemo.Models
{
    public class PorsonalModel
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public DateTime DataOfBerth { get; set; }
        public bool IsActive { get; set; }
        public decimal AccountBalance { get; set; }
        public List<AddressModel> Addresses { set; get;  } = new List<AddressModel>();
        public AddressModel PrimaryAddress { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName}{LastName}";

            }
        }


    }
}
