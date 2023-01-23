namespace BlazorWebAssemblySignalRApp.Shared;

//public class WeatherForecast
//{
//    public DateOnly Date { get; set; }

//    public int TemperatureC { get; set; }

//    public string? Summary { get; set; }

//    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}

// これがないとビルドが失敗する
// 参照を切ればいいと思うが
// Shared の参照があるところまで特定していない
public class Dummy
{
    public string str;
}
