using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImagesService _ICarImagesService;
        public CarImagesController(ICarImagesService _icarimagesservice)
        {
            _ICarImagesService = _icarimagesservice;
        }
        [HttpPost("addimage")]
        public IActionResult AddImage([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImages carImages)
        {
            var result = _ICarImagesService.AddImage(file, carImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var carimage = _ICarImagesService.GetById(Id).Data;
            var result = _ICarImagesService.Delete(carimage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult UpdateImage([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImages carImages)
        {
            var result = _ICarImagesService.UpdateImage(file, carImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _ICarImagesService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _ICarImagesService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("checknullimage")]
        public IActionResult CheckNullImage(int id)
        {
            var result = _ICarImagesService.CheckNullImage(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
