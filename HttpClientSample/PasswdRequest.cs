namespace HttpClientSample
{
    internal class PasswdRequest
    {
        public string? Pwdhash { get; set; }

        public PasswdRequest(String pwdhash)
        {
            Pwdhash = pwdhash;
        }
    }
}
