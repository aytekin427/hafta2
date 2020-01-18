using hafta2.DTOs;
using System;

namespace hafta2.Controllers
{
    internal interface IProductService
    {
        object Add(ProductAddDto model);
        object Update(ProductUpdateDto model);
        object Delete(Guid id);
        object Get();
    }
}