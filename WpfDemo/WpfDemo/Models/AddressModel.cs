using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo.Models
{
    public  class AddressModel
    {
        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string FullAddress
        {
            get
            {
                return $"{StreetAddress} {City} {State}";
            }
        }

    }
}
