using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;

namespace ModelDataUsingViewData.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // return View();
        // Employee emp = new Employee(){
        //     EmpId = 1,
        //     EmpName = "John Doe",
        //     Designation = "Manager",
        //     Salary = 50000
        // };
        // ViewData["myEmployee"] = emp;

    //    var employees = new List<Employee>(){
    //     new Employee{EmpId = 1, EmpName = "John Doe", Designation = "Manager", Salary = 50000},
    //     new Employee{EmpId = 2, EmpName = "Jane Doe", Designation = "Developer", Salary = 30000},
    //     new Employee{EmpId = 3, EmpName = "Jim Doe", Designation = "Designer", Salary = 40000},
    //     new Employee{EmpId = 4, EmpName = "Jill Doe", Designation = "HR", Salary = 20000},
    //     new Employee{EmpId = 5, EmpName = "Jack Doe", Designation = "Marketing", Salary = 10000},
    //    };
    //    ViewData["empList"] = employees;


    // strongly typed view
    // Employee emp = new Employee(){
    //     EmpId = 1,
    //     EmpName = "John Doe",
    //     Designation = "Manager",
    //     Salary = 50000
    // };

    List<Employee> emp = new List<Employee>(){
        new Employee{EmpId = 1, EmpName = "John Doe", Designation = "Manager", Salary = 50000},
        new Employee{EmpId = 2, EmpName = "Jane Doe", Designation = "Developer", Salary = 30000},
        new Employee{EmpId = 3, EmpName = "Jim Doe", Designation = "Designer", Salary = 40000},
        new Employee{EmpId = 4, EmpName = "Jill Doe", Designation = "HR", Salary = 20000},
        new Employee{EmpId = 5, EmpName = "Jack Doe", Designation = "Marketing", Salary = 10000},
    };

    
        
        return View(emp);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
