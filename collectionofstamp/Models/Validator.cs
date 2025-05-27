using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionofstamp.Models
{
    public static class Validator
    {
        public static bool ValidateRequiredFields(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть всі поля",
                        "Перевірка даних",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateYear(TextBox yearTextBox)
        {
            if (!int.TryParse(yearTextBox.Text, out int year))
            {
                MessageBox.Show("Рік випуску повинен бути " +
                    "цілим числом.", "Помилка введення", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yearTextBox.Focus();
                return false;
            }
            if (year < 1840 || year > DateTime.Now.Year)
            {
                MessageBox.Show($"Рік випуску повинен бути між " +
                    $"1840 і {DateTime.Now.Year}.",
                    "Помилка введення", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yearTextBox.Focus();
                return false;
            }
            return true;
        }

        public static bool ValidateCirculation(TextBox circulationTextBox) 
        {
            if (!int.TryParse(circulationTextBox.Text, out int circulation))
            {
                MessageBox.Show("Тираж повинен бути цілим числом.",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                circulationTextBox.Focus();
                return false;
            }

            if (circulation <= 0)
            {
                MessageBox.Show("Тираж повинен бути більше 0.",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                circulationTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}
