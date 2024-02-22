using System;
namespace Domain.Model
{
	public class MeetingRoom
	{
        public Guid Id { get; set; }

        public string RoomName { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public int Person { get; set; }

        public bool Tv { get; set; }

        public bool WhiteBoard { get; set; }

        public Guid BookMeetingRoomId { get; set; }

        public BookMeetingRoom bookMeetingRoom { get; set; }
    }
}

