using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Training_Project__List_of_expenses_and_List_of_debt_obligations_.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Expense")]
        public string ExpenseName { get; set; }
        public int Amount { get; set; }
    }
}
