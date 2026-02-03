namespace DotNet_Api_Practise_03.Entities.Dtos
{
    public class UpdateEmployeeDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
