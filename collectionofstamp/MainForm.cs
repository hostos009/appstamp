using collectionofstamp.Models;
using System.Text.Json;

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
            LoadData();
            DisplayData();
        }

        private void CheckAndCreateFiles()
        {
            string[] files = { "stamps.json", "collectors.json", "mycollection.json" };
        
            foreach(var file in files)
            {
                if (!File.Exists(file))
                {
                    File.WriteAllText(file, "[]");
                }
            }
        }

        private void LoadData()
        {
            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                string stampsJson = File.ReadAllText("stamps.json", System.Text.Encoding.UTF8);
                stamps = JsonSerializer.Deserialize<List<Stamp>>(stampsJson);

                string collectorsJson = File.ReadAllText("collectors.json", System.Text.Encoding.UTF8);
                collectors = JsonSerializer.Deserialize<List<Collector>>(collectorsJson);

                string myCollectionJson = File.ReadAllText("mycollection.json", System.Text.Encoding.UTF8);
                myCollection = JsonSerializer.Deserialize<List<Stamp>>(myCollectionJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних: {ex.Message}");
            }
        }

        private void SaveData()
        {
            try
            {
                File.WriteAllText("stamps.json", JsonSerializer.Serialize(stamps));
                File.WriteAllText("collectors.json", JsonSerializer.Serialize(collectors));
                File.WriteAllText("mycollection.json", JsonSerializer.Serialize(myCollection));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження даних: {ex.Message}");
            }
        }

        private void DisplayData()
        {
            DisplayAllStamps();
            DisplayAllCollectors();
            DisplayAllMyCollection();
        }

        private void DisplayAllStamps()
        {
            listBoxStamps.Items.Clear();
            foreach (var stamp in stamps)
            {
                listBoxStamps.Items.Add($"{stamp.Naming}   {stamp.Country}   {stamp.Price}   " +
                    $"{stamp.Year}   {stamp.Circulation}   {stamp.Features}");
            }
        }

        private void DisplayAllCollectors()
        {
            listBoxCollectors.Items.Clear();
            foreach (var collector in collectors)
            {
                listBoxCollectors.Items.Add($"{collector.Name}   {collector.Country}   " +
                    $"{collector.ContactData}   {collector.RareStamps}");
            }
        }

        private void DisplayAllMyCollection()
        {
            listBoxMy.Items.Clear();
            foreach (var stamp in myCollection)
            {
                listBoxMy.Items.Add($"{stamp.Naming}   {stamp.Country}   {stamp.Price}   " +
                    $"{stamp.Year}   {stamp.Circulation}   {stamp.Features}");
            }
        }

        private bool ValidateRequiredFields(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть всі поля форми.",
                        "Перевірка даних", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool ValidateYear(TextBox yearTextBox)
        {
            if (!int.TryParse(yearTextBox.Text, out int year))
            {
                MessageBox.Show("Рік випуску повинен бути цілим числом.",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yearTextBox.Focus();
                return false;
            }

            if (year < 1840 || year > DateTime.Now.Year)
            {
                MessageBox.Show($"Рік випуску повинен бути між 1840 і {DateTime.Now.Year}.",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yearTextBox.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateCirculation(TextBox circulationTextBox)
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

        private void ClearStampFields()
        {
            txtBoxNaming.Clear();
            txtBoxCountry.Clear();
            txtBoxPrice.Clear();
            txtBoxYear.Clear();
            txtBoxCirculation.Clear();
            txtBoxFeatures.Clear();
        }

        private void ClearCollectorFields()
        {
            txtBoxCountryCollectors.Clear();
            txtBoxNameCollectors.Clear();
            txtBoxContactCollectors.Clear();
            txtBoxRareCollectors.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields(txtBoxNaming, txtBoxCountry,
                txtBoxPrice, txtBoxYear, txtBoxCirculation))
            {
                return;
            }
            if (!ValidateYear(txtBoxYear) || 
                !ValidateCirculation(txtBoxCirculation))
            {
                return;
            }
            try
            {
                var stamp = new Stamp
                {
                    Naming = txtBoxNaming.Text,
                    Country = txtBoxCountry.Text,
                    Price = txtBoxPrice.Text,
                    Year = int.Parse(txtBoxYear.Text),
                    Circulation = int.Parse(txtBoxCirculation.Text),
                    Features = txtBoxFeatures.Text
                };
                stamps.Add(stamp);
                SaveData();
                DisplayAllStamps();
                ClearStampFields();
                MessageBox.Show("Марку успішно додано", "Інформація",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка додавання: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddCollectors_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields(txtBoxCountryCollectors, 
                txtBoxNameCollectors, txtBoxContactCollectors))
            {
                return;
            }

            try
            {
                var collector = new Collector
                {
                    Country = txtBoxCountryCollectors.Text.Trim(),
                    Name = txtBoxNameCollectors.Text.Trim(),
                    ContactData = txtBoxContactCollectors.Text.Trim(),
                    RareStamps = txtBoxRareCollectors.Text.Trim()
                };
                collectors.Add(collector);
                SaveData();
                DisplayAllCollectors();
                ClearCollectorFields();
                MessageBox.Show("Колекціонера успішно додано!", "Інформація",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка додавання колекціонера: {ex.Message}",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddMyCollection_Click(object sender, EventArgs e)
        {
            if(listBoxStamps.SelectedIndex < 0)
            {
                MessageBox.Show("Будь ласка, виберіть марку для додавання в колекцію.",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var selectedStamp = stamps[listBoxStamps.SelectedIndex];
                bool stampExists = myCollection.Any(s =>
                    s.Naming == selectedStamp.Naming &&
                    s.Country == selectedStamp.Country &&
                    s.Year == selectedStamp.Year);
                if (stampExists)
                {
                    MessageBox.Show("Така марка вже є у вашій колекції.",
                        "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                myCollection.Add(selectedStamp);
                SaveData();
                DisplayAllMyCollection();
                MessageBox.Show("Марку успішно додано до колекції!",
                    "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка додавання марки до колекції: {ex.Message}",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
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
                DisplayAllStamps();
                return;
            }

            listBoxStamps.Items.Clear();
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
                    listBoxStamps.Items.Add($"{stamp.Naming}   " +
                        $"{stamp.Country}   {stamp.Price}   " +
                    $"{stamp.Year}   {stamp.Circulation}   {stamp.Features}");
                }
            }
        }

        private void buttonSearchCollectors_Click(object sender, EventArgs e)
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
                DisplayAllCollectors();
                return;
            }

            listBoxCollectors.Items.Clear();
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
                    listBoxCollectors.Items.Add($"{collector.Name}   {collector.Country}   " +
                    $"{collector.ContactData}   {collector.RareStamps}");
                }
            }
        }

        private void buttonSearchMy_Click(object sender, EventArgs e)
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
                DisplayAllMyCollection();
                return;
            }

            listBoxMy.Items.Clear();
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
                    listBoxMy.Items.Add($"{stamp.Naming}   " +
                        $"{stamp.Country}   {stamp.Price}   " +
                    $"{stamp.Year}   {stamp.Circulation}   {stamp.Features}");
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxMy.SelectedIndex < 0)
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
                    myCollection.RemoveAt(listBoxMy.SelectedIndex);
                    SaveData();
                    ClearMyCollectionTextBoxes();
                    DisplayAllMyCollection();
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

        private void ClearMyCollectionTextBoxes()
        {
            txtBoxNamingMy.Clear();
            txtBoxCountryMy.Clear();
            txtBoxPriceMy.Clear();
            txtBoxYearMy.Clear();
            txtBoxCirculationMy.Clear();
            txtBoxFeaturesMy.Clear();
        }

        private void listBoxStamps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStamps.SelectedIndex >= 0)
            {
                var stamp = stamps[listBoxStamps.SelectedIndex];
                txtBoxNaming.Text = stamp.Naming;
                txtBoxCountry.Text = stamp.Country;
                txtBoxPrice.Text = stamp.Price.ToString();
                txtBoxYear.Text = stamp.Year.ToString();
                txtBoxCirculation.Text = stamp.Circulation.ToString();
                txtBoxFeatures.Text = stamp.Features;
            }
        }

        private void listBoxCollectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCollectors.SelectedIndex >= 0)
            {
                var collector = collectors[listBoxCollectors.SelectedIndex];
                txtBoxCountryCollectors.Text = collector.Country;
                txtBoxNameCollectors.Text = collector.Name;
                txtBoxContactCollectors.Text = collector.ContactData;
                txtBoxRareCollectors.Text = collector.RareStamps;
            }
        }

        private void listBoxMy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMy.SelectedIndex >= 0)
            {
                var stamp = myCollection[listBoxMy.SelectedIndex];
                txtBoxNamingMy.Text = stamp.Naming;
                txtBoxCountryMy.Text = stamp.Country;
                txtBoxPriceMy.Text = stamp.Price.ToString();
                txtBoxYearMy.Text = stamp.Year.ToString();
                txtBoxCirculationMy.Text = stamp.Circulation.ToString();
                txtBoxFeaturesMy.Text = stamp.Features;
            }
        }
    }
}
