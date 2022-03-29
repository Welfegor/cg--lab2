
namespace Lab2
{
    partial class MainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationAboutSignalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnaliseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ModellingToolStripMenuItem,
            this.instrumetsToolStripMenuItem,
            this.FilterToolStripMenuItem,
            this.AnaliseToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            // 
            // ModellingToolStripMenuItem
            // 
            this.ModellingToolStripMenuItem.Name = "ModellingToolStripMenuItem";
            this.ModellingToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.ModellingToolStripMenuItem.Text = "Моделирование";
            // 
            // instrumetsToolStripMenuItem
            // 
            this.instrumetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationAboutSignalToolStripMenuItem});
            this.instrumetsToolStripMenuItem.Name = "instrumetsToolStripMenuItem";
            this.instrumetsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.instrumetsToolStripMenuItem.Text = "Инструменты";
            // 
            // informationAboutSignalToolStripMenuItem
            // 
            this.informationAboutSignalToolStripMenuItem.Name = "informationAboutSignalToolStripMenuItem";
            this.informationAboutSignalToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.informationAboutSignalToolStripMenuItem.Text = "Информация о сигнале";
            this.informationAboutSignalToolStripMenuItem.Click += new System.EventHandler(this.InfoClick);
            // 
            // FilterToolStripMenuItem
            // 
            this.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem";
            this.FilterToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.FilterToolStripMenuItem.Text = "Фильтрация";
            // 
            // AnaliseToolStripMenuItem
            // 
            this.AnaliseToolStripMenuItem.Name = "AnaliseToolStripMenuItem";
            this.AnaliseToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.AnaliseToolStripMenuItem.Text = "Анализ";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpToolStripMenuItem.Text = "Справка";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "File";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "DSP-Goreev-Saryan-Skopin-Pushkarev";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModellingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AnaliseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem instrumetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationAboutSignalToolStripMenuItem;
    }
}

