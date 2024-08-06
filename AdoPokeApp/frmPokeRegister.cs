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
    public partial class frmPokeRegister : Form
    {
        public frmPokeRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Pokemon poke = new Pokemon();
            PokeServices service = new PokeServices();

            try
            {
                poke.Number = int.Parse(txbNumber.Text);
                poke.Name = txbName.Text;
                poke.Description = txbDescription.Text;
                poke.UrlImage = txbUrlImage.Text;
                poke.Type = (Element)cboType.SelectedItem;
                poke.Weakness = (Element)cboWeakness.SelectedItem;

                service.add(poke);
                MessageBox.Show("Added successfully");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmPokeRegister_Load(object sender, EventArgs e)
        {
            ElementServices elementService = new ElementServices();
            try
            {
                cboType.DataSource = elementService.list();
                cboWeakness.DataSource = elementService.list();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txbUrlImage_Leave(object sender, EventArgs e)
        {
            loadImage(txbUrlImage.Text);
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
    }
}