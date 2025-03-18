using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using KenHttpClientLibraryForInterfax;

namespace KenHttpClientTestAppForInterfax
{
    public partial class DlgFaxPdfDocument : Form
    {
        bool UserClickedSendFax = false;
        string PdfFilepath {  get; set; }
        List<FaxDestination> FaxDestinations { get; set; }
        FaxSendOptions FaxSendOptions { get; set; }
        public DlgFaxPdfDocument(string pdfFilepath, List<FaxDestination> faxDestinations, FaxSendOptions faxSendOptions)
        {
            InitializeComponent();
            PdfFilepath = pdfFilepath; 
            FaxDestinations = faxDestinations;
            FaxSendOptions = faxSendOptions;
        }

        private void DlgFaxPdfDocument_Load(object sender, EventArgs e)
        {
            DisplayFaxInfo();
            DisplayDestinations();
            if (File.Exists(PdfFilepath))
            {
                webBrowser1.Navigate(PdfFilepath);
            }
            // keep track if user clicked the button (otherwise act as cancelled)
            UserClickedSendFax = false;
        }
        private void DisplayFaxInfo()
        {
            FileInfo fileInfo = new FileInfo(PdfFilepath);
            textBoxFaxDocumentFolderName.Text = fileInfo.DirectoryName;
            textBoxFaxDocumentFilename.Text = fileInfo.Name;
            textBoxCSID.Text = FaxSendOptions.Csid;
            textBoxSubject.Text = FaxSendOptions.Reference;
        }
        private void DisplayDestinations()
        {
            dataGridViewFaxDestinations.Rows.Clear();
            foreach (var faxDestination in FaxDestinations)
            {

                DataGridViewRow dgvrow = dataGridViewFaxDestinations.Rows[dataGridViewFaxDestinations.Rows.Add()];
                dgvrow.Cells[Column_FaxNumber.Index].Value = faxDestination.FaxNumber;
                dgvrow.Cells[Column_FaxContact.Index].Value = faxDestination.Contact;
                dgvrow.Cells[Column_FaxSubject.Index].Value = FaxSendOptions.Reference;
            }
        }
        private void DlgFaxPdfDocument_FormClosed(object sender, FormClosedEventArgs e)
        {
            webBrowser1.Dispose();
            if (UserClickedSendFax)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void buttonCancelFax_Click(object sender, EventArgs e)
        {
            UserClickedSendFax = false;
            Close();
        }

        private void buttonSendFax_Click(object sender, EventArgs e)
        {
            UserClickedSendFax = true;
            Close();
        }
    }
}
