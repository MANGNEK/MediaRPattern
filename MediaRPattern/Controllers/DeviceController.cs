using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediaRPattern.Controllers;

public class DeviceController : Controller
{
    private readonly IDevice _device;

    public DeviceController(IDevice device) => _device = device;

    [HttpPost]
    [Route("create")]
    public void CreateDevice([FromBody] Device device)
    {
        _device.Add(device);
    }
}