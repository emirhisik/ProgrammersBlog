using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Concrete;
using System.Collections.Generic;
using ProgrammersBlog.Entities.Dtos;

namespace ProgrammersBlog.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<Category>> Get(int categoryId);
        Task<IDataResult<IList<Category>>> GetAll();
        Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName);
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<IResult> Delete(int categoryId);
        Task<IResult> HardDelete(int categoryId);
    }
}
