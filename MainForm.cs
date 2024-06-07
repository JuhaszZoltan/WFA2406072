namespace WFA2406072
{
    public partial class MainForm : Form
    {
        private Color oBckCol;
        private string oFrmTxt;
        private string oBtnTxt;

        public MainForm()
        {
            InitializeComponent();

            oBckCol = this.BackColor;
            oFrmTxt = this.Text;
            oBtnTxt = btn.Text;

            pbxBlue.Click += PictureBox_Click;
            pbxCrimson.Click += PictureBox_Click;
            pbxGold.Click += PictureBox_Click;
            pbxGreen.Click += PictureBox_Click;
            pbxMagenta.Click += PictureBox_Click;
            pbxSky.Click += PictureBox_Click;
        }

        private void PictureBox_Click(object? sender, EventArgs e)
        {
            this.BackColor = (sender as PictureBox).BackColor;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            btn.Text = btn.Text.ToUpper();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"x:= {Cursor.Position.X}; y:= {Cursor.Position.Y}";
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = oBckCol;
            this.Text = oFrmTxt;
            btn.Text = oBtnTxt;
        }
    }
}
