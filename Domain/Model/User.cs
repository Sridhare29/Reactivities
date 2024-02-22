using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
	public class User
	{
        public Guid Id { get; set; }

        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public string Title { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile number must be 10 digits")]
        public int mobileNumber { get; set; }
    }
}

