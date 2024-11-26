using C_Bootcamp_301.DataAccessLayer.Abstract;
using C_Bootcamp_301.DataAccessLayer.Repositeries;
using C_Bootcamp_301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Bootcamp_301.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>, ICategoryDal
    {
    }
}
