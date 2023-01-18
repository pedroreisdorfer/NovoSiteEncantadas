using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebEncantadas.Models;
using WebEncantadas;
using QRCoder;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;


namespace WebEncantadas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        QrCode qrcode = new QrCode();

        public object GeneratorQRCoder { get; private set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //Nome da função deve ser o mesmo que o nome da sua controller
        {
            return View();
        }

        //public IActionResult QRCode()
        //{
        //    var qrCodeImage = GenerateQRCode("texto para gerar o QR Code");
        //    var stream = new MemoryStream();
        //    qrCodeImage.Save(stream, ImageFormat.Png);
        //    stream.Position = 0;
        //    return File(stream, "image/png");

        //}

        //public IActionResult GenerateQRCode()
        //{
        //    // Gerar o conteúdo do QRCode
        //    string qrCodeContent = "http://localhost:53318/Home";

        //    // Gerar o QRCode
        //    QRCodeGenerator qrGenerator = new QRCodeGenerator();
        //    QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrCodeContent, QRCodeGenerator.ECCLevel.Q);
        //    QRCode qrCode = new QRCode(qrCodeData);

        //    // Gerar a imagem do QRCode
        //    Bitmap qrCodeImage = qrCode.GetGraphic(20);

        //    // Salvar a imagem do QRCode em um arquivo
        //    string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "qrcode.png");
        //    qrCodeImage.Save(filePath, ImageFormat.Png);

        //    // Exibir a imagem do QRCode na página
        //    return File(filePath, "image/png");
           
        //}

        //public IActionResult GeradorQRCoder()
        //{
        //    string url = "http://localhost:53318/Home";
        //    ViewBag.Message = url;
        //    return View();
        //}

        //public IActionResult GeradorQRCodeEmail()
        //{
        //    Image image = GeneratorQRCoder.GeneratedQRCodeMail("teste@email.com", "Teste QR Code", "Uma mensagem qualquer");
        //    byte[] byteArray = GeneratorQRCoder.ImageToByte2(image);
        //    ViewBag.Message = byteArray;
        //    return View();
        //}

        //------------------Teste Geração do QrCode------------------------------








        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
