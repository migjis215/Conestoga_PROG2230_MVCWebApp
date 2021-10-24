/* TransactionRecord.cs
 * Class that stores a model of the transaction records data
 * Revision History
 *      Jisung Kim, 2021.09.28: Created
 *      Jisung Kim, 2021.10.14: Edited
 *      
 */

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PROG2230_JisungKim.Models
{
    public class TransactionRecord
    {
        public int TransactionRecordId { get; set; }

        [Required(ErrorMessage = "Please enter the quantity.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity of shares must be a positive integer.")]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Please enter the share price.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Share price must be greater than zero.")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [DisplayName("Share Price")]
        public double? SharePrice { get; set; }

        [Required(ErrorMessage = "Please enter the transaction type.")]
        public int TransactionTypeId { get; set; }

        public TransactionType TransactionType { get; set; }

        [Required]
        public int CompanyId { get; set; }

        public Company Company { get; set; }

        /// <summary>
        /// Calculate the gross value
        /// </summary>
        /// <returns>The gross value</returns>
        public double CalculateGrossValue()
        {
            if (TransactionType.Name == "Buy")
            {
                return -(double)(Quantity * SharePrice);
            }
            return (double)(Quantity * SharePrice);
        }

        /// <summary>
        /// Calculate the net value
        /// </summary>
        /// <returns>The net value</returns>
        public double CalculateNetValue()
        {
            return CalculateGrossValue() - TransactionType.CommissionFee;
        }
    }
}
