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
                Name = "Mamut włochaty",
                Epoch = "Kenozoik",
                Place = "Europa"
            });

            animals.Add(new ExtinctAnimal
            {
                Name = "Smilodon",
                Epoch = "Kenozoik",
                Place = "Ameryka Północna"
            });

            animals.Add(new ExtinctAnimal
            {
                Name = "Tyrannosaurus rex",
                Epoch = "Kreda",
                Place = "Ameryka Północna"
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
