using EmployeeManagment.Models;
using EmployeeManagment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Controllers
{
        [Route("Home")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [Route("")]
        [Route("Index")]
        [Route("~/")]
        public ViewResult Index()
        {
            var model= employeeRepository.GetEmployees();
            return View(model);
        }


        [Route("Details/{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = employeeRepository.GetEmployee(id??1),
                PageTitle="Employee Details"
            };

            return View(homeDetailsViewModel);
        }
    }
}
