namespace Service.Validation
{
    public class Validacoes
    {
        public bool IsUrlValid(string url, out IDictionary<string, string> validationErrors)
        {
            validationErrors = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(url))
            {
                validationErrors.Add("Link", "A URL não pode ser vazia.");
                return false;
            }

            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) ||
                !(uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                validationErrors.Add("Link", "A URL é inválida.");
                return false;
            }

            return true;
        }
    }
}
