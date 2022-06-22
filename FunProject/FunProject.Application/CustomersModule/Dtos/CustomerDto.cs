using FunProject.Domain.Enums;

namespace FunProject.Application.CustomersModule.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType Type { get; set; }
    }
}
