'========================================================================
' This conversion was produced by the Free Edition of
' Instant VB courtesy of Tangible Software Solutions.
' Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
'========================================================================

Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports IronPdf

Namespace IronPDFDemo
	Friend Class Program
		Shared Sub Main(ByVal args() As String)
			Console.WriteLine("Hold on tight!")

			Dim htmlToPdf = New HtmlToPdf() ' new instance of HtmlToPdf

			'html to pdf
			'html to turn into pdf
			Dim html = "<h1>Hello World!</h1><br><p>This is IronPdf.</p>"

			' turn html to pdf
			Dim pdf = htmlToPdf.RenderHtmlAsPdf(html)

			' save resulting pdf into file
			pdf.SaveAs(Path.Combine(Directory.GetCurrentDirectory(), "HtmlToPdf.Pdf"))

			'url to pdf
			' uri of the page to turn into pdf
			Dim uri = New Uri("http://www.google.com/ncr")

			' turn page into pdf
			pdf = htmlToPdf.RenderUrlAsPdf(uri)

			' save resulting pdf into file
			pdf.SaveAs(Path.Combine(Directory.GetCurrentDirectory(), "UrlToPdf.Pdf"))

			Console.WriteLine("Done. Please find results under '{0}' directory.", Directory.GetCurrentDirectory())
			Console.WriteLine("Press any key to continue.")
			Console.ReadKey()
		End Sub
	End Class
End Namespace
