using Acme.BookStore.Books;
using AutoMapper;
using Volo.Abp.Identity;
using Acme.BookStore.Authors;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Author, AuthorDto>();

    }
}
