using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using com.google.zxing.qrcode;
using com.google.zxing.common;
using ZXing;
using ZXing.ImageSharp;
using QRCoder;
using System.Drawing;

namespace WebEncantadas
{
    public class QrCode
    {
        public static Bitmap GenerateQRCode(string text)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }
    }
}
