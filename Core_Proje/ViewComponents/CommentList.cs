﻿using Core_Proje.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Onur"
                },
                new UserComment
                {
                    ID=2,
                    Username="Soner"
                },
                new UserComment
                {
                    ID=3,
                    Username="Doğukan"
                }
            };
            return View(commentvalues);
        }
    }
}
