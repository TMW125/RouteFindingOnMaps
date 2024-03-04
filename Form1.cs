using System.Windows.Forms;

namespace RouteFindingOnMaps
{
    public partial class Form1 : Form
    {
        bool addMarker;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addMarker = false;
        }
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = openFileDialog1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                pictureBox1.Image = image;
                addMarker = true;
            }
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void addMarkerClick(object sender, MouseEventArgs e)
        {
            if (addMarker)
            {
                Label label = new Label();
                label.Location = e.Location;
                label.Text = e.Location.ToString();
                label.BackColor = Color.Transparent;
                pictureBox1.Controls.Add(label);
            }
        }
    }
}
