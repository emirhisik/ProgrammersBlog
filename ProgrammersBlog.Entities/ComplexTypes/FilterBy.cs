using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.ComplexTypes
{
    public enum FilterBy
    {
        Category=0, //GetAllByUserIdOnDate(FilterBy=FilterBy.Category,int categoryId)
        Date=1,
        ViewsCount=2,
        CommentCount=3
    }
}
