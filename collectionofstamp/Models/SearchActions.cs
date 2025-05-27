using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace collectionofstamp.Models
{
    public static class SearchActions
    {
        public static void SearchStamps(List<Stamp> stamps, DataGridView dataGridView, TextBox txtBoxNaming,
            TextBox txtBoxCountry, TextBox txtBoxPrice, TextBox txtBoxYear, TextBox txtBoxCirculation,
            TextBox txtBoxFeatures, Action displayAllStamps)
        {
            string searchNaming = txtBoxNaming.Text.Trim().ToLower();
            string searchCountry = txtBoxCountry.Text.Trim().ToLower();
            string searchPrice = txtBoxPrice.Text.Trim().ToLower();
            string searchFeatures = txtBoxFeatures.Text.Trim().ToLower();

            bool searchYear = int.TryParse(txtBoxYear.Text.Trim(), out int yearSearch);
            bool searchCirculation = int.TryParse(txtBoxCirculation.Text.Trim(), out int circulationSearch);

            if (string.IsNullOrEmpty(searchNaming) &&
                string.IsNullOrEmpty(searchCountry) &&
                string.IsNullOrEmpty(searchPrice) &&
                string.IsNullOrEmpty(searchFeatures) &&
                !searchYear && !searchCirculation)
            {
                displayAllStamps();
                Clear.ClearStampFields(txtBoxNaming, txtBoxCountry, txtBoxPrice, txtBoxYear, txtBoxCirculation, txtBoxFeatures);
                return;
            }

            dataGridView.Rows.Clear();
            foreach (var stamp in stamps)
            {
                bool byName = string.IsNullOrEmpty(searchNaming) ||
                    stamp.Naming.ToLower().Contains(searchNaming);

                bool byCountry = string.IsNullOrEmpty(searchCountry) ||
                    stamp.Country.ToLower().Contains(searchCountry);

                bool byPrice = string.IsNullOrEmpty(searchPrice) ||
                    stamp.Price.ToLower().Contains(searchPrice);

                bool byFeatures = string.IsNullOrEmpty(searchFeatures) ||
                    stamp.Features.ToLower().Contains(searchFeatures);

                bool byYear = !searchYear || stamp.Year == yearSearch;

                bool byCirculation = !searchCirculation || stamp.Circulation == circulationSearch;

                if (byName && byCountry && byPrice &&
                    byFeatures && byYear && byCirculation)
                {
                    dataGridView.Rows.Add(
                        stamp.Naming,
                        stamp.Country,
                        stamp.Price,
                        stamp.Year,
                        stamp.Circulation,
                        stamp.Features);
                }
            }
            Clear.ClearStampFields(txtBoxNaming, txtBoxCountry, txtBoxPrice, txtBoxYear, txtBoxCirculation, txtBoxFeatures);
        }

        public static void SearchCollectors(List<Collector> collectors, DataGridView dataGridView,
            TextBox txtBoxCountryCollectors, TextBox txtBoxNameCollectors, TextBox txtBoxContactCollectors,
            TextBox txtBoxRareCollectors, Action displayAllCollectors)
        {
            string searchCountry = txtBoxCountryCollectors.Text.Trim().ToLower();
            string searchName = txtBoxNameCollectors.Text.Trim().ToLower();
            string searchContactData = txtBoxContactCollectors.Text.Trim().ToLower();
            string searchRareStamp = txtBoxRareCollectors.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchCountry) &&
                string.IsNullOrEmpty(searchName) &&
                string.IsNullOrEmpty(searchContactData) &&
                string.IsNullOrEmpty(searchRareStamp))
            {
                displayAllCollectors();
                Clear.ClearCollectorFields(txtBoxCountryCollectors, txtBoxNameCollectors, txtBoxContactCollectors, txtBoxRareCollectors);
                return;
            }

            dataGridView.Rows.Clear();
            foreach (var collector in collectors)
            {
                bool byName = string.IsNullOrEmpty(searchName) ||
                    collector.Name.ToLower().Contains(searchName);

                bool byCountry = string.IsNullOrEmpty(searchCountry) ||
                    collector.Country.ToLower().Contains(searchCountry);

                bool byContactData = string.IsNullOrEmpty(searchContactData) ||
                    collector.ContactData.ToLower().Contains(searchContactData);

                bool byRareStamps = string.IsNullOrEmpty(searchRareStamp) ||
                    collector.RareStamps.ToLower().Contains(searchRareStamp);

                if (byName && byCountry &&
                    byContactData && byRareStamps)
                {
                    dataGridView.Rows.Add(
                        collector.Country,
                        collector.Name,
                        collector.ContactData,
                        collector.RareStamps);
                }
            }
            Clear.ClearCollectorFields(txtBoxCountryCollectors, txtBoxNameCollectors, txtBoxContactCollectors, txtBoxRareCollectors);
        }

        public static void SearchMyCollection(List<Stamp> myCollection, DataGridView dataGridView,
            TextBox txtBoxNamingMy, TextBox txtBoxCountryMy, TextBox txtBoxPriceMy,
            TextBox txtBoxYearMy, TextBox txtBoxCirculationMy, TextBox txtBoxFeaturesMy,
            Action displayAllMyCollection)
        {
            string searchNaming = txtBoxNamingMy.Text.Trim().ToLower();
            string searchCountry = txtBoxCountryMy.Text.Trim().ToLower();
            string searchPrice = txtBoxPriceMy.Text.Trim().ToLower();
            string searchFeatures = txtBoxFeaturesMy.Text.Trim().ToLower();

            bool searchYear = int.TryParse(txtBoxYearMy.Text.Trim(), out int yearSearch);
            bool searchCirculation = int.TryParse(txtBoxCirculationMy.Text.Trim(), out int circulationSearch);

            if (string.IsNullOrEmpty(searchNaming) &&
                string.IsNullOrEmpty(searchCountry) &&
                string.IsNullOrEmpty(searchPrice) &&
                string.IsNullOrEmpty(searchFeatures) &&
                !searchYear && !searchCirculation)
            {
                displayAllMyCollection();
                Clear.ClearMyCollectionTextBoxes(txtBoxNamingMy, txtBoxCountryMy, txtBoxPriceMy, txtBoxYearMy, txtBoxCirculationMy, txtBoxFeaturesMy);
                return;
            }

            dataGridView.Rows.Clear();
            foreach (var stamp in myCollection)
            {
                bool byName = string.IsNullOrEmpty(searchNaming) ||
                    stamp.Naming.ToLower().Contains(searchNaming);

                bool byCountry = string.IsNullOrEmpty(searchCountry) ||
                    stamp.Country.ToLower().Contains(searchCountry);

                bool byPrice = string.IsNullOrEmpty(searchPrice) ||
                    stamp.Price.ToLower().Contains(searchPrice);

                bool byFeatures = string.IsNullOrEmpty(searchFeatures) ||
                    stamp.Features.ToLower().Contains(searchFeatures);

                bool byYear = !searchYear || stamp.Year == yearSearch;

                bool byCirculation = !searchCirculation || stamp.Circulation == circulationSearch;

                if (byName && byCountry && byPrice &&
                    byFeatures && byYear && byCirculation)
                {
                    dataGridView.Rows.Add(
                        stamp.Naming,
                        stamp.Country,
                        stamp.Price,
                        stamp.Year,
                        stamp.Circulation,
                        stamp.Features);
                }
            }
            Clear.ClearMyCollectionTextBoxes(txtBoxNamingMy, txtBoxCountryMy, txtBoxPriceMy, txtBoxYearMy, txtBoxCirculationMy, txtBoxFeaturesMy);
        }
    }
}