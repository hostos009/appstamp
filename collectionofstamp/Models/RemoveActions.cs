using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace collectionofstamp.Models
{
    public static class RemoveActions
    {
        public static void RemoveFromMyCollection(List<Stamp> myCollection, DataGridView dataGridView,
            TextBox txtBoxNamingMy, TextBox txtBoxCountryMy, TextBox txtBoxPriceMy,
            TextBox txtBoxYearMy, TextBox txtBoxCirculationMy, TextBox txtBoxFeaturesMy,
            Action saveData, Action displayAllMyCollection)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть марку для видалення",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цю марку з колекції?",
                    "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dataGridView.SelectedRows[0].Index;
                    myCollection.RemoveAt(selectedIndex);
                    saveData();
                    displayAllMyCollection();
                    MessageBox.Show("Марку успішно видалено з колекції",
                        "Інформація", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час видалення: {ex.Message}",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}