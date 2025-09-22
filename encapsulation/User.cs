namespace App;

class User
{
    public string Name { get; set; }
    public string Email { get; }
    private string Password;

    public bool UpdateEmail(string newEmail)
    {
        if (newEmail.Contains("@") && newEmail.Length < 320)
        {
            Email = newEmail;
        }
    }

    public bool SetPassword(string newPassword)
    {
        bool result = false;

        if (newPassword.Length > 8)
        {
            newPassword = newPassword;
        }
        return result;
    }


}