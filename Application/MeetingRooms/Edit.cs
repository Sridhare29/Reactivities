using System;
using Domain.Model;
using MediatR;
using Persistence;

namespace Application.MeetingRooms
{
	public class Edit
	{
		public class Command :IRequest
		{
			public BookMeetingRoom bookMeeting { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            public readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var bookroom = await _context.bookMeetingRooms.FindAsync(request.bookMeeting.Id);

                bookroom.MeetingName = request.bookMeeting.MeetingName ?? bookroom.MeetingName;

                await _context.SaveChangesAsync();
            }
        }
    }
}

