
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.MeetingRooms;
using Domain.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Persistence;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace API.Controllers
{
    public class BookingController : BaseApiController
    {
        //private readonly IMediator _mediator;
        //public BookingController(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}

        [HttpGet]
        public async Task<ActionResult<List<BookMeetingRoom>>> GetMeetingRoom()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookMeetingRoom>> GetMeetingRoom(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult> CreateMeeting([FromBody]BookMeetingRoom bookMeetingRoom)
        {
            await Mediator.Send(new Create.Command { MeetingRoom = bookMeetingRoom });
            return Ok("Scuccesfull, You have Post Data");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditMeeting(Guid Id, BookMeetingRoom bookMeetingRoom)
        {
            bookMeetingRoom.Id = Id;
            await Mediator.Send(new Edit.Command { bookMeeting = bookMeetingRoom });
            return Ok("Scuccesfull, You have Put Data");
        }
    }
}

