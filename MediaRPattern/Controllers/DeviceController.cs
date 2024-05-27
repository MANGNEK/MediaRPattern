using MediaR.Domain.Core.Device.CreateDevice;
using MediaR.Domain.Core.Device.Updatedevice;
using MediaR.Domain.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediaRPattern.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class DeviceController : ControllerBase
{
    private readonly IMediator _mediator;

    public DeviceController(IMediator mediator) => _mediator = mediator;

    [HttpPost]
    [Route("create")]
    public async void CreateDevice([FromBody] DeviceDTO device)
    {
        var result = await _mediator.Send(new CreateDeviceCommand(device));
    }

    [HttpPatch]
    [Route("update")]
    public async Task<string> UpdateDevice(string id, [FromBody] DeviceDTO device)
    {
        var result = await _mediator.Send(new UpdateDeviceCommand(id, device));
        return result;
    }
}