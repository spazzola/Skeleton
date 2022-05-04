using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private List<clsCustomer> tstCustomerList;
        public clsCustomer customer { get; set; }

        public List<clsCustomer> customersList { get; set; }

        public int count { get; set; }
    }
}