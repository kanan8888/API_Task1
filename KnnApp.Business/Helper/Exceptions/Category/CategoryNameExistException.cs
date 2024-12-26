using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnnApp.Business.Helper.Exceptions.Category;
public class CategoryNameExistException : Exception
{
    public CategoryNameExistException():base(){}
    public CategoryNameExistException(string message):base(message){}

}
