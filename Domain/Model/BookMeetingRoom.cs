using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
	public class BookMeetingRoom
	{
		public Guid Id { get; set; }

		public string MeetingName { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Required(ErrorMessage = "Date is required")]
        //[FutureDate(ErrorMessage = "Date must be a future date")]
        //public DateTime Date { get; set; }

        public int EmployeeCount { get; set; }

        //[DataType(DataType.Time)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        //[Required(ErrorMessage = "Start Time is required")]
        public TimeSpan StartTime { get; set; }

        //[DataType(DataType.Time)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        //[Required(ErrorMessage = "End Time is required")]
        //[EndTimeGreaterThanStartTime(ErrorMessage = "End Time must be greater than Start Time")]
        public TimeSpan EndTime { get; set; }

        //[ForeignKey("KaniniLocation")]
        public Guid KaniniLocationId { get; set; }

        //public KaniniLocation KaniniLocation { get; set; }



        //public class EndTimeGreaterThanStartTimeAttribute : ValidationAttribute
        //{
        //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //    {
        //        var bookMeetingRoom = (BookMeetingRoom)validationContext.ObjectInstance;

        //        if (bookMeetingRoom.StartTime >= bookMeetingRoom.EndTime)
        //        {
        //            return new ValidationResult(ErrorMessage);
        //        }

        //        return ValidationResult.Success;
        //    }
        //}

        //public class FutureDateAttribute : ValidationAttribute
        //{
        //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //    {
        //        DateTime date = (DateTime)value;

        //        if (date.Date < DateTime.Today)
        //        {
        //            return new ValidationResult(ErrorMessage);
        //        }

        //        return ValidationResult.Success;
        //    }
        //}
    }
}

