using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using u1.DbData;
using u1.Models;
using X.PagedList;

namespace u1.Controllers
{
    public class USoftController : Controller
    {
        //-------------------------------------------------
        AbstractContext ac = new AbstractContext();
        
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

