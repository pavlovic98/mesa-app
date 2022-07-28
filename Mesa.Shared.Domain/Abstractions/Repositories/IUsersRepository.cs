namespace Mesa.Shared.Domain.Abstractions.Repositories
{
    public interface IUsersRepository
    {
        Task AddUser(string name);
        Task DeleteUser(string name);
        Task GetUsers();
    }
}
