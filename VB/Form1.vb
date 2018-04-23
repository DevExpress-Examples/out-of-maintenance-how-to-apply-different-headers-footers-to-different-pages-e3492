Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraRichEdit.Commands.Internal

Namespace RichEditDifferentHeaders
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			' Fill first section with text
			For i As Integer = 0 To 4
				richEditControl1.Document.AppendText(StringSample.SampleText)
			Next i

			' Add a header to the document
			Dim firstSection As Section = richEditControl1.Document.Sections(0)
			Dim doc As SubDocument = firstSection.BeginUpdateHeader()
			doc.InsertText(doc.CreatePosition(doc.Range.End.ToInt()), "Default Header")
			firstSection.EndUpdateHeader(doc)

			' Add a new section with a separate header
			richEditControl1.Document.AppendSection()

			Dim newSection As Section = richEditControl1.Document.Sections(richEditControl1.Document.Sections.Count - 1)

			newSection.UnlinkHeaderFromPrevious()

			doc = newSection.BeginUpdateHeader()
			doc.Replace(doc.Range, "Non-Default Header")
			newSection.EndUpdateHeader(doc)

			richEditControl1.Document.AppendText(StringSample.SampleText)
		End Sub
	End Class
End Namespace