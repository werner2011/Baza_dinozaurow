using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Baza_dinozaurow
{
    public partial class Form1 : Form
    {
        private List<ExtinctAnimal> animals;

        public Form1()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        public Form1(List<ExtinctAnimal> animals) : this()
        {
            this.animals = animals;
        }

        private void FillComboBoxes()
        {
            comboBoxEpoch.Items.Clear();
            comboBoxEpoch.Items.Add("Trias");
            comboBoxEpoch.Items.Add("Jura");
            comboBoxEpoch.Items.Add("Kreda");
            comboBoxEpoch.Items.Add("Kenozoik");

            comboBoxPlace.Items.Clear();
            comboBoxPlace.Items.Add("Europa");
            comboBoxPlace.Items.Add("Azja");
            comboBoxPlace.Items.Add("Afryka");
            comboBoxPlace.Items.Add("Ameryka Północna");
            comboBoxPlace.Items.Add("Ameryka Południowa");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                comboBoxEpoch.SelectedItem == null ||
                comboBoxPlace.SelectedItem == null)
            {
                MessageBox.Show("Uzupełnij wszystkie pola.");
                return;
            }

            ExtinctAnimal animal = new ExtinctAnimal
            {
                Name = textBoxName.Text,
                Epoch = comboBoxEpoch.SelectedItem.ToString(),
                Place = comboBoxPlace.SelectedItem.ToString()
            };

            if (animals != null)
            {
                animals.Add(animal);
            }

            MessageBox.Show("Dodano zwierzę.");
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
