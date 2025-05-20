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

        private void buttonAdd_Click(object sender, EventArgs e)
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
        }

        private void buttonAddCollectors_Click(object sender, EventArgs e)
        {
            var collector = new Collector
            {
                Country = txtBoxCountryCollectors.Text,
                Name = txtBoxNameCollectors.Text,
                ContactData = txtBoxContactCollectors.Text,
                RareStamps = txtBoxRareCollectors.Text
            };
            collectors.Add(collector);
            SaveData();
            DisplayAllCollectors();
        }

        private void buttonAddMyCollection_Click(object sender, EventArgs e)
        {
            if (listBoxStamps.SelectedIndex >= 0)
            {
                var selectedStamp = stamps[listBoxStamps.SelectedIndex];
                myCollection.Add(selectedStamp);
                SaveData();
                DisplayAllMyCollection();
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
            if(listBoxMy.SelectedIndex >= 0)
            {
                myCollection.RemoveAt(listBoxMy.SelectedIndex);
                SaveData();
                ClearMyCollectionTextBoxes();
                DisplayAllMyCollection();
                MessageBox.Show("Марку успішно видалено з колекції",
                    "Інформація", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть марку для видалення",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearMyCollectionTextBoxes()
        {
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
