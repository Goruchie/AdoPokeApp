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
            load();
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon selected = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            loadImage(selected.UrlImage);
        }

        private void load()
        {
            PokeServices service = new PokeServices();
            try
            {
                pokeList = service.list();
                dgvPokemons.DataSource = pokeList;
                dgvPokemons.Columns["UrlImage"].Visible = false;
                dgvPokemons.Columns["Id"].Visible = false;
                loadImage(pokeList[0].UrlImage);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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
            load();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Pokemon selected;
            selected = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

            frmPokeRegister modify = new frmPokeRegister(selected);
            modify.ShowDialog();
            load();
        }

        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnDeleteL_Click(object sender, EventArgs e)
        {
            delete(true);
        }
        
        private void delete(bool logically = false)
        {
            PokeServices service = new PokeServices();
            Pokemon selected;
            try
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to delete this Pokemon?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    selected = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

                    if(logically)
                        service.deleteLogically(selected.Id);
                    else
                        service.delete(selected.Id);
                    load();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
