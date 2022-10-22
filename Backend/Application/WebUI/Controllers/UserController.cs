using Application.Common;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class UserController : Controller
{
    private readonly IApplicationDbContext _applicationDbContext;
    public UserController(IApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    [HttpGet]
    public User Index()
    {
        return _applicationDbContext.User.ToList().First();
    }
}
