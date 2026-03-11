namespace CODE_TP_MODUL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event ini akan dijalankan ketika tombol "Kirim" diklik
        private void btnKirim_Click(object sender, EventArgs e)
        {
            // Mengambil input teks yang dimasukkan user pada TextBox
            string nama = txtNama.Text;

            // Mengecek apakah textbox kosong atau hanya berisi spasi
            if (string.IsNullOrWhiteSpace(nama))
            {
                // Jika kosong maka label akan menampilkan pesan error
                lblOutput.Text = "Nama tidak boleh kosong!";
            }
            else
            {
                // Jika ada input maka program menampilkan pesan halo
                // dan menambahkan nama yang dimasukkan user
                lblOutput.Text = "Halo " + nama;
            }
        }
    }
}

