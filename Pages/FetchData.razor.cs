using BlazorServerTest.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorServerTest.Pages
{
    public partial class FetchData
    {
        [Inject]
        WeatherForecastService? ForecastService { get; set; }

        private WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
        }


    }
}
