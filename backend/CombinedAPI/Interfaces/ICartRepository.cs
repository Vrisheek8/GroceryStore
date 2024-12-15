using CombinedAPI.Models;

namespace CombinedAPI.Interfaces
{
  public interface ICartRepository
  {
    Cart getUserCart(int userId);
    bool addToCart(int userId, int product, int amount);
    bool removeFromCart(int userId, int product);
    bool updateAmount(int userId, int product, int amount);
    bool initiateCart(Cart cart);
    bool clearCart(int userId);
    }
}
