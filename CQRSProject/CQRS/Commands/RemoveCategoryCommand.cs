namespace CQRSProject.CQRS.Commands
{
    public class RemoveCategoryCommand
    {
        public RemoveCategoryCommand(int categoryId)
        {
            CategoryId = categoryId;
        }

        public int CategoryId { get; set; }
    }
}
