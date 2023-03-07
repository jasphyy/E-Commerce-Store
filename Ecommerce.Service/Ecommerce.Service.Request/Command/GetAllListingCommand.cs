using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Service.Entities.Models;
using MediatR;

namespace Ecommerce.Service.Request.Command;
public class GetAllListingCommand : IRequest<IList<ListingsModel>>
{
}
