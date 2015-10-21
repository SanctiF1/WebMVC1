using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVC1.ViewModels;


namespace WebMVC1.Models
{
    public class EmployeeListViewModel: BaseViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        //public string UserName { get; set; }
        //public FooterViewModel FooterData { get; set; }
    }
}