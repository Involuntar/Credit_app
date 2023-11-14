using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Data
{
    class Credits
    {
        public string Term_id { get; set; } 
        public string Summ { get; set; }
        public string Rate_id { get; set; }
        public string Credit_type_id { get; set; }
        public string Statuses_id { get; set; }
        public string Users_id { get; set; }
        public Credits(string term_id, string summ, string rate_id, string credit_type_id, string statuses_id, string users_id)
        {
            Term_id = term_id;
            Summ = summ;
            Rate_id = rate_id;
            Credit_type_id = credit_type_id;
            Statuses_id = statuses_id;
            Users_id = users_id;
        }
    }
}
