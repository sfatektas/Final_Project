using AutoMapper;
using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Bussines.Interfaces;
using MSS_NewsWeb.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.ViewComponents
{
    public class GetLastFivePost : ViewComponent
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;

        public GetLastFivePost(IUow uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _uow.GetRepository<Post>().GetQueryable().OrderByDescending(x => x.Id).Take(5).ToListAsync();
            return View(_mapper.Map<List<PostListDto>>(response));
        }

    }

    
}
