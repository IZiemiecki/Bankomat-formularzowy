using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ziemiecki_42601_Projekt4
{
    public partial class iz_PulpitBankomatu : Form
    {

        int iz_IloscPieniedzyPLN = 0;
        int iz_IloscPieniedzyEURO = 0;
        int[,] iz_NominałyBankomatuPLN = {{25, 200},
                                              {25, 100},
                                              {25, 50},
                                              {25, 20},
                                              {25, 10},
                                              {25, 5},
                                              {25, 2},
                                              {25, 1}};
        const int iz_NajmniejszyNominałBanknotuPLN = 10;

        int[,] iz_NominałyBankomatuEURO = {{25, 500},
                                               {25, 200},
                                               {25, 100},
                                               {25, 50},
                                               {25, 20},
                                               {25, 10},
                                               {25, 5},
                                               {25, 2},
                                               {25, 1}};
        const int iz_NajmniejszyNominałBanknotuEURO = 5;

        public iz_PulpitBankomatu()
        {
            InitializeComponent();
            this.Left = 30;
            this.Top = 30;
            this.AutoScroll = true;    //autoscroll w przypadku braku miejsca
            iz_cmbRodzajWaluty.SelectedIndex = 0; // domyślnie pln
            iz_cmbListaWalutKonfiguracja.SelectedIndex = 0; // domyslnie pln
            this.tabControl1.SelectedTab = iz_tabKonBan; //tab (Kon)figuracja (Ban)komatu
            iz_rbDomyślna.Checked = true;
            iz_rbLosowo.Checked = false;

            tabControl1.TabPages.Remove(iz_tabWypNom);
            tabControl1.TabPages.Remove(iz_tabZlecWyp); //usunięcie dwóch zakładek aby nie były dostępne przed skonfigurowaniem programu, pojawią się po konfiguracji

        }

        private void iz_ObliczPozostalaIloscPieniedzy()
        {
            //resetowanie wartosci przed ponownym ich zapisywaniem
            iz_IloscPieniedzyPLN = 0;
            iz_IloscPieniedzyEURO = 0;
            for (int i = 0; i < iz_NominałyBankomatuPLN.GetLength(0); i++)
                iz_IloscPieniedzyPLN += iz_NominałyBankomatuPLN[i, 0] * iz_NominałyBankomatuPLN[i, 1];

            for (int i = 0; i < iz_NominałyBankomatuEURO.GetLength(0); i++)
                iz_IloscPieniedzyEURO += iz_NominałyBankomatuEURO[i, 0] * iz_NominałyBankomatuEURO[i, 1];
        }

        private void iz_btnAkceptacja_Click(object sender, EventArgs e)
        {
            //deklaracje
            int iz_KwotaDoWypłaty = 0, iz_ResztaDoWypłaty = 0, iz_Index = 0, iz_i = 0, iz_LiczbaNominałów = 0;

            //sprawdzanie, czy bankomat nie jest pusty
            iz_ObliczPozostalaIloscPieniedzy(); //(re-)obliczenie ilosci pieniedzy w bankomacie (dla obu walut
            if (iz_IloscPieniedzyPLN == 0 && iz_IloscPieniedzyEURO == 0)
            {
                iz_btnAkceptacja.Enabled = false;
                iz_cmbRodzajWaluty.Enabled = false;
                iz_txtKwotaDoWyplaty.Enabled = false;
                errorProvider1.SetError(iz_txtKwotaDoWyplaty, "ERROR: Bankomat wypłacił wszystkie pieniądze,\n\tzarówno PLN jak i EURO.");
            }

            //sprawdzanie bledow
            //zła waluta
            if (iz_cmbListaWalutKonfiguracja.SelectedIndex != 0 && iz_cmbListaWalutKonfiguracja.SelectedIndex != 1)
            {
                errorProvider1.SetError(iz_cmbListaWalutKonfiguracja, "ERROR: wybrano niepoprawną walutę!\nWybierz ponownie z podanej listy.");
                return;
            }
            else
                errorProvider1.Dispose();

            //kwota pusta
            if (iz_cmbRodzajWaluty.SelectedIndex != 0 && iz_cmbRodzajWaluty.SelectedIndex != 1)
            {
                errorProvider1.SetError(iz_cmbRodzajWaluty, "ERROR: wybrano niepoprawną walutę!");
                return;
            }

            if (string.IsNullOrEmpty(iz_txtKwotaDoWyplaty.Text))
            {
                errorProvider1.SetError(iz_txtKwotaDoWyplaty, "ERROR: brak podanej kwoty do wypłaty!");
                return;
            }
            else
                errorProvider1.Dispose(); //czyszczenie error providera

            //zle wpisana kwota
            try
            {
                iz_KwotaDoWypłaty = int.Parse(iz_txtKwotaDoWyplaty.Text);
            }
            catch (Exception)
            {
                errorProvider1.SetError(iz_txtKwotaDoWyplaty, "ERROR: błąd w zapisie kwoty do wypłaty!");
                return;
            }

            //zerowa kwota
            if (iz_KwotaDoWypłaty <= 0)
            {
                errorProvider1.SetError(iz_txtKwotaDoWyplaty, "ERROR: kwota do wypłaty musi być większa niż 0!");
                return;
            }
            else
                errorProvider1.Dispose(); //czyszczenie error providera


            //czy kwota nie jest wieksza niz ilosc posiadanych pieniedzy
            switch (iz_cmbRodzajWaluty.SelectedIndex)
            {   //pln
                case 0:
                    if (iz_KwotaDoWypłaty > iz_IloscPieniedzyPLN)
                    {
                        errorProvider1.SetError(iz_txtKwotaDoWyplaty, "ERROR: Bankomat nie posiada tylu pieniedzy.\nIlosc pieniedzy w bankomacie wynosi: " + iz_IloscPieniedzyPLN + " PLN.");
                        return;  //jesli nie ma pieniedzy - wyjscie z kodu klikniecia
                    }
                    break;
                //euro
                case 1:
                    if (iz_KwotaDoWypłaty > iz_IloscPieniedzyEURO)
                    {
                        errorProvider1.SetError(iz_txtKwotaDoWyplaty, "ERROR: Bankomat nie posiada tylu pieniedzy.\nIlosc pieniedzy w bankomacie wynosi: " + iz_IloscPieniedzyEURO + " EURO.");
                        return; // jesli nie ma pieniedzy - wyjscie z kodu klikniecia
                    }
                    break;
            }



            //rozpoczecie wyplacania aka wpisywanie do DataGridView

            iz_ResztaDoWypłaty = iz_KwotaDoWypłaty;
            iz_Index = 0;
            iz_i = 0;
            //resetowanie tablicy wyswietlajacej ewentualne stare wyplaty
            iz_dvgListaWypłaty.Rows.Clear();
            iz_dvgListaWypłaty.Refresh();


            switch (iz_cmbRodzajWaluty.SelectedIndex)
            {
                case 0:
                    while ((iz_ResztaDoWypłaty > 0 && (iz_Index < iz_NominałyBankomatuPLN.GetLength(0))))
                    {
                        iz_LiczbaNominałów = iz_ResztaDoWypłaty / iz_NominałyBankomatuPLN[iz_Index, 1];

                        if (iz_LiczbaNominałów > iz_NominałyBankomatuPLN[iz_Index, 0])
                        {
                            iz_LiczbaNominałów = iz_NominałyBankomatuPLN[iz_Index, 0];
                            iz_NominałyBankomatuPLN[iz_Index, 0] = 0;
                        }
                        else
                            iz_NominałyBankomatuPLN[iz_Index, 0] = iz_NominałyBankomatuPLN[iz_Index, 0] - iz_LiczbaNominałów;

                        if (iz_LiczbaNominałów > 0)
                        {
                            iz_dvgListaWypłaty.Rows.Add();
                            iz_dvgListaWypłaty.Rows[iz_i].Cells[0].Value = iz_LiczbaNominałów;
                            iz_dvgListaWypłaty.Rows[iz_i].Cells[1].Value = iz_NominałyBankomatuPLN[iz_Index, 1];
                            if (iz_NominałyBankomatuPLN[iz_Index, 1] >= iz_NajmniejszyNominałBanknotuPLN)
                                iz_dvgListaWypłaty.Rows[iz_i].Cells[2].Value = "banknot";
                            else
                                iz_dvgListaWypłaty.Rows[iz_i].Cells[2].Value = "moneta";

                            iz_dvgListaWypłaty.Rows[iz_i].Cells[3].Value = iz_cmbRodzajWaluty.SelectedItem;
                            iz_i++;
                        }


                        iz_ResztaDoWypłaty -= iz_LiczbaNominałów * iz_NominałyBankomatuPLN[iz_Index, 1];
                        iz_Index++;
                    }
                    iz_IloscPieniedzyPLN -= iz_KwotaDoWypłaty;
                    break;
                case 1:
                    while ((iz_ResztaDoWypłaty > 0 && (iz_Index < iz_NominałyBankomatuEURO.GetLength(0))))
                    {
                        iz_LiczbaNominałów = iz_ResztaDoWypłaty / iz_NominałyBankomatuEURO[iz_Index, 1];

                        if (iz_LiczbaNominałów > iz_NominałyBankomatuEURO[iz_Index, 0])
                        {
                            iz_LiczbaNominałów = iz_NominałyBankomatuEURO[iz_Index, 0];
                            iz_NominałyBankomatuEURO[iz_Index, 0] = 0;
                        }
                        else
                            iz_NominałyBankomatuEURO[iz_Index, 0] = iz_NominałyBankomatuEURO[iz_Index, 0] - iz_LiczbaNominałów;

                        if (iz_LiczbaNominałów > 0)
                        {
                            iz_dvgListaWypłaty.Rows.Add();
                            iz_dvgListaWypłaty.Rows[iz_i].Cells[0].Value = iz_LiczbaNominałów;
                            iz_dvgListaWypłaty.Rows[iz_i].Cells[1].Value = iz_NominałyBankomatuEURO[iz_Index, 1];
                            if (iz_NominałyBankomatuEURO[iz_Index, 1] >= iz_NajmniejszyNominałBanknotuEURO)
                                iz_dvgListaWypłaty.Rows[iz_i].Cells[2].Value = "banknot";
                            else
                                iz_dvgListaWypłaty.Rows[iz_i].Cells[2].Value = "moneta";

                            iz_dvgListaWypłaty.Rows[iz_i].Cells[3].Value = iz_cmbRodzajWaluty.SelectedItem;
                            iz_i++;
                        }


                        iz_ResztaDoWypłaty -= iz_LiczbaNominałów * iz_NominałyBankomatuEURO[iz_Index, 1];
                        iz_Index++;
                    }
                    iz_IloscPieniedzyEURO -= iz_KwotaDoWypłaty;
                    break;
            }
            iz_dvgListaWypłaty.Visible = true;
            iz_lblListaWypłaconychNominałów.Visible = true;
            iz_btnResetuj.Visible = true;

            iz_btnCzyChceszPonownie.Visible = true;
            iz_btnCzyChceszPonownie.Enabled = true;

            if (iz_IloscPieniedzyPLN == 0 && iz_IloscPieniedzyEURO == 0)
            {
                iz_btnAkceptacja.Enabled = false;
                iz_cmbRodzajWaluty.Enabled = false;
                iz_txtKwotaDoWyplaty.Enabled = false;
                errorProvider1.SetError(iz_txtKwotaDoWyplaty, "ERROR: Bankomat wypłacił wszystkie pieniądze,\n\tzarówno PLN jak i EURO.");
                iz_btnCzyChceszPonownie.Enabled = false;    //nie zezwalaj na ponowną wypłątę
                iz_btnCzyChceszPonownie.Visible = false;

                iz_btnZakończProgram.Text = "Zakończ Program (bankomat jest pusty)";
            }

            iz_btnAkceptacja.Visible = false;
            tabControl1.TabPages.Add(iz_tabWypNom);
            tabControl1.SelectedIndex = 1;
        }

        private void iz_btnResetuj_Click(object sender, EventArgs e)
        {
            //resetowanie i zezwolenie na uzycie listy walut i okna do wpisywania wysokosci wyplaty
            iz_cmbRodzajWaluty.SelectedIndex = 0;
            iz_cmbRodzajWaluty.Enabled = true;
            iz_txtKwotaDoWyplaty.Text = "";
            iz_txtKwotaDoWyplaty.Enabled = true;

            //ukrywanie tabelki i napisu wyplaty oraz przycisku reset
            iz_lblListaWypłaconychNominałów.Visible = false;
            iz_dvgListaWypłaty.Visible = false;
            iz_btnResetuj.Visible = false;

            //lista wyplat jest resetowana przy kazdym wyplacaniu

            //czyszczenie error providera i wlaczenie przycisku akceptacja
            iz_btnAkceptacja.Enabled = true;
            errorProvider1.Dispose();

            //chowanie przycisku do wypłaty ponownej
            iz_btnCzyChceszPonownie.Visible = false;
            iz_btnCzyChceszPonownie.Enabled = false;
        }

        private void iz_btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iz_rbLosowo_CheckedChanged(object sender, EventArgs e)
        {
            iz_txtDolnaGranica.Visible = true;
            iz_txtGórnaGranica.Visible = true;
            iz_btnAkceptujNominały.Visible = true;
            iz_lbDolnaGranicaPrzedziału.Visible = true;
            iz_lbGórnaGranicaPrzedziału.Visible = true;

        }

        private void iz_rbDomyślna_CheckedChanged(object sender, EventArgs e)
        {
            iz_txtDolnaGranica.Visible = false;
            iz_txtGórnaGranica.Visible = false;
            iz_btnAkceptujNominały.Visible = false;
            iz_lbDolnaGranicaPrzedziału.Visible = false;
            iz_lbGórnaGranicaPrzedziału.Visible = false;
        }

        private void iz_btnAkceptujNominały_Click(object sender, EventArgs e)
        {
            int iz_GGPN, iz_DGPN;
            Random iz_Random = new Random();

            if (iz_cmbListaWalutKonfiguracja.SelectedIndex != 0 && iz_cmbListaWalutKonfiguracja.SelectedIndex != 1)
            {
                errorProvider1.SetError(iz_cmbListaWalutKonfiguracja, "ERROR: wybrano niepoprawną walutę!\nWybierz ponownie z podanej listy.");
                return;
            }
            else
                errorProvider1.Dispose();

            try
            {
                iz_GGPN = int.Parse(iz_txtGórnaGranica.Text);
            }
            catch (Exception)
            {
                errorProvider1.SetError(iz_txtGórnaGranica, "ERROR: nie wpisano liczby!");
                return;
            }
            try
            {
                iz_DGPN = int.Parse(iz_txtDolnaGranica.Text);
            }
            catch (Exception)
            {
                errorProvider1.SetError(iz_txtDolnaGranica, "ERROR: nie wpisano liczby!");
                return;
            }

            if (iz_DGPN < 0)
            {
                errorProvider1.SetError(iz_txtDolnaGranica, "ERROR: granica nie może być ujemna!");
                return;
            }
            else if (iz_GGPN <= iz_DGPN)
            {
                errorProvider1.SetError(iz_txtGórnaGranica, "ERROR: Górna granica musi być większa niż dolna!");
                return;
            }


            switch (iz_cmbListaWalutKonfiguracja.SelectedIndex)
            {
                case 0:
                    //losowanie nominałów dla pln
                    for (int k = 0; k < iz_NominałyBankomatuPLN.GetLength(0); k++)
                        iz_NominałyBankomatuPLN[k, 0] = (int)(iz_Random.NextDouble() * (iz_GGPN - iz_DGPN) + iz_DGPN);  // losowanie, z tym, ze baknotow musi byc minimum tyle, ile wynosi dolna granica
                    break;
                case 1:
                    //losowanie nominałów dla euro
                    for (int k = 0; k < iz_NominałyBankomatuEURO.GetLength(0); k++)
                        iz_NominałyBankomatuEURO[k, 0] = (int)(iz_Random.NextDouble() * (iz_GGPN - iz_DGPN) + iz_DGPN);  // losowanie, z tym, ze baknotow musi byc minimum tyle, ile wynosi dolna granica
                    break;
            }
            iz_lbInfoBoxKB.Text = "Losowanie pomyślne! Możesz przejść do zlecenia wypłaty lub losować ponownie (dla innej waluty).";
        }

        private void iz_cmbListaWalutKonfiguracja_SelectedIndexChanged(object sender, EventArgs e)
        {
            iz_lbInfoBoxKB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(iz_tabZlecWyp);//dodawanie zakładek wypłaty
            tabControl1.SelectedIndex = 1; // zmiana na zakładke zlecenia wypłaty
            tabControl1.TabPages.Remove(iz_tabKonBan); // usuniecie zakladki konfiguracyjnej jako ze juz nie jest potrzebna i nie powinno sie w niej grzebac
        }



        private void iz_PulpitBankomatu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Pytanie = MessageBox.Show("Czy na pewno chcesz wyjść z programu?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (Pytanie == DialogResult.Yes)
                e.Cancel = false;
            else
                if (Pytanie == DialogResult.No)
                    e.Cancel = true;
                else
                    e.Cancel = true;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iz_btnCzyChceszPonownie_Click_1(object sender, EventArgs e)
        {

            iz_btnCzyChceszPonownie.Visible = false;
            iz_btnCzyChceszPonownie.Enabled = false;
            iz_btnAkceptacja.Visible = true;
            iz_btnAkceptacja.Enabled = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.TabPages.Remove(iz_tabWypNom);

        }







    }
}
