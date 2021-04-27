
namespace GraphicsDeviceInterface
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IOToolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PaintToolsStrip = new System.Windows.Forms.ToolStrip();
            this.LineButton = new System.Windows.Forms.ToolStripButton();
            this.CircleButton = new System.Windows.Forms.ToolStripButton();
            this.RectangleButton = new System.Windows.Forms.ToolStripButton();
            this.Seperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ResizeButton = new System.Windows.Forms.ToolStripButton();
            this.ColorPickerButton = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.RelocateButton = new System.Windows.Forms.ToolStripButton();
            this.IOToolStrip.SuspendLayout();
            this.PaintToolsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // IOToolStrip
            // 
            this.IOToolStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.IOToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.IOToolStrip.Location = new System.Drawing.Point(0, 0);
            this.IOToolStrip.Name = "IOToolStrip";
            this.IOToolStrip.Size = new System.Drawing.Size(2485, 46);
            this.IOToolStrip.TabIndex = 0;
            this.IOToolStrip.Text = "I/O Tools";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 46);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // PaintToolsStrip
            // 
            this.PaintToolsStrip.ImageScalingSize = new System.Drawing.Size(92, 92);
            this.PaintToolsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineButton,
            this.CircleButton,
            this.RectangleButton,
            this.Seperator1,
            this.ResizeButton,
            this.ColorPickerButton,
            this.RelocateButton});
            this.PaintToolsStrip.Location = new System.Drawing.Point(0, 46);
            this.PaintToolsStrip.Margin = new System.Windows.Forms.Padding(4);
            this.PaintToolsStrip.Name = "PaintToolsStrip";
            this.PaintToolsStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.PaintToolsStrip.Size = new System.Drawing.Size(2485, 102);
            this.PaintToolsStrip.TabIndex = 1;
            this.PaintToolsStrip.Text = "Paint Tools";
            this.PaintToolsStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.PaintToolsStrip_ItemClicked);
            // 
            // LineButton
            // 
            this.LineButton.Checked = true;
            this.LineButton.CheckOnClick = true;
            this.LineButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineButton.Image = ((System.Drawing.Image)(resources.GetObject("LineButton.Image")));
            this.LineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(96, 96);
            this.LineButton.Text = "Line";
            this.LineButton.ToolTipText = "Line";
            // 
            // CircleButton
            // 
            this.CircleButton.AccessibleName = "CircleButton";
            this.CircleButton.CheckOnClick = true;
            this.CircleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CircleButton.Image = ((System.Drawing.Image)(resources.GetObject("CircleButton.Image")));
            this.CircleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(96, 96);
            this.CircleButton.Text = "Circle";
            this.CircleButton.ToolTipText = "Circle";
            // 
            // RectangleButton
            // 
            this.RectangleButton.CheckOnClick = true;
            this.RectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("RectangleButton.Image")));
            this.RectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(96, 96);
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.ToolTipText = "Rectangle";
            // 
            // Seperator1
            // 
            this.Seperator1.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.Seperator1.Name = "Seperator1";
            this.Seperator1.Size = new System.Drawing.Size(6, 102);
            // 
            // ResizeButton
            // 
            this.ResizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResizeButton.Image = ((System.Drawing.Image)(resources.GetObject("ResizeButton.Image")));
            this.ResizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(96, 96);
            this.ResizeButton.Text = "Resize";
            this.ResizeButton.ToolTipText = "Resize";
            // 
            // ColorPickerButton
            // 
            this.ColorPickerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorPickerButton.Image = ((System.Drawing.Image)(resources.GetObject("ColorPickerButton.Image")));
            this.ColorPickerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorPickerButton.Name = "ColorPickerButton";
            this.ColorPickerButton.Size = new System.Drawing.Size(96, 96);
            this.ColorPickerButton.Text = "ColorPicker";
            this.ColorPickerButton.ToolTipText = "Color Picker";
            // 
            // RelocateButton
            // 
            this.RelocateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RelocateButton.Image = ((System.Drawing.Image)(resources.GetObject("RelocateButton.Image")));
            this.RelocateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RelocateButton.Name = "RelocateButton";
            this.RelocateButton.Size = new System.Drawing.Size(96, 96);
            this.RelocateButton.Text = "Relocate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2485, 1537);
            this.Controls.Add(this.PaintToolsStrip);
            this.Controls.Add(this.IOToolStrip);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.IOToolStrip.ResumeLayout(false);
            this.IOToolStrip.PerformLayout();
            this.PaintToolsStrip.ResumeLayout(false);
            this.PaintToolsStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip IOToolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStrip PaintToolsStrip;
        private System.Windows.Forms.ToolStripButton CircleButton;
        private System.Windows.Forms.ToolStripButton LineButton;
        private System.Windows.Forms.ToolStripButton RectangleButton;
        private System.Windows.Forms.ToolStripSeparator Seperator1;
        private System.Windows.Forms.ToolStripButton ResizeButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton ColorPickerButton;
        private System.Windows.Forms.ToolStripButton RelocateButton;
    }
}

