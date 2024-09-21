using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class earthquakes
{
    [JsonProperty("mag")]
    public double mag { get; set; }

    [JsonProperty("place")]
    public string place { get; set; }

    [JsonProperty("time")]
    public int time { get; set; }

    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("tsunami")]
    public int tsunami { get; set; }

    [JsonProperty("sig")]
    public int sig { get; set; }

    [JsonProperty("net")]
    public string net { get; set; }

    [JsonProperty("types")]
    public string types { get; set; }

    [JsonProperty("nst")]
    public int nst { get; set; }

    [JsonProperty("dmin")]
    public double dmin { get; set; }

    [JsonProperty("rms")]
    public double rms { get; set; }

    [JsonProperty("gap")]
    public int gap { get; set; }

    [JsonProperty("magType")]
    public string magType { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("coordinates")]
    public double[] coordinates { get; set; }

}

public class data
{
    [JsonProperty("earthquakes_LastUpdated")]
    public int earthquakesLastUpdated { get; set; }

    [JsonProperty("earthquakes_LastHour")]
    public int earthquakesLastHour { get; set; }

    [JsonProperty("earthquakes")]
    public earthquakes[] earthquakes { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
