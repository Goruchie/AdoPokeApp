using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain;
using service;

namespace AdoPokeApp
{
    public partial class AdoPokeApp : Form
    {
        private List<Pokemon> pokeList;
        public AdoPokeApp()
        {
            InitializeComponent();
        }

        private void AdoPokeApp_Load(object sender, EventArgs e)
        {
            PokeServices service = new PokeServices();
            try
            {
                pokeList = service.list();
                dgvPokemons.DataSource = pokeList;
                dgvPokemons.Columns["UrlImage"].Visible = false;
                loadImage(pokeList[0].UrlImage);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon selected = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            loadImage(selected.UrlImage);
        }

        private void loadImage(string image)
        {
            try
            {
                pbxPokemon.Load(image);
            }
            catch (Exception ex)
            {

                pbxPokemon.Load("https://pbs.twimg.com/media/ERPDVqzWAAUwLRl.png");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPokeRegister register = new frmPokeRegister();
            register.ShowDialog();
        }
    }
}
