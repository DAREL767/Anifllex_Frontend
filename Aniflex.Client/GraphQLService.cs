using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aniflex.Client
{
    public class GraphQLService
    {
        private readonly GraphQLHttpClient _client;

        public GraphQLService()
        {
            _client = new GraphQLHttpClient("http://localhost:8080/graphql", new NewtonsoftJsonSerializer());
        }

        // 1. LISTAR PELÍCULAS
        public async Task<List<Pelicula>> ObtenerPeliculasAsync()
        {
            var request = new GraphQLRequest
            {
                Query = @"
                query {
                    listarPeliculas {
                        id
                        titulo
                        duracionMinutos
                        recaudacionTaquilla
                        esSaga
                    }
                }"
            };

            var response = await _client.SendQueryAsync<ListarPeliculasResponse>(request);
            VerificarErrores(response);
            return response.Data?.ListarPeliculas ?? new List<Pelicula>();
        }

        // 2. BUSCAR PELÍCULA POR ID
        public async Task<Pelicula> ObtenerPeliculaPorIdAsync(string id)
        {
            var request = new GraphQLRequest
            {
                Query = @"
                query($id: ID!) {
                    buscarPeliculaPorId(id: $id) {
                        id
                        titulo
                        duracionMinutos
                        recaudacionTaquilla
                        esSaga
                    }
                }",
                Variables = new { id }
            };

            var response = await _client.SendQueryAsync<BuscarPeliculaPorIdResponse>(request);
            VerificarErrores(response);
            return response.Data?.BuscarPeliculaPorId;
        }

        // 3. CREAR PELÍCULA
        public async Task<Pelicula> CrearPeliculaAsync(Pelicula pelicula)
        {
            var request = new GraphQLRequest
            {
                Query = @"
                mutation($peliculaInput: PeliculaInput!) {
                    crearPelicula(peliculaInput: $peliculaInput) {
                        id
                        titulo
                        duracionMinutos
                        recaudacionTaquilla
                        esSaga
                    }
                }",
                Variables = new
                {
                    peliculaInput = new
                    {
                        id = pelicula.Id,
                        titulo = pelicula.Titulo,
                        duracionMinutos = pelicula.Duracion,
                        recaudacionTaquilla = pelicula.Recaudacion,
                        esSaga = pelicula.EsSaga
                    }
                }
            };

            var response = await _client.SendMutationAsync<CrearPeliculaResponse>(request);
            VerificarErrores(response);
            return response.Data?.CrearPelicula;
        }

        // 4. ACTUALIZAR PELÍCULA
        public async Task<Pelicula> ActualizarPeliculaAsync(Pelicula pelicula)
        {
            var request = new GraphQLRequest
            {
                Query = @"
                mutation($id: ID!, $peliculaInput: PeliculaInput!) {
                    actualizarPelicula(id: $id, peliculaInput: $peliculaInput) {
                        id
                        titulo
                        duracionMinutos
                        recaudacionTaquilla
                        esSaga
                    }
                }",
                Variables = new
                {
                    id = pelicula.Id,
                    peliculaInput = new
                    {
                        id = pelicula.Id,
                        titulo = pelicula.Titulo,
                        duracionMinutos = pelicula.Duracion,
                        recaudacionTaquilla = pelicula.Recaudacion,
                        esSaga = pelicula.EsSaga
                    }
                }
            };

            var response = await _client.SendMutationAsync<ActualizarPeliculaResponse>(request);
            VerificarErrores(response);
            return response.Data?.ActualizarPelicula;
        }

        // 5. ELIMINAR PELÍCULA
        public async Task<bool> EliminarPeliculaAsync(string id)
        {
            var request = new GraphQLRequest
            {
                Query = @"
                mutation($id: ID!) {
                    eliminarPelicula(id: $id)
                }",
                Variables = new { id }
            };

            var response = await _client.SendMutationAsync<EliminarPeliculaResponse>(request);
            VerificarErrores(response);
            return response.Data?.EliminarPelicula ?? false;
        }

        // --- VALIDACIÓN DE ERRORES ---
        private void VerificarErrores<T>(GraphQLResponse<T> response)
        {
            if (response.Errors != null && response.Errors.Length > 0)
            {
                throw new Exception(response.Errors[0].Message);
            }
        }

        // --- CLASES AUXILIARES ---
        private class ListarPeliculasResponse
        {
            [JsonProperty("listarPeliculas")]
            public List<Pelicula> ListarPeliculas { get; set; }
        }

        private class BuscarPeliculaPorIdResponse
        {
            [JsonProperty("buscarPeliculaPorId")]
            public Pelicula BuscarPeliculaPorId { get; set; }
        }

        private class CrearPeliculaResponse
        {
            [JsonProperty("crearPelicula")]
            public Pelicula CrearPelicula { get; set; }
        }

        private class ActualizarPeliculaResponse
        {
            [JsonProperty("actualizarPelicula")]
            public Pelicula ActualizarPelicula { get; set; }
        }

        private class EliminarPeliculaResponse
        {
            [JsonProperty("eliminarPelicula")]
            public bool EliminarPelicula { get; set; }
        }
    }
}
