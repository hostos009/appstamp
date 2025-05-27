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
            CheckAndCreateFiles();
            LoadData();
            DisplayData();
        }

        private void CheckAndCreateFiles()
        {
            string[] files = { "stamps.json", "collectors.json", "mycollection.json" };

            foreach (var file in files)
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
                stamps = JsonSerializer.Deserialize<List<Stamp>>(stampsJson) ?? new List<Stamp>();

                string collectorsJson = File.ReadAllText("collectors.json", System.Text.Encoding.UTF8);
                collectors = JsonSerializer.Deserialize<List<Collector>>(collectorsJson) ?? new List<Collector>();

                string myCollectionJson = File.ReadAllText("mycollection.json", System.Text.Encoding.UTF8);
                myCollection = JsonSerializer.Deserialize<List<Stamp>>(myCollectionJson) ?? new List<Stamp>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних: {ex.Message}");
                stamps = new List<Stamp>();
                collectors = new List<Collector>();
                myCollection = new List<Stamp>();
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
            dataGridViewStamps.Rows.Clear();
            foreach (var stamp in stamps)
            {
                dataGridViewStamps.Rows.Add(
                    stamp.Naming,
                    stamp.Country,
                    stamp.Price,
                    stamp.Year,
                    stamp.Circulation,
                    stamp.Features);
            }
            ClearStampFields();
        }

        private void DisplayAllCollectors()
        {
            dataGridViewCollectors.Rows.Clear();
            foreach (var collector in collectors)
            {
                dataGridViewCollectors.Rows.Add(
                    collector.Country,
                    collector.Name,
                    collector.ContactData,
                    collector.RareStamps);
            }
            ClearCollectorFields();
        }

        private void DisplayAllMyCollection()
        {
            dataGridViewMy.Rows.Clear();
            foreach (var stamp in myCollection)
            {
                dataGridViewMy.Rows.Add(
                    stamp.Naming,
                    stamp.Country,
                    stamp.Price,
                    stamp.Year,
                    stamp.Circulation,
                    stamp.Features);
            }
            ClearMyCollectionTextBoxes();
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

        private void ClearMyCollectionTextBoxes()
        {
            txtBoxNamingMy.Clear();
            txtBoxCountryMy.Clear();
            txtBoxPriceMy.Clear();
            txtBoxYearMy.Clear();
            txtBoxCirculationMy.Clear();
            txtBoxFeaturesMy.Clear();
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

            string newCountry = txtBoxCountryCollectors.Text.Trim();
            string newName = txtBoxNameCollectors.Text.Trim();
            string newContactData = txtBoxContactCollectors.Text.Trim();

            if (collectors.Any(c => c.Country == newCountry && c.Name == newName && c.ContactData == newContactData))
            {
                MessageBox.Show("Колекціонер з такою країною, ім'ям та контактними даними вже існує.",
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
                SaveData();
                DisplayAllMyCollection();
                ClearStampFields();
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
                ClearStampFields();
                return;
            }

            dataGridViewStamps.Rows.Clear();
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
                    dataGridViewStamps.Rows.Add(
                        stamp.Naming,
                        stamp.Country,
                        stamp.Price,
                        stamp.Year,
                        stamp.Circulation,
                        stamp.Features);
                }
            }
            ClearStampFields();
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
                ClearCollectorFields();
                return;
            }

            dataGridViewCollectors.Rows.Clear();
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
                    dataGridViewCollectors.Rows.Add(
                        collector.Country,
                        collector.Name,
                        collector.ContactData,
                        collector.RareStamps);
                }
            }
            ClearCollectorFields();
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
                ClearMyCollectionTextBoxes();
                return;
            }

            dataGridViewMy.Rows.Clear();
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
                    dataGridViewMy.Rows.Add(
                        stamp.Naming,
                        stamp.Country,
                        stamp.Price,
                        stamp.Year,
                        stamp.Circulation,
                        stamp.Features);
                }
            }
            ClearMyCollectionTextBoxes();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewMy.SelectedRows.Count == 0)
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
                    int selectedIndex = dataGridViewMy.SelectedRows[0].Index;
                    myCollection.RemoveAt(selectedIndex);
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

        private void buttonEditStamp_Click(object sender, EventArgs e)
        {
            if (dataGridViewStamps.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть марку для редагування.",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateRequiredFields(txtBoxNaming, txtBoxCountry, txtBoxPrice, txtBoxYear, txtBoxCirculation))
            {
                return;
            }

            if (!ValidateYear(txtBoxYear) || !ValidateCirculation(txtBoxCirculation))
            {
                return;
            }

            try
            {
                int selectedIndex = dataGridViewStamps.SelectedRows[0].Index;
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

                SaveData();
                DisplayAllStamps();
                DisplayAllMyCollection();
                ClearStampFields();
                MessageBox.Show("Марку успішно відредаговано!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка редагування марки: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditCollectors_Click(object sender, EventArgs e)
        {
            if (dataGridViewCollectors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть колекціонера для редагування.",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateRequiredFields(txtBoxCountryCollectors, txtBoxNameCollectors, txtBoxContactCollectors))
            {
                return;
            }

            try
            {
                int selectedIndex = dataGridViewCollectors.SelectedRows[0].Index;
                var collector = collectors[selectedIndex];

                collector.Country = txtBoxCountryCollectors.Text.Trim();
                collector.Name = txtBoxNameCollectors.Text.Trim();
                collector.ContactData = txtBoxContactCollectors.Text.Trim();
                collector.RareStamps = txtBoxRareCollectors.Text.Trim();

                SaveData();
                DisplayAllCollectors();
                ClearCollectorFields();
                MessageBox.Show("Колекціонера успішно відредаговано!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка редагування колекціонера: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}