using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MEPTender.Models;

namespace MEPTender.Pages
{
    public class RegisterEmployee : PageModel
    {
        DAL objemployee = new DAL();

        [BindProperty]
        public Employee employee { get; set; }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            objemployee.AddEmployee(employee);

            return RedirectToPage("./RegisterEmployee");
        }
    }
}