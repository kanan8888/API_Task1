using KnnApp.Core.Entityes;
using KnnApp.DAL.Context;
using KnnApp.DAL.Repositories.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnnApp.DAL.Repositories.İmplementations;
public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(KnnAppDbContext context) : base(context) { }



}
