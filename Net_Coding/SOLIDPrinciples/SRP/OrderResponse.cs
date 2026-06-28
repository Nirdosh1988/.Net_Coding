using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples.SRP
{
    public record OrderResponse(
    Guid OrderId,
    string CustomerName,
    decimal TotalAmount,
    string Status,
    DateTime OrderDate);
}
