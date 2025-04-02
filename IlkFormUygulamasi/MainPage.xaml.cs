namespace IlkFormUygulamasi;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    void ToplaClicked(object sender, EventArgs e)
    {
        // TextBox'lardan değer al
        int sayi1 = Convert.ToInt32(sayi1Entry.Text);
        int sayi2 = Convert.ToInt32(sayi2Entry.Text);

        // Toplama işlemi
        int toplam = sayi1 + sayi2;

        // Sonucu Label'a yaz
        sonucLabel.Text = $"Toplam: {toplam}";
    }
}
