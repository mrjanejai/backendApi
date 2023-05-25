namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateRequest
{
    private string _title;
    public string Title
    {
        get=> _title;
        set=> _title=replaceEmptyWithNull(value);
    }

    private string _firstName;
    public string FirstName { get=> _firstName; set=> _firstName=replaceEmptyWithNull(value); }

    private string _lastName;
    public string LastName { get=> _lastName; set=> _lastName=replaceEmptyWithNull(value); }

    private string _userName;
    public string Username { get=>_userName; set=>_userName=replaceEmptyWithNull(value); }

    //[EnumDataType(typeof(Role))]
    //public string Role { get; set; }

    private string _email;
    [EmailAddress]
    public string Email 
    { 
        get => _email; 
        set=> _email = replaceEmptyWithNull(value); 
    }

    // treat empty string as null for password fields to 
    // make them optional in front end apps
    private string _password;
    [MinLength(6)]
    public string Password
    {
        get => _password;
        set => _password = replaceEmptyWithNull(value);
    }

    private string _confirmPassword;
    [Compare("Password")]
    public string ConfirmPassword 
    {
        get => _confirmPassword;
        set => _confirmPassword = replaceEmptyWithNull(value);
    }

    // helpers

    private string replaceEmptyWithNull(string value)
    {
        // replace empty string with null to make field optional
        return string.IsNullOrEmpty(value) ? null : value;
    }
}