using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Models;
using ApplicationCore.Paging;
using ApplicationCore.Views;
using Infrastructure.Views;

namespace Web.Models.Admin
{
    public class SubscribesAdminModel
    {
        public ICollection<BaseOption<int>> PlansOptions { get; set; } = new List<BaseOption<int>>();

        public PagedList<Subscribe, SubscribeViewModel> PagedList { get; set; }

        public void LoadPlansOptions(IEnumerable<PlanViewModel> planViews)
        {
            var options = new List<BaseOption<int>>();
            foreach (var plan in planViews)
            {
                string text = $"{plan.Name} - {plan.StartDateText} ~ {plan.EndDateText}";
                options.Add(new BaseOption<int>(plan.Id, text));
            }

            PlansOptions = options;
        }

    }
}
