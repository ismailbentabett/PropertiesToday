using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Properties.Commands
{
    public class CreatePropertyRequestHandler : IRequestHandler<
        CreatePropertyRequest,
        bool
    >
    {
        private readonly IPropertyRepo _propertyRepository;
        //imapper 
        private readonly IMapper _mapper;


        public CreatePropertyRequestHandler(IPropertyRepo propertyRepository,
            IMapper mapper
        )
        {
            _propertyRepository = propertyRepository;
            _mapper = mapper;
        }

        public Task<bool> Handle(CreatePropertyRequest request, CancellationToken cancellationToken)
        {
            Property property = _mapper.Map<Property>(request.NewPropertyRequest);
            _propertyRepository.AddProperty(property);
            _propertyRepository.SaveChanges();
            return Task.FromResult(true);

        }
    }
}