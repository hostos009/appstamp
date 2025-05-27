using collectionofstamp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace collectionofstamp
{
    public partial class MainForm : Form
    {
        private List<Stamp> stamps = new List<Stamp>();
        private List<Collector> collectors = new List<Collector>();
        private List<Stamp> myCollection = new List<Stamp>();

        public MainForm()
        {
            InitializeComponent();
            DataManager.CheckAndCreateFiles();
            (stamps, collectors, myCollection) = DataManager.LoadData();
            DisplayData();
        }

        private void SaveData()
        {
            try
            {
                DataManager.SaveData(stamps, collectors, myCollection);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження даних: {ex.Message}");
            }
        }

        private void DisplayData()
        {
            DisplayManager.DisplayAllStamps(dataGridViewStamps, stamps);
            dataGridViewStamps.ClearSelection();
            DisplayManager.DisplayAllCollectors(dataGridViewCollectors, collectors);
            dataGridViewCollectors.ClearSelection();
            DisplayManager.DisplayAllMyCollection(dataGridViewMy, myCollection);
            dataGridViewMy.ClearSelection();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddActions.AddStamp(
                stamps,
                txtBoxNaming, txtBoxCountry, txtBoxPrice, txtBoxYear, txtBoxCirculation, txtBoxFeatures,
                SaveData,
                () => DisplayManager.DisplayAllStamps(dataGridViewStamps, stamps));
        }

        private void buttonAddCollectors_Click(object sender, EventArgs e)
        {
            AddActions.AddCollector(
                collectors,
                txtBoxCountryCollectors, txtBoxNameCollectors, txtBoxContactCollectors, txtBoxRareCollectors,
                SaveData,
                () => DisplayManager.DisplayAllCollectors(dataGridViewCollectors, collectors));
        }

        private void buttonAddMyCollection_Click(object sender, EventArgs e)
        {
            AddActions.AddToMyCollection(
                stamps, myCollection, dataGridViewStamps,
                txtBoxNaming, txtBoxCountry, txtBoxPrice, txtBoxYear, txtBoxCirculation, txtBoxFeatures,
                SaveData,
                () => DisplayManager.DisplayAllMyCollection(dataGridViewMy, myCollection));
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchActions.SearchStamps(
                stamps, dataGridViewStamps,
                txtBoxNaming, txtBoxCountry, txtBoxPrice, txtBoxYear, txtBoxCirculation, txtBoxFeatures,
                () => DisplayManager.DisplayAllStamps(dataGridViewStamps, stamps));
        }

        private void buttonSearchCollectors_Click(object sender, EventArgs e)
        {
            SearchActions.SearchCollectors(
                collectors, dataGridViewCollectors,
                txtBoxCountryCollectors, txtBoxNameCollectors, txtBoxContactCollectors, txtBoxRareCollectors,
                () => DisplayManager.DisplayAllCollectors(dataGridViewCollectors, collectors));
        }

        private void buttonSearchMy_Click(object sender, EventArgs e)
        {
            SearchActions.SearchMyCollection(
                myCollection, dataGridViewMy,
                txtBoxNamingMy, txtBoxCountryMy, txtBoxPriceMy, txtBoxYearMy, txtBoxCirculationMy, txtBoxFeaturesMy,
                () => DisplayManager.DisplayAllMyCollection(dataGridViewMy, myCollection));
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveActions.RemoveFromMyCollection(
                myCollection, dataGridViewMy,
                txtBoxNamingMy, txtBoxCountryMy, txtBoxPriceMy, txtBoxYearMy, txtBoxCirculationMy, txtBoxFeaturesMy,
                SaveData,
                () => DisplayManager.DisplayAllMyCollection(dataGridViewMy, myCollection));
        }

        private void buttonEditStamp_Click(object sender, EventArgs e)
        {
            EditActions.EditStamp(
                stamps, myCollection, dataGridViewStamps,
                txtBoxNaming, txtBoxCountry, txtBoxPrice, txtBoxYear, txtBoxCirculation, txtBoxFeatures,
                SaveData,
                () => DisplayManager.DisplayAllStamps(dataGridViewStamps, stamps),
                () => DisplayManager.DisplayAllMyCollection(dataGridViewMy, myCollection));
        }

        private void buttonEditCollectors_Click(object sender, EventArgs e)
        {
            EditActions.EditCollector(
                collectors, dataGridViewCollectors,
                txtBoxCountryCollectors, txtBoxNameCollectors, txtBoxContactCollectors, txtBoxRareCollectors,
                SaveData,
                () => DisplayManager.DisplayAllCollectors(dataGridViewCollectors, collectors));
        }

        private void dataGridViewStamps_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStamps.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewStamps.SelectedRows[0];
                txtBoxNaming.Text = selectedRow.Cells["nameStampColumn"].Value?.ToString();
                txtBoxCountry.Text = selectedRow.Cells["countryStampColumn"].Value?.ToString();
                txtBoxPrice.Text = selectedRow.Cells["priceStampColumn"].Value?.ToString();
                txtBoxYear.Text = selectedRow.Cells["yearStampColumn"].Value?.ToString();
                txtBoxCirculation.Text = selectedRow.Cells["circulationStampColumn"].Value?.ToString();
                txtBoxFeatures.Text = selectedRow.Cells["featuresStampColumn"].Value?.ToString();
            }
        }

        private void dataGridViewCollectors_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCollectors.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCollectors.SelectedRows[0];
                txtBoxCountryCollectors.Text = selectedRow.Cells["countryCollectorColumn"].Value?.ToString();
                txtBoxNameCollectors.Text = selectedRow.Cells["nameCollectorColumn"].Value?.ToString();
                txtBoxContactCollectors.Text = selectedRow.Cells["contactCollectorColumn"].Value?.ToString();
                txtBoxRareCollectors.Text = selectedRow.Cells["rareStampsCollectorColumn"].Value?.ToString();
            }
        }

        private void dataGridViewMy_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMy.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMy.SelectedRows[0];
                txtBoxNamingMy.Text = selectedRow.Cells["nameMyColumn"].Value?.ToString();
                txtBoxCountryMy.Text = selectedRow.Cells["countryMyColumn"].Value?.ToString();
                txtBoxPriceMy.Text = selectedRow.Cells["priceMyColumn"].Value?.ToString();
                txtBoxYearMy.Text = selectedRow.Cells["yearMyColumn"].Value?.ToString();
                txtBoxCirculationMy.Text = selectedRow.Cells["circulationMyColumn"].Value?.ToString();
                txtBoxFeaturesMy.Text = selectedRow.Cells["featuresMyColumn"].Value?.ToString();
            }
        }

        private void txtBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}