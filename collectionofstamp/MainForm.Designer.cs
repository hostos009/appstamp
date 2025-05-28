using System.Windows.Forms;

namespace collectionofstamp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabStamps = new TabPage();
            dataGridViewStamps = new DataGridView();
            nameStampColumn = new DataGridViewTextBoxColumn();
            countryStampColumn = new DataGridViewTextBoxColumn();
            priceStampColumn = new DataGridViewTextBoxColumn();
            yearStampColumn = new DataGridViewTextBoxColumn();
            circulationStampColumn = new DataGridViewTextBoxColumn();
            featuresStampColumn = new DataGridViewTextBoxColumn();
            panelStamps = new Panel();
            buttonEditStamp = new Button();
            labelNaming = new Label();
            txtBoxNaming = new TextBox();
            labelFeatures = new Label();
            labelCirculation = new Label();
            labelYear = new Label();
            labelPrice = new Label();
            labelCountry = new Label();
            buttonAddMyCollection = new Button();
            buttonSearch = new Button();
            buttonAdd = new Button();
            txtBoxFeatures = new TextBox();
            txtBoxCirculation = new TextBox();
            txtBoxYear = new TextBox();
            txtBoxPrice = new TextBox();
            txtBoxCountry = new TextBox();
            tabCollectors = new TabPage();
            dataGridViewCollectors = new DataGridView();
            countryCollectorColumn = new DataGridViewTextBoxColumn();
            nameCollectorColumn = new DataGridViewTextBoxColumn();
            contactCollectorColumn = new DataGridViewTextBoxColumn();
            rareStampsCollectorColumn = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            buttonEditCollectors = new Button();
            labelNameOfCollectors = new Label();
            labelCountryOfCollectors = new Label();
            labelRareCollectors = new Label();
            labelDataCollectors = new Label();
            buttonSearchCollectors = new Button();
            buttonAddCollectors = new Button();
            txtBoxRareCollectors = new TextBox();
            txtBoxContactCollectors = new TextBox();
            txtBoxNameCollectors = new TextBox();
            txtBoxCountryCollectors = new TextBox();
            tabMyCollection = new TabPage();
            dataGridViewMy = new DataGridView();
            nameMyColumn = new DataGridViewTextBoxColumn();
            countryMyColumn = new DataGridViewTextBoxColumn();
            priceMyColumn = new DataGridViewTextBoxColumn();
            yearMyColumn = new DataGridViewTextBoxColumn();
            circulationMyColumn = new DataGridViewTextBoxColumn();
            featuresMyColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            buttonRemove = new Button();
            labelNamingMy = new Label();
            txtBoxNamingMy = new TextBox();
            labelFeaturesMy = new Label();
            labelCirculationMy = new Label();
            labelYearMy = new Label();
            labelPriceMy = new Label();
            labelCountryMy = new Label();
            buttonSearchMy = new Button();
            txtBoxFeaturesMy = new TextBox();
            txtBoxCirculationMy = new TextBox();
            txtBoxYearMy = new TextBox();
            txtBoxPriceMy = new TextBox();
            txtBoxCountryMy = new TextBox();
            tabControl1.SuspendLayout();
            tabStamps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStamps).BeginInit();
            panelStamps.SuspendLayout();
            tabCollectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCollectors).BeginInit();
            panel2.SuspendLayout();
            tabMyCollection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMy).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabStamps);
            tabControl1.Controls.Add(tabCollectors);
            tabControl1.Controls.Add(tabMyCollection);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 451);
            tabControl1.TabIndex = 0;
            // 
            // tabStamps
            // 
            tabStamps.Controls.Add(dataGridViewStamps);
            tabStamps.Controls.Add(panelStamps);
            tabStamps.Location = new Point(4, 24);
            tabStamps.Name = "tabStamps";
            tabStamps.Padding = new Padding(3);
            tabStamps.Size = new Size(776, 423);
            tabStamps.TabIndex = 0;
            tabStamps.Text = "Марки";
            tabStamps.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStamps
            // 
            dataGridViewStamps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStamps.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewStamps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStamps.Columns.AddRange(new DataGridViewColumn[] { nameStampColumn, countryStampColumn, priceStampColumn, yearStampColumn, circulationStampColumn, featuresStampColumn });
            dataGridViewStamps.Dock = DockStyle.Fill;
            dataGridViewStamps.Location = new Point(185, 3);
            dataGridViewStamps.MultiSelect = false;
            dataGridViewStamps.Name = "dataGridViewStamps";
            dataGridViewStamps.ReadOnly = true;
            dataGridViewStamps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStamps.Size = new Size(588, 417);
            dataGridViewStamps.TabIndex = 13;
            dataGridViewStamps.SelectionChanged += dataGridViewStamps_SelectionChanged;
            // 
            // nameStampColumn
            // 
            nameStampColumn.HeaderText = "Назва";
            nameStampColumn.Name = "nameStampColumn";
            nameStampColumn.ReadOnly = true;
            nameStampColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // 
            // countryStampColumn
            // 
            countryStampColumn.HeaderText = "Країна";
            countryStampColumn.Name = "countryStampColumn";
            countryStampColumn.ReadOnly = true;
            countryStampColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // 
            // priceStampColumn
            // 
            priceStampColumn.HeaderText = "Номінальна вартість";
            priceStampColumn.Name = "priceStampColumn";
            priceStampColumn.ReadOnly = true;
            priceStampColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // 
            // yearStampColumn
            // 
            yearStampColumn.HeaderText = "Рік випуску";
            yearStampColumn.Name = "yearStampColumn";
            yearStampColumn.ReadOnly = true;
            yearStampColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // 
            // circulationStampColumn
            // 
            circulationStampColumn.HeaderText = "Тираж";
            circulationStampColumn.Name = "circulationStampColumn";
            circulationStampColumn.ReadOnly = true;
            circulationStampColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // 
            // featuresStampColumn
            // 
            featuresStampColumn.HeaderText = "Особливості";
            featuresStampColumn.Name = "featuresStampColumn";
            featuresStampColumn.ReadOnly = true;
            featuresStampColumn.MinimumWidth = 100;
            featuresStampColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // 
            // panelStamps
            // 
            panelStamps.Controls.Add(buttonEditStamp);
            panelStamps.Controls.Add(labelNaming);
            panelStamps.Controls.Add(txtBoxNaming);
            panelStamps.Controls.Add(labelFeatures);
            panelStamps.Controls.Add(labelCirculation);
            panelStamps.Controls.Add(labelYear);
            panelStamps.Controls.Add(labelPrice);
            panelStamps.Controls.Add(labelCountry);
            panelStamps.Controls.Add(buttonAddMyCollection);
            panelStamps.Controls.Add(buttonSearch);
            panelStamps.Controls.Add(buttonAdd);
            panelStamps.Controls.Add(txtBoxFeatures);
            panelStamps.Controls.Add(txtBoxCirculation);
            panelStamps.Controls.Add(txtBoxYear);
            panelStamps.Controls.Add(txtBoxPrice);
            panelStamps.Controls.Add(txtBoxCountry);
            panelStamps.Dock = DockStyle.Left;
            panelStamps.Location = new Point(3, 3);
            panelStamps.Name = "panelStamps";
            panelStamps.Size = new Size(182, 417);
            panelStamps.TabIndex = 0;
            // 
            // buttonEditStamp
            // 
            buttonEditStamp.BackColor = Color.LightGray;
            buttonEditStamp.Location = new Point(3, 275);
            buttonEditStamp.Name = "buttonEditStamp";
            buttonEditStamp.Size = new Size(176, 30);
            buttonEditStamp.TabIndex = 15;
            buttonEditStamp.Text = "Змінити";
            buttonEditStamp.UseVisualStyleBackColor = false;
            buttonEditStamp.Click += buttonEditStamp_Click;
            // 
            // labelNaming
            // 
            labelNaming.AutoSize = true;
            labelNaming.Location = new Point(3, 3);
            labelNaming.Name = "labelNaming";
            labelNaming.Size = new Size(39, 15);
            labelNaming.TabIndex = 14;
            labelNaming.Text = "Назва";
            // 
            // txtBoxNaming
            // 
            txtBoxNaming.Location = new Point(3, 21);
            txtBoxNaming.Name = "txtBoxNaming";
            txtBoxNaming.Size = new Size(176, 23);
            txtBoxNaming.TabIndex = 13;
            // 
            // labelFeatures
            // 
            labelFeatures.AutoSize = true;
            labelFeatures.Location = new Point(3, 223);
            labelFeatures.Name = "labelFeatures";
            labelFeatures.Size = new Size(77, 15);
            labelFeatures.TabIndex = 12;
            labelFeatures.Text = "Особливості";
            // 
            // labelCirculation
            // 
            labelCirculation.AutoSize = true;
            labelCirculation.Location = new Point(3, 179);
            labelCirculation.Name = "labelCirculation";
            labelCirculation.Size = new Size(42, 15);
            labelCirculation.TabIndex = 11;
            labelCirculation.Text = "Тираж";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(3, 135);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(70, 15);
            labelYear.TabIndex = 10;
            labelYear.Text = "Рік випуску";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(3, 91);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(121, 15);
            labelPrice.TabIndex = 9;
            labelPrice.Text = "Номінальна вартість";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(3, 47);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(43, 15);
            labelCountry.TabIndex = 8;
            labelCountry.Text = "Країна";
            // 
            // buttonAddMyCollection
            // 
            buttonAddMyCollection.BackColor = Color.Gainsboro;
            buttonAddMyCollection.Location = new Point(3, 383);
            buttonAddMyCollection.Name = "buttonAddMyCollection";
            buttonAddMyCollection.Size = new Size(176, 30);
            buttonAddMyCollection.TabIndex = 7;
            buttonAddMyCollection.Text = "Додати до моєї колекції";
            buttonAddMyCollection.UseVisualStyleBackColor = false;
            buttonAddMyCollection.Click += buttonAddMyCollection_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Gainsboro;
            buttonSearch.Location = new Point(3, 347);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(176, 30);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Gainsboro;
            buttonAdd.Location = new Point(3, 311);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(176, 30);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // txtBoxFeatures
            // 
            txtBoxFeatures.Location = new Point(3, 241);
            txtBoxFeatures.Name = "txtBoxFeatures";
            txtBoxFeatures.Size = new Size(176, 23);
            txtBoxFeatures.TabIndex = 4;
            // 
            // txtBoxCirculation
            // 
            txtBoxCirculation.Location = new Point(3, 197);
            txtBoxCirculation.Name = "txtBoxCirculation";
            txtBoxCirculation.Size = new Size(176, 23);
            txtBoxCirculation.TabIndex = 3;
            // 
            // txtBoxYear
            // 
            txtBoxYear.Location = new Point(3, 153);
            txtBoxYear.Name = "txtBoxYear";
            txtBoxYear.Size = new Size(176, 23);
            txtBoxYear.TabIndex = 2;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(3, 109);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(176, 23);
            txtBoxPrice.TabIndex = 1;
            txtBoxPrice.TextChanged += txtBoxPrice_TextChanged;
            // 
            // txtBoxCountry
            // 
            txtBoxCountry.Location = new Point(3, 65);
            txtBoxCountry.Name = "txtBoxCountry";
            txtBoxCountry.Size = new Size(176, 23);
            txtBoxCountry.TabIndex = 0;
            // 
            // tabCollectors
            // 
            tabCollectors.Controls.Add(dataGridViewCollectors);
            tabCollectors.Controls.Add(panel2);
            tabCollectors.Location = new Point(4, 24);
            tabCollectors.Name = "tabCollectors";
            tabCollectors.Padding = new Padding(3);
            tabCollectors.Size = new Size(776, 423);
            tabCollectors.TabIndex = 1;
            tabCollectors.Text = "Колекціонери";
            tabCollectors.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCollectors
            // 
            dataGridViewCollectors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCollectors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCollectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCollectors.Columns.AddRange(new DataGridViewColumn[] { countryCollectorColumn, nameCollectorColumn, contactCollectorColumn, rareStampsCollectorColumn });
            dataGridViewCollectors.Dock = DockStyle.Fill;
            dataGridViewCollectors.Location = new Point(185, 3);
            dataGridViewCollectors.MultiSelect = false;
            dataGridViewCollectors.Name = "dataGridViewCollectors";
            dataGridViewCollectors.ReadOnly = true;
            dataGridViewCollectors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCollectors.Size = new Size(588, 417);
            dataGridViewCollectors.TabIndex = 14;
            dataGridViewCollectors.SelectionChanged += dataGridViewCollectors_SelectionChanged;
            // 
            // countryCollectorColumn
            // 
            countryCollectorColumn.HeaderText = "Країна";
            countryCollectorColumn.Name = "countryCollectorColumn";
            countryCollectorColumn.ReadOnly = true;
            countryCollectorColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // 
            // nameCollectorColumn
            // 
            nameCollectorColumn.HeaderText = "Ім'я";
            nameCollectorColumn.Name = "nameCollectorColumn";
            nameCollectorColumn.ReadOnly = true;
            nameCollectorColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // 
            // contactCollectorColumn
            // 
            contactCollectorColumn.HeaderText = "Контактні дані";
            contactCollectorColumn.Name = "contactCollectorColumn";
            contactCollectorColumn.ReadOnly = true;
            contactCollectorColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // 
            // rareStampsCollectorColumn
            // 
            rareStampsCollectorColumn.HeaderText = "Рідкісні марки";
            rareStampsCollectorColumn.Name = "rareStampsCollectorColumn";
            rareStampsCollectorColumn.ReadOnly = true;
            rareStampsCollectorColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonEditCollectors);
            panel2.Controls.Add(labelNameOfCollectors);
            panel2.Controls.Add(labelCountryOfCollectors);
            panel2.Controls.Add(labelRareCollectors);
            panel2.Controls.Add(labelDataCollectors);
            panel2.Controls.Add(buttonSearchCollectors);
            panel2.Controls.Add(buttonAddCollectors);
            panel2.Controls.Add(txtBoxRareCollectors);
            panel2.Controls.Add(txtBoxContactCollectors);
            panel2.Controls.Add(txtBoxNameCollectors);
            panel2.Controls.Add(txtBoxCountryCollectors);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(182, 417);
            panel2.TabIndex = 1;
            // 
            // buttonEditCollectors
            // 
            buttonEditCollectors.BackColor = Color.LightGray;
            buttonEditCollectors.Location = new Point(3, 272);
            buttonEditCollectors.Name = "buttonEditCollectors";
            buttonEditCollectors.Size = new Size(176, 35);
            buttonEditCollectors.TabIndex = 14;
            buttonEditCollectors.Text = "Змінити";
            buttonEditCollectors.UseVisualStyleBackColor = false;
            buttonEditCollectors.Click += buttonEditCollectors_Click;
            // 
            // labelNameOfCollectors
            // 
            labelNameOfCollectors.AutoSize = true;
            labelNameOfCollectors.Location = new Point(3, 57);
            labelNameOfCollectors.Name = "labelNameOfCollectors";
            labelNameOfCollectors.Size = new Size(28, 15);
            labelNameOfCollectors.TabIndex = 13;
            labelNameOfCollectors.Text = "Ім'я";
            // 
            // labelCountryOfCollectors
            // 
            labelCountryOfCollectors.AutoSize = true;
            labelCountryOfCollectors.Location = new Point(3, 13);
            labelCountryOfCollectors.Name = "labelCountryOfCollectors";
            labelCountryOfCollectors.Size = new Size(43, 15);
            labelCountryOfCollectors.TabIndex = 12;
            labelCountryOfCollectors.Text = "Країна";
            // 
            // labelRareCollectors
            // 
            labelRareCollectors.AutoSize = true;
            labelRareCollectors.Location = new Point(3, 145);
            labelRareCollectors.Name = "labelRareCollectors";
            labelRareCollectors.Size = new Size(86, 15);
            labelRareCollectors.TabIndex = 11;
            labelRareCollectors.Text = "Рідкісні марки";
            // 
            // labelDataCollectors
            // 
            labelDataCollectors.AutoSize = true;
            labelDataCollectors.Location = new Point(3, 101);
            labelDataCollectors.Name = "labelDataCollectors";
            labelDataCollectors.Size = new Size(85, 15);
            labelDataCollectors.TabIndex = 10;
            labelDataCollectors.Text = "Контактні дані";
            // 
            // buttonSearchCollectors
            // 
            buttonSearchCollectors.BackColor = Color.Gainsboro;
            buttonSearchCollectors.Location = new Point(3, 354);
            buttonSearchCollectors.Name = "buttonSearchCollectors";
            buttonSearchCollectors.Size = new Size(176, 35);
            buttonSearchCollectors.TabIndex = 6;
            buttonSearchCollectors.Text = "Пошук";
            buttonSearchCollectors.UseVisualStyleBackColor = false;
            buttonSearchCollectors.Click += buttonSearchCollectors_Click;
            // 
            // buttonAddCollectors
            // 
            buttonAddCollectors.BackColor = Color.Gainsboro;
            buttonAddCollectors.Location = new Point(3, 313);
            buttonAddCollectors.Name = "buttonAddCollectors";
            buttonAddCollectors.Size = new Size(176, 35);
            buttonAddCollectors.TabIndex = 5;
            buttonAddCollectors.Text = "Додати";
            buttonAddCollectors.UseVisualStyleBackColor = false;
            buttonAddCollectors.Click += buttonAddCollectors_Click;
            // 
            // txtBoxRareCollectors
            // 
            txtBoxRareCollectors.Location = new Point(3, 163);
            txtBoxRareCollectors.Name = "txtBoxRareCollectors";
            txtBoxRareCollectors.Size = new Size(176, 23);
            txtBoxRareCollectors.TabIndex = 3;
            // 
            // txtBoxContactCollectors
            // 
            txtBoxContactCollectors.Location = new Point(3, 119);
            txtBoxContactCollectors.Name = "txtBoxContactCollectors";
            txtBoxContactCollectors.Size = new Size(176, 23);
            txtBoxContactCollectors.TabIndex = 2;
            // 
            // txtBoxNameCollectors
            // 
            txtBoxNameCollectors.Location = new Point(3, 75);
            txtBoxNameCollectors.Name = "txtBoxNameCollectors";
            txtBoxNameCollectors.Size = new Size(176, 23);
            txtBoxNameCollectors.TabIndex = 1;
            // 
            // txtBoxCountryCollectors
            // 
            txtBoxCountryCollectors.Location = new Point(3, 31);
            txtBoxCountryCollectors.Name = "txtBoxCountryCollectors";
            txtBoxCountryCollectors.Size = new Size(176, 23);
            txtBoxCountryCollectors.TabIndex = 0;
            // 
            // tabMyCollection
            // 
            tabMyCollection.Controls.Add(dataGridViewMy);
            tabMyCollection.Controls.Add(panel1);
            tabMyCollection.Location = new Point(4, 24);
            tabMyCollection.Name = "tabMyCollection";
            tabMyCollection.Size = new Size(776, 423);
            tabMyCollection.TabIndex = 2;
            tabMyCollection.Text = "Моя колекція";
            tabMyCollection.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMy
            // 
            dataGridViewMy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMy.Columns.AddRange(new DataGridViewColumn[] { nameMyColumn, countryMyColumn, priceMyColumn, yearMyColumn, circulationMyColumn, featuresMyColumn });
            dataGridViewMy.Dock = DockStyle.Fill;
            dataGridViewMy.Location = new Point(182, 0);
            dataGridViewMy.MultiSelect = false;
            dataGridViewMy.Name = "dataGridViewMy";
            dataGridViewMy.ReadOnly = true;
            dataGridViewMy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMy.Size = new Size(594, 423);
            dataGridViewMy.TabIndex = 14;
            dataGridViewMy.SelectionChanged += dataGridViewMy_SelectionChanged;
            // 
            // nameMyColumn
            // 
            nameMyColumn.HeaderText = "Назва";
            nameMyColumn.Name = "nameMyColumn";
            nameMyColumn.ReadOnly = true;
            nameMyColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // 
            // countryMyColumn
            // 
            countryMyColumn.HeaderText = "Країна";
            countryMyColumn.Name = "countryMyColumn";
            countryMyColumn.ReadOnly = true;
            countryMyColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // 
            // priceMyColumn
            // 
            priceMyColumn.HeaderText = "Номінальна вартість";
            priceMyColumn.Name = "priceMyColumn";
            priceMyColumn.ReadOnly = true;
            priceMyColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // 
            // yearMyColumn
            // 
            yearMyColumn.HeaderText = "Рік випуску";
            yearMyColumn.Name = "yearMyColumn";
            yearMyColumn.ReadOnly = true;
            yearMyColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // 
            // circulationMyColumn
            // 
            circulationMyColumn.HeaderText = "Тираж";
            circulationMyColumn.Name = "circulationMyColumn";
            circulationMyColumn.ReadOnly = true;
            countryMyColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // 
            // featuresMyColumn
            // 
            featuresMyColumn.HeaderText = "Особливості";
            featuresMyColumn.Name = "featuresMyColumn";
            featuresMyColumn.ReadOnly = true;
            featuresMyColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonRemove);
            panel1.Controls.Add(labelNamingMy);
            panel1.Controls.Add(txtBoxNamingMy);
            panel1.Controls.Add(labelFeaturesMy);
            panel1.Controls.Add(labelCirculationMy);
            panel1.Controls.Add(labelYearMy);
            panel1.Controls.Add(labelPriceMy);
            panel1.Controls.Add(labelCountryMy);
            panel1.Controls.Add(buttonSearchMy);
            panel1.Controls.Add(txtBoxFeaturesMy);
            panel1.Controls.Add(txtBoxCirculationMy);
            panel1.Controls.Add(txtBoxYearMy);
            panel1.Controls.Add(txtBoxPriceMy);
            panel1.Controls.Add(txtBoxCountryMy);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 423);
            panel1.TabIndex = 1;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.Gainsboro;
            buttonRemove.Location = new Point(3, 355);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(176, 35);
            buttonRemove.TabIndex = 15;
            buttonRemove.Text = "Видалити";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // labelNamingMy
            // 
            labelNamingMy.AutoSize = true;
            labelNamingMy.Location = new Point(3, 14);
            labelNamingMy.Name = "labelNamingMy";
            labelNamingMy.Size = new Size(39, 15);
            labelNamingMy.TabIndex = 14;
            labelNamingMy.Text = "Назва";
            // 
            // txtBoxNamingMy
            // 
            txtBoxNamingMy.Location = new Point(3, 32);
            txtBoxNamingMy.Name = "txtBoxNamingMy";
            txtBoxNamingMy.Size = new Size(176, 23);
            txtBoxNamingMy.TabIndex = 13;
            // 
            // labelFeaturesMy
            // 
            labelFeaturesMy.AutoSize = true;
            labelFeaturesMy.Location = new Point(3, 234);
            labelFeaturesMy.Name = "labelFeaturesMy";
            labelFeaturesMy.Size = new Size(77, 15);
            labelFeaturesMy.TabIndex = 12;
            labelFeaturesMy.Text = "Особливості";
            // 
            // labelCirculationMy
            // 
            labelCirculationMy.AutoSize = true;
            labelCirculationMy.Location = new Point(3, 190);
            labelCirculationMy.Name = "labelCirculationMy";
            labelCirculationMy.Size = new Size(42, 15);
            labelCirculationMy.TabIndex = 11;
            labelCirculationMy.Text = "Тираж";
            // 
            // labelYearMy
            // 
            labelYearMy.AutoSize = true;
            labelYearMy.Location = new Point(3, 146);
            labelYearMy.Name = "labelYearMy";
            labelYearMy.Size = new Size(70, 15);
            labelYearMy.TabIndex = 10;
            labelYearMy.Text = "Рік випуску";
            // 
            // labelPriceMy
            // 
            labelPriceMy.AutoSize = true;
            labelPriceMy.Location = new Point(3, 102);
            labelPriceMy.Name = "labelPriceMy";
            labelPriceMy.Size = new Size(121, 15);
            labelPriceMy.TabIndex = 9;
            labelPriceMy.Text = "Номінальна вартість";
            // 
            // labelCountryMy
            // 
            labelCountryMy.AutoSize = true;
            labelCountryMy.Location = new Point(3, 58);
            labelCountryMy.Name = "labelCountryMy";
            labelCountryMy.Size = new Size(43, 15);
            labelCountryMy.TabIndex = 8;
            labelCountryMy.Text = "Країна";
            // 
            // buttonSearchMy
            // 
            buttonSearchMy.BackColor = Color.Gainsboro;
            buttonSearchMy.Location = new Point(3, 314);
            buttonSearchMy.Name = "buttonSearchMy";
            buttonSearchMy.Size = new Size(176, 35);
            buttonSearchMy.TabIndex = 6;
            buttonSearchMy.Text = "Пошук";
            buttonSearchMy.UseVisualStyleBackColor = false;
            buttonSearchMy.Click += buttonSearchMy_Click;
            // 
            // txtBoxFeaturesMy
            // 
            txtBoxFeaturesMy.Location = new Point(3, 252);
            txtBoxFeaturesMy.Name = "txtBoxFeaturesMy";
            txtBoxFeaturesMy.Size = new Size(176, 23);
            txtBoxFeaturesMy.TabIndex = 4;
            // 
            // txtBoxCirculationMy
            // 
            txtBoxCirculationMy.Location = new Point(3, 208);
            txtBoxCirculationMy.Name = "txtBoxCirculationMy";
            txtBoxCirculationMy.Size = new Size(176, 23);
            txtBoxCirculationMy.TabIndex = 3;
            // 
            // txtBoxYearMy
            // 
            txtBoxYearMy.Location = new Point(3, 164);
            txtBoxYearMy.Name = "txtBoxYearMy";
            txtBoxYearMy.Size = new Size(176, 23);
            txtBoxYearMy.TabIndex = 2;
            // 
            // txtBoxPriceMy
            // 
            txtBoxPriceMy.Location = new Point(3, 120);
            txtBoxPriceMy.Name = "txtBoxPriceMy";
            txtBoxPriceMy.Size = new Size(176, 23);
            txtBoxPriceMy.TabIndex = 1;
            // 
            // txtBoxCountryMy
            // 
            txtBoxCountryMy.Location = new Point(3, 76);
            txtBoxCountryMy.Name = "txtBoxCountryMy";
            txtBoxCountryMy.Size = new Size(176, 23);
            txtBoxCountryMy.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 451);
            Controls.Add(tabControl1);
            MinimumSize = new Size(800, 490);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stamp Collection";
            tabControl1.ResumeLayout(false);
            tabStamps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStamps).EndInit();
            panelStamps.ResumeLayout(false);
            panelStamps.PerformLayout();
            tabCollectors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCollectors).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabMyCollection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMy).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabStamps;
        private TabPage tabCollectors;
        private TabPage tabMyCollection;
        private Panel panelStamps;
        private TextBox txtBoxPrice;
        private TextBox txtBoxCountry;
        private Button buttonAddMyCollection;
        private Button buttonSearch;
        private Button buttonAdd;
        private TextBox txtBoxFeatures;
        private TextBox txtBoxCirculation;
        private TextBox txtBoxYear;
        private Label labelPrice;
        private Label labelCountry;
        private Label labelYear;
        private Label labelCirculation;
        private Label labelFeatures;
        private Panel panel1;
        private Label labelFeaturesMy;
        private Label labelCirculationMy;
        private Label labelYearMy;
        private Label labelPriceMy;
        private Label labelCountryMy;
        private Button buttonSearchMy;
        private TextBox txtBoxFeaturesMy;
        private TextBox txtBoxCirculationMy;
        private TextBox txtBoxYearMy;
        private TextBox txtBoxPriceMy;
        private TextBox txtBoxCountryMy;
        private Panel panel2;
        private Label labelNameOfCollectors;
        private Label labelCountryOfCollectors;
        private Label labelRareCollectors;
        private Label labelDataCollectors;
        private Button buttonSearchCollectors;
        private Button buttonAddCollectors;
        private TextBox txtBoxRareCollectors;
        private TextBox txtBoxContactCollectors;
        private TextBox txtBoxNameCollectors;
        private TextBox txtBoxCountryCollectors;
        private DataGridView dataGridViewStamps;
        private DataGridView dataGridViewCollectors;
        private DataGridView dataGridViewMy;
        private Label labelNaming;
        private TextBox txtBoxNaming;
        private Label labelNamingMy;
        private TextBox txtBoxNamingMy;
        private Button buttonRemove;
        private DataGridViewTextBoxColumn nameStampColumn;
        private DataGridViewTextBoxColumn countryStampColumn;
        private DataGridViewTextBoxColumn priceStampColumn;
        private DataGridViewTextBoxColumn yearStampColumn;
        private DataGridViewTextBoxColumn circulationStampColumn;
        private DataGridViewTextBoxColumn featuresStampColumn;
        private DataGridViewTextBoxColumn countryCollectorColumn;
        private DataGridViewTextBoxColumn nameCollectorColumn;
        private DataGridViewTextBoxColumn contactCollectorColumn;
        private DataGridViewTextBoxColumn rareStampsCollectorColumn;
        private DataGridViewTextBoxColumn nameMyColumn;
        private DataGridViewTextBoxColumn countryMyColumn;
        private DataGridViewTextBoxColumn priceMyColumn;
        private DataGridViewTextBoxColumn yearMyColumn;
        private DataGridViewTextBoxColumn circulationMyColumn;
        private DataGridViewTextBoxColumn featuresMyColumn;
        private Button buttonEditStamp;
        private Button buttonEditCollectors;
    }
}