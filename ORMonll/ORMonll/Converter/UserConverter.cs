using AutoMapper;
using ORMonll.Dto;
using ORMonll.Entity;

namespace ORMonll.Converter;

public class UserConverter
{
    public static User convert(UserDto userDto)
    {
        var config = new MapperConfiguration(cfg => { cfg.CreateMap<UserDto, User>(); });
        return config.CreateMapper().Map<UserDto, User>(userDto);
    }

    public static UserDto convert(User user)
    {
        return null;
    }
}