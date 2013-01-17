namespace SpriteGenerator
{
    partial class SpritesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpritesForm));
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInputDirectoryPath = new System.Windows.Forms.TextBox();
            this.textBoxOutputImageFilePath = new System.Windows.Forms.TextBox();
            this.textBoxOutputCSSFilePath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialogOutputImage = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogOutputCss = new System.Windows.Forms.SaveFileDialog();
            this.buttonBrowseFolder = new System.Windows.Forms.Button();
            this.buttonSelectOutputImageFilePath = new System.Windows.Forms.Button();
            this.buttonSelectOutputCSSFilePath = new System.Windows.Forms.Button();
            this.groupBoxPaths = new System.Windows.Forms.GroupBox();
            this.numericUpDownDistanceBetweenImages = new System.Windows.Forms.NumericUpDown();
            this.labelDistanceBetweenImages = new System.Windows.Forms.Label();
            this.radioButtonRectangularLayout = new System.Windows.Forms.RadioButton();
            this.groupBoxLayout = new System.Windows.Forms.GroupBox();
            this.labelSprites = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.numericUpDownImagesInColumn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownImagesInRow = new System.Windows.Forms.NumericUpDown();
            this.radioButtonVerticalLayout = new System.Windows.Forms.RadioButton();
            this.radioButtonAutomaticLayout = new System.Windows.Forms.RadioButton();
            this.radioButtonHorizontalLayout = new System.Windows.Forms.RadioButton();
            this.groupBoxDistances = new System.Windows.Forms.GroupBox();
            this.numericUpDownMarginWidth = new System.Windows.Forms.NumericUpDown();
            this.labelMarginWidth = new System.Windows.Forms.Label();
            this.groupBoxPaths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistanceBetweenImages)).BeginInit();
            this.groupBoxLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagesInColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagesInRow)).BeginInit();
            this.groupBoxDistances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarginWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Enabled = false;
            this.buttonGenerate.Location = new System.Drawing.Point(285, 229);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Images directory path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output image file path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output CSS file path:";
            // 
            // textBoxInputDirectoryPath
            // 
            this.textBoxInputDirectoryPath.Location = new System.Drawing.Point(132, 19);
            this.textBoxInputDirectoryPath.Name = "textBoxInputDirectoryPath";
            this.textBoxInputDirectoryPath.ReadOnly = true;
            this.textBoxInputDirectoryPath.Size = new System.Drawing.Size(127, 20);
            this.textBoxInputDirectoryPath.TabIndex = 0;
            // 
            // textBoxOutputImageFilePath
            // 
            this.textBoxOutputImageFilePath.Location = new System.Drawing.Point(132, 45);
            this.textBoxOutputImageFilePath.Name = "textBoxOutputImageFilePath";
            this.textBoxOutputImageFilePath.ReadOnly = true;
            this.textBoxOutputImageFilePath.Size = new System.Drawing.Size(127, 20);
            this.textBoxOutputImageFilePath.TabIndex = 1;
            // 
            // textBoxOutputCSSFilePath
            // 
            this.textBoxOutputCSSFilePath.Location = new System.Drawing.Point(132, 71);
            this.textBoxOutputCSSFilePath.Name = "textBoxOutputCSSFilePath";
            this.textBoxOutputCSSFilePath.ReadOnly = true;
            this.textBoxOutputCSSFilePath.Size = new System.Drawing.Size(127, 20);
            this.textBoxOutputCSSFilePath.TabIndex = 2;
            // 
            // saveFileDialogOutputImage
            // 
            this.saveFileDialogOutputImage.Filter = "PNG Image|*.png";
            // 
            // saveFileDialogOutputCss
            // 
            this.saveFileDialogOutputCss.Filter = "CSS file|*.css";
            // 
            // buttonBrowseFolder
            // 
            this.buttonBrowseFolder.Location = new System.Drawing.Point(276, 17);
            this.buttonBrowseFolder.Name = "buttonBrowseFolder";
            this.buttonBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFolder.TabIndex = 8;
            this.buttonBrowseFolder.Text = "Browse";
            this.buttonBrowseFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseFolder.Click += new System.EventHandler(this.buttonBrowseFolder_Click);
            // 
            // buttonSelectOutputImageFilePath
            // 
            this.buttonSelectOutputImageFilePath.Location = new System.Drawing.Point(276, 43);
            this.buttonSelectOutputImageFilePath.Name = "buttonSelectOutputImageFilePath";
            this.buttonSelectOutputImageFilePath.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectOutputImageFilePath.TabIndex = 9;
            this.buttonSelectOutputImageFilePath.Text = "Browse";
            this.buttonSelectOutputImageFilePath.UseVisualStyleBackColor = true;
            this.buttonSelectOutputImageFilePath.Click += new System.EventHandler(this.buttonSelectOutputImageFilePath_Click);
            // 
            // buttonSelectOutputCSSFilePath
            // 
            this.buttonSelectOutputCSSFilePath.Location = new System.Drawing.Point(276, 69);
            this.buttonSelectOutputCSSFilePath.Name = "buttonSelectOutputCSSFilePath";
            this.buttonSelectOutputCSSFilePath.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectOutputCSSFilePath.TabIndex = 10;
            this.buttonSelectOutputCSSFilePath.Text = "Browse";
            this.buttonSelectOutputCSSFilePath.UseVisualStyleBackColor = true;
            this.buttonSelectOutputCSSFilePath.Click += new System.EventHandler(this.buttonSelectOutputCssFilePath_Click);
            // 
            // groupBoxPaths
            // 
            this.groupBoxPaths.Controls.Add(this.label1);
            this.groupBoxPaths.Controls.Add(this.textBoxInputDirectoryPath);
            this.groupBoxPaths.Controls.Add(this.textBoxOutputImageFilePath);
            this.groupBoxPaths.Controls.Add(this.buttonSelectOutputCSSFilePath);
            this.groupBoxPaths.Controls.Add(this.buttonBrowseFolder);
            this.groupBoxPaths.Controls.Add(this.buttonSelectOutputImageFilePath);
            this.groupBoxPaths.Controls.Add(this.label2);
            this.groupBoxPaths.Controls.Add(this.textBoxOutputCSSFilePath);
            this.groupBoxPaths.Controls.Add(this.label3);
            this.groupBoxPaths.Location = new System.Drawing.Point(9, 12);
            this.groupBoxPaths.Name = "groupBoxPaths";
            this.groupBoxPaths.Size = new System.Drawing.Size(357, 103);
            this.groupBoxPaths.TabIndex = 11;
            this.groupBoxPaths.TabStop = false;
            this.groupBoxPaths.Text = "Paths";
            // 
            // numericUpDownDistanceBetweenImages
            // 
            this.numericUpDownDistanceBetweenImages.Location = new System.Drawing.Point(141, 24);
            this.numericUpDownDistanceBetweenImages.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDistanceBetweenImages.Name = "numericUpDownDistanceBetweenImages";
            this.numericUpDownDistanceBetweenImages.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownDistanceBetweenImages.TabIndex = 13;
            this.numericUpDownDistanceBetweenImages.Tag = "";
            // 
            // labelDistanceBetweenImages
            // 
            this.labelDistanceBetweenImages.AutoSize = true;
            this.labelDistanceBetweenImages.Location = new System.Drawing.Point(6, 26);
            this.labelDistanceBetweenImages.Name = "labelDistanceBetweenImages";
            this.labelDistanceBetweenImages.Size = new System.Drawing.Size(132, 13);
            this.labelDistanceBetweenImages.TabIndex = 14;
            this.labelDistanceBetweenImages.Text = "Distance between images:";
            // 
            // radioButtonRectangularLayout
            // 
            this.radioButtonRectangularLayout.AutoSize = true;
            this.radioButtonRectangularLayout.Enabled = false;
            this.radioButtonRectangularLayout.Location = new System.Drawing.Point(6, 88);
            this.radioButtonRectangularLayout.Name = "radioButtonRectangularLayout";
            this.radioButtonRectangularLayout.Size = new System.Drawing.Size(83, 17);
            this.radioButtonRectangularLayout.TabIndex = 15;
            this.radioButtonRectangularLayout.Text = "Rectangular";
            this.radioButtonRectangularLayout.UseVisualStyleBackColor = true;
            this.radioButtonRectangularLayout.CheckedChanged += new System.EventHandler(this.radioButtonRectangularLayout_CheckedChanged);
            // 
            // groupBoxLayout
            // 
            this.groupBoxLayout.Controls.Add(this.labelSprites);
            this.groupBoxLayout.Controls.Add(this.labelX);
            this.groupBoxLayout.Controls.Add(this.numericUpDownImagesInColumn);
            this.groupBoxLayout.Controls.Add(this.numericUpDownImagesInRow);
            this.groupBoxLayout.Controls.Add(this.radioButtonVerticalLayout);
            this.groupBoxLayout.Controls.Add(this.radioButtonAutomaticLayout);
            this.groupBoxLayout.Controls.Add(this.radioButtonHorizontalLayout);
            this.groupBoxLayout.Controls.Add(this.radioButtonRectangularLayout);
            this.groupBoxLayout.Location = new System.Drawing.Point(9, 121);
            this.groupBoxLayout.Name = "groupBoxLayout";
            this.groupBoxLayout.Size = new System.Drawing.Size(162, 136);
            this.groupBoxLayout.TabIndex = 16;
            this.groupBoxLayout.TabStop = false;
            this.groupBoxLayout.Text = "Layout";
            // 
            // labelSprites
            // 
            this.labelSprites.AutoSize = true;
            this.labelSprites.Enabled = false;
            this.labelSprites.Location = new System.Drawing.Point(119, 113);
            this.labelSprites.Name = "labelSprites";
            this.labelSprites.Size = new System.Drawing.Size(40, 13);
            this.labelSprites.TabIndex = 22;
            this.labelSprites.Text = "images";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Enabled = false;
            this.labelX.Location = new System.Drawing.Point(66, 113);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(12, 13);
            this.labelX.TabIndex = 21;
            this.labelX.Text = "x";
            // 
            // numericUpDownImagesInColumn
            // 
            this.numericUpDownImagesInColumn.Enabled = false;
            this.numericUpDownImagesInColumn.Location = new System.Drawing.Point(80, 111);
            this.numericUpDownImagesInColumn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownImagesInColumn.Name = "numericUpDownImagesInColumn";
            this.numericUpDownImagesInColumn.Size = new System.Drawing.Size(33, 20);
            this.numericUpDownImagesInColumn.TabIndex = 20;
            // 
            // numericUpDownImagesInRow
            // 
            this.numericUpDownImagesInRow.Enabled = false;
            this.numericUpDownImagesInRow.Location = new System.Drawing.Point(28, 111);
            this.numericUpDownImagesInRow.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownImagesInRow.Name = "numericUpDownImagesInRow";
            this.numericUpDownImagesInRow.ReadOnly = true;
            this.numericUpDownImagesInRow.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownImagesInRow.TabIndex = 19;
            this.numericUpDownImagesInRow.ValueChanged += new System.EventHandler(this.numericUpDownImagesInRow_ValueChanged);
            // 
            // radioButtonVerticalLayout
            // 
            this.radioButtonVerticalLayout.AutoSize = true;
            this.radioButtonVerticalLayout.Enabled = false;
            this.radioButtonVerticalLayout.Location = new System.Drawing.Point(6, 65);
            this.radioButtonVerticalLayout.Name = "radioButtonVerticalLayout";
            this.radioButtonVerticalLayout.Size = new System.Drawing.Size(60, 17);
            this.radioButtonVerticalLayout.TabIndex = 18;
            this.radioButtonVerticalLayout.TabStop = true;
            this.radioButtonVerticalLayout.Text = "Vertical";
            this.radioButtonVerticalLayout.UseVisualStyleBackColor = true;
            this.radioButtonVerticalLayout.CheckedChanged += new System.EventHandler(this.radioButtonLayout_CheckedChanged);
            // 
            // radioButtonAutomaticLayout
            // 
            this.radioButtonAutomaticLayout.AutoSize = true;
            this.radioButtonAutomaticLayout.Checked = true;
            this.radioButtonAutomaticLayout.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAutomaticLayout.Name = "radioButtonAutomaticLayout";
            this.radioButtonAutomaticLayout.Size = new System.Drawing.Size(72, 17);
            this.radioButtonAutomaticLayout.TabIndex = 17;
            this.radioButtonAutomaticLayout.TabStop = true;
            this.radioButtonAutomaticLayout.Text = "Automatic";
            this.radioButtonAutomaticLayout.UseVisualStyleBackColor = true;
            this.radioButtonAutomaticLayout.CheckedChanged += new System.EventHandler(this.radioButtonLayout_CheckedChanged);
            // 
            // radioButtonHorizontalLayout
            // 
            this.radioButtonHorizontalLayout.AutoSize = true;
            this.radioButtonHorizontalLayout.Enabled = false;
            this.radioButtonHorizontalLayout.Location = new System.Drawing.Point(6, 42);
            this.radioButtonHorizontalLayout.Name = "radioButtonHorizontalLayout";
            this.radioButtonHorizontalLayout.Size = new System.Drawing.Size(72, 17);
            this.radioButtonHorizontalLayout.TabIndex = 16;
            this.radioButtonHorizontalLayout.Text = "Horizontal";
            this.radioButtonHorizontalLayout.UseVisualStyleBackColor = true;
            this.radioButtonHorizontalLayout.CheckedChanged += new System.EventHandler(this.radioButtonLayout_CheckedChanged);
            // 
            // groupBoxDistances
            // 
            this.groupBoxDistances.Controls.Add(this.numericUpDownMarginWidth);
            this.groupBoxDistances.Controls.Add(this.labelMarginWidth);
            this.groupBoxDistances.Controls.Add(this.labelDistanceBetweenImages);
            this.groupBoxDistances.Controls.Add(this.numericUpDownDistanceBetweenImages);
            this.groupBoxDistances.Location = new System.Drawing.Point(174, 121);
            this.groupBoxDistances.Name = "groupBoxDistances";
            this.groupBoxDistances.Size = new System.Drawing.Size(192, 82);
            this.groupBoxDistances.TabIndex = 17;
            this.groupBoxDistances.TabStop = false;
            this.groupBoxDistances.Text = "Distances";
            // 
            // numericUpDownMarginWidth
            // 
            this.numericUpDownMarginWidth.Location = new System.Drawing.Point(141, 54);
            this.numericUpDownMarginWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMarginWidth.Name = "numericUpDownMarginWidth";
            this.numericUpDownMarginWidth.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownMarginWidth.TabIndex = 16;
            // 
            // labelMarginWidth
            // 
            this.labelMarginWidth.AutoSize = true;
            this.labelMarginWidth.Location = new System.Drawing.Point(6, 54);
            this.labelMarginWidth.Name = "labelMarginWidth";
            this.labelMarginWidth.Size = new System.Drawing.Size(70, 13);
            this.labelMarginWidth.TabIndex = 15;
            this.labelMarginWidth.Text = "Margin width:";
            // 
            // SpritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 263);
            this.Controls.Add(this.groupBoxDistances);
            this.Controls.Add(this.groupBoxLayout);
            this.Controls.Add(this.groupBoxPaths);
            this.Controls.Add(this.buttonGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpritesForm";
            this.Text = "SpriteGenerator";
            this.groupBoxPaths.ResumeLayout(false);
            this.groupBoxPaths.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistanceBetweenImages)).EndInit();
            this.groupBoxLayout.ResumeLayout(false);
            this.groupBoxLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagesInColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagesInRow)).EndInit();
            this.groupBoxDistances.ResumeLayout(false);
            this.groupBoxDistances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarginWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInputDirectoryPath;
        private System.Windows.Forms.TextBox textBoxOutputImageFilePath;
        private System.Windows.Forms.TextBox textBoxOutputCSSFilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutputImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutputCss;
        private System.Windows.Forms.Button buttonBrowseFolder;
        private System.Windows.Forms.Button buttonSelectOutputImageFilePath;
        private System.Windows.Forms.Button buttonSelectOutputCSSFilePath;
        private System.Windows.Forms.GroupBox groupBoxPaths;
        private System.Windows.Forms.NumericUpDown numericUpDownDistanceBetweenImages;
        private System.Windows.Forms.Label labelDistanceBetweenImages;
        private System.Windows.Forms.RadioButton radioButtonRectangularLayout;
        private System.Windows.Forms.GroupBox groupBoxLayout;
        private System.Windows.Forms.RadioButton radioButtonHorizontalLayout;
        private System.Windows.Forms.GroupBox groupBoxDistances;
        private System.Windows.Forms.RadioButton radioButtonAutomaticLayout;
        private System.Windows.Forms.RadioButton radioButtonVerticalLayout;
        private System.Windows.Forms.NumericUpDown numericUpDownMarginWidth;
        private System.Windows.Forms.Label labelMarginWidth;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.NumericUpDown numericUpDownImagesInColumn;
        private System.Windows.Forms.NumericUpDown numericUpDownImagesInRow;
        private System.Windows.Forms.Label labelSprites;
    }
}

