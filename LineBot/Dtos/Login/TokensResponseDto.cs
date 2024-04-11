namespace LineBot.Dtos
{
    public class TokensResponseDto
    {
        public string Access_token { get; set; }
        public string Token_type { get; set; }
        public string Refresh_token { get; set; }
        public int Expires_in { get; set; }
        public string Scope { get; set; }
        public string? Id_token { get; set; }
    }

    public class UserProfileDto
    {
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public string StatusMessage { get; set; }
        public string PictureUrl { get; set; }
    }

}
