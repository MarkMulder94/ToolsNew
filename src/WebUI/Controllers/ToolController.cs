using CleanArchitecture.Application.Tools.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebUI.Controllers
{
    public class ToolController : ApiController
    {

        [HttpPost]
        public async Task<ActionResult<string>> CreateEmployee(CreateToolCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
