using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class MainWindow : Form
    {
        Oscilogram osc;
        ChannelsInfo info;
        public string filename;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void HelpClick(object sender, EventArgs e)
        {
            MessageBox.Show("Название программы: DSP\n\nРазработчики:\n Гореев Марат\n Сарьян Дмитрий\n Скопин Семен\n Пушкарев Алексей\n", "Справка");
        }
        
        private void OpenClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog.FileName;
            string[] array = File.ReadAllLines(filename, Encoding.Default);
            osc = new Oscilogram(array);
            osc.Show();

        }

        private void InfoClick(object sender, EventArgs e)
        {
            info = new ChannelsInfo(osc.ChannelsNumber, osc.SamplesNumber, osc.SamplingRate, osc.StartDate, osc.StartTime, osc.ChannelsNames, filename);
            info.Show();
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {
            HelpToolStripMenuItem.Click += HelpClick;

            OpenToolStripMenuItem.Click += OpenClick;

            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
