using eStore_Admin.Application.RequestDTOs;
using eStore_Admin.Application.Responses;
using MediatR;

namespace eStore_Admin.Application.Requests.Gamepads.Commands.Edit
{
    public class EditGamepadCommand : IRequest<GamepadResponse>
    {
        public EditGamepadCommand(int gamepadId)
        {
            GamepadId = gamepadId;
        }

        public int GamepadId { get; }
        public GamepadDto Gamepad { get; set; }
    }
}