using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Training_Project__List_of_expenses_and_List_of_debt_obligations_.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lender { get; set; }
        public string ItemName { get; set; }
    }
}
