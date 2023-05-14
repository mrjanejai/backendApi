namespace WebApi.Models.Users;

using System.Text.Json.Serialization;
using WebApi.Entities;

public class AuthenticateResponse
{
    [JsonIgnore]
    public int Id { get; set; }
    [JsonIgnore]
    public string FirstName { get; set; }
    [JsonIgnore]
    public string LastName { get; set; }
    [JsonIgnore]
    public string Username { get; set; }



    public string AuthenticationToken { get; set; }

    //[JsonIgnore] // refresh token is returned in http only cookie
    public string RefreshToken { get; set; }

    public string expiresAt { get; set; }

    public AuthenticateResponse(User user, string jwtToken, string refreshToken)
    {
        Id = user.Id;
        FirstName = user.FirstName;
        LastName = user.LastName;
        Username = user.Username;
        expiresAt = DateTime.UtcNow.AddDays(1).ToString();
        AuthenticationToken = jwtToken;
        RefreshToken = refreshToken;
    }
}