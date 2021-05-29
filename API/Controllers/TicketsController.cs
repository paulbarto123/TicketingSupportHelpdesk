using API.Base;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repositories.Data;
using API.Repositories.Interface;
using API.Context;
using Microsoft.Extensions.Configuration;
using API.ViewModel;
using Dapper;
using System.Data;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : BaseController<Ticket, TicketRepository, int>
    {
        private readonly TicketRepository ticketRepository;
        private readonly IGenericDapper dapper;
        private readonly MyContext myContext;
        private IConfiguration Configuration;
        public TicketsController (TicketRepository ticketRepository,
            IConfiguration Configuration,
            IGenericDapper dapper,
            MyContext myContext) : base(ticketRepository)
        {
            this.ticketRepository = ticketRepository;
            this.Configuration = Configuration;
            this.dapper = dapper;
            this.myContext = myContext;
        }

        [HttpPost]
        [Route("Create-Ticket")]
        public ActionResult Register([FromBody] CreateTicketVM ticketVM)
        {
            var dbparams = new DynamicParameters();

            dbparams.Add("Name", ticketVM.TicketName, DbType.String);
            dbparams.Add("Description", ticketVM.Description, DbType.String);
            dbparams.Add("CLientId", ticketVM.ClientId, DbType.String);
            dbparams.Add("CategoriesId", ticketVM.CategoriesId, DbType.Int32);
            dbparams.Add("Subject", ticketVM.Subject, DbType.String);
            dbparams.Add("Message", ticketVM.Message, DbType.String);

            var result = Task.FromResult(dapper.Insert<int>("[dbo].[SP_Register]", dbparams, commandType: CommandType.StoredProcedure));

            return Ok(new Response
            {
                Status = "Success",
                Message = "User created successfully!"
            });
        }
    }
}
