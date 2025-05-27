using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace collectionofstamp.Models
{
    public static class AddActions
    {
        public static void AddStamp(List<Stamp> stamps, TextBox txtBoxNaming, TextBox txtBoxCountry,
            TextBox txtBoxPrice, TextBox txtBoxYear, TextBox txtBoxCirculation, TextBox txtBoxFeatures,
            Action saveData, Action displayAllStamps)
        {
            if (!Validator.ValidateRequiredFields(txtBoxNaming, txtBoxCountry, txtBoxPrice, txtBoxYear, txtBoxCirculation))
            {
                return;
            }
            if (!Validator.ValidateYear(txtBoxYear) || !Validator.ValidateCirculation(txtBoxCirculation))
            {
                return;
            }

            string newNaming = txtBoxNaming.Text.Trim();
            string newCountry = txtBoxCountry.Text.Trim();
            int newYear = int.Parse(txtBoxYear.Text.Trim());

            if (stamps.Any(s => s.Naming == newNaming && s.Country == newCountry && s.Year == newYear))
            {
                MessageBox.Show("Марка з такою назвою, країною та роком уже існує в списку.",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var stamp = new Stamp
                {
                    Naming = newNaming,
                    Country = newCountry,
                    Price = txtBoxPrice.Text,
                    Year = newYear,
                    Circulation = int.Parse(txtBoxCirculation.Text),
                    Features = txtBoxFeatures.Text
                };
                stamps.Add(stamp);
                saveData();
                displayAllStamps();
                Clear.ClearStampFields(txtBoxNaming, txtBoxCountry, txtBoxPrice, txtBoxYear, txtBoxCirculation, txtBoxFeatures);
                MessageBox.Show("Марку успішно додано", "Інформація",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка додавання: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddCollector(List<Collector> collectors, TextBox txtBoxCountryCollectors,
            TextBox txtBoxNameCollectors, TextBox txtBoxContactCollectors, TextBox txtBoxRareCollectors,
            Action saveData, Action displayAllCollectors)
        {
            if (!Validator.ValidateRequiredFields(txtBoxCountryCollectors, txtBoxNameCollectors, txtBoxContactCollectors))
            {
                return;
            }

            string newCountry = txtBoxCountryCollectors.Text.Trim();
            string newName = txtBoxNameCollectors.Text.Trim();
            string newContactData = txtBoxContactCollectors.Text.Trim();

            if (collectors.Any(c => c.Country == newCountry && c.Name == newName && c.ContactData == newContactData))
            {
                MessageBox.Show("Колекціонер з такою країною, ім’ям та контактними даними вже існує.",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var collector = new Collector
                {
                    Country = newCountry,
                    Name = newName,
                    ContactData = newContactData,
                    RareStamps = txtBoxRareCollectors.Text
                };
                collectors.Add(collector);
                saveData();
                displayAllCollectors();
                Clear.ClearCollectorFields(txtBoxCountryCollectors, txtBoxNameCollectors, txtBoxContactCollectors, txtBoxRareCollectors);
                MessageBox.Show("Колекціонера успішно додано!", "Інформація",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка додавання колекціонера: {ex.Message}",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddToMyCollection(List<Stamp> stamps, List<Stamp> myCollection, DataGridView dataGridViewStamps,
            TextBox txtBoxNaming, TextBox txtBoxCountry, TextBox txtBoxPrice, TextBox txtBoxYear,
            TextBox txtBoxCirculation, TextBox txtBoxFeatures, Action saveData, Action displayAllMyCollection)
        {
            if (dataGridViewStamps.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть марку для додавання в колекцію.",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int selectedIndex = dataGridViewStamps.SelectedRows[0].Index;
                var selectedStamp = stamps[selectedIndex];

                myCollection.Add(selectedStamp);
                saveData();
                displayAllMyCollection();
                Clear.ClearStampFields(txtBoxNaming, txtBoxCountry, txtBoxPrice, txtBoxYear, txtBoxCirculation, txtBoxFeatures);
                MessageBox.Show("Марку успішно додано до колекції!",
                    "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка додавання марки до колекції: {ex.Message}",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}