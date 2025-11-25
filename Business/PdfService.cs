using iTextSharp.text;
using iTextSharp.text.pdf;
using Proyect_Sencom_Form.Domain;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;

namespace Proyect_Sencom_Form.Business
{
    public class PdfService
    {// Clase encargada de generar los pdf con formato
        public void GenerarReporteFactura(Factura factura, Cliente cliente, string ruta)
        {
            if (factura == null) throw new ArgumentNullException(nameof(factura));
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));
            if (string.IsNullOrWhiteSpace(ruta)) throw new ArgumentException("Ruta inválida.");

            using (FileStream fs = new FileStream(ruta, FileMode.Create))
            {
                // Configuración del documento
                Document doc = new Document(PageSize.A4, 50, 50, 60, 50); // márgenes
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                // Encabezado y pie
                writer.PageEvent = new EncabezadoPieEvent();

                doc.AddAuthor("Sistema Facturación Solar");
                doc.AddTitle("Reporte de Factura");
                doc.AddSubject("Detalle completo de factura y cliente");
                doc.AddCreationDate();

                doc.Open();

                // Fuentes reutilizables
                var fTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                var fSeccion = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE);
                var fNormal = FontFactory.GetFont(FontFactory.HELVETICA, 11, BaseColor.DARK_GRAY);
                var fResaltado = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, new BaseColor(0, 70, 140));

                // Título principal
                Paragraph titulo = new Paragraph("REPORTE DE FACTURA", fTitulo)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 15f
                };
                doc.Add(titulo);

                // Sección Cliente
                doc.Add(ConstruirCajaSeccion("DATOS DEL CLIENTE", new[]
                {
                    Tupla("Nombre", cliente.Nombre),
                    Tupla("Dirección", cliente.Direccion),
                    Tupla("ID Cliente", cliente.IdCliente.ToString())
                }, fSeccion, fNormal));

                // Sección Factura
                doc.Add(ConstruirCajaSeccion("DETALLE DE FACTURA", new[]
                {
                    Tupla("ID Factura", factura.IdFactura.ToString()),
                    Tupla("Fecha Emisión", factura.FechaEmision.ToShortDateString()),
                    Tupla("Mes", factura.MesNombre + " (#" + factura.MesNumero + ")"),
                    Tupla("Capacidad Planta (kW)", factura.CapacidadPlantaKw.ToString("N2")),
                    Tupla("Producción Mensual (kWh)", factura.ProduccionKwhMes.ToString("N2")),
                    Tupla("Producción Acumulada (kWh)", factura.ProduccionAcumuladaKwh.ToString("N2"))
                }, fSeccion, fNormal));

                // Totales y montos
                PdfPTable tablaTotales = new PdfPTable(2)
                {
                    WidthPercentage = 100,
                    SpacingBefore = 10f
                };
                tablaTotales.SetWidths(new float[] { 60, 40 });

                AgregarFilaKV(tablaTotales, "Monto Mensual", factura.MontoMes.ToString("C2"), fResaltado, fNormal, new BaseColor(235, 245, 255));
                AgregarFilaKV(tablaTotales, "Monto Acumulado", factura.MontoAcumulado.ToString("C2"), fResaltado, fNormal, new BaseColor(225, 240, 250));

                doc.Add(tablaTotales);

                // Observaciones / Nota
                Paragraph nota = new Paragraph("Documento generado automáticamente el " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9, BaseColor.GRAY))
                {
                    SpacingBefore = 15f
                };
                doc.Add(nota);

                doc.Close();
            }
        }

        private static Tuple<string, string> Tupla(string k, string v) => new Tuple<string, string>(k, v);

        private PdfPTable ConstruirCajaSeccion(string titulo, Tuple<string, string>[] datos, Font fTitulo, Font fContenido)
        {
            PdfPTable contenedor = new PdfPTable(1) { WidthPercentage = 100, SpacingAfter = 10f };

            PdfPCell header = new PdfPCell(new Phrase(titulo, fTitulo))
            {
                BackgroundColor = new BaseColor(0, 90, 160),
                Padding = 6f
            };
            contenedor.AddCell(header);

            PdfPTable inner = new PdfPTable(2) { WidthPercentage = 100 }; inner.SetWidths(new float[] { 35, 65 });
            bool alternate = false;
            foreach (var par in datos)
            {
                BaseColor bg = alternate ? new BaseColor(245, 245, 250) : BaseColor.WHITE;
                alternate = !alternate;
                inner.AddCell(Celda(par.Item1, fResaltar: true, fondo: bg));
                inner.AddCell(Celda(par.Item2, fResaltar: false, fondo: bg));
            }
            PdfPCell wrap = new PdfPCell(inner) { Padding = 4f, Border = Rectangle.NO_BORDER };
            contenedor.AddCell(wrap);
            return contenedor;
        }

        private PdfPCell Celda(string texto, bool fResaltar, BaseColor fondo)
        {
            var f = FontFactory.GetFont(FontFactory.HELVETICA, 10, fResaltar ? Font.BOLD : Font.NORMAL, BaseColor.BLACK);
            return new PdfPCell(new Phrase(texto, f))
            {
                Border = Rectangle.NO_BORDER,
                BackgroundColor = fondo,
                Padding = 4f
            };
        }

        private void AgregarFilaKV(PdfPTable tabla, string k, string v, Font fKey, Font fValue, BaseColor fondo)
        {
            PdfPCell c1 = new PdfPCell(new Phrase(k, fKey)) { Padding = 6f, BackgroundColor = fondo, BorderColor = new BaseColor(200, 200, 210) };
            PdfPCell c2 = new PdfPCell(new Phrase(v, fValue)) { Padding = 6f, BackgroundColor = fondo, BorderColor = new BaseColor(200, 200, 210) };
            tabla.AddCell(c1);
            tabla.AddCell(c2);
        }
    }

    // Evento para encabezado y pie de página
    internal class EncabezadoPieEvent : PdfPageEventHelper
    {
        private readonly Font _fHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, BaseColor.WHITE);
        private readonly Font _fFooter = FontFactory.GetFont(FontFactory.HELVETICA, 8, BaseColor.GRAY);

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            PdfPTable header = new PdfPTable(1) { TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin };
            PdfPCell cell = new PdfPCell(new Phrase("Sistema de Facturación Solar", _fHeader))
            {
                BackgroundColor = new BaseColor(0, 90, 160),
                Padding = 6f,
                Border = Rectangle.NO_BORDER
            };
            header.AddCell(cell);
            header.WriteSelectedRows(0, -1, document.LeftMargin, document.PageSize.Height - 10, writer.DirectContent);

            PdfPTable footer = new PdfPTable(2) { TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin };
            footer.SetWidths(new float[] { 50, 50 });
            PdfPCell fc1 = new PdfPCell(new Phrase("Generado: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), _fFooter)) { Border = Rectangle.NO_BORDER, Padding = 4f };
            PdfPCell fc2 = new PdfPCell(new Phrase("Página " + writer.PageNumber, _fFooter)) { Border = Rectangle.NO_BORDER, Padding = 4f, HorizontalAlignment = Element.ALIGN_RIGHT };
            footer.AddCell(fc1);
            footer.AddCell(fc2);
            footer.WriteSelectedRows(0, -1, document.LeftMargin, document.BottomMargin - 5, writer.DirectContent);
        }
    }
}
