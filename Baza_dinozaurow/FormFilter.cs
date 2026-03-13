using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Baza_dinozaurow
{
    public partial class FormFilter : Form
    {
        public List<ExtinctAnimal> Animals { get; set; } = new List<ExtinctAnimal>();

        public FormFilter()
        {
            InitializeComponent();
        }

        private void FormFilter_Load(object sender, EventArgs e)
        {
            ShowAnimals(Animals);
        }

        private void ShowAnimals(List<ExtinctAnimal> list)
        {
            listBoxAnimals.DataSource = null;
            listBoxAnimals.DataSource = list;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<ExtinctAnimal> filtered = Animals;

            if (radioTrias.Checked)
                filtered = filtered.Where(a => a.Epoka == "Trias").ToList();
            else if (radioJura.Checked)
                filtered = filtered.Where(a => a.Epoka == "Jura").ToList();
            else if (radioKreda.Checked)
                filtered = filtered.Where(a => a.Epoka == "Kreda").ToList();
            else if (radioKenozoik.Checked)
                filtered = filtered.Where(a => a.Epoka == "Kenozoik").ToList();

            ShowAnimals(filtered);
        }

        private void listBoxZwierzeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExtinctAnimal animal = listBoxAnimals.SelectedItem as ExtinctAnimal;

            if (animal != null)
            {
                labelDetails.Text =
                    "Nazwa: " + animal.Nazwa + Environment.NewLine +
                    "Epoka: " + animal.Epoka + Environment.NewLine +
                    "Miejsce: " + animal.Miejsce_wystepowania;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void listBoxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}