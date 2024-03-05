using System.Windows.Forms;

namespace RouteFindingOnMaps
{
    public partial class Form1 : Form
    {
        private bool addMarker;
        private List<Point> markers;
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
                mapImage.Image = image;
                mapImage.SizeMode = PictureBoxSizeMode.StretchImage;
                addMarker = true;
                markers = new List<Point>();
            }
        }
        private void addMarkerClick(object sender, MouseEventArgs e)
        {
            if (addMarker)
            {
                Label label = new Label();
                label.Location = e.Location;
                label.Text = e.Location.ToString();
                label.BackColor = Color.Transparent;
                mapImage.Controls.Add(label);
                markers.Add(e.Location);
            }
        }
        private void clearMarkers(object sender, EventArgs e)
        {
            mapImage.Controls.Clear();
        }
        private void findShortestPath(object sender, EventArgs e)
        {
            if (addMarker)
            {
                foreach (Point mark in markers)
                {
                    
                }
            }
        }
    }
}
