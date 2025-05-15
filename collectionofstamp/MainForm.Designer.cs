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
            listBoxStamps = new ListBox();
            panelStamps = new Panel();
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
            listBoxCollectors = new ListBox();
            panel2 = new Panel();
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
            listBoxMy = new ListBox();
            panel1 = new Panel();
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
            panelStamps.SuspendLayout();
            tabCollectors.SuspendLayout();
            panel2.SuspendLayout();
            tabMyCollection.SuspendLayout();
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
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabStamps
            // 
            tabStamps.Controls.Add(listBoxStamps);
            tabStamps.Controls.Add(panelStamps);
            tabStamps.Location = new Point(4, 24);
            tabStamps.Name = "tabStamps";
            tabStamps.Padding = new Padding(3);
            tabStamps.Size = new Size(792, 422);
            tabStamps.TabIndex = 0;
            tabStamps.Text = "Марки";
            tabStamps.UseVisualStyleBackColor = true;
            // 
            // listBoxStamps
            // 
            listBoxStamps.Dock = DockStyle.Fill;
            listBoxStamps.FormattingEnabled = true;
            listBoxStamps.ItemHeight = 15;
            listBoxStamps.Location = new Point(185, 3);
            listBoxStamps.Name = "listBoxStamps";
            listBoxStamps.Size = new Size(604, 416);
            listBoxStamps.TabIndex = 13;
            listBoxStamps.SelectedIndexChanged += listBoxStamps_SelectedIndexChanged;
            // 
            // panelStamps
            // 
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
            panelStamps.Size = new Size(182, 416);
            panelStamps.TabIndex = 0;
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
            buttonAddMyCollection.Location = new Point(3, 368);
            buttonAddMyCollection.Name = "buttonAddMyCollection";
            buttonAddMyCollection.Size = new Size(176, 35);
            buttonAddMyCollection.TabIndex = 7;
            buttonAddMyCollection.Text = "Додати до моєї колекції";
            buttonAddMyCollection.UseVisualStyleBackColor = true;
            buttonAddMyCollection.Click += buttonAddMyCollection_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(3, 327);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(176, 35);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 286);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(176, 35);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
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
            tabCollectors.Controls.Add(listBoxCollectors);
            tabCollectors.Controls.Add(panel2);
            tabCollectors.Location = new Point(4, 24);
            tabCollectors.Name = "tabCollectors";
            tabCollectors.Padding = new Padding(3);
            tabCollectors.Size = new Size(792, 422);
            tabCollectors.TabIndex = 1;
            tabCollectors.Text = "Колекціонери";
            tabCollectors.UseVisualStyleBackColor = true;
            // 
            // listBoxCollectors
            // 
            listBoxCollectors.Dock = DockStyle.Fill;
            listBoxCollectors.FormattingEnabled = true;
            listBoxCollectors.ItemHeight = 15;
            listBoxCollectors.Location = new Point(185, 3);
            listBoxCollectors.Name = "listBoxCollectors";
            listBoxCollectors.Size = new Size(604, 416);
            listBoxCollectors.TabIndex = 14;
            listBoxCollectors.SelectedIndexChanged += listBoxCollectors_SelectedIndexChanged;
            // 
            // panel2
            // 
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
            panel2.Size = new Size(182, 416);
            panel2.TabIndex = 1;
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
            buttonSearchCollectors.Location = new Point(3, 327);
            buttonSearchCollectors.Name = "buttonSearchCollectors";
            buttonSearchCollectors.Size = new Size(176, 35);
            buttonSearchCollectors.TabIndex = 6;
            buttonSearchCollectors.Text = "Пошук";
            buttonSearchCollectors.UseVisualStyleBackColor = true;
            buttonSearchCollectors.Click += buttonSearchCollectors_Click;
            // 
            // buttonAddCollectors
            // 
            buttonAddCollectors.Location = new Point(3, 286);
            buttonAddCollectors.Name = "buttonAddCollectors";
            buttonAddCollectors.Size = new Size(176, 35);
            buttonAddCollectors.TabIndex = 5;
            buttonAddCollectors.Text = "Додати";
            buttonAddCollectors.UseVisualStyleBackColor = true;
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
            tabMyCollection.Controls.Add(listBoxMy);
            tabMyCollection.Controls.Add(panel1);
            tabMyCollection.Location = new Point(4, 24);
            tabMyCollection.Name = "tabMyCollection";
            tabMyCollection.Size = new Size(792, 422);
            tabMyCollection.TabIndex = 2;
            tabMyCollection.Text = "Моя колекція";
            tabMyCollection.UseVisualStyleBackColor = true;
            // 
            // listBoxMy
            // 
            listBoxMy.Dock = DockStyle.Fill;
            listBoxMy.FormattingEnabled = true;
            listBoxMy.ItemHeight = 15;
            listBoxMy.Location = new Point(182, 0);
            listBoxMy.Name = "listBoxMy";
            listBoxMy.Size = new Size(610, 422);
            listBoxMy.TabIndex = 14;
            listBoxMy.SelectedIndexChanged += listBoxMy_SelectedIndexChanged;
            // 
            // panel1
            // 
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
            panel1.Size = new Size(182, 422);
            panel1.TabIndex = 1;
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
            buttonSearchMy.Location = new Point(3, 327);
            buttonSearchMy.Name = "buttonSearchMy";
            buttonSearchMy.Size = new Size(176, 35);
            buttonSearchMy.TabIndex = 6;
            buttonSearchMy.Text = "Пошук";
            buttonSearchMy.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Stamp Collection";
            tabControl1.ResumeLayout(false);
            tabStamps.ResumeLayout(false);
            panelStamps.ResumeLayout(false);
            panelStamps.PerformLayout();
            tabCollectors.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabMyCollection.ResumeLayout(false);
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
        private ListBox listBoxStamps;
        private ListBox listBoxCollectors;
        private ListBox listBoxMy;
        private Label labelNaming;
        private TextBox txtBoxNaming;
        private Label labelNamingMy;
        private TextBox txtBoxNamingMy;
    }
}
