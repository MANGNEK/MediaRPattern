using MediaR.Domain.Core.Device.CreateDevice;
using MediaR.Domain.Core.Device.DeleteDevice;
using MediaR.Domain.Core.Device.GetAllDevice;
using MediaR.Domain.Core.Device.GetByIdDevice;
using MediaR.Domain.Core.Device.Updatedevice;
using MediaR.Domain.DTO;
using MediaR.Domain.Models;
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

    [HttpGet]
    [Route("getAll")]
    public async Task<List<DeviceReponse>> GetAll()
    {
        return await _mediator.Send(new GetAllDeviceConmand());
    }

    [HttpGet]
    [Route("getById")]
    public async Task<DeviceReponse> GetById(string id)
    {
        return await _mediator.Send(new GetByIdDeviceCommand(id));
    }

    [HttpDelete]
    [Route("delete")]
    public Task<string> DeleteById(string id)
    {
        return _mediator.Send(new DeleteDeviceCommand(id));
    }
}