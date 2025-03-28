using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using KenHttpClientLibraryForInterfax;
using System.Drawing.Imaging;

namespace KenHttpClientTestAppForInterfax
{
    public partial class Form1 : Form
    {
        FaxClient faxClient;
        const string MY_INTERFAX_USERID = "your_userid";
        const string MY_INTERFAX_PASSWORD = "your_password";

        const string testFolderPath = "TestData";
        //onst string testFileSmall = "Dummy File to test Interfax with small file.pdf";
        const string testFileSmall = "test - single page.pdf";
        const string testFileSmallDocx = "test.docx";

        const string testTwoPageDocument = "Dummy 2-page document to test Interfax.pdf";
        const string simulatorSuccessFaxNumber = "+999-9999-0";
        const string simulatorFailureFaxNumber = "+999-9999-6017";
        int currentFaxImagePageIndex = -1;
        int ctrPagesInFaxImage = 0;
        const string outputFilenameForSavedTif = "KenTestTifToOpenAsPDF.tif";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string interfaxUserid = MY_INTERFAX_USERID;
            string interfaxPpassword = MY_INTERFAX_PASSWORD;
            faxClient = new FaxClient(interfaxUserid, interfaxPpassword);
            //
            textBoxSimulatorFaxNumberSuccess.Text = simulatorSuccessFaxNumber;
            textBoxSimulatorFaxNumberFailure.Text = simulatorFailureFaxNumber;
        }

