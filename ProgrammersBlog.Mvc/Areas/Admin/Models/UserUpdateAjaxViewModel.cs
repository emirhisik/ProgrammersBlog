﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Dtos;

namespace ProgrammersBlog.Mvc.Areas.Admin.Models
{
    public class UserUpdateAjaxViewModel
    {
        public UserUpdateDto UserAddDto { get; set; }
        public string UserUpdatePartial { get; set; }
        public UserDto UserDto { get; set; }
        public UserUpdateDto UserUpdateDto { get; internal set; }
    }
}
