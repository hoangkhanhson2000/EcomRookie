using Rookie.Ecom.Contracts.Dtos;
using Rookie.Ecom.DataAccessor.Entities;

namespace Rookie.Ecom.Business
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            FromDataAccessorLayer();
            FromPresentationLayer();
        }

        private void FromPresentationLayer()
        {
            CreateMap<CategoryDto, Category>();
            CreateMap<ProductDto, Product>();
            CreateMap<AddressDto, Address>();

            CreateMap<UserDto, User>();
          
            CreateMap<RatingDto, Rating>()
            .ForMember(d => d.User, t => t.Ignore());
            CreateMap<CartDto, Cart>()
            .ForMember(d => d.User, t => t.Ignore());
            CreateMap<CartDto, Cart>();
           

            CreateMap<OrderDto, Order>()
             .ForMember(d => d.User, t => t.Ignore());
           

             


        }

        private void FromDataAccessorLayer()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Product, ProductDto>()
            .ForMember(d => d.Category, t => t.Ignore());
            CreateMap<User, UserDto>();
            CreateMap<Rating, RatingDto>();
            CreateMap<Order, OrderDto>();
            CreateMap<Cart, CartDto>()
            .ForMember(d => d.CartItem, t => t.Ignore());
            CreateMap<Address, AddressDto>();

        }
    }
}
