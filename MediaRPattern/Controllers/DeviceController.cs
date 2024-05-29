using MediaR.Domain.Core.Device.CreateDevice;
using MediaR.Domain.Core.Device.DeleteDevice;
using MediaR.Domain.Core.Device.GetAllDevice;
using MediaR.Domain.Core.Device.GetByIdDevice;
using MediaR.Domain.Core.Device.Updatedevice;
using MediaR.Domain.DTO;
using MediaR.Domain.Models;
using MediaR.Domain.Response;
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
    public async Task<Result> CreateDevice([FromBody] DeviceDTO device)
    {
        return await _mediator.Send(new CreateDeviceCommand(device));
    }

    [HttpPatch]
    [Route("update")]
    public async Task<Result> UpdateDevice(string id, [FromBody] DeviceDTO device)
    {
        return await _mediator.Send(new UpdateDeviceCommand(id, device));
    }

    [HttpGet]
    [Route("getAll")]
    public async Task<Result> GetAll()
    {
        return await _mediator.Send(new GetAllDeviceConmand());
    }

    [HttpGet]
    [Route("getById")]
    public async Task<Result> GetById(string id)
    {
        return await _mediator.Send(new GetByIdDeviceCommand(id));
    }

    [HttpDelete]
    [Route("delete")]
    public Task<Result> DeleteById(string id)
    {
        return _mediator.Send(new DeleteDeviceCommand(id));
    }
}