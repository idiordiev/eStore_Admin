using eStore_Admin.Application.RequestDTOs;
using eStore_Admin.Application.Responses;
using MediatR;

namespace eStore_Admin.Application.Requests.Mousepads.Commands.Edit
{
    public class EditMousepadCommand : IRequest<MousepadResponse>
    {
        public EditMousepadCommand(int mousepadId)
        {
            MousepadId = mousepadId;
        }

        public int MousepadId { get; }
        public MousepadDto Mousepad { get; set; }
    }
}