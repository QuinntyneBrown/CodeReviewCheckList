using System.Collections.Generic;
using CodeReviewCheckList.Dtos;
using CodeReviewCheckList.Data;
using System.Linq;

namespace CodeReviewCheckList.Services
{
    public class CodeReviewCheckListService : ICodeReviewCheckListService
    {
        public CodeReviewCheckListService(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.CodeReviewCheckLists;
            _cache = cacheProvider.GetCache();
        }

        public CodeReviewCheckListAddOrUpdateResponseDto AddOrUpdate(CodeReviewCheckListAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new Models.CodeReviewCheckList());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new CodeReviewCheckListAddOrUpdateResponseDto(entity);
        }

        public ICollection<CodeReviewCheckListDto> Get()
        {
            ICollection<CodeReviewCheckListDto> response = new HashSet<CodeReviewCheckListDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach (var entity in entities) { response.Add(new CodeReviewCheckListDto(entity)); }
            return response;
        }

        public CodeReviewCheckListDto GetById(int id)
        {
            return new CodeReviewCheckListDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        protected readonly IUow _uow;
        protected readonly IRepository<Models.CodeReviewCheckList> _repository;
        protected readonly ICache _cache;
    }
}
