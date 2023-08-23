using Ardalis.GuardClauses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopWeb.ApplicationCore.Services;
using Microsoft.eShopWeb.Web.Features.MyOrders;
using Microsoft.eShopWeb.Web.Features.OrderDetails;
using Microsoft.eShopWeb.Web.ViewModels;

namespace Microsoft.eShopWeb.Web.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
[Authorize] // Controllers that mainly require Authorization still use Controller/View; other pages use Pages
[Route("[controller]/[action]")]
public class OrderController : Controller
{
    private readonly IMediator _mediator;
    private CatPhotoService CatPhotoService;

    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
        CatPhotoService = new CatPhotoService();
    }

    [HttpGet]
    public async Task<IActionResult> MyOrders()
    {   
        Guard.Against.Null(User?.Identity?.Name, nameof(User.Identity.Name));
        var viewModel = await _mediator.Send(new GetMyOrders(User.Identity.Name));

        return View(viewModel);
    }

    [HttpGet("{orderId}")]
    public async Task<IActionResult> Detail(int orderId)
    {
        Guard.Against.Null(User?.Identity?.Name, nameof(User.Identity.Name));
        var viewModel = await _mediator.Send(new GetOrderDetails(User.Identity.Name, orderId));

        if (viewModel == null)
        {
            return BadRequest("No such order found for this user.");
        }

        return View(viewModel);
    }

    [HttpGet("{catName}")]
    public async Task<IActionResult> HasCat(string catName)
    {
        var hasCat = CatPhotoService.HasCat(catName);
        var model = new CatViewModel(catName);
        return View(model);
    }
}
