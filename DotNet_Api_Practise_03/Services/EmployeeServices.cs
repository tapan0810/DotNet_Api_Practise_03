using DotNet_Api_Practise_03.Data;
using DotNet_Api_Practise_03.Entities.Dtos;
using DotNet_Api_Practise_03.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNet_Api_Practise_03.Services
{
    public class EmployeeServices : IEmployeeService
    {
        private readonly EmployeeDbContext _context;
        public EmployeeServices(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllEmployeesDto>> GetAllEmployees()
        {
            return await _context.Employees
                .Select(s => new GetAllEmployeesDto
                {
                    Id = s.Id,
                    Name = s.Name
                }).ToListAsync();
        }

        public async Task<GetEmployeeByIdDto?> GetEmployeeById(int id)
        {
            return await _context.Employees.
                Where(s => s.Id == id).
                Select(s => new GetEmployeeByIdDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Email = s.Email,
                    Phone = s.Phone,
                    Description = s.Description
                }).FirstOrDefaultAsync();
        }

        public async Task<GetEmployeeByIdDto?> CreateEmployee(CreateEmployeeDto create)
        {
            var employee = new Employee
            {
              
                Name = create.Name,
                Email = create.Email,
                Phone = create.Phone,
                Description = create.Description
            };

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return new GetEmployeeByIdDto
            {
                Name = employee.Name,
                Email = employee.Email,
                Phone = employee.Phone,
                Description = employee.Description

            };
        }

        public async Task<bool> UpdateEmployee(int id, UpdateEmployeeDto update)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(s => s.Id == id);
            if (emp is null)
                return false;

            emp.Name = update.Name;
            emp.Email = update.Email;
            emp.Phone = update.Phone;
            emp.Description = update.Description;

            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(s => s.Id == id);
            if (emp is null) return false;

            _context.Employees.Remove(emp);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
