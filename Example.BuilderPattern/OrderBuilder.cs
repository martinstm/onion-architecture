using Example.Core.DomainServices.Repositories;
using Models;

namespace Example.BuilderPattern
{
    public class OrderBuilder : IBuilder<Order>
    {
        private Order _order = new Order();
        private readonly IBuyerRepository _buyerRepository;
        private readonly ISellerRepository _sellerRepository;

        public OrderBuilder() 
        { }

        private OrderBuilder(
                         IBuyerRepository buyerRepository,
                         ISellerRepository sellerRepository)
        {
            _buyerRepository = buyerRepository;
            _sellerRepository = sellerRepository;
        }

        public static OrderBuilder Init(
                                   IBuyerRepository buyerRepository,
                                   ISellerRepository sellerRepository)
        {
            return new OrderBuilder(buyerRepository, sellerRepository);
        }

        public Order Build() => _order;

        public OrderBuilder SetBuyer(int buyerId)
        {
            _order.Buyer = _buyerRepository.GetById(buyerId);
            return this;
        }
        public OrderBuilder SetSeller(int sellerId)
        {
            _order.Seller = _sellerRepository.GetById(sellerId);
            return this;
        }
    }
}
