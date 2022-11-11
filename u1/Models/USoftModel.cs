using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using u1.DbModels;
using X.PagedList;

namespace u1.Models
{
    public class USoftModel
    {
        //public IPagedList<OneRecord> pList { get; set; }
        public IPagedList<AbstractEnt> pList { get; set; }
        public SelectList valuesToSelect { get; }
        public int SelectedValue { get; set; }

        public USoftModel()
        {
            valuesToSelect = new SelectList(new List<int> { 10, 25, 50 }, 10);
            //SelectedValue = 10;
        }
    }
}

