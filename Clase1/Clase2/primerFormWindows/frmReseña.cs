
using primerFormWindows.Entidad;

namespace primerFormWindows
{
    public partial class frmReseña : Form
    {
        public frmReseña()
        {
            InitializeComponent();
            cargarPuntuacion();
        }

        private void cargarPuntuacion()
        {
            cboPuntuacion.Items.Clear();
            cboPuntuacion.Items.Add("1");
            cboPuntuacion.Items.Add("2");
            cboPuntuacion.Items.Add("3");
            cboPuntuacion.Items.Add("4");
            cboPuntuacion.Items.Add("5");
            cboPuntuacion.Items.Add("6");
            cboPuntuacion.Items.Add("7");
            cboPuntuacion.Items.Add("8");
            cboPuntuacion.Items.Add("9");
            cboPuntuacion.Items.Add("10");

            cboPuntuacion.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Resenia resenia = new Resenia(
                dtpFecha.Value.ToString("dd/MM/yyyy"),
                txtDireccion.Text,
                cboTipoLocal.SelectedItem.ToString(),
                cboPuntuacion.SelectedItem.ToString()
                );

            //CargarGrillaResenias(resenia);
            EnviarReseniasAApi(resenia);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta frmAlta = new frmAlta();
            frmAlta.Show();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            ObtenerReseniasDeApi();
        }

        private void CargarGrillaResenias(Resenia resenia)
        {
            dgvResenia.Rows.Add(
                resenia.Fecha,
                resenia.Direccion,
                resenia.TipoLocal,
                resenia.Puntuacion
                );
        }

        private async Task EnviarReseniasAApi(Resenia resenia)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(resenia);

            var data = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            using(var client = new HttpClient())
            {
                var response = await client.PostAsync("https://localhost:7258/api/Resenias", data);
            }

        }

        private async Task ObtenerReseniasDeApi()
        {
            using(var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7258/api/Resenias");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var resenias = 
                        System.Text.Json.JsonSerializer.Deserialize<List<Resenia>>(jsonResponse,
                        new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true});
                    foreach (var resenia in resenias)
                    {
                        CargarGrillaResenias(resenia);
                    }
                }
            }
        }
    }


}