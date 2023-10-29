using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Bank.Data
{
    class Mortgages
    {
        public string Cost { get; set; }
        public string Init_fee { get; set; }
        public string Credit_summ { get; set; }
        public string Term_id { get; set; }
        public string Rate_id { get; set; }
        public string Credit_type_id { get; set; }
        public string Users_id { get; set; }
        public string Statuses_id { get; set; }

        public Mortgages(string cost, string init_fee, string credit_summ, 
            string term_id, string rate_id, string credit_type_id, string users_id, string statuses_id)
        {
            Cost = cost;
            Init_fee = init_fee;
            Credit_summ = credit_summ;
            Term_id = term_id;
            Rate_id = rate_id;
            Credit_type_id = credit_type_id;
            Users_id = users_id;
            Statuses_id = statuses_id;
        }
    }
}
