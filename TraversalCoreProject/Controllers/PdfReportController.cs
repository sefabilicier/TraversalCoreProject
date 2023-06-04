using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace TraversalCoreProject.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4); 
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Reservation Pdf Report");

            document.Add(paragraph);
            document.Close();

            return File("/pdfreports/file1.pdf", "application/pdf", "file1.pdf");
        }

        public IActionResult StaticCustomerReports()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document();
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3); //sütun sayısı

            pdfPTable.AddCell("Guest Name");
            pdfPTable.AddCell("Guest Surname");
            pdfPTable.AddCell("Guest Identity Number");

            pdfPTable.AddCell("Eylül");
            pdfPTable.AddCell("Yücedağ");
            pdfPTable.AddCell("1111111111");

            pdfPTable.AddCell("Kemal");
            pdfPTable.AddCell("Yildirim");
            pdfPTable.AddCell("9999999999");

            pdfPTable.AddCell("Mehmet");
            pdfPTable.AddCell("Yücedağ");
            pdfPTable.AddCell("5555555555");

            document.Add(pdfPTable);

            document.Close();
            return File("/pdfreports/file2.pdf", "application/pdf", "file2.pdf");
        }


    }
}
