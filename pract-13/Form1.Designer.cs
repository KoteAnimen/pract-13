namespace pract_13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sizeTable = new System.Windows.Forms.ToolStripStatusLabel();
            this.numerBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenTable = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTable = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTable = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateRandomTable = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableNumbers = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.countRows = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.countColumns = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.minNumber = new System.Windows.Forms.NumericUpDown();
            this.contextMenuTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FillTable = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateRandomTableContext = new System.Windows.Forms.ToolStripMenuItem();
            this.answer = new System.Windows.Forms.TextBox();
            this.GetAnswer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuAnswer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GetAnswerContext = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableNumbers)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumber)).BeginInit();
            this.contextMenuTable.SuspendLayout();
            this.contextMenuAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTable,
            this.SaveTable,
            this.ClearTable,
            this.Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutUs});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeTable,
            this.numerBox});
            this.statusStrip1.Location = new System.Drawing.Point(0, 463);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateRandomTable});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sizeTable
            // 
            this.sizeTable.Name = "sizeTable";
            this.sizeTable.Size = new System.Drawing.Size(98, 17);
            this.sizeTable.Text = "Размер таблицы";
            // 
            // numerBox
            // 
            this.numerBox.Name = "numerBox";
            this.numerBox.Size = new System.Drawing.Size(87, 17);
            this.numerBox.Text = "Номер ячейки";
            // 
            // OpenTable
            // 
            this.OpenTable.Name = "OpenTable";
            this.OpenTable.Size = new System.Drawing.Size(180, 22);
            this.OpenTable.Text = "Открыть";
            // 
            // SaveTable
            // 
            this.SaveTable.Name = "SaveTable";
            this.SaveTable.Size = new System.Drawing.Size(180, 22);
            this.SaveTable.Text = "Сохранить";
            // 
            // ClearTable
            // 
            this.ClearTable.Name = "ClearTable";
            this.ClearTable.Size = new System.Drawing.Size(180, 22);
            this.ClearTable.Text = "Очистить";
            // 
            // AboutUs
            // 
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(180, 22);
            this.AboutUs.Text = "О программе";
            // 
            // CreateRandomTable
            // 
            this.CreateRandomTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateRandomTable.Image = ((System.Drawing.Image)(resources.GetObject("CreateRandomTable.Image")));
            this.CreateRandomTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateRandomTable.Name = "CreateRandomTable";
            this.CreateRandomTable.Size = new System.Drawing.Size(23, 22);
            this.CreateRandomTable.Text = "Создать рандомную таблицу";
            this.CreateRandomTable.ToolTipText = "Создать рандомную таблицу";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableNumbers);
            this.groupBox1.Location = new System.Drawing.Point(13, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(13, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 180);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройка таблицы";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.ContextMenuStrip = this.contextMenuAnswer;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.GetAnswer);
            this.groupBox3.Controls.Add(this.answer);
            this.groupBox3.Location = new System.Drawing.Point(448, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 174);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // tableNumbers
            // 
            this.tableNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableNumbers.ContextMenuStrip = this.contextMenuTable;
            this.tableNumbers.Location = new System.Drawing.Point(7, 20);
            this.tableNumbers.Name = "tableNumbers";
            this.tableNumbers.Size = new System.Drawing.Size(762, 194);
            this.tableNumbers.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.countColumns);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.countRows);
            this.groupBox4.Location = new System.Drawing.Point(7, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 112);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Размер таблицы";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.maxNumber);
            this.groupBox5.Controls.Add(this.minNumber);
            this.groupBox5.Location = new System.Drawing.Point(223, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 112);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Диапазон значений";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(115, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Заполнить таблицу";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // countRows
            // 
            this.countRows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countRows.Location = new System.Drawing.Point(7, 35);
            this.countRows.Name = "countRows";
            this.countRows.Size = new System.Drawing.Size(120, 20);
            this.countRows.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество строк";
            // 
            // countColumns
            // 
            this.countColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countColumns.Location = new System.Drawing.Point(7, 81);
            this.countColumns.Name = "countColumns";
            this.countColumns.Size = new System.Drawing.Size(120, 20);
            this.countColumns.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество столбцов";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Максимальное значение";
            // 
            // maxNumber
            // 
            this.maxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxNumber.Location = new System.Drawing.Point(7, 81);
            this.maxNumber.Name = "maxNumber";
            this.maxNumber.Size = new System.Drawing.Size(120, 20);
            this.maxNumber.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Минимальное значение";
            // 
            // minNumber
            // 
            this.minNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minNumber.Location = new System.Drawing.Point(7, 35);
            this.minNumber.Name = "minNumber";
            this.minNumber.Size = new System.Drawing.Size(120, 20);
            this.minNumber.TabIndex = 4;
            // 
            // contextMenuTable
            // 
            this.contextMenuTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FillTable,
            this.CreateRandomTableContext});
            this.contextMenuTable.Name = "contextMenuTable";
            this.contextMenuTable.Size = new System.Drawing.Size(231, 48);
            // 
            // FillTable
            // 
            this.FillTable.Name = "FillTable";
            this.FillTable.Size = new System.Drawing.Size(230, 22);
            this.FillTable.Text = "Заполнить таблицу";
            // 
            // CreateRandomTableContext
            // 
            this.CreateRandomTableContext.Name = "CreateRandomTableContext";
            this.CreateRandomTableContext.Size = new System.Drawing.Size(230, 22);
            this.CreateRandomTableContext.Text = "Создать случайную таблицу";
            // 
            // answer
            // 
            this.answer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer.Location = new System.Drawing.Point(6, 53);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(328, 20);
            this.answer.TabIndex = 0;
            // 
            // GetAnswer
            // 
            this.GetAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GetAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetAnswer.Location = new System.Drawing.Point(6, 81);
            this.GetAnswer.Name = "GetAnswer";
            this.GetAnswer.Size = new System.Drawing.Size(328, 58);
            this.GetAnswer.TabIndex = 1;
            this.GetAnswer.Text = "Получить ответ";
            this.GetAnswer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Количество столбцов, где ячейки упорядочены по убыванию";
            // 
            // contextMenuAnswer
            // 
            this.contextMenuAnswer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetAnswerContext});
            this.contextMenuAnswer.Name = "contextMenuAnswer";
            this.contextMenuAnswer.Size = new System.Drawing.Size(161, 26);
            // 
            // GetAnswerContext
            // 
            this.GetAnswerContext.Name = "GetAnswerContext";
            this.GetAnswerContext.Size = new System.Drawing.Size(160, 22);
            this.GetAnswerContext.Text = "Получить ответ";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "Выход";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 524);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическая №13";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableNumbers)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumber)).EndInit();
            this.contextMenuTable.ResumeLayout(false);
            this.contextMenuAnswer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTable;
        private System.Windows.Forms.ToolStripMenuItem SaveTable;
        private System.Windows.Forms.ToolStripMenuItem ClearTable;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutUs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sizeTable;
        private System.Windows.Forms.ToolStripStatusLabel numerBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CreateRandomTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tableNumbers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown maxNumber;
        private System.Windows.Forms.NumericUpDown minNumber;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown countColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown countRows;
        private System.Windows.Forms.ContextMenuStrip contextMenuTable;
        private System.Windows.Forms.ToolStripMenuItem FillTable;
        private System.Windows.Forms.ToolStripMenuItem CreateRandomTableContext;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GetAnswer;
        private System.Windows.Forms.ContextMenuStrip contextMenuAnswer;
        private System.Windows.Forms.ToolStripMenuItem GetAnswerContext;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

