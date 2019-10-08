using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FLogin : Form
    {

        private Point MouseOff;

        private bool IsMouseDown = false;

        private static FLogin _Instancia;

        public static FLogin GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FLogin();
            }
            return _Instancia;
        }

        public FLogin()
        {
            InitializeComponent();
            EventoConboBox();
            ListarUsuario();
            TxtClave.Focus();
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EventoConboBox()
        {
            DataTable DtUsuario = EUsuario.Mostrar();
            for (int i = 0; i <= Convert.ToInt32(DtUsuario.Rows.Count) - 1; i++)
            {
                TxtCod_usuario.Items.Add(DtUsuario.Rows[i][0].ToString());
            }
        }

        public void ListarUsuario()
        {
            try
            {
                DataSet DsListarUsuario = EUsuario.Listar();

                TxtCod_usuario.Text = DsListarUsuario.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_mapa.Text = DsListarUsuario.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtDesc_usuario.Text = DsListarUsuario.Tables[0].Rows[0]["desc_usuario"].ToString();
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }

        private void SeleccionarUsuario()
        {
            DataSet DsSelecUsuario = EUsuario.SelecUsuario(TxtCod_usuario.Text);
            TxtCod_usuario.Text = DsSelecUsuario.Tables[0].Rows[0]["cod_usuario"].ToString();
            TxtDesc_usuario.Text = DsSelecUsuario.Tables[0].Rows[0]["desc_usuario"].ToString();
            TxtCod_mapa.Text = DsSelecUsuario.Tables[0].Rows[0]["cod_mapa"].ToString();
        }

        private void ValidarLogin()
        {
            DataTable DsDatos = EUsuario.Login(TxtCod_usuario.Text, TxtClave.Text);
            AManager mAManager = AManager.GetAManager();

            if (DsDatos.Rows.Count == 0)
            {
                MensajeError("Clave Incorrecta, Intente Nuevamente!");
                TxtClave.Focus();
                TxtClave.Text = string.Empty;
            }
            else
            {
                Hide();
                mAManager.UsuarioLog();
                mAManager.ValidadAcceso();
                mAManager.Show();
                TxtClave.Text = string.Empty;
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            TxtClave.Focus();
        }

        #region MOVER SIN BORDES

        private void FLogin_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                MouseOff = new Point(xOffset, yOffset);
                IsMouseDown = true;
            }
        }

        private void FLogin_MouseUp(object sender, MouseEventArgs e)
        {
            // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button == MouseButtons.Left)
            {
                IsMouseDown = false;
            }
        }

        private void FLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                Point mousePos = MousePosition;
                mousePos.Offset(MouseOff.X, MouseOff.Y);
                Location = mousePos;
            }
        }
        #endregion

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ValidarLogin();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtCod_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarUsuario();
        }

        private void TxtClave_TextChanged(object sender, EventArgs e)
        {
            if (TxtClave.Text != string.Empty)
            {
                BtnAceptar.Enabled = true;
                TxtClave.Focus();
            }
        }

        private void BtnCancelar2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            AManager mAManager = AManager.GetAManager();
            mAManager.Close();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void TxtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                BtnAceptar.Focus();
            }
        }
    }
}
