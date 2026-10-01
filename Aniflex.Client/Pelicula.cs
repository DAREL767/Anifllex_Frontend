using System;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Aniflex.Client
{
    public class Pelicula
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("titulo")]
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonProperty("duracionMinutos")]
        [JsonPropertyName("duracionMinutos")]
        public int Duracion { get; set; }

        [JsonProperty("recaudacionTaquilla")]
        [JsonPropertyName("recaudacionTaquilla")]
        public double Recaudacion { get; set; }

        [JsonProperty("esSaga")]
        [JsonPropertyName("esSaga")]
        public bool EsSaga { get; set; }

        [JsonProperty("fechaEstreno")]
        [JsonPropertyName("fechaEstreno")]
        public string FechaEstreno { get; set; } // Formato ISO ej: "2026-10-01"
    }
}