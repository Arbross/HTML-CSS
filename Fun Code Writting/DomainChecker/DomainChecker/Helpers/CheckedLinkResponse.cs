namespace DomainChecker.Helpers
{
    /// <summary>
    /// A class to get the status code response from linked site
    /// </summary>
    public class CheckedLinkResponse
    {
        public string Url { get; set; }
        public int? StatusCode { get; set; }
    }
}
