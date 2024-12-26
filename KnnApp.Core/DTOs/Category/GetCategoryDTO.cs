using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnnApp.Core.DTOs.Category;
public record GetCategoryDTO
{
    public int Id { get; set; }
    public string CategoryName { get; set; }

}
