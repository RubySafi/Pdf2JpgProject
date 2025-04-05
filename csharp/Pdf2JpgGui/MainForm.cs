
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Pdf2JpgGui;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        AppConfig.Load();
        this.Text = "PDF2JPG " + AsmUtility.GetAssemblyVersion();

        string exeDirectory = AsmUtility.GetAssemblyDirectoryName();
        string outputDirectory = Path.Combine(exeDirectory, AppConfig.DefaultOutput);

        if (!Directory.Exists(outputDirectory))
        {
            Directory.CreateDirectory(outputDirectory);
        }
        textBoxOutputDir.Text = outputDirectory;
    }

    private void buttonPdfFilePath_Click(object sender, EventArgs e)
    {
        openFileDialog1.InitialDirectory = AsmUtility.GetAssemblyDirectoryName();
        DialogResult result = openFileDialog1.ShowDialog();

        if (result == DialogResult.OK)
        {
            string filePath = openFileDialog1.FileName;
            textBoxPdfFilePath.Text = filePath;
        }
        else
        {
        }
    }

    private void buttonOutputDir_Click(object sender, EventArgs e)
    {
        DialogResult result = folderBrowserDialog1.ShowDialog();

        if (result == DialogResult.OK)
        {
            string folderPath = folderBrowserDialog1.SelectedPath;
            textBoxOutputDir.Text = folderPath;
        }
        else
        {
        }
    }

    private void buttonConvert_Click(object sender, EventArgs e)
    {
        string pdfFilePath = textBoxPdfFilePath.Text;
        string outputDir = textBoxOutputDir.Text;

        if (string.IsNullOrWhiteSpace(pdfFilePath) || !File.Exists(pdfFilePath))
        {
            MessageBox.Show("Please provide a valid PDF file path.");
            return;
        }

        if (string.IsNullOrWhiteSpace(outputDir) || !Directory.Exists(outputDir))
        {
            MessageBox.Show("Please provide a valid output directory.");
            return;
        }


        string exeDirectory = AsmUtility.GetAssemblyDirectoryName();
        string scriptPath = Path.Combine(exeDirectory, AppConfig.PythonScript);

        string escapedPdfFilePath = "\"" + pdfFilePath + "\"";
        string escapedOutputDir = "\"" + outputDir + "\"";

        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = "python",
            Arguments = $"\"{scriptPath}\" {escapedPdfFilePath} {escapedOutputDir}",
            CreateNoWindow = true,
            UseShellExecute = false
        };

        try
        {
            Process process = Process.Start(startInfo);
            process.WaitForExit();

            MessageBox.Show("PDF to JPG conversion completed!");

            Process.Start("explorer.exe", outputDir);
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred while running the script: " + ex.Message);
        }

    }

    private void MainForm_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && Path.GetExtension(files[0]).ToLower() == ".pdf")
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }

    private void MainForm_DragDrop(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && Path.GetExtension(files[0]).ToLower() == ".pdf")
            {
                textBoxPdfFilePath.Text = files[0];
            }
        }
    }

}
