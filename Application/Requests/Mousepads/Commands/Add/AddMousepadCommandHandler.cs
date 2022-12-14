using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using eStore_Admin.Application.Interfaces.Persistence;
using eStore_Admin.Application.Interfaces.Services;
using eStore_Admin.Application.Responses;
using eStore_Admin.Domain.Entities;
using MediatR;

namespace eStore_Admin.Application.Requests.Mousepads.Commands.Add
{
    public class AddMousepadCommandHandler : IRequestHandler<AddMousepadCommand, MousepadResponse>
    {
        private readonly IDateTimeService _dateTimeService;
        private readonly ILoggingService _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AddMousepadCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILoggingService logger,
            IDateTimeService dateTimeService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
            _dateTimeService = dateTimeService;
        }

        public async Task<MousepadResponse> Handle(AddMousepadCommand request, CancellationToken cancellationToken)
        {
            var mousepad = _mapper.Map<Mousepad>(request.Mousepad);
            mousepad.Created = _dateTimeService.Now();
            mousepad.LastModified = _dateTimeService.Now();

            cancellationToken.ThrowIfCancellationRequested();

            _unitOfWork.MousepadRepository.Add(mousepad);
            await _unitOfWork.SaveAsync(cancellationToken);

            _logger.LogInformation("The mousepad with id {0} has been added.", mousepad.Id);

            return _mapper.Map<MousepadResponse>(mousepad);
        }
    }
}