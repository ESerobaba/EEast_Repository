using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PresentationLayer.Models
{
    [Serializable]
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentId { get; set; }
        public double AmountOfManeyDeposited { get; set; }
        public DateTime DateOfPay { get; set; }
        public Customer? CustomerId { get; set; }

    }
}
