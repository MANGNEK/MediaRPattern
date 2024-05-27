using MediaR.Domain.Core.Device.CreateDevice;
using MediaR.Domain.DTO;
using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediaRPattern.Controllers;

public class DeviceController : Controller
{
    private readonly IMediator _mediator;

    public DeviceController(IMediator mediator) => _mediator = mediator;

    [HttpPost]
    [Route("create")]
    public async void CreateDevice([FromBody] DeviceDTO device)
    {
        await _mediator.Send(new CreateDeviceRequest(device));
    }
}