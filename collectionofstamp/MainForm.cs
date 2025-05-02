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
                string stampsJson = File.ReadAllText("stamps.json");
                stamps = JsonSerializer.Deserialize<List<Stamp>>(stampsJson);

                string collectorsJson = File.ReadAllText("collectors.json");
                collectors = JsonSerializer.Deserialize<List<Collector>>(collectorsJson);

                string myCollectionJson = File.ReadAllText("mycollection.json");
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
            // Відображення всіх даних
            DisplayAllStamps();
            DisplayAllCollectors();
            DisplayAllMyCollection();
        }

        private void DisplayAllStamps()
        {
            listBoxStamps.Items.Clear();
            foreach (var stamp in stamps)
            {
                listBoxStamps.Items.Add($"{stamp.Country} - {stamp.Price} ({stamp.Year})");
            }
        }

        private void DisplayAllCollectors()
        {
            listBoxCollectors.Items.Clear();
            foreach (var collector in collectors)
            {
                listBoxCollectors.Items.Add($"{collector.Name} - {collector.Country}");
            }
        }

        private void DisplayAllMyCollection()
        {
            listBoxMy.Items.Clear();
            foreach (var stamp in myCollection)
            {
                listBoxMy.Items.Add($"{stamp.Country} - {stamp.Price} ({stamp.Year})");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var stamp = new Stamp
            {
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
            string searchTerm = txtBoxCountry.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                DisplayAllStamps();
                return;
            }

            listBoxStamps.Items.Clear();
            foreach (var stamp in stamps)
            {
                if (stamp.Country.ToLower().Contains(searchTerm))
                {
                    listBoxStamps.Items.Add($"{stamp.Country} - {stamp.Price} ({stamp.Year})");
                }
            }
        }

        private void buttonSearchCollectors_Click(object sender, EventArgs e)
        {
            string searchTerm = txtBoxNameCollectors.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                DisplayAllCollectors();
                return;
            }

            listBoxCollectors.Items.Clear();
            foreach (var collector in collectors)
            {
                if (collector.Name.ToLower().Contains(searchTerm))
                {
                    listBoxCollectors.Items.Add($"{collector.Name} - {collector.Country}");
                }
            }
        }

        private void buttonSearchMy_Click(object sender, EventArgs e)
        {
            string searchTerm = txtBoxCountryMy.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                DisplayAllMyCollection();
                return;
            }

            listBoxMy.Items.Clear();
            foreach (var stamp in myCollection)
            {
                if (stamp.Country.ToLower().Contains(searchTerm))
                {
                    listBoxMy.Items.Add($"{stamp.Country} - {stamp.Price} ({stamp.Year})");
                }
            }
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
                txtBoxCountryMy.Text = stamp.Country;
                txtBoxPriceMy.Text = stamp.Price.ToString();
                txtBoxYearMy.Text = stamp.Year.ToString();
                txtBoxCirculationMy.Text = stamp.Circulation.ToString();
                txtBoxFeaturesMy.Text = stamp.Features;
            }
        }
    }
}
