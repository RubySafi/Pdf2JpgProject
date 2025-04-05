namespace Pdf2JpgGui;
using System.Windows.Forms;
using System.Drawing;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(750, 140);

        this.AllowDrop = true;
        this.DragEnter += MainForm_DragEnter;
        this.DragDrop += MainForm_DragDrop;

        textBoxPdfFilePath = new TextBox();
        textBoxOutputDir = new TextBox();
        buttonPdfFilePath = new Button();
        buttonOutputDir = new Button();
        buttonConvert = new Button();
        checkBoxDefault = new CheckBox();
        panel1 = new Panel();
        label1 = new Label();
        label2 = new Label();

        openFileDialog1 = new OpenFileDialog();
        folderBrowserDialog1 = new FolderBrowserDialog();

        // Panel properties
        panel1.Location = new Point(80, 10);
        panel1.Name = "panel1";
        panel1.Size = new Size(650, 180);


        panel1.Controls.Add(buttonPdfFilePath);
        panel1.Controls.Add(buttonOutputDir);
        panel1.Controls.Add(buttonConvert);
        panel1.Controls.Add(textBoxPdfFilePath);
        panel1.Controls.Add(textBoxOutputDir);
        panel1.Controls.Add(checkBoxDefault);

        // TextBox properties
        textBoxPdfFilePath.Location = new Point(10, 10); // Position on the form
        textBoxPdfFilePath.Name = "textBox1";
        textBoxPdfFilePath.Size = new Size(600, 20);      // Width and height
        textBoxPdfFilePath.TabIndex = 0;                  // Tab order for keyboard navigation
        textBoxPdfFilePath.ReadOnly = true;

        // TextBox properties
        textBoxOutputDir.Location = new Point(10, 40); // Position on the form
        textBoxOutputDir.Name = "textBox1";
        textBoxOutputDir.Size = new Size(600, 20);      // Width and height
        textBoxOutputDir.TabIndex = 1;                  // Tab order for keyboard navigation
        textBoxOutputDir.ReadOnly = true;

        // button1 properties
        buttonPdfFilePath.Location = new Point(615, 10);
        buttonPdfFilePath.Name = "button1";
        buttonPdfFilePath.Size = new Size(28, 28);
        buttonPdfFilePath.TabIndex = 0;
        buttonPdfFilePath.Text = "...";
        buttonPdfFilePath.UseVisualStyleBackColor = true;
        buttonPdfFilePath.Click += buttonPdfFilePath_Click;

        // button2 properties
        buttonOutputDir.Location = new Point(615, 40);
        buttonOutputDir.Name = "button2";
        buttonOutputDir.Size = new Size(28, 28);
        buttonOutputDir.TabIndex = 0;
        buttonOutputDir.Text = "...";
        buttonOutputDir.UseVisualStyleBackColor = true;
        buttonOutputDir.Click += buttonOutputDir_Click;

        // button3 properties
        buttonConvert.Location = new Point(562, 80);
        buttonConvert.Name = "button2";
        buttonConvert.Size = new Size(80, 28);
        buttonConvert.TabIndex = 0;
        buttonConvert.Text = "Convert";
        buttonConvert.UseVisualStyleBackColor = true;
        buttonConvert.Click += buttonConvert_Click;


        // Label properties
        label1.AutoSize = true; // Adjusts size automatically based on text
        label1.Location = new Point(20, 23); // Sets position on the form
        label1.Name = "labelInput";
        label1.Text = "pdf file :"; // Sets the displayed text

        // Label properties
        label2.AutoSize = true; // Adjusts size automatically based on text
        label2.Location = new Point(20, 53); // Sets position on the form
        label2.Name = "labelOutput";
        label2.Text = "output :"; // Sets the displayed text


        // openFileDialog1
        openFileDialog1.InitialDirectory = "C:\\";  // Set the initial directory
        openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";  // File type filter
        openFileDialog1.Title = "Select a pdf File";  // Title of the dialog
        openFileDialog1.RestoreDirectory = true;

        // folderBrowserDialog1
        folderBrowserDialog1.SelectedPath = "C:\\";  // Set the initial folder
        

        // checkBox1 properties
        checkBoxDefault.AutoSize = true;
        checkBoxDefault.Location = new Point(280, 84);
        checkBoxDefault.Name = "checkBox1";
        checkBoxDefault.Size = new Size(101, 24);
        checkBoxDefault.TabIndex = 2;
        checkBoxDefault.Text = "output : use default folder";
        checkBoxDefault.Checked = true;
        checkBoxDefault.UseVisualStyleBackColor = true;


        // Add the text box to the form
        Controls.Add(panel1);
        Controls.Add(label1);
        Controls.Add(label2);

        
    }

    #endregion

    private TextBox textBoxPdfFilePath;
    private TextBox textBoxOutputDir;
    private Button buttonPdfFilePath;
    private Button buttonOutputDir;
    private Button buttonConvert;
    private Panel panel1;

    private Label label1;
    private Label label2;
    private OpenFileDialog openFileDialog1;
    private FolderBrowserDialog folderBrowserDialog1;
    private CheckBox checkBoxDefault;
}
