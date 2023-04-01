using BookingAppWinForm.Models;

namespace BookingAppWinForm.Repository.RepUser
{
    public interface IUserRepository
    {
        User Register(User user);
        User Login(User user);

    }
}
