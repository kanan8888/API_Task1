using KnnApp.Core.Entityes.Common;
using KnnApp.DAL.Context;
using KnnApp.DAL.Repositories.İnterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KnnApp.DAL.Repositories.İmplementations;
public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
{
    readonly KnnAppDbContext _context;
    public Repository(KnnAppDbContext context)
    {
        _context = context;
    }

    public DbSet<TEntity> Table => _context.Set<TEntity>();

    public async Task<TEntity> Create(TEntity entity)
    {
        await Table.AddAsync(entity);
        return entity;
    }

    public void Delete(TEntity entity)
    {
        Table.Remove(entity);
    }

    public IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> expression=null)
    {
        return expression!=null ? Table.Where(expression) : Table;
    }

    public IQueryable<TEntity> GetAll()
    {
        return Table;
    }

    public async Task<TEntity> GetById(int id)
    {
        return await Table.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Update(TEntity entity)
    {
        Table.Update(entity);
    }

    public Task<bool> IsExist(Expression<Func<TEntity,bool>> expression) 
    {
        return Table.AnyAsync(expression);
    }

}
