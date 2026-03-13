using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baza_dinozaurow
{
    public partial class MainForm : Form
    {
        private List<ExtinctAnimal> animals = new List<ExtinctAnimal>(); 
        public MainForm()
        {
            InitializeComponent();
            AddStartData();
            RefreshGrid();
        }
        private void AddStartData()
        {
            animals.Add(new ExtinctAnimal
            {
                Nazwa = "Mamut wlochaty",
                Epoka = "Kenozoik",
                Miejsce_wystepowania = "Europa"
            });

            animals.Add(new ExtinctAnimal
            {
                Nazwa = "Smilodon",
                Epoka = "Kenozoik",
                Miejsce_wystepowania = "Ameryka Polnocna"
            });

            animals.Add(new ExtinctAnimal
            {
                Nazwa = "Tyrannosaurus rex",
                Epoka = "Kreda",
                Miejsce_wystepowania = "Ameryka Polnocna"
            });
        }

        private void RefreshGrid()
        {
            dataGridViewAnimals.DataSource = null;
            dataGridViewAnimals.DataSource = animals;
        }

        private void buttonOpenAdd_Click(object sender, EventArgs e)
        {
            Form1 addForm = new Form1(animals);
            addForm.ShowDialog();
            RefreshGrid();
        }

        private void buttonOpenFilter_Click(object sender, EventArgs e)
        {
            FormFilter filterForm = new FormFilter();
            filterForm.Animals = animals;
            filterForm.ShowDialog();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
