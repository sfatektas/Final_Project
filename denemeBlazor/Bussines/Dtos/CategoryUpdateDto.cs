using denemeBlazor.Services.Interfaces;

namespace denemeBlazor.Bussines.Dtos
{
    public class CategoryUpdateDto : IUpdateDto
    {
        public int Id { get; set; }

        public string Defination { get; set; }

    }
}
