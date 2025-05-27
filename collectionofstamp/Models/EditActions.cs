using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace collectionofstamp.Models
{
    public static class EditActions
    {
        public static void EditStamp(List<Stamp> stamps, List<Stamp> myCollection, DataGridView dataGridView,
            TextBox txtBoxNaming, TextBox txtBoxCountry, TextBox txtBoxPrice, TextBox txtBoxYear,
            TextBox txtBoxCirculation, TextBox txtBoxFeatures, Action saveData, Action displayAllStamps,
            Action displayAllMyCollection)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть марку для редагування.",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validator.ValidateRequiredFields(txtBoxNaming, txtBoxCountry, txtBoxPrice, txtBoxYear, txtBoxCirculation))
            {
                return;
            }

            if (!Validator.ValidateYear(txtBoxYear) || !Validator.ValidateCirculation(txtBoxCirculation))
            {
                return;
            }

            try
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                var stamp = stamps[selectedIndex];

                string oldNaming = stamp.Naming;
                string oldCountry = stamp.Country;
                int oldYear = stamp.Year;

                stamp.Naming = txtBoxNaming.Text.Trim();
                stamp.Country = txtBoxCountry.Text.Trim();
                stamp.Price = txtBoxPrice.Text.Trim();
                stamp.Year = int.Parse(txtBoxYear.Text.Trim());
                stamp.Circulation = int.Parse(txtBoxCirculation.Text.Trim());
                stamp.Features = txtBoxFeatures.Text.Trim();

                var myStamp = myCollection.FirstOrDefault(s =>
                    s.Naming == oldNaming &&
                    s.Country == oldCountry &&
                    s.Year == oldYear);
                if (myStamp != null)
                {
                    myStamp.Naming = stamp.Naming;
                    myStamp.Country = stamp.Country;
                    myStamp.Price = stamp.Price;
                    myStamp.Year = stamp.Year;
                    myStamp.Circulation = stamp.Circulation;
                    myStamp.Features = stamp.Features;
                }

                saveData();
                displayAllStamps();
                displayAllMyCollection();
                Clear.ClearStampFields(txtBoxNaming, txtBoxCountry, txtBoxPrice, txtBoxYear, txtBoxCirculation, txtBoxFeatures);
                MessageBox.Show("Марку успішно відредаговано!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка редагування марки: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void EditCollector(List<Collector> collectors, DataGridView dataGridView,
            TextBox txtBoxCountryCollectors, TextBox txtBoxNameCollectors, TextBox txtBoxContactCollectors,
            TextBox txtBoxRareCollectors, Action saveData, Action displayAllCollectors)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть колекціонера для редагування.",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validator.ValidateRequiredFields(txtBoxCountryCollectors, txtBoxNameCollectors, txtBoxContactCollectors))
            {
                return;
            }

            try
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                var collector = collectors[selectedIndex];

                collector.Country = txtBoxCountryCollectors.Text.Trim();
                collector.Name = txtBoxNameCollectors.Text.Trim();
                collector.ContactData = txtBoxContactCollectors.Text.Trim();
                collector.RareStamps = txtBoxRareCollectors.Text.Trim();

                saveData();
                displayAllCollectors();
                Clear.ClearCollectorFields(txtBoxCountryCollectors, txtBoxNameCollectors, txtBoxContactCollectors, txtBoxRareCollectors);
                MessageBox.Show("Колекціонера успішно відредаговано!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка редагування колекціонера: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}