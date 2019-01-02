using System;
using System.IO;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using PdfGeneratorApi.Utility;

namespace PdfGeneratorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfCreatorController : ControllerBase
    {
        private IConverter _converter;

        public PdfCreatorController(IConverter converter)
        {
            _converter = converter;
        }

        [HttpGet]
        [Route("createpdf")]
        public IActionResult CreatePdf()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                Copies = 1,
                PaperSize = PaperKind.A4Small,
                DocumentTitle = "PDF Report",
                DPI = 380
            };
            
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = TemplateGenerator.GetHTMLString(),
                WebSettings = { DefaultEncoding = "utf-8"}
            };
            
            var pdf = new HtmlToPdfDocument
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            try
            {
                var file = _converter.Convert(pdf);
                return File(file, "application/pdf");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Ok(e.Message);
            }

        }
    }
}