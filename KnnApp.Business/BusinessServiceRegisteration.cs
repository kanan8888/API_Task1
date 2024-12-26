using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnnApp.Business;
public static class BusinessServiceRegisteration
{
    public static void AddBusinessService(this IServiceCollection service) 
    {
        //service.AddAutoMapper(typeof(BusinessServiceRegisteration));
    }
}
