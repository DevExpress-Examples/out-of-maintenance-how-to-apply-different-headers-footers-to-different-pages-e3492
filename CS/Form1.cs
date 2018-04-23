using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.Commands.Internal;

namespace RichEditDifferentHeaders {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // Fill first section with text
            for (int i = 0; i < 5; i++) {
                richEditControl1.Document.AppendText(StringSample.SampleText);
            }

            // Add a header to the document
            Section firstSection = richEditControl1.Document.Sections[0];
            SubDocument doc = firstSection.BeginUpdateHeader();
            doc.InsertText(doc.CreatePosition(doc.Range.End.ToInt()), "Default Header");
            firstSection.EndUpdateHeader(doc);

            // Add a new section with a separate header
            richEditControl1.Document.AppendSection();
			richEditControl1.Document.CaretPosition = richEditControl1.Document.Range.End;

			EditPageHeaderCommand editPageHeaderCommand = new EditPageHeaderCommand(richEditControl1);
            ToggleHeaderFooterLinkToPreviousCommand toggleHeaderFooterLinkToPreviousCommand = new ToggleHeaderFooterLinkToPreviousCommand(richEditControl1);
            ClosePageHeaderFooterCommand closePageHeaderFooterCommand = new ClosePageHeaderFooterCommand(richEditControl1);

			editPageHeaderCommand.Execute();
			toggleHeaderFooterLinkToPreviousCommand.Execute();
            closePageHeaderFooterCommand.Execute();

            Section newSection = richEditControl1.Document.Sections[richEditControl1.Document.Sections.Count - 1];

			doc = newSection.BeginUpdateHeader();
            doc.Replace(doc.Range, "Non-Default Header");
			newSection.EndUpdateHeader(doc);

            richEditControl1.Document.AppendText(StringSample.SampleText);
        }
    }
}