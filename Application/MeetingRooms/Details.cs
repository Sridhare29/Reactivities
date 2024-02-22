using System;
using Domain.Model;
using MediatR;
using Persistence;

namespace Application.MeetingRooms
{
	public class Details
	{
		public class Query : IRequest<BookMeetingRoom>
		{
			public Guid Id { get; set; }
		}

        public class Handler : IRequestHandler<Query, BookMeetingRoom>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<BookMeetingRoom> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.bookMeetingRooms.FindAsync(request.Id);
            }
        }
    }
}

