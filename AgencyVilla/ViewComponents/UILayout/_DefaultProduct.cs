using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.ProductDtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.UILayout;

public class _DefaultProduct : ViewComponent
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public _DefaultProduct(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var data = await _productService.TGetListAsync();
        var mapped = _mapper.Map<List<ResultProductDto>>(data);
        return View(mapped);
    }
}
