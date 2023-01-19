using AutoMapper;
using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Bussines.Interfaces;
using denemeBlazor.Bussines.Services;
using denemeBlazor.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Entities;

namespace denemeBlazor.ViewComponents
{
    public class GetCommands : ViewComponent
    {
        readonly IUow _uow;
        readonly IMapper _mapper;
        public GetCommands(IUow uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var response = await _uow.GetRepository<Comment>().GetQueryable().OrderByDescending(x=>x.CreatedTime).Include(x=>x.AppUser).ToListAsync();
            return View(_mapper.Map<List<CommentListDto>>(response));
        }
    }
}
