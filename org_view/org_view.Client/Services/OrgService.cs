using org_view.Client.Models;
using System.Text.Json;

namespace org_view.Client.Services
{
    public class OrgService : IOrgService
    {
        private readonly HttpClient _httpClient; 
        public OrgService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://data.brreg.no/enhetsregisteret/api/enheter/");
        }

        public Task AddOrg(Org org)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetOrg(string orgId)
        {
            var response = await _httpClient.GetAsync(_httpClient.BaseAddress);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<Org> GetOrgAsDto(string orgId)
        {
            Uri uri_with_orn_id = new Uri(_httpClient.BaseAddress, orgId);
            var response = await _httpClient.GetAsync(uri_with_orn_id);
            response.EnsureSuccessStatusCode();
            using var stream = await response.Content.ReadAsStreamAsync();
            var dto = await JsonSerializer.DeserializeAsync<OrgDto>(stream);
            return new Org
            {
                Id = dto.organisasjonsnummer,
                Name = dto.navn,
                NumberOfEmployee = dto.antallAnsatte
            };
        }
    }
}
