using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnnApp.Core.DTOs.Category;
public record GetAllCategoryDTO
{
    ICollection<GetCategoryDTO> Categories { get; set; }
    
}
