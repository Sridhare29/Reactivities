using System;
using Domain.Model;
using MediatR;
using Persistence;

namespace Application.MeetingRooms
{
	public class Create
	{
		public class Command : IRequest
		{
			public BookMeetingRoom MeetingRoom { get; set; }
		}

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                this._context = context;
            }
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                _context.bookMeetingRooms.Add(request.MeetingRoom);
                  await _context.SaveChangesAsync();
            }
        }
    }
}

