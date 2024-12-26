using AutoMapper;
using KnnApp.Business.Helper.Exceptions.Category;
using KnnApp.Business.Helper.Exceptions.Common;
using KnnApp.Business.Services.Interfaces;
using KnnApp.Core.DTOs.Category;
using KnnApp.Core.Entityes;
using KnnApp.DAL.Repositories.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnnApp.Business.Services.Implementation;
public class CategoryService : ICategoryService
{
    readonly ICategoryRepository _repository;
    readonly IMapper _mapper;

    public CategoryService(ICategoryRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetCategoryDTO> Create(CreateCategoryDTO categoryDTO)
    {
        if (await _repository.IsExist(c => c.CategoryName==categoryDTO.CategoryName)) 
        {
            throw new CategoryNameExistException();
        }

        var category = _mapper.Map<Category>(categoryDTO);
        var newCategory = _repository.Create(category);
        _repository.SaveChangesAsync();

        return _mapper.Map<GetCategoryDTO>(newCategory);

    }

    public GetCategoryDTO GetById(int id)
    {
        if (id <= 0) throw new NegativeIdException();

        GetCategoryDTO dto = _mapper.Map<GetCategoryDTO>(_repository.GetById(id));
        return dto;
        
    }

    Task<GetCategoryDTO> ICategoryService.GetById(int id)
    {
        throw new NotImplementedException();
    }
}
