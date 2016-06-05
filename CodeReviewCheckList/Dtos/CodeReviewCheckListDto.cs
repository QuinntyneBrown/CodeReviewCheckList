using CodeReviewCheckList.Models;

namespace CodeReviewCheckList.Dtos
{
    public class CodeReviewCheckListDto
    {
        public CodeReviewCheckListDto()
        {

        }

        public CodeReviewCheckListDto(Models.CodeReviewCheckList entity)
        {
            Id = entity.Id;
            Name = entity.Name;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
    }
}
