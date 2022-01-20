using System.Windows;

namespace PdfiumViewer.WPFDemo
{
    /// <summary>
    /// Shell.xaml 的交互逻辑
    /// </summary>
    public partial class Shell : Window
    {
        PdfDocument pdfDoc;

        public Shell()
        {
            InitializeComponent();
        }

        private void LoadPDFButton_Click(object sender, RoutedEventArgs e)
        {
            using (var dialog = new System.Windows.Forms.OpenFileDialog())
            {
                dialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                dialog.Title = "Open PDF File";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pdfDoc = PdfDocument.Load(dialog.FileName);
                    pdfviewer.Document = pdfDoc;
                }
            }
        }
    }
}
