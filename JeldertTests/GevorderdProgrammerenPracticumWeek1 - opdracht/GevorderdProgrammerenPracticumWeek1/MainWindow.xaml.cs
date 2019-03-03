using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace GevorderdProgrammerenPracticumWeek1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private List<Persoon> personen;
		private Persoon selectedPersoon;

		public MainWindow()
		{
			personen = new List<Persoon>();
			InitializeComponent();
		}

		private void AddPersoonButton_Click(object sender, EventArgs e)
		{
			int leeftijd;
			if (VoornaamTextBox.Text != "" && AchternaamTextBox.Text != "" && int.TryParse(LeeftijdTextBox.Text, out leeftijd) && WoonplaatsTextBox.Text != "")
			{
				personen.Add(new Persoon(VoornaamTextBox.Text, AchternaamTextBox.Text, leeftijd, WoonplaatsTextBox.Text));
				showPersonen();
				clearTextboxenPersoon();
			}
			else
				MessageBox.Show("Er is iets verkeerd ingvoerd", "Error");
		}

		/// <summary>
		/// Laat alle personen zien in de listbox voor personen
		/// </summary>
		private void showPersonen()
		{
			PersonenListBox.Items.Clear();
			foreach (Persoon p in personen)
			{
				PersonenListBox.Items.Add(p.GetNaam());
			}
		}

		/// <summary>
		/// Haalt de invoer uit de tekstboxen van een persoon weg
		/// </summary>
		private void clearTextboxenPersoon()
		{
			VoornaamTextBox.Text = "";
			AchternaamTextBox.Text = "";
			LeeftijdTextBox.Text = "";
            WoonplaatsTextBox.Text = "";
		}

		/// <summary>
		/// Haalt de invoer uit de tekstboxen van een huisdier weg
		/// </summary>
		private void clearTextboxenHuisdier()
		{
			HuisdierNaamTextBox.Text = "";
			HuisdierSoortTextBox.Text = "";
            ZindelijkCheckBox.IsChecked = false;
		}

		/// <summary>
		/// Laat alle huisdieren van de geselecteerde persoon zien in de listbox voor huisdieren
		/// </summary>
		private void ShowHuisdieren(Persoon p)
		{
            if (p != null)
            {
                HuisdierenListBox.Items.Clear();
                foreach (Huisdier hd in p.GetHuisdieren())
                {
                    HuisdierenListBox.Items.Add(hd.GetBeschrijving());
                }
            }
		}

		private void AddHuisdierButton_Click(object sender, EventArgs e)
		{
			if (HuisdierNaamTextBox.Text != "" && HuisdierSoortTextBox.Text != "")
			{
				selectedPersoon?.AddHuisdier(new Huisdier(HuisdierNaamTextBox.Text, HuisdierSoortTextBox.Text, (bool)ZindelijkCheckBox.IsChecked));
				ShowHuisdieren(selectedPersoon);
				clearTextboxenHuisdier();
			}
		}

		private void PersonenListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
            int selected = PersonenListBox.SelectedIndex;
            if (selected >= 0)
            {
                selectedPersoon = personen[selected];
                ShowHuisdieren(selectedPersoon);
                AddHuisdierButton.IsEnabled = true;
            }
		}

		private void HuisdierenListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
            int selected = HuisdierenListBox.SelectedIndex;
            if (selected >= 0)
            {
                Huisdier h = selectedPersoon.GetHuisdieren()[HuisdierenListBox.SelectedIndex];
                MessageBox.Show(h.GetNaam() + " is een " + h.GetSoort() + ".\n" + "Zindelijk: " + h.GetZindelijk() + ".\n" + selectedPersoon.GetNaam() + " (" + selectedPersoon.GetLeeftijd() + " jaar oud) is de eigenaar." + selectedPersoon.GetNaam() + "woont in " + selectedPersoon.GetWoonplaats() + ".", "Info");
            }
		}
    }
}
