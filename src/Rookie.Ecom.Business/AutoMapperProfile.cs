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
            CreateMap<CategoryDto, Category>()
               .ForMember(d => d.Products, t => t.Ignore());
            CreateMap<ProductDto, Product>()
             .ForMember(d => d.Category, t => t.Ignore());

            CreateMap<UserDto, User>();
          
            CreateMap<RatingDto, Rating>()
            .ForMember(d => d.User, t => t.Ignore());
            CreateMap<CartDto, Cart>()
            .ForMember(d => d.User, t => t.Ignore());
            CreateMap<OrderDto, Order>()
             .ForMember(d => d.User, t => t.Ignore());
            CreateMap<Address, AddressDto>();
             


        }

        private void FromDataAccessorLayer()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Product, ProductDto>();
            CreateMap<User, UserDto>();
            CreateMap<Rating, RatingDto>();
            CreateMap<Order, OrderDto>();
            CreateMap<Cart, CartDto>();
            CreateMap<Address, AddressDto>();

        }
    }
}
