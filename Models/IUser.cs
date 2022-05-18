namespace ArchivosDB.Models
{
    interface IUser
    {
        string Username { set; get; }
        string Password { set; get; }
        string Email { set; get; }
        byte[] Avatar { set; get; }
    }
}
