using KnnApp.Core.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnnApp.Business.Services.Interfaces;
public interface ICategoryService
{
    Task<GetCategoryDTO> Create(CreateCategoryDTO categoryDTO);
    Task<GetCategoryDTO> GetById(int id);
    //List<GetAllCategoryDTO> GetAll();

}
