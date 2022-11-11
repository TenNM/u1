using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using u1.DbData;
using u1.Models;
using X.PagedList;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace u1.Controllers
{
    public class USoftController : Controller
    {
        //-------------------------------------------------
        //List<OneRecord> recList;
        AbstractContext ac = new AbstractContext();
        //public USoftController()
        //{
        //    recList = new List<OneRecord>();
        //    for(int i = 0; i < 100000; ++i)
        //    {
        //        recList.Add(
        //            new OneRecord(
        //                i,
        //                "text" + i,
        //                (1 == (i & 1))
        //        ));
        //    }
        //}
        //-------------------------------------------------

        //[HttpGet]
        //public IActionResult USoft(int? page)
        //{
        //    var pageN = page ?? 1;
        //    var pageSz = 10;

        //    var onePage = recList.ToPagedList(pageN, pageSz);

        //    USoftModel m = new USoftModel();
        //    m.SelectedValue = pageSz;
        //    return View(m);
        //}

        //[HttpGet]
        //public IActionResult USoft(USoftModel m, int? page)
        //{
        //    var pageN = page ?? 1;
        //    var pageSz = m.SelectedValue;

        //    if (pageSz == 0) pageSz = 10;//

        //    var onePage = recList.ToPagedList(pageN, pageSz);

        //    m.pList = onePage;
        //    return View(m);
        //}

        [HttpGet]
        public async Task<IActionResult> USoft(USoftModel m, int? page)
        {
            var query = from ae in ac.AbstractTables
                           select ae;
            //
            var pageN = page ?? 1;
            var pageSz = m.SelectedValue;

            if (pageSz == 0) pageSz = 10;//

            //var onePage = recList.ToPagedList(pageN, pageSz);
            var onePage = await query.ToPagedListAsync(pageN, pageSz);

            m.pList = onePage;
            return View(m);
        }
    }
}

