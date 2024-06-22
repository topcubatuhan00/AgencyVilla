using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.ProductDtos;
using AgencyVilla.Entity.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace AgencyVilla.Controllers;

public class ProductController : Controller
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public ProductController
    (
        IMapper mapper,
        IProductService productService
        )
    {
        _mapper = mapper;
        _productService = productService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _productService.TGetListAsync();
        var productList = _mapper.Map<List<ResultProductDto>>(data);
        return View(productList);
    }

    public async Task<IActionResult> DeleteProduct(ObjectId id)
    {
        await _productService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateProduct()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(CreateProductDto dto)
    {
        var product = _mapper.Map<Product>(dto);
        await _productService.TCreateAsync(product);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateProduct(ObjectId id)
    {
        var data = await _productService.TGetByIdAsync(id);
        var mappedData = _mapper.Map<UpdateProductDto>(data);
        return View(mappedData);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateProduct(UpdateProductDto dto)
    {
        var product = _mapper.Map<Product>(dto);
        await _productService.TUpdateAsync(product);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> ProductDetails(ObjectId id)
    {
        var data = await _productService.TGetByIdAsync(id);
        var mapped = _mapper.Map<ResultProductDto>(data);
        return View(mapped);
    }
}
