using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Washi.API.Domain.Models;

namespace Washi.API.Domain.Services.Communications
{
    public class DistrictResponse:BaseResponse<District>
    {
        public DistrictResponse(string message) : base(message) { }
        public DistrictResponse(District district) : base(district) { }
    }
}
