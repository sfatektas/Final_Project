using AutoMapper;
using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Bussines.Interfaces;
using denemeBlazor.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Entities;

namespace denemeBlazor.ViewComponents
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
            var response = await _uow.GetRepository<Post>().GetQueryable().OrderBy(x => x.CreatedTime).Take(5).ToListAsync();
            return View(_mapper.Map<List<PostListDto>>(response));
        }

    }

    
}
