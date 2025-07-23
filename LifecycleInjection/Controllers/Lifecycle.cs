using Microsoft.AspNetCore.Mvc;
using LifecycleInjection;

[ApiController]
[Route("api/[controller]")]
public class GuidTestController : ControllerBase
{
    private readonly SingletonMessageService _singleton1;
    private readonly SingletonMessageService _singleton2;

    private readonly ScopedMessageService _scoped1;
    private readonly ScopedMessageService _scoped2;

    private readonly TransientMessageService _transient1;
    private readonly TransientMessageService _transient2;

    public GuidTestController(
        SingletonMessageService singleton1,
        SingletonMessageService singleton2,
        ScopedMessageService scoped1,
        ScopedMessageService scoped2,
        TransientMessageService transient1,
        TransientMessageService transient2)
    {
        _singleton1 = singleton1;
        _singleton2 = singleton2;
        _scoped1 = scoped1;
        _scoped2 = scoped2;
        _transient1 = transient1;
        _transient2 = transient2;
    }

    [HttpGet("guids")]
    public IActionResult GetGuids()
    {
        var singleton1 = _singleton1.GetMessage();
        var singleton2 = _singleton2.GetMessage();

        var scoped1 = _scoped1.GetMessage();
        var scoped2 = _scoped2.GetMessage();

        var transient1 = _transient1.GetMessage();
        var transient2 = _transient2.GetMessage();

        return Ok(new
        {
            Singleton1 = singleton1,
            Singleton2 = singleton2,
            SingletonEqual = singleton1 == singleton2,

            Scoped1 = scoped1,
            Scoped2 = scoped2,
            ScopedEqual = scoped1 == scoped2,

            Transient1 = transient1,
            Transient2 = transient2,
            TransientEqual = transient1 == transient2
        });
    }
}
