interface IPassword
{
    void PasswordCheck(string password, string result, int idx);
    string GeneratePassword(int length);
}
