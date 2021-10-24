/* TransactionType.cs
 * Class that stores a model of the transaction types data
 * Revision History
 *      Jisung Kim, 2021.09.28: Created
 *      
 */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PROG2230_JisungKim.Models
{
    public class TransactionType
    {
        public int TransactionTypeId { get; set; }

        [DisplayName("Type")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [DisplayName("Commission Fee")]
        public double CommissionFee { get; set; }
    }
}
