namespace Bookify.Domain.Users;
public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid Id, CancellationToken cancellationToken = default);
    void Add(User user);
}
