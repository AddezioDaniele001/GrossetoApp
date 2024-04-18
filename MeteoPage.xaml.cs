using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace GrossetoApp;

public partial class MeteoPage : ContentPage
{
	readonly HttpClient ht=new HttpClient();

	string Meteourl = "https://api.jsonbin.io/v3/b/6620334ce41b4d34e4e60a2c";

	public ObservableCollection<Meteoday> MeteoList { get; set; } = new();

    public MeteoPage()
	{
		InitializeComponent();
		MeteoCollectionView.ItemsSource= MeteoList;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

    }

	public async void LoadData()
	{
		var MeteoResponse = await ht.GetFromJsonAsync<MeteoResponse>(Meteourl);

		foreach (var meteo in MeteoList)
		{
			MeteoList.Add(meteo);
		}
	}
}