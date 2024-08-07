using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain;
using service;
using System.Configuration;


namespace AdoPokeApp
{
    public partial class frmPokeRegister : Form
    {
        private Pokemon pokemon = null;
        private OpenFileDialog file = null;
        public frmPokeRegister()
        {
            InitializeComponent();
        }
        public frmPokeRegister(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modify Pokemon";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            PokeServices service = new PokeServices();

            try
            {
                if(pokemon == null)                
                   pokemon = new Pokemon();
                
                pokemon.Number = int.Parse(txbNumber.Text);
                pokemon.Name = txbName.Text;
                pokemon.Description = txbDescription.Text;
                pokemon.UrlImage = txbUrlImage.Text;
                pokemon.Type = (Element)cboType.SelectedItem;
                pokemon.Weakness = (Element)cboWeakness.SelectedItem;

                if(pokemon.Id != 0)
                {
                    service.modify(pokemon);
                    MessageBox.Show("Modified successfully");
                }
                else
                {
                    service.add(pokemon);
                    MessageBox.Show("Added successfully");
                }     
                
                if(file != null && !(txbUrlImage.Text.ToUpper().Contains("HTTP")))
                    File.Copy(file.FileName, ConfigurationManager.AppSettings["images-folder"] + file.SafeFileName);

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
                cboType.ValueMember = "Id";
                cboType.DisplayMember = "Description";
                cboWeakness.DataSource = elementService.list();
                cboWeakness.ValueMember = "Id";
                cboWeakness.DisplayMember = "Description";

                if (pokemon != null)
                {
                    txbNumber.Text = pokemon.Number.ToString();
                    txbName.Text = pokemon.Name;
                    txbDescription.Text = pokemon.Description;
                    txbUrlImage.Text = pokemon.UrlImage;
                    loadImage(pokemon.UrlImage);
                    cboType.SelectedValue = pokemon.Type.Id;
                    cboWeakness.SelectedValue = pokemon.Weakness.Id;
                    
                
                }
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

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file .Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if(file.ShowDialog() == DialogResult.OK)
            {
                txbUrlImage.Text = file.FileName;
                loadImage(file.FileName);

                //File.Copy(file.FileName, ConfigurationManager.AppSettings["images-folder"] + file.SafeFileName);
            }
        }
    }
}