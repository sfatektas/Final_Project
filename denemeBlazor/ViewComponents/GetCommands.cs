using AutoMapper;
using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Bussines.Interfaces;
using MSS_NewsWeb.Bussines.Services;
using MSS_NewsWeb.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.ViewComponents
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
            var response = await _uow.GetRepository<Comment>().GetQueryable().Where(x=>x.PostId == id).OrderByDescending(x=>x.Id).Include(x=>x.AppUser).ToListAsync();
            return View(_mapper.Map<List<CommentListDto>>(response));
        }
    }
}
