namespace Bookify.Domain.Users;
public interface IUserRepository
{
    Task<User?> GetByIdAsync(UserId Id, CancellationToken cancellationToken = default);
    void Add(User user);
}
