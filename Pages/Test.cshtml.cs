using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace ProjectManagementCMS_Blazor.Pages
{
    public class TestModel : PageModel
    {
        private readonly Data.AppDBContext _contect;

        public TestModel(Data.AppDBContext context)
        {
            _contect = context;
        }


        public void OnGetAsync()
        {
           


        }
    }
}
