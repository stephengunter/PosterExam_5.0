﻿using ApplicationCore.Models;
using ApplicationCore.Paging;
using ApplicationCore.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    //public class QuestionsParams
    //{ 
    //    public int Subject { get; set; }
    //    public int Term { get; set; }
    //    public int Recruit { get; set; }
    //}

    public class QuestionsAdminModel
    {
        public List<SubjectViewModel> Subjects { get; set; } = new List<SubjectViewModel>();

        public List<RecruitViewModel> Recruits { get; set; } = new List<RecruitViewModel>();

        public PagedList<Question, QuestionViewModel> PagedList { get; set; }
    }
}
