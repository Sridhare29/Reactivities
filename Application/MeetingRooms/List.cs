using System;
using Domain.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.MeetingRooms
{
	public class List
	{
		public class Query : IRequest<List<BookMeetingRoom>> { }

        public class Handler : IRequestHandler<Query, List<BookMeetingRoom>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<BookMeetingRoom>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.bookMeetingRooms.ToListAsync();
            }
        }
    }
}

