﻿using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHRM.Server.Pages
{
    public class EmployeeDetailBase : ComponentBase
    {
        [Parameter]
        public string EmployeeID { get; set; }
        public Employee Employee { get; set; } = new Employee();
        protected override Task OnInitializedAsync()
        {

            InitializeCountries();
            InitializeJobCategories();
            InitializeEmployees();
            Employee = Employees.FirstOrDefault(e => e.EmployeeId == EmployeeID);
            return base.OnInitializedAsync();
        }

        public IEnumerable<Employee> Employees { get; set; }

        private List<Country> Countries { get; set; }

        private List<JobCategory> JobCategories { get; set; }

        private void InitializeJobCategories()
        {
            JobCategories = new List<JobCategory>()
            {
                new JobCategory{JobCategoryId = 1, JobCategoryName = "Pie research"},
                new JobCategory{JobCategoryId = 2, JobCategoryName = "Sales"},
                new JobCategory{JobCategoryId = 3, JobCategoryName = "Management"},
                new JobCategory{JobCategoryId = 4, JobCategoryName = "Store staff"},
                new JobCategory{JobCategoryId = 5, JobCategoryName = "Finance"},
                new JobCategory{JobCategoryId = 6, JobCategoryName = "QA"},
                new JobCategory{JobCategoryId = 7, JobCategoryName = "IT"},
                new JobCategory{JobCategoryId = 8, JobCategoryName = "Cleaning"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"}
            };
        }

        private void InitializeCountries()
        {
            Countries = new List<Country>
            {
                new Country {CountryId = 1, Name = "Belgium"},
                new Country {CountryId = 2, Name = "Netherlands"},
                new Country {CountryId = 3, Name = "USA"},
                new Country {CountryId = 4, Name = "Japan"},
                new Country {CountryId = 5, Name = "China"},
                new Country {CountryId = 6, Name = "UK"},
                new Country {CountryId = 7, Name = "France"},
                new Country {CountryId = 8, Name = "Brazil"}
            };
        }

        private void InitializeEmployees()
        {
            var e1 = new Employee
            {
                CountryId = 3,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1989, 3, 11),
                City = "Louisville",
                Email = "bethany@bethanyspieshop.com",
                EmployeeId = "1q6wD1H",
                FirstName = "Libby",
                LastName = "Turpin",
                Gender = Gender.Female,
                PhoneNumber = "324777888773",
                Smoker = false,
                Street = "946 Goss Ave. #4105",
                Zip = "40217",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1)
            };

            var e2 = new Employee
            {
                CountryId = 3,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1979, 1, 16),
                City = "Antwerp",
                Email = "gill@bethanyspieshop.com",
                EmployeeId = "t6jT0jG",
                FirstName = "Harlan",
                LastName = "Tiu",
                Gender = Gender.Male,
                PhoneNumber = "33999909923",
                Smoker = false,
                Street = "946 Goss Ave. #4105",
                Zip = "40217",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24)
            };
            Employees = new List<Employee> { e1, e2 };
        }
    }
}
