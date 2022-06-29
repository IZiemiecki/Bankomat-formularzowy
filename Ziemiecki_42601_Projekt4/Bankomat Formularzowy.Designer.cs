namespace Ziemiecki_42601_Projekt4
{
    partial class iz_PulpitBankomatu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.iz_tabWypNom = new System.Windows.Forms.TabPage();
            this.iz_lblListaWypłaconychNominałów = new System.Windows.Forms.Label();
            this.iz_dvgListaWypłaty = new System.Windows.Forms.DataGridView();
            this.LiczbaWyłacanychNominałów = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WartośćWypłacanegoNominału = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RodzajNominału = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RodzajWaluty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iz_tabZlecWyp = new System.Windows.Forms.TabPage();
            this.iz_btnEXIT = new System.Windows.Forms.Button();
            this.iz_cmbRodzajWaluty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iz_btnAkceptacja = new System.Windows.Forms.Button();
            this.iz_btnResetuj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.iz_txtKwotaDoWyplaty = new System.Windows.Forms.TextBox();
            this.iz_tabKonBan = new System.Windows.Forms.TabPage();
            this.iz_btnPrzejdźDoZlecenia = new System.Windows.Forms.Button();
            this.iz_lbInfoBoxKB = new System.Windows.Forms.Label();
            this.iz_btnAkceptujNominały = new System.Windows.Forms.Button();
            this.iz_lbGórnaGranicaPrzedziału = new System.Windows.Forms.Label();
            this.iz_lbDolnaGranicaPrzedziału = new System.Windows.Forms.Label();
            this.iz_txtGórnaGranica = new System.Windows.Forms.TextBox();
            this.iz_txtDolnaGranica = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iz_rbLosowo = new System.Windows.Forms.RadioButton();
            this.iz_rbDomyślna = new System.Windows.Forms.RadioButton();
            this.iz_cmbListaWalutKonfiguracja = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.iz_btnCzyChceszPonownie = new System.Windows.Forms.Button();
            this.iz_btnZakończProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.iz_tabWypNom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iz_dvgListaWypłaty)).BeginInit();
            this.iz_tabZlecWyp.SuspendLayout();
            this.iz_tabKonBan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // iz_tabWypNom
            // 
            this.iz_tabWypNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iz_tabWypNom.Controls.Add(this.iz_btnZakończProgram);
            this.iz_tabWypNom.Controls.Add(this.iz_btnCzyChceszPonownie);
            this.iz_tabWypNom.Controls.Add(this.iz_lblListaWypłaconychNominałów);
            this.iz_tabWypNom.Controls.Add(this.iz_dvgListaWypłaty);
            this.iz_tabWypNom.Location = new System.Drawing.Point(4, 22);
            this.iz_tabWypNom.Name = "iz_tabWypNom";
            this.iz_tabWypNom.Size = new System.Drawing.Size(828, 389);
            this.iz_tabWypNom.TabIndex = 2;
            this.iz_tabWypNom.Text = "Wypłata nominałów";
            // 
            // iz_lblListaWypłaconychNominałów
            // 
            this.iz_lblListaWypłaconychNominałów.AutoSize = true;
            this.iz_lblListaWypłaconychNominałów.BackColor = System.Drawing.Color.Transparent;
            this.iz_lblListaWypłaconychNominałów.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.iz_lblListaWypłaconychNominałów.Location = new System.Drawing.Point(282, 13);
            this.iz_lblListaWypłaconychNominałów.Name = "iz_lblListaWypłaconychNominałów";
            this.iz_lblListaWypłaconychNominałów.Size = new System.Drawing.Size(246, 19);
            this.iz_lblListaWypłaconychNominałów.TabIndex = 8;
            this.iz_lblListaWypłaconychNominałów.Text = "Lista wypłaconych nominałów:";
            this.iz_lblListaWypłaconychNominałów.Visible = false;
            // 
            // iz_dvgListaWypłaty
            // 
            this.iz_dvgListaWypłaty.AllowUserToAddRows = false;
            this.iz_dvgListaWypłaty.AllowUserToDeleteRows = false;
            this.iz_dvgListaWypłaty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iz_dvgListaWypłaty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LiczbaWyłacanychNominałów,
            this.WartośćWypłacanegoNominału,
            this.RodzajNominału,
            this.RodzajWaluty});
            this.iz_dvgListaWypłaty.Location = new System.Drawing.Point(11, 96);
            this.iz_dvgListaWypłaty.Name = "iz_dvgListaWypłaty";
            this.iz_dvgListaWypłaty.ReadOnly = true;
            this.iz_dvgListaWypłaty.Size = new System.Drawing.Size(794, 152);
            this.iz_dvgListaWypłaty.TabIndex = 9;
            this.iz_dvgListaWypłaty.Visible = false;
            // 
            // LiczbaWyłacanychNominałów
            // 
            this.LiczbaWyłacanychNominałów.HeaderText = "Liczba wypłacanych nominałów";
            this.LiczbaWyłacanychNominałów.Name = "LiczbaWyłacanychNominałów";
            this.LiczbaWyłacanychNominałów.ReadOnly = true;
            this.LiczbaWyłacanychNominałów.Width = 150;
            // 
            // WartośćWypłacanegoNominału
            // 
            this.WartośćWypłacanegoNominału.HeaderText = "Wartość wypłacanego nominału";
            this.WartośćWypłacanegoNominału.Name = "WartośćWypłacanegoNominału";
            this.WartośćWypłacanegoNominału.ReadOnly = true;
            this.WartośćWypłacanegoNominału.Width = 200;
            // 
            // RodzajNominału
            // 
            this.RodzajNominału.HeaderText = "Rodzaj nominału (banknot lub moneta)";
            this.RodzajNominału.Name = "RodzajNominału";
            this.RodzajNominału.ReadOnly = true;
            this.RodzajNominału.Width = 200;
            // 
            // RodzajWaluty
            // 
            this.RodzajWaluty.HeaderText = "Rodzaj waluty";
            this.RodzajWaluty.Name = "RodzajWaluty";
            this.RodzajWaluty.ReadOnly = true;
            this.RodzajWaluty.Width = 200;
            // 
            // iz_tabZlecWyp
            // 
            this.iz_tabZlecWyp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iz_tabZlecWyp.Controls.Add(this.iz_btnEXIT);
            this.iz_tabZlecWyp.Controls.Add(this.iz_cmbRodzajWaluty);
            this.iz_tabZlecWyp.Controls.Add(this.label3);
            this.iz_tabZlecWyp.Controls.Add(this.iz_btnAkceptacja);
            this.iz_tabZlecWyp.Controls.Add(this.iz_btnResetuj);
            this.iz_tabZlecWyp.Controls.Add(this.label4);
            this.iz_tabZlecWyp.Controls.Add(this.iz_txtKwotaDoWyplaty);
            this.iz_tabZlecWyp.Location = new System.Drawing.Point(4, 22);
            this.iz_tabZlecWyp.Name = "iz_tabZlecWyp";
            this.iz_tabZlecWyp.Padding = new System.Windows.Forms.Padding(3);
            this.iz_tabZlecWyp.Size = new System.Drawing.Size(828, 389);
            this.iz_tabZlecWyp.TabIndex = 1;
            this.iz_tabZlecWyp.Text = "Zlecenie Wypłaty";
            // 
            // iz_btnEXIT
            // 
            this.iz_btnEXIT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.iz_btnEXIT.Location = new System.Drawing.Point(217, 269);
            this.iz_btnEXIT.Name = "iz_btnEXIT";
            this.iz_btnEXIT.Size = new System.Drawing.Size(346, 61);
            this.iz_btnEXIT.TabIndex = 8;
            this.iz_btnEXIT.Text = "REZYGNACJA Z WYPŁATY\r\n(wyjdź z programu)";
            this.iz_btnEXIT.UseVisualStyleBackColor = true;
            this.iz_btnEXIT.Click += new System.EventHandler(this.iz_btnEXIT_Click);
            // 
            // iz_cmbRodzajWaluty
            // 
            this.iz_cmbRodzajWaluty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.iz_cmbRodzajWaluty.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.iz_cmbRodzajWaluty.Items.AddRange(new object[] {
            "Złotówki \tPLN",
            "Euro \tEUR"});
            this.iz_cmbRodzajWaluty.Location = new System.Drawing.Point(87, 109);
            this.iz_cmbRodzajWaluty.Name = "iz_cmbRodzajWaluty";
            this.iz_cmbRodzajWaluty.Size = new System.Drawing.Size(169, 24);
            this.iz_cmbRodzajWaluty.TabIndex = 3;
            this.iz_cmbRodzajWaluty.Text = "Lista walut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(83, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wybierz rodzaj waluty:";
            // 
            // iz_btnAkceptacja
            // 
            this.iz_btnAkceptacja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.iz_btnAkceptacja.Location = new System.Drawing.Point(324, 205);
            this.iz_btnAkceptacja.Name = "iz_btnAkceptacja";
            this.iz_btnAkceptacja.Size = new System.Drawing.Size(132, 26);
            this.iz_btnAkceptacja.TabIndex = 6;
            this.iz_btnAkceptacja.Text = "AKCEPTACJA";
            this.iz_btnAkceptacja.UseVisualStyleBackColor = true;
            this.iz_btnAkceptacja.Click += new System.EventHandler(this.iz_btnAkceptacja_Click);
            // 
            // iz_btnResetuj
            // 
            this.iz_btnResetuj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.iz_btnResetuj.Location = new System.Drawing.Point(338, 237);
            this.iz_btnResetuj.Name = "iz_btnResetuj";
            this.iz_btnResetuj.Size = new System.Drawing.Size(103, 26);
            this.iz_btnResetuj.TabIndex = 7;
            this.iz_btnResetuj.Text = "RESETUJ";
            this.iz_btnResetuj.UseVisualStyleBackColor = true;
            this.iz_btnResetuj.Visible = false;
            this.iz_btnResetuj.Click += new System.EventHandler(this.iz_btnResetuj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(346, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wpisz wysokość\r\nkwoty do wypłaty:";
            // 
            // iz_txtKwotaDoWyplaty
            // 
            this.iz_txtKwotaDoWyplaty.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.iz_txtKwotaDoWyplaty.Location = new System.Drawing.Point(500, 109);
            this.iz_txtKwotaDoWyplaty.Name = "iz_txtKwotaDoWyplaty";
            this.iz_txtKwotaDoWyplaty.Size = new System.Drawing.Size(108, 23);
            this.iz_txtKwotaDoWyplaty.TabIndex = 5;
            // 
            // iz_tabKonBan
            // 
            this.iz_tabKonBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iz_tabKonBan.Controls.Add(this.iz_btnPrzejdźDoZlecenia);
            this.iz_tabKonBan.Controls.Add(this.iz_lbInfoBoxKB);
            this.iz_tabKonBan.Controls.Add(this.iz_btnAkceptujNominały);
            this.iz_tabKonBan.Controls.Add(this.iz_lbGórnaGranicaPrzedziału);
            this.iz_tabKonBan.Controls.Add(this.iz_lbDolnaGranicaPrzedziału);
            this.iz_tabKonBan.Controls.Add(this.iz_txtGórnaGranica);
            this.iz_tabKonBan.Controls.Add(this.iz_txtDolnaGranica);
            this.iz_tabKonBan.Controls.Add(this.groupBox1);
            this.iz_tabKonBan.Controls.Add(this.iz_cmbListaWalutKonfiguracja);
            this.iz_tabKonBan.Controls.Add(this.label5);
            this.iz_tabKonBan.Controls.Add(this.label1);
            this.iz_tabKonBan.Controls.Add(this.label2);
            this.iz_tabKonBan.Location = new System.Drawing.Point(4, 22);
            this.iz_tabKonBan.Name = "iz_tabKonBan";
            this.iz_tabKonBan.Padding = new System.Windows.Forms.Padding(3);
            this.iz_tabKonBan.Size = new System.Drawing.Size(828, 389);
            this.iz_tabKonBan.TabIndex = 0;
            this.iz_tabKonBan.Text = "Konfiguracja Bankomatu";
            // 
            // iz_btnPrzejdźDoZlecenia
            // 
            this.iz_btnPrzejdźDoZlecenia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.iz_btnPrzejdźDoZlecenia.Location = new System.Drawing.Point(584, 261);
            this.iz_btnPrzejdźDoZlecenia.Name = "iz_btnPrzejdźDoZlecenia";
            this.iz_btnPrzejdźDoZlecenia.Size = new System.Drawing.Size(234, 38);
            this.iz_btnPrzejdźDoZlecenia.TabIndex = 13;
            this.iz_btnPrzejdźDoZlecenia.Text = "Przejdź do zlecenia wypłaty";
            this.iz_btnPrzejdźDoZlecenia.UseVisualStyleBackColor = true;
            this.iz_btnPrzejdźDoZlecenia.Click += new System.EventHandler(this.button1_Click);
            // 
            // iz_lbInfoBoxKB
            // 
            this.iz_lbInfoBoxKB.BackColor = System.Drawing.Color.Transparent;
            this.iz_lbInfoBoxKB.Font = new System.Drawing.Font("Arial", 10F);
            this.iz_lbInfoBoxKB.Location = new System.Drawing.Point(22, 288);
            this.iz_lbInfoBoxKB.Name = "iz_lbInfoBoxKB";
            this.iz_lbInfoBoxKB.Size = new System.Drawing.Size(250, 70);
            this.iz_lbInfoBoxKB.TabIndex = 12;
            // 
            // iz_btnAkceptujNominały
            // 
            this.iz_btnAkceptujNominały.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.iz_btnAkceptujNominały.Location = new System.Drawing.Point(468, 267);
            this.iz_btnAkceptujNominały.Name = "iz_btnAkceptujNominały";
            this.iz_btnAkceptujNominały.Size = new System.Drawing.Size(110, 26);
            this.iz_btnAkceptujNominały.TabIndex = 11;
            this.iz_btnAkceptujNominały.Text = "Akceptuj";
            this.iz_btnAkceptujNominały.UseVisualStyleBackColor = true;
            this.iz_btnAkceptujNominały.Visible = false;
            this.iz_btnAkceptujNominały.Click += new System.EventHandler(this.iz_btnAkceptujNominały_Click);
            // 
            // iz_lbGórnaGranicaPrzedziału
            // 
            this.iz_lbGórnaGranicaPrzedziału.AutoSize = true;
            this.iz_lbGórnaGranicaPrzedziału.BackColor = System.Drawing.Color.Transparent;
            this.iz_lbGórnaGranicaPrzedziału.Font = new System.Drawing.Font("Arial", 10F);
            this.iz_lbGórnaGranicaPrzedziału.Location = new System.Drawing.Point(352, 227);
            this.iz_lbGórnaGranicaPrzedziału.Name = "iz_lbGórnaGranicaPrzedziału";
            this.iz_lbGórnaGranicaPrzedziału.Size = new System.Drawing.Size(207, 16);
            this.iz_lbGórnaGranicaPrzedziału.TabIndex = 10;
            this.iz_lbGórnaGranicaPrzedziału.Text = "Podaj górną granicę przedziału:";
            this.iz_lbGórnaGranicaPrzedziału.Visible = false;
            // 
            // iz_lbDolnaGranicaPrzedziału
            // 
            this.iz_lbDolnaGranicaPrzedziału.AutoSize = true;
            this.iz_lbDolnaGranicaPrzedziału.BackColor = System.Drawing.Color.Transparent;
            this.iz_lbDolnaGranicaPrzedziału.Font = new System.Drawing.Font("Arial", 10F);
            this.iz_lbDolnaGranicaPrzedziału.Location = new System.Drawing.Point(352, 201);
            this.iz_lbDolnaGranicaPrzedziału.Name = "iz_lbDolnaGranicaPrzedziału";
            this.iz_lbDolnaGranicaPrzedziału.Size = new System.Drawing.Size(205, 16);
            this.iz_lbDolnaGranicaPrzedziału.TabIndex = 9;
            this.iz_lbDolnaGranicaPrzedziału.Text = "Podaj dolną granicę przedziału:";
            this.iz_lbDolnaGranicaPrzedziału.Visible = false;
            // 
            // iz_txtGórnaGranica
            // 
            this.iz_txtGórnaGranica.Location = new System.Drawing.Point(577, 226);
            this.iz_txtGórnaGranica.Name = "iz_txtGórnaGranica";
            this.iz_txtGórnaGranica.Size = new System.Drawing.Size(100, 20);
            this.iz_txtGórnaGranica.TabIndex = 8;
            this.iz_txtGórnaGranica.Visible = false;
            // 
            // iz_txtDolnaGranica
            // 
            this.iz_txtDolnaGranica.Location = new System.Drawing.Point(577, 200);
            this.iz_txtDolnaGranica.Name = "iz_txtDolnaGranica";
            this.iz_txtDolnaGranica.Size = new System.Drawing.Size(100, 20);
            this.iz_txtDolnaGranica.TabIndex = 7;
            this.iz_txtDolnaGranica.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iz_rbLosowo);
            this.groupBox1.Controls.Add(this.iz_rbDomyślna);
            this.groupBox1.Location = new System.Drawing.Point(311, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 66);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz wartość nominałów w bankomacie";
            // 
            // iz_rbLosowo
            // 
            this.iz_rbLosowo.AutoSize = true;
            this.iz_rbLosowo.Font = new System.Drawing.Font("Arial", 8.25F);
            this.iz_rbLosowo.Location = new System.Drawing.Point(250, 23);
            this.iz_rbLosowo.Name = "iz_rbLosowo";
            this.iz_rbLosowo.Size = new System.Drawing.Size(171, 32);
            this.iz_rbLosowo.TabIndex = 6;
            this.iz_rbLosowo.TabStop = true;
            this.iz_rbLosowo.Text = "Liczba losowana z podanego \r\nprzedziału liczbowego";
            this.iz_rbLosowo.UseVisualStyleBackColor = true;
            this.iz_rbLosowo.CheckedChanged += new System.EventHandler(this.iz_rbLosowo_CheckedChanged);
            // 
            // iz_rbDomyślna
            // 
            this.iz_rbDomyślna.AutoSize = true;
            this.iz_rbDomyślna.Font = new System.Drawing.Font("Arial", 8.25F);
            this.iz_rbDomyślna.Location = new System.Drawing.Point(44, 30);
            this.iz_rbDomyślna.Name = "iz_rbDomyślna";
            this.iz_rbDomyślna.Size = new System.Drawing.Size(139, 18);
            this.iz_rbDomyślna.TabIndex = 5;
            this.iz_rbDomyślna.TabStop = true;
            this.iz_rbDomyślna.Text = "Domyślna (25 każdego)";
            this.iz_rbDomyślna.UseVisualStyleBackColor = true;
            this.iz_rbDomyślna.CheckedChanged += new System.EventHandler(this.iz_rbDomyślna_CheckedChanged);
            // 
            // iz_cmbListaWalutKonfiguracja
            // 
            this.iz_cmbListaWalutKonfiguracja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.iz_cmbListaWalutKonfiguracja.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.iz_cmbListaWalutKonfiguracja.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.iz_cmbListaWalutKonfiguracja.Items.AddRange(new object[] {
            "Złotówki \tPLN",
            "Euro \tEUR"});
            this.iz_cmbListaWalutKonfiguracja.Location = new System.Drawing.Point(62, 119);
            this.iz_cmbListaWalutKonfiguracja.Name = "iz_cmbListaWalutKonfiguracja";
            this.iz_cmbListaWalutKonfiguracja.Size = new System.Drawing.Size(169, 24);
            this.iz_cmbListaWalutKonfiguracja.TabIndex = 4;
            this.iz_cmbListaWalutKonfiguracja.Text = "Lista walut";
            this.iz_cmbListaWalutKonfiguracja.SelectedIndexChanged += new System.EventHandler(this.iz_cmbListaWalutKonfiguracja_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(58, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Wybierz rodzaj waluty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(305, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANKOMAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8F);
            this.label2.Location = new System.Drawing.Point(308, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "(ustawienia wstępne bankomatu)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.iz_tabKonBan);
            this.tabControl1.Controls.Add(this.iz_tabZlecWyp);
            this.tabControl1.Controls.Add(this.iz_tabWypNom);
            this.tabControl1.Location = new System.Drawing.Point(-3, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 415);
            this.tabControl1.TabIndex = 10;
            // 
            // iz_btnCzyChceszPonownie
            // 
            this.iz_btnCzyChceszPonownie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.iz_btnCzyChceszPonownie.Location = new System.Drawing.Point(286, 267);
            this.iz_btnCzyChceszPonownie.Name = "iz_btnCzyChceszPonownie";
            this.iz_btnCzyChceszPonownie.Size = new System.Drawing.Size(276, 26);
            this.iz_btnCzyChceszPonownie.TabIndex = 10;
            this.iz_btnCzyChceszPonownie.Text = "Czy chcesz wypłacić ponownie?";
            this.iz_btnCzyChceszPonownie.UseVisualStyleBackColor = true;
            this.iz_btnCzyChceszPonownie.Visible = false;
            this.iz_btnCzyChceszPonownie.Click += new System.EventHandler(this.iz_btnCzyChceszPonownie_Click_1);
            // 
            // iz_btnZakończProgram
            // 
            this.iz_btnZakończProgram.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.iz_btnZakończProgram.Location = new System.Drawing.Point(253, 299);
            this.iz_btnZakończProgram.Name = "iz_btnZakończProgram";
            this.iz_btnZakończProgram.Size = new System.Drawing.Size(346, 61);
            this.iz_btnZakończProgram.TabIndex = 11;
            this.iz_btnZakończProgram.Text = "Zakończ program";
            this.iz_btnZakończProgram.UseVisualStyleBackColor = true;
            this.iz_btnZakończProgram.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // iz_PulpitBankomatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 412);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "iz_PulpitBankomatu";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pulpit Bankomatu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.iz_PulpitBankomatu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.iz_tabWypNom.ResumeLayout(false);
            this.iz_tabWypNom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iz_dvgListaWypłaty)).EndInit();
            this.iz_tabZlecWyp.ResumeLayout(false);
            this.iz_tabZlecWyp.PerformLayout();
            this.iz_tabKonBan.ResumeLayout(false);
            this.iz_tabKonBan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage iz_tabKonBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton iz_rbLosowo;
        private System.Windows.Forms.RadioButton iz_rbDomyślna;
        private System.Windows.Forms.ComboBox iz_cmbListaWalutKonfiguracja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage iz_tabZlecWyp;
        private System.Windows.Forms.Button iz_btnEXIT;
        private System.Windows.Forms.ComboBox iz_cmbRodzajWaluty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button iz_btnAkceptacja;
        private System.Windows.Forms.Button iz_btnResetuj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox iz_txtKwotaDoWyplaty;
        private System.Windows.Forms.TabPage iz_tabWypNom;
        private System.Windows.Forms.Label iz_lblListaWypłaconychNominałów;
        private System.Windows.Forms.DataGridView iz_dvgListaWypłaty;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiczbaWyłacanychNominałów;
        private System.Windows.Forms.DataGridViewTextBoxColumn WartośćWypłacanegoNominału;
        private System.Windows.Forms.DataGridViewTextBoxColumn RodzajNominału;
        private System.Windows.Forms.DataGridViewTextBoxColumn RodzajWaluty;
        private System.Windows.Forms.Button iz_btnAkceptujNominały;
        private System.Windows.Forms.Label iz_lbGórnaGranicaPrzedziału;
        private System.Windows.Forms.Label iz_lbDolnaGranicaPrzedziału;
        private System.Windows.Forms.TextBox iz_txtGórnaGranica;
        private System.Windows.Forms.TextBox iz_txtDolnaGranica;
        private System.Windows.Forms.Label iz_lbInfoBoxKB;
        private System.Windows.Forms.Button iz_btnPrzejdźDoZlecenia;
        private System.Windows.Forms.Button iz_btnZakończProgram;
        private System.Windows.Forms.Button iz_btnCzyChceszPonownie;
    }
}

