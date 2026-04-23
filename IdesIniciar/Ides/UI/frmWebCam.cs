using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ides.UI
{
    public partial class frmWebCam : Form
    {
        public string Mensagem(string mensagem, string foto)
        {
            UI.frmMensagem m = new UI.frmMensagem();
            m.mensagem = mensagem;
            m.foto = foto;
            m.ShowDialog();
            return m.sn;
        }

        private bool mover;
        private int cX, cY;
        private int contador = 1;

        //metodos para salvar e tirar foto pela webcan
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
        }

        //metodos para salvar e tirar foto pela webcan
        AForge.Video.DirectShow.VideoCaptureDevice videoSource;

        public frmWebCam()
        {
            InitializeComponent();

            //metodo para salvar e tirar foto pela webcan
            AForge.Video.DirectShow.FilterInfoCollection videosources = new AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);

            //metodo para tirar e salvar foto pela webcan
            try
            {
                if (videosources != null)
                {
                    videoSource = new AForge.Video.DirectShow.VideoCaptureDevice(videosources[0].MonikerString);
                    videoSource.NewFrame += (s, e) => ptbCaptura.Image = (Bitmap)e.Frame.Clone();
                    videoSource.Start();
                }
            }
            catch
            {
                Mensagem("O SEU COMPUTADOR NÃO POSSUI WEBCAM", "error");
                return;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ptbCaptura.Image.Save(string.Format("snapshot-{0}.png", contador++), System.Drawing.Imaging.ImageFormat.Png);
            videoSource.SignalToStop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoSource.Start();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTituloWebCam_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

        private void lblTituloWebCam_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }

        private void lblTituloWebCam_MouseUp(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - pnlTitulo.Left);
                this.Top += e.Y - (cY - pnlTitulo.Top);
            }
        }


    }  
}