        private void buttonTest1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var balance = faxClient.GetAcctBalance();
                textBoxTest1Balance.Text = balance.ToString("C2");
            }
            catch (Exception exc) { KenMessages.DisplayExceptionMessage(exc); }
            finally { Cursor.Current = Cursors.Arrow; }
        }

        private void buttonTest2_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // Test with special characters
                FaxSendOptions faxSendOptions = new FaxSendOptions("Información Económica");
                string faxNumber = simulatorSuccessFaxNumber;
                string contact = "Darwin Núñez (test)";
                string docFilepath = Path.Combine(testFolderPath, testTwoPageDocument);
                long faxID = faxClient.SendFaxToSingleDestination(docFilepath, contact, faxNumber, faxSendOptions);
                textBoxTest2FaxID.Text = faxID.ToString();
            }
            catch (Exception exc) { KenMessages.DisplayExceptionMessage(exc); }
            finally { Cursor.Current = Cursors.Arrow; }
        }

        private void buttonTest3_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                FaxSendOptions faxSendOptions = new FaxSendOptions("Información Económica");
                string docFilepath = Path.Combine(testFolderPath, testFileSmall);
                List<FaxDestination> faxDestinations = new List<FaxDestination>
                {
                    new FaxDestination(simulatorSuccessFaxNumber, "Darwin Núñez"),
                    new FaxDestination(simulatorSuccessFaxNumber, "George Washington")
                };
                long batchID = faxClient.SendFaxToMultipleDestinations(docFilepath, faxDestinations, faxSendOptions);
                textBoxTest3BatchID.Text = batchID.ToString();
            }
            catch (Exception exc) { KenMessages.DisplayExceptionMessage(exc); }
            finally { Cursor.Current = Cursors.Arrow; }
        }
        private void buttonTest3A_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                FaxSendOptions faxSendOptions = new FaxSendOptions("Información Económica");
                List<FaxDestination> faxDestinations = new List<FaxDestination>
                {
                    new FaxDestination(simulatorSuccessFaxNumber, "Darwin Núñez"),
                    new FaxDestination(simulatorSuccessFaxNumber, "George Washington")
                };
                // Tricky! We need absolute filepath for webbrowser to work in DlgFaxPdfDocument!
                FileInfo fileInfo = new FileInfo(testFolderPath);
                var dir = fileInfo.DirectoryName;
                string pdfFilepath = Path.Combine(dir, testFolderPath, testFileSmall);

                DlgFaxPdfDocument dlg = new DlgFaxPdfDocument(pdfFilepath, faxDestinations, faxSendOptions);
                var result = dlg.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    KenMessages.DisplayInfoMessage("Fax was not sent; fax was cancelled by user.");
                }
                else
                {
                    long batchID = faxClient.SendFaxToMultipleDestinations(pdfFilepath, faxDestinations, faxSendOptions);
                    textBoxTest3BatchID.Text = batchID.ToString();
                }
            }
            catch (Exception exc) { KenMessages.DisplayExceptionMessage(exc); }
            finally { Cursor.Current = Cursors.Arrow; }
        }
        private void buttonTest4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTest4BatchID.Text))
            {
                KenMessages.DisplayInfoMessage("You must specify a batchID.");
            }
            else if (long.TryParse(textBoxTest4BatchID.Text, out long batchID) == false)
            {
                KenMessages.DisplayInfoMessage("BatchID is not a valid number.");
            }
            else
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    List<FaxDetailSummary> listChildSummary = faxClient.GetBatchChildFaxes(batchID);
                    List<string> listFaxIDs = new List<string>();
                    textBoxTest4ListChildFaxIDs.Text = String.Join(", ", listChildSummary.Select(k => k.id.ToString()));
                }
                catch (Exception exc) { KenMessages.DisplayExceptionMessage(exc); }
                finally { Cursor.Current = Cursors.Arrow; }
            }
        }

        private void buttonTest5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTest5ListIDs.Text))
            {
                KenMessages.DisplayInfoMessage("You must specify a list of IDs.");
            }
            else
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    List<string> listIDs = textBoxTest5ListIDs.Text.Split(',').ToList();
                    List<FaxDetailAll> listDetails = faxClient.GetFaxDetailsViaSearch(listIDs);
                    populateTest5Datagrid(listDetails);
                    textBoxCtrFaxDetailsInResponse.Text = listDetails.Count.ToString();
                }
                catch (Exception exc) { KenMessages.DisplayExceptionMessage(exc); }
                finally { Cursor.Current = Cursors.Arrow; }
            }
        }
        private void populateTest5Datagrid(List<FaxDetailAll> listDetails)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                dataGridView1.Rows.Clear();
                foreach (FaxDetailAll faxDetails in listDetails)
                {
                    DataGridViewRow dgvrow = dataGridView1.Rows[dataGridView1.Rows.Add()];
                    dgvrow.Cells[Column_Test5id.Index].Value = faxDetails.id.ToString();
                    dgvrow.Cells[Column_Test5status.Index].Value = faxDetails.status.ToString();
                    dgvrow.Cells[Column_Test5units.Index].Value = faxDetails.units.ToString();
                    dgvrow.Cells[Column_Test5costPerUnit.Index].Value = faxDetails.costPerUnit.ToString();
                    dgvrow.Cells[Column_Test5SenderCSID.Index].Value = faxDetails.senderCSID.ToString();
                    dgvrow.Cells[Column_Test5contact.Index].Value = faxDetails.contact.ToString();
                    dgvrow.Cells[Column_Test5DestFax.Index].Value = faxDetails.destinationFax.ToString();
                    dgvrow.Cells[Column_Test5subject.Index].Value = faxDetails.subject.ToString();
                }
            }
            catch (Exception exc) { KenMessages.DisplayExceptionMessage(exc); }
            finally { Cursor.Current = Cursors.Arrow; }
        }
        
        private void buttonTest7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTest7FaxID.Text))
            {
                KenMessages.DisplayInfoMessage("You must specify a faxID.");
            }
            else if (long.TryParse(textBoxTest7FaxID.Text, out long faxID) == false)
            {
                KenMessages.DisplayInfoMessage("FaxID is not a valid number.");
            }
            else
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Image faxImage = faxClient.GetFaxImage(faxID);
                    pictureBox1.Image = faxImage;
                    currentFaxImagePageIndex = 0;
                    ctrPagesInFaxImage = GetPageCount(faxImage);
                    textBoxPageNofN.Text = $"1 of {ctrPagesInFaxImage.ToString()}";
                    //
                    if (checkBoxSaveImageAsTif.Checked)
                    {
                        SaveImageAsTif(faxImage);
                    }
                }
                catch (Exception exc) { KenMessages.DisplayExceptionMessage(exc); }
                finally { Cursor.Current = Cursors.Arrow; }
            }
        }
        private void SaveImageAsTif(Image image)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string filepath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), outputFilenameForSavedTif);
                string uniqueFilepath = makeFilespecUnique(filepath, 20);
                image.Save(uniqueFilepath);
                Process.Start(uniqueFilepath);
            }
            catch (Exception exc) { KenMessages.DisplayExceptionMessage(exc); }
            finally { Cursor.Current = Cursors.Arrow; }
        }
        public string makeFilespecUnique(string originalFilespec, int maxNumberToMakeUnique)
        {
            string uniqueFilespec = originalFilespec;
            string originalFileExtension = Path.GetExtension(originalFilespec);
            int uniqueNumber = 1;
            while (File.Exists(uniqueFilespec))
            {
                uniqueFilespec = Path.ChangeExtension(originalFilespec, null)
                                        + "_" + uniqueNumber.ToString() + originalFileExtension;
                uniqueNumber++;
                if (uniqueNumber > maxNumberToMakeUnique)
                {
                    throw new Exception("Too many files exist with name: " + Path.GetFileName(originalFilespec));
                }
            }
            return uniqueFilespec;
        }
        /// <summary>
        /// Gets the number of pages in a TIF image
        /// </summary>
        private int GetPageCount(Image image)
        {
            FrameDimension dimension;
            dimension = FrameDimension.Page;
            return image.GetFrameCount(dimension);
        }
        private void buttonPrevImage_Click(object sender, EventArgs e)
        {
            if (currentFaxImagePageIndex > 0)
            {
                pictureBox1.Image.SelectActiveFrame(FrameDimension.Page, currentFaxImagePageIndex - 1);
                pictureBox1.Invalidate();
                currentFaxImagePageIndex--;
                textBoxPageNofN.Text = $"{(currentFaxImagePageIndex+1).ToString()} of {ctrPagesInFaxImage.ToString()}";
            }
        }

        private void buttonNextImage_Click(object sender, EventArgs e)
        {
            if (currentFaxImagePageIndex < ctrPagesInFaxImage - 1)
            {
                pictureBox1.Image.SelectActiveFrame(FrameDimension.Page, currentFaxImagePageIndex + 1);
                pictureBox1.Invalidate();
                currentFaxImagePageIndex++;
                textBoxPageNofN.Text = $"{(currentFaxImagePageIndex + 1).ToString()} of {ctrPagesInFaxImage.ToString()}";
            }
        }

        
    }
}
