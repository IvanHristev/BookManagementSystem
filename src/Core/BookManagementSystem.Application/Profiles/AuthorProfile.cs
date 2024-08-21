using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BookManagementSystem.Application.Dtos.AuthorDtos;
using BookManagementSystem.Application.Dtos.eDtos;
using BookManagementSystem.Application.Dtos.BookDtos;
using BookManagementSystem.Application.Dtos.PublisherDtos;
using BookManagementSystem.Domain.Entities;


namespace BookManagementSystem.Application.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<AuthorUpdateDto, Author>();

            CreateMap<Publisher, AuthorPublisherDto>();
            CreateMap<Publisher, PublisherCreateDto>().ReverseMap();
            CreateMap<Book, AuthorBookDto>();

            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.BirthDay, opt => opt.MapFrom(src => src.DateOfBirth)).ReverseMap();

            CreateMap<Publisher, PublisherCreateDto>().ReverseMap();
            CreateMap<Publisher, PublisherUpdateDto>().ReverseMap();
            CreateMap<Publisher, PublisherGetDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => $"{src.Author.FirstName} {src.Author.LastName}"))
                .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.Books));

            CreateMap<Book, BookCreateDto>().ReverseMap();
            CreateMap<Book, BookUpdateDto>().ReverseMap();
            CreateMap<Book, BookGetDto>()
                .ForMember(dest => dest.PublisherName, opt => opt.MapFrom(src => src.Publisher.Name))
                .ForMember(dest => dest.Authors, opt => opt.MapFrom(src => src.BookAuthors.Select(ta => ta.Author)));

            CreateMap<BookAuthor, AuthorGetDto>()
                .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.AuthorId))
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => $"{src.Author.FirstName} {src.Author.LastName}"));

            CreateMap<BookAuthor, BookGetDto>()
                .ForMember(dest => dest.BookId, opt => opt.MapFrom(src => src.BookId))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Book.Title));
        }

    }
}
