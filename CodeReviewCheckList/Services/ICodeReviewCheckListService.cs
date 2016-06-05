using CodeReviewCheckList.Dtos;
using System.Collections.Generic;

namespace CodeReviewCheckList.Services
{
    public interface ICodeReviewCheckListService
    {
        CodeReviewCheckListAddOrUpdateResponseDto AddOrUpdate(CodeReviewCheckListAddOrUpdateRequestDto request);
        ICollection<CodeReviewCheckListDto> Get();
        CodeReviewCheckListDto GetById(int id);
        dynamic Remove(int id);
    }
}
