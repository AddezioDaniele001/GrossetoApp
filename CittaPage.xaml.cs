using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace GrossetoApp;

public partial class CittaPage : ContentPage
{
	readonly HttpClient httpClient= new HttpClient();

	string Cittaurl = "https://api.jsonbin.io/v3/b/662034fead19ca34f85bbe8b";

	public ObservableCollection<Citta> CittaList { get; set; } = new();
    public CittaPage()
	{
		InitializeComponent();
		CittaCollectionView.ItemSource = CittaList;
	}


	protected override  void OnAppearing()
	{
		base.OnAppearing();
		LoadData();
	}
	public async void LoadData()
	{
		var CittaResponse = await httpClient.GetFromJsonAsync<CittaResponse>(Cittaurl);

        foreach (var citta in CittaList)
        {
			CittaList.Add(citta);
        }
    }
}