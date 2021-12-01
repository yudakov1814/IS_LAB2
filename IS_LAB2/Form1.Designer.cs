
namespace IS_LAB2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WordLabel = new System.Windows.Forms.Label();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.SizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.IterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IterLabel = new System.Windows.Forms.Label();
            this.MutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MutLabel = new System.Windows.Forms.Label();
            this.BestLabel = new System.Windows.Forms.Label();
            this.BestNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.run = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.CurrentWord = new System.Windows.Forms.Label();
            this.CurWordLabel = new System.Windows.Forms.Label();
            this.CurIterNumLabel = new System.Windows.Forms.Label();
            this.CurIterNum = new System.Windows.Forms.Label();
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IterNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX2.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY2.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(0, 0);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "сходимость";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(576, 450);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Location = new System.Drawing.Point(582, 15);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(38, 13);
            this.WordLabel.TabIndex = 1;
            this.WordLabel.Text = "Слово";
            // 
            // WordTextBox
            // 
            this.WordTextBox.Location = new System.Drawing.Point(776, 12);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(120, 20);
            this.WordTextBox.TabIndex = 2;
            this.WordTextBox.Text = "МИР";
            // 
            // SizeNumericUpDown
            // 
            this.SizeNumericUpDown.Location = new System.Drawing.Point(776, 38);
            this.SizeNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SizeNumericUpDown.Name = "SizeNumericUpDown";
            this.SizeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.SizeNumericUpDown.TabIndex = 3;
            this.SizeNumericUpDown.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(582, 40);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(102, 13);
            this.SizeLabel.TabIndex = 4;
            this.SizeLabel.Text = "Размер популяции";
            // 
            // IterNumericUpDown
            // 
            this.IterNumericUpDown.Location = new System.Drawing.Point(776, 64);
            this.IterNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.IterNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IterNumericUpDown.Name = "IterNumericUpDown";
            this.IterNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IterNumericUpDown.TabIndex = 5;
            this.IterNumericUpDown.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // IterLabel
            // 
            this.IterLabel.AutoSize = true;
            this.IterLabel.Location = new System.Drawing.Point(582, 66);
            this.IterLabel.Name = "IterLabel";
            this.IterLabel.Size = new System.Drawing.Size(166, 13);
            this.IterLabel.TabIndex = 6;
            this.IterLabel.Text = "Максимальное число итераций";
            // 
            // MutNumericUpDown
            // 
            this.MutNumericUpDown.DecimalPlaces = 2;
            this.MutNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MutNumericUpDown.Location = new System.Drawing.Point(776, 90);
            this.MutNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MutNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MutNumericUpDown.Name = "MutNumericUpDown";
            this.MutNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MutNumericUpDown.TabIndex = 7;
            this.MutNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // MutLabel
            // 
            this.MutLabel.AutoSize = true;
            this.MutLabel.Location = new System.Drawing.Point(582, 92);
            this.MutLabel.Name = "MutLabel";
            this.MutLabel.Size = new System.Drawing.Size(117, 13);
            this.MutLabel.TabIndex = 8;
            this.MutLabel.Text = "Вероятность мутации";
            // 
            // BestLabel
            // 
            this.BestLabel.AutoSize = true;
            this.BestLabel.Location = new System.Drawing.Point(582, 118);
            this.BestLabel.Name = "BestLabel";
            this.BestLabel.Size = new System.Drawing.Size(111, 13);
            this.BestLabel.TabIndex = 9;
            this.BestLabel.Text = "Доля лучших особей";
            // 
            // BestNumericUpDown
            // 
            this.BestNumericUpDown.DecimalPlaces = 2;
            this.BestNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.BestNumericUpDown.Location = new System.Drawing.Point(776, 116);
            this.BestNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BestNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.BestNumericUpDown.Name = "BestNumericUpDown";
            this.BestNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.BestNumericUpDown.TabIndex = 10;
            this.BestNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(711, 160);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 11;
            this.run.Text = "Старт";
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // CurrentWord
            // 
            this.CurrentWord.AutoSize = true;
            this.CurrentWord.Location = new System.Drawing.Point(690, 193);
            this.CurrentWord.Name = "CurrentWord";
            this.CurrentWord.Size = new System.Drawing.Size(10, 13);
            this.CurrentWord.TabIndex = 12;
            this.CurrentWord.Text = " ";
            // 
            // CurWordLabel
            // 
            this.CurWordLabel.AutoSize = true;
            this.CurWordLabel.Location = new System.Drawing.Point(585, 193);
            this.CurWordLabel.Name = "CurWordLabel";
            this.CurWordLabel.Size = new System.Drawing.Size(85, 13);
            this.CurWordLabel.TabIndex = 13;
            this.CurWordLabel.Text = "Текущее слово";
            // 
            // CurIterNumLabel
            // 
            this.CurIterNumLabel.AutoSize = true;
            this.CurIterNumLabel.Location = new System.Drawing.Point(585, 217);
            this.CurIterNumLabel.Name = "CurIterNumLabel";
            this.CurIterNumLabel.Size = new System.Drawing.Size(91, 13);
            this.CurIterNumLabel.TabIndex = 14;
            this.CurIterNumLabel.Text = "Номер итерации";
            // 
            // CurIterNum
            // 
            this.CurIterNum.AutoSize = true;
            this.CurIterNum.Location = new System.Drawing.Point(690, 217);
            this.CurIterNum.Name = "CurIterNum";
            this.CurIterNum.Size = new System.Drawing.Size(13, 13);
            this.CurIterNum.TabIndex = 15;
            this.CurIterNum.Text = "0";
            // 
            // LogListBox
            // 
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.Location = new System.Drawing.Point(585, 258);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(311, 186);
            this.LogListBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Лог";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogListBox);
            this.Controls.Add(this.CurIterNum);
            this.Controls.Add(this.CurIterNumLabel);
            this.Controls.Add(this.CurWordLabel);
            this.Controls.Add(this.CurrentWord);
            this.Controls.Add(this.run);
            this.Controls.Add(this.BestNumericUpDown);
            this.Controls.Add(this.BestLabel);
            this.Controls.Add(this.MutLabel);
            this.Controls.Add(this.MutNumericUpDown);
            this.Controls.Add(this.IterLabel);
            this.Controls.Add(this.IterNumericUpDown);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.SizeNumericUpDown);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.Chart);
            this.Name = "Form1";
            this.Text = "Генерация слова";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IterNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.NumericUpDown SizeNumericUpDown;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.NumericUpDown IterNumericUpDown;
        private System.Windows.Forms.Label IterLabel;
        private System.Windows.Forms.NumericUpDown MutNumericUpDown;
        private System.Windows.Forms.Label MutLabel;
        private System.Windows.Forms.Label BestLabel;
        private System.Windows.Forms.NumericUpDown BestNumericUpDown;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label CurrentWord;
        private System.Windows.Forms.Label CurWordLabel;
        private System.Windows.Forms.Label CurIterNumLabel;
        private System.Windows.Forms.Label CurIterNum;
        private System.Windows.Forms.ListBox LogListBox;
        private System.Windows.Forms.Label label1;
    }
}

