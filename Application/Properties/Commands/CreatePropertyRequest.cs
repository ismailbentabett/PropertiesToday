using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using MediatR;

namespace Application.Properties.Commands
{
    public class CreatePropertyRequest : IRequest<
        bool
    >
    {
        public NewPropertyRequest? NewPropertyRequest { get; set; }

        public CreatePropertyRequest(NewPropertyRequest? newPropertyRequest)
        {
            NewPropertyRequest = newPropertyRequest;
        }

       
    }
}