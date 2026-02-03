using DotNet_Api_Practise_03.Entities.Dtos;

namespace DotNet_Api_Practise_03.Services
{
    public interface IEmployeeService
    {
        public Task<GetEmployeeByIdDto?> GetEmployeeById(int id);
        public Task<List<GetAllEmployeesDto>> GetAllEmployees();
        public Task<GetEmployeeByIdDto?> CreateEmployee(CreateEmployeeDto create);
        public Task<bool> UpdateEmployee(int id, UpdateEmployeeDto update);
        public Task<bool> DeleteEmployee(int id);
    }
}
