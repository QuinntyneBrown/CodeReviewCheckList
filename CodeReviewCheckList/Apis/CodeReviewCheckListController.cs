using CodeReviewCheckList.Dtos;
using CodeReviewCheckList.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace CodeReviewCheckList.Apis
{
    [Authorize]
    [RoutePrefix("api/codereviewchecklist")]
    public class CodeReviewCheckListController : ApiController
    {
        public CodeReviewCheckListController(ICodeReviewCheckListService service)
        {
            _service = service;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(CodeReviewCheckListAddOrUpdateResponseDto))]
        public IHttpActionResult Add(CodeReviewCheckListAddOrUpdateRequestDto dto) { return Ok(_service.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(CodeReviewCheckListAddOrUpdateResponseDto))]
        public IHttpActionResult Update(CodeReviewCheckListAddOrUpdateRequestDto dto) { return Ok(_service.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<CodeReviewCheckListDto>))]
        public IHttpActionResult Get() { return Ok(_service.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(CodeReviewCheckListDto))]
        public IHttpActionResult GetById(int id) { return Ok(_service.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_service.Remove(id)); }

        protected readonly ICodeReviewCheckListService _service;


    }
}
