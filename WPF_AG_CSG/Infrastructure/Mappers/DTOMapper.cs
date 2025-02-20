using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_AG_CSG.Domain.Entities;

namespace WPF_AG_CSG.Infrastructure.Mappers
{
    public class DTOMapper
    {
        public Dictionary<string, object> ToDictionary(PFDto dto)
        {
            return new Dictionary<string, object>
            {
                {"name", dto.name },
                {"data", dto.data }
            };
        }
    }
}
