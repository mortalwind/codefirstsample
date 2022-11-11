using AutoMapper;

using CodeFirstSample.Data;
using CodeFirstSample.Models;

namespace CodeFirstSample.Profiles;

public class MapperProfiles :Profile
{
	public MapperProfiles()
	{
        CreateMap<Book, BookDTO>().ReverseMap();

        CreateMap<Book, BookListDTO>().ForMember(x => x.Author, m => m.MapFrom(d => d.Author.FullName));

    }
    
}
