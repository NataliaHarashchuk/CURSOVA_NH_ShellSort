namespace CURSOVA_NH
{
    partial class MainForm
    {
        
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxArray = new System.Windows.Forms.TextBox();
            this.InputError = new System.Windows.Forms.Label();
            this.ArrayGenerator = new System.Windows.Forms.GroupBox();
            this.GenerateParamError = new System.Windows.Forms.Label();
            this.textBoxGenerateNumOfElem = new System.Windows.Forms.TextBox();
            this.labelGenerateNumOfElem = new System.Windows.Forms.Label();
            this.textBoxGenerateUpperBound = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxGenerateLowerBound = new System.Windows.Forms.TextBox();
            this.TypeOfGeneration = new System.Windows.Forms.GroupBox();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonGeneratorDescending = new System.Windows.Forms.RadioButton();
            this.radioButtonGeneratorAscending = new System.Windows.Forms.RadioButton();
            this.Desh = new System.Windows.Forms.Label();
            this.labelArrayRange = new System.Windows.Forms.Label();
            this.SortingParam = new System.Windows.Forms.GroupBox();
            this.SortingShellSequence = new System.Windows.Forms.GroupBox();
            this.radioButtonSortTokuda = new System.Windows.Forms.RadioButton();
            this.radioButtonDortFibonacci = new System.Windows.Forms.RadioButton();
            this.radioButtonSortSedgwick = new System.Windows.Forms.RadioButton();
            this.radioButtonSortClassic = new System.Windows.Forms.RadioButton();
            this.SortAscOrDesc = new System.Windows.Forms.GroupBox();
            this.radioButtonSortDesc = new System.Windows.Forms.RadioButton();
            this.radioButtonSortAsc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelComarisons = new System.Windows.Forms.Label();
            this.labelSwaps = new System.Windows.Forms.Label();
            this.buttonStartSort = new System.Windows.Forms.Button();
            this.SaveMessageLabel = new System.Windows.Forms.Label();
            this.groupBoxCompAndSwaps = new System.Windows.Forms.GroupBox();
            this.ArrayGenerator.SuspendLayout();
            this.TypeOfGeneration.SuspendLayout();
            this.SortingParam.SuspendLayout();
            this.SortingShellSequence.SuspendLayout();
            this.SortAscOrDesc.SuspendLayout();
            this.groupBoxCompAndSwaps.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxArray
            // 
            this.textBoxArray.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxArray.Location = new System.Drawing.Point(435, 13);
            this.textBoxArray.Multiline = true;
            this.textBoxArray.Name = "textBoxArray";
            this.textBoxArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxArray.Size = new System.Drawing.Size(477, 389);
            this.textBoxArray.TabIndex = 0;
            // 
            // InputError
            // 
            this.InputError.AutoSize = true;
            this.InputError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(182)))), ((int)(((byte)(31)))));
            this.InputError.Location = new System.Drawing.Point(432, 414);
            this.InputError.Name = "InputError";
            this.InputError.Size = new System.Drawing.Size(0, 17);
            this.InputError.TabIndex = 1;
            // 
            // ArrayGenerator
            // 
            this.ArrayGenerator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ArrayGenerator.Controls.Add(this.GenerateParamError);
            this.ArrayGenerator.Controls.Add(this.textBoxGenerateNumOfElem);
            this.ArrayGenerator.Controls.Add(this.labelGenerateNumOfElem);
            this.ArrayGenerator.Controls.Add(this.textBoxGenerateUpperBound);
            this.ArrayGenerator.Controls.Add(this.buttonGenerate);
            this.ArrayGenerator.Controls.Add(this.textBoxGenerateLowerBound);
            this.ArrayGenerator.Controls.Add(this.TypeOfGeneration);
            this.ArrayGenerator.Controls.Add(this.Desh);
            this.ArrayGenerator.Controls.Add(this.labelArrayRange);
            this.ArrayGenerator.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrayGenerator.Location = new System.Drawing.Point(18, 13);
            this.ArrayGenerator.Name = "ArrayGenerator";
            this.ArrayGenerator.Padding = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ArrayGenerator.Size = new System.Drawing.Size(388, 389);
            this.ArrayGenerator.TabIndex = 2;
            this.ArrayGenerator.TabStop = false;
            this.ArrayGenerator.Text = "Генерування масиву";
            // 
            // GenerateParamError
            // 
            this.GenerateParamError.Font = new System.Drawing.Font("Cascadia Code", 7F);
            this.GenerateParamError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(182)))), ((int)(((byte)(31)))));
            this.GenerateParamError.Location = new System.Drawing.Point(17, 263);
            this.GenerateParamError.Name = "GenerateParamError";
            this.GenerateParamError.Size = new System.Drawing.Size(353, 69);
            this.GenerateParamError.TabIndex = 13;
            // 
            // textBoxGenerateNumOfElem
            // 
            this.textBoxGenerateNumOfElem.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenerateNumOfElem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxGenerateNumOfElem.Location = new System.Drawing.Point(217, 38);
            this.textBoxGenerateNumOfElem.Name = "textBoxGenerateNumOfElem";
            this.textBoxGenerateNumOfElem.Size = new System.Drawing.Size(153, 23);
            this.textBoxGenerateNumOfElem.TabIndex = 7;
            // 
            // labelGenerateNumOfElem
            // 
            this.labelGenerateNumOfElem.AutoSize = true;
            this.labelGenerateNumOfElem.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenerateNumOfElem.Location = new System.Drawing.Point(14, 38);
            this.labelGenerateNumOfElem.Name = "labelGenerateNumOfElem";
            this.labelGenerateNumOfElem.Size = new System.Drawing.Size(160, 17);
            this.labelGenerateNumOfElem.TabIndex = 6;
            this.labelGenerateNumOfElem.Text = "Кількість елементів";
            // 
            // textBoxGenerateUpperBound
            // 
            this.textBoxGenerateUpperBound.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenerateUpperBound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxGenerateUpperBound.Location = new System.Drawing.Point(305, 73);
            this.textBoxGenerateUpperBound.Name = "textBoxGenerateUpperBound";
            this.textBoxGenerateUpperBound.Size = new System.Drawing.Size(65, 23);
            this.textBoxGenerateUpperBound.TabIndex = 4;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.buttonGenerate.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate.Location = new System.Drawing.Point(123, 335);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(140, 41);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Згенерувати";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxGenerateLowerBound
            // 
            this.textBoxGenerateLowerBound.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenerateLowerBound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxGenerateLowerBound.Location = new System.Drawing.Point(217, 73);
            this.textBoxGenerateLowerBound.Name = "textBoxGenerateLowerBound";
            this.textBoxGenerateLowerBound.Size = new System.Drawing.Size(65, 23);
            this.textBoxGenerateLowerBound.TabIndex = 3;
            // 
            // TypeOfGeneration
            // 
            this.TypeOfGeneration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(253)))));
            this.TypeOfGeneration.Controls.Add(this.radioButtonRandom);
            this.TypeOfGeneration.Controls.Add(this.radioButtonGeneratorDescending);
            this.TypeOfGeneration.Controls.Add(this.radioButtonGeneratorAscending);
            this.TypeOfGeneration.Font = new System.Drawing.Font("Cascadia Code SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOfGeneration.Location = new System.Drawing.Point(20, 114);
            this.TypeOfGeneration.Name = "TypeOfGeneration";
            this.TypeOfGeneration.Size = new System.Drawing.Size(350, 146);
            this.TypeOfGeneration.TabIndex = 2;
            this.TypeOfGeneration.TabStop = false;
            this.TypeOfGeneration.Text = "Вид генерації";
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonRandom.Location = new System.Drawing.Point(6, 87);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(157, 21);
            this.radioButtonRandom.TabIndex = 5;
            this.radioButtonRandom.Text = "Випадковим чином";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            this.radioButtonRandom.CheckedChanged += new System.EventHandler(this.radioButtonRandom_CheckedChanged);
            // 
            // radioButtonGeneratorDescending
            // 
            this.radioButtonGeneratorDescending.AutoSize = true;
            this.radioButtonGeneratorDescending.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGeneratorDescending.Location = new System.Drawing.Point(6, 60);
            this.radioButtonGeneratorDescending.Name = "radioButtonGeneratorDescending";
            this.radioButtonGeneratorDescending.Size = new System.Drawing.Size(125, 21);
            this.radioButtonGeneratorDescending.TabIndex = 4;
            this.radioButtonGeneratorDescending.Text = "За спаданням";
            this.radioButtonGeneratorDescending.UseVisualStyleBackColor = true;
            this.radioButtonGeneratorDescending.CheckedChanged += new System.EventHandler(this.radioButtonGeneratorDescending_CheckedChanged);
            // 
            // radioButtonGeneratorAscending
            // 
            this.radioButtonGeneratorAscending.AutoSize = true;
            this.radioButtonGeneratorAscending.Checked = true;
            this.radioButtonGeneratorAscending.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGeneratorAscending.Location = new System.Drawing.Point(6, 32);
            this.radioButtonGeneratorAscending.Name = "radioButtonGeneratorAscending";
            this.radioButtonGeneratorAscending.Size = new System.Drawing.Size(133, 21);
            this.radioButtonGeneratorAscending.TabIndex = 3;
            this.radioButtonGeneratorAscending.TabStop = true;
            this.radioButtonGeneratorAscending.Text = "За зростанням";
            this.radioButtonGeneratorAscending.UseVisualStyleBackColor = true;
            this.radioButtonGeneratorAscending.CheckedChanged += new System.EventHandler(this.radioButtonGeneratorAscending_CheckedChanged);
            // 
            // Desh
            // 
            this.Desh.AutoSize = true;
            this.Desh.Location = new System.Drawing.Point(288, 76);
            this.Desh.Name = "Desh";
            this.Desh.Size = new System.Drawing.Size(16, 17);
            this.Desh.TabIndex = 1;
            this.Desh.Text = "-";
            // 
            // labelArrayRange
            // 
            this.labelArrayRange.AutoSize = true;
            this.labelArrayRange.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArrayRange.Location = new System.Drawing.Point(17, 76);
            this.labelArrayRange.Name = "labelArrayRange";
            this.labelArrayRange.Size = new System.Drawing.Size(72, 17);
            this.labelArrayRange.TabIndex = 0;
            this.labelArrayRange.Text = "Діапазон";
            // 
            // SortingParam
            // 
            this.SortingParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.SortingParam.Controls.Add(this.SortingShellSequence);
            this.SortingParam.Controls.Add(this.SortAscOrDesc);
            this.SortingParam.Location = new System.Drawing.Point(18, 447);
            this.SortingParam.Name = "SortingParam";
            this.SortingParam.Size = new System.Drawing.Size(525, 252);
            this.SortingParam.TabIndex = 3;
            this.SortingParam.TabStop = false;
            this.SortingParam.Text = "Параметри сортування";
            // 
            // SortingShellSequence
            // 
            this.SortingShellSequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(253)))));
            this.SortingShellSequence.Controls.Add(this.radioButtonSortTokuda);
            this.SortingShellSequence.Controls.Add(this.radioButtonDortFibonacci);
            this.SortingShellSequence.Controls.Add(this.radioButtonSortSedgwick);
            this.SortingShellSequence.Controls.Add(this.radioButtonSortClassic);
            this.SortingShellSequence.Location = new System.Drawing.Point(289, 55);
            this.SortingShellSequence.Name = "SortingShellSequence";
            this.SortingShellSequence.Size = new System.Drawing.Size(200, 154);
            this.SortingShellSequence.TabIndex = 1;
            this.SortingShellSequence.TabStop = false;
            this.SortingShellSequence.Text = "Вид сортування Шелла";
            // 
            // radioButtonSortTokuda
            // 
            this.radioButtonSortTokuda.AutoSize = true;
            this.radioButtonSortTokuda.Location = new System.Drawing.Point(6, 117);
            this.radioButtonSortTokuda.Name = "radioButtonSortTokuda";
            this.radioButtonSortTokuda.Size = new System.Drawing.Size(189, 21);
            this.radioButtonSortTokuda.TabIndex = 5;
            this.radioButtonSortTokuda.Text = "Послідовність Токуда";
            this.radioButtonSortTokuda.UseVisualStyleBackColor = true;
            this.radioButtonSortTokuda.CheckedChanged += new System.EventHandler(this.radioButtonSortTokuda_CheckedChanged);
            // 
            // radioButtonDortFibonacci
            // 
            this.radioButtonDortFibonacci.AutoSize = true;
            this.radioButtonDortFibonacci.Location = new System.Drawing.Point(6, 89);
            this.radioButtonDortFibonacci.Name = "radioButtonDortFibonacci";
            this.radioButtonDortFibonacci.Size = new System.Drawing.Size(205, 21);
            this.radioButtonDortFibonacci.TabIndex = 4;
            this.radioButtonDortFibonacci.Text = "Послідовність Фібоначі";
            this.radioButtonDortFibonacci.UseVisualStyleBackColor = true;
            this.radioButtonDortFibonacci.CheckedChanged += new System.EventHandler(this.radioButtonDortFibonacci_CheckedChanged);
            // 
            // radioButtonSortSedgwick
            // 
            this.radioButtonSortSedgwick.AutoSize = true;
            this.radioButtonSortSedgwick.Location = new System.Drawing.Point(6, 62);
            this.radioButtonSortSedgwick.Name = "radioButtonSortSedgwick";
            this.radioButtonSortSedgwick.Size = new System.Drawing.Size(205, 21);
            this.radioButtonSortSedgwick.TabIndex = 3;
            this.radioButtonSortSedgwick.Text = "Послідовність Седжвіка";
            this.radioButtonSortSedgwick.UseVisualStyleBackColor = true;
            this.radioButtonSortSedgwick.CheckedChanged += new System.EventHandler(this.radioButtonSortSedgwick_CheckedChanged);
            // 
            // radioButtonSortClassic
            // 
            this.radioButtonSortClassic.AutoSize = true;
            this.radioButtonSortClassic.Checked = true;
            this.radioButtonSortClassic.Location = new System.Drawing.Point(6, 34);
            this.radioButtonSortClassic.Name = "radioButtonSortClassic";
            this.radioButtonSortClassic.Size = new System.Drawing.Size(93, 21);
            this.radioButtonSortClassic.TabIndex = 2;
            this.radioButtonSortClassic.TabStop = true;
            this.radioButtonSortClassic.Text = "Класичне";
            this.radioButtonSortClassic.UseVisualStyleBackColor = true;
            this.radioButtonSortClassic.CheckedChanged += new System.EventHandler(this.radioButtonSortClassic_CheckedChanged);
            // 
            // SortAscOrDesc
            // 
            this.SortAscOrDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(253)))));
            this.SortAscOrDesc.Controls.Add(this.radioButtonSortDesc);
            this.SortAscOrDesc.Controls.Add(this.radioButtonSortAsc);
            this.SortAscOrDesc.Location = new System.Drawing.Point(20, 55);
            this.SortAscOrDesc.Name = "SortAscOrDesc";
            this.SortAscOrDesc.Size = new System.Drawing.Size(200, 138);
            this.SortAscOrDesc.TabIndex = 0;
            this.SortAscOrDesc.TabStop = false;
            this.SortAscOrDesc.Text = "Порядок сортування";
            // 
            // radioButtonSortDesc
            // 
            this.radioButtonSortDesc.AutoSize = true;
            this.radioButtonSortDesc.Location = new System.Drawing.Point(19, 62);
            this.radioButtonSortDesc.Name = "radioButtonSortDesc";
            this.radioButtonSortDesc.Size = new System.Drawing.Size(125, 21);
            this.radioButtonSortDesc.TabIndex = 1;
            this.radioButtonSortDesc.Text = "За спаданням";
            this.radioButtonSortDesc.UseVisualStyleBackColor = true;
            this.radioButtonSortDesc.CheckedChanged += new System.EventHandler(this.radioButtonSortDesc_CheckedChanged);
            // 
            // radioButtonSortAsc
            // 
            this.radioButtonSortAsc.AutoSize = true;
            this.radioButtonSortAsc.Checked = true;
            this.radioButtonSortAsc.Location = new System.Drawing.Point(19, 34);
            this.radioButtonSortAsc.Name = "radioButtonSortAsc";
            this.radioButtonSortAsc.Size = new System.Drawing.Size(133, 21);
            this.radioButtonSortAsc.TabIndex = 0;
            this.radioButtonSortAsc.TabStop = true;
            this.radioButtonSortAsc.Text = "За зростанням";
            this.radioButtonSortAsc.UseVisualStyleBackColor = true;
            this.radioButtonSortAsc.CheckedChanged += new System.EventHandler(this.radioButtonSortAsc_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Кількість порівнянь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Кількість перестановок";
            // 
            // labelComarisons
            // 
            this.labelComarisons.AutoSize = true;
            this.labelComarisons.Location = new System.Drawing.Point(220, 45);
            this.labelComarisons.Name = "labelComarisons";
            this.labelComarisons.Size = new System.Drawing.Size(0, 17);
            this.labelComarisons.TabIndex = 10;
            // 
            // labelSwaps
            // 
            this.labelSwaps.AutoSize = true;
            this.labelSwaps.Location = new System.Drawing.Point(220, 120);
            this.labelSwaps.Name = "labelSwaps";
            this.labelSwaps.Size = new System.Drawing.Size(0, 17);
            this.labelSwaps.TabIndex = 11;
            // 
            // buttonStartSort
            // 
            this.buttonStartSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.buttonStartSort.Location = new System.Drawing.Point(679, 447);
            this.buttonStartSort.Name = "buttonStartSort";
            this.buttonStartSort.Size = new System.Drawing.Size(140, 42);
            this.buttonStartSort.TabIndex = 12;
            this.buttonStartSort.Text = "Сортувати";
            this.buttonStartSort.UseVisualStyleBackColor = false;
            this.buttonStartSort.Click += new System.EventHandler(this.ButtonStartSort_Click);
            // 
            // SaveMessageLabel
            // 
            this.SaveMessageLabel.Font = new System.Drawing.Font("Cascadia Code", 7F);
            this.SaveMessageLabel.Location = new System.Drawing.Point(15, 712);
            this.SaveMessageLabel.Name = "SaveMessageLabel";
            this.SaveMessageLabel.Size = new System.Drawing.Size(897, 49);
            this.SaveMessageLabel.TabIndex = 13;
            // 
            // groupBoxCompAndSwaps
            // 
            this.groupBoxCompAndSwaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(253)))));
            this.groupBoxCompAndSwaps.Controls.Add(this.labelSwaps);
            this.groupBoxCompAndSwaps.Controls.Add(this.labelComarisons);
            this.groupBoxCompAndSwaps.Controls.Add(this.label2);
            this.groupBoxCompAndSwaps.Controls.Add(this.label1);
            this.groupBoxCompAndSwaps.Location = new System.Drawing.Point(582, 519);
            this.groupBoxCompAndSwaps.Name = "groupBoxCompAndSwaps";
            this.groupBoxCompAndSwaps.Size = new System.Drawing.Size(330, 180);
            this.groupBoxCompAndSwaps.TabIndex = 14;
            this.groupBoxCompAndSwaps.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(938, 769);
            this.Controls.Add(this.groupBoxCompAndSwaps);
            this.Controls.Add(this.SaveMessageLabel);
            this.Controls.Add(this.buttonStartSort);
            this.Controls.Add(this.SortingParam);
            this.Controls.Add(this.ArrayGenerator);
            this.Controls.Add(this.InputError);
            this.Controls.Add(this.textBoxArray);
            this.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Shell Sort";
            this.ArrayGenerator.ResumeLayout(false);
            this.ArrayGenerator.PerformLayout();
            this.TypeOfGeneration.ResumeLayout(false);
            this.TypeOfGeneration.PerformLayout();
            this.SortingParam.ResumeLayout(false);
            this.SortingShellSequence.ResumeLayout(false);
            this.SortingShellSequence.PerformLayout();
            this.SortAscOrDesc.ResumeLayout(false);
            this.SortAscOrDesc.PerformLayout();
            this.groupBoxCompAndSwaps.ResumeLayout(false);
            this.groupBoxCompAndSwaps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArray;
        private System.Windows.Forms.Label InputError;
        private System.Windows.Forms.GroupBox ArrayGenerator;
        private System.Windows.Forms.GroupBox TypeOfGeneration;
        private System.Windows.Forms.Label Desh;
        private System.Windows.Forms.Label labelArrayRange;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.RadioButton radioButtonGeneratorDescending;
        private System.Windows.Forms.RadioButton radioButtonGeneratorAscending;
        private System.Windows.Forms.TextBox textBoxGenerateUpperBound;
        private System.Windows.Forms.TextBox textBoxGenerateLowerBound;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.GroupBox SortingParam;
        private System.Windows.Forms.GroupBox SortingShellSequence;
        private System.Windows.Forms.GroupBox SortAscOrDesc;
        private System.Windows.Forms.RadioButton radioButtonSortTokuda;
        private System.Windows.Forms.RadioButton radioButtonDortFibonacci;
        private System.Windows.Forms.RadioButton radioButtonSortSedgwick;
        private System.Windows.Forms.RadioButton radioButtonSortClassic;
        private System.Windows.Forms.RadioButton radioButtonSortDesc;
        private System.Windows.Forms.RadioButton radioButtonSortAsc;
        private System.Windows.Forms.Label labelGenerateNumOfElem;
        private System.Windows.Forms.TextBox textBoxGenerateNumOfElem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelComarisons;
        private System.Windows.Forms.Label labelSwaps;
        private System.Windows.Forms.Button buttonStartSort;
        private System.Windows.Forms.Label GenerateParamError;
        private System.Windows.Forms.Label SaveMessageLabel;
        private System.Windows.Forms.GroupBox groupBoxCompAndSwaps;
    }
}

