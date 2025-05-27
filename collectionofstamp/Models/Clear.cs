using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionofstamp.Models
{
    public static class Clear
    {
        public static void ClearStampFields(TextBox txtBoxNaming, TextBox txtBoxCountry, TextBox txtBoxPrice,
            TextBox txtBoxYear, TextBox txtBoxCirculation, TextBox txtBoxFeatures)
        {
            txtBoxNaming.Clear();
            txtBoxCountry.Clear();
            txtBoxPrice.Clear();
            txtBoxYear.Clear();
            txtBoxCirculation.Clear();
            txtBoxFeatures.Clear();
        }

        public static void ClearCollectorFields(TextBox txtBoxCountryCollectors, TextBox txtBoxNameCollectors,
            TextBox txtBoxContactCollectors, TextBox txtBoxRareCollectors)
        {
            txtBoxCountryCollectors.Clear();
            txtBoxNameCollectors.Clear();
            txtBoxContactCollectors.Clear();
            txtBoxRareCollectors.Clear();
        }

        public static void ClearMyCollectionTextBoxes(TextBox txtBoxNamingMy, TextBox txtBoxCountryMy,
            TextBox txtBoxPriceMy, TextBox txtBoxYearMy, TextBox txtBoxCirculationMy, TextBox txtBoxFeaturesMy)
        {
            txtBoxNamingMy.Clear();
            txtBoxCountryMy.Clear();
            txtBoxPriceMy.Clear();
            txtBoxYearMy.Clear();
            txtBoxCirculationMy.Clear();
            txtBoxFeaturesMy.Clear();
        }
    }
}
