/* Company.cs
 * Class that stores a model of the companies data
 * Revision History
 *      Jisung Kim, 2021.10.14: Created
 *      
 */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PROG2230_JisungKim.Models
{
    public class Company
    {
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Please enter the company name.")]
        [DisplayName("Company Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the ticker symbol.")]
        [DisplayName("Ticker")]
        public string TickerSymbol { get; set; }
    }
}
