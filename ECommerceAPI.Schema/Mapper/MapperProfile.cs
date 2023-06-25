using AutoMapper;
using ECommerceAPI.Data;
using ECommerceAPI.Data.Domain;
using ECommerceAPI.Schema.DataSets.Admin;
using ECommerceAPI.Schema.DataSets.Category;
using ECommerceAPI.Schema.DataSets.Coupon;
using ECommerceAPI.Schema.DataSets.Order;
using ECommerceAPI.Schema.DataSets.OrderDetail;
using ECommerceAPI.Schema.DataSets.Product;
using ECommerceAPI.Schema.DataSets.User;

namespace ECommerceAPI.Schema
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserResponse>();
            CreateMap<UserRequest, User>();
            CreateMap<AdminRequest, User>();
            CreateMap<User, AdminResponse>();
            CreateMap<Product, ProductResponse>();
            CreateMap<ProductRequest, Product>();
            CreateMap<Category, CategoryResponse>();
            CreateMap<CategoryRequest, Category>();
            CreateMap<Coupon, CouponRequest>().ReverseMap();
            CreateMap<Coupon, CouponResponse>().ReverseMap();
            CreateMap<Order, OrderRequest>().ReverseMap();
            CreateMap<Order, OrderResponse>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailRequest>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailResponse>().ReverseMap();
        }
    }
}
