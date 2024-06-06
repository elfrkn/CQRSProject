namespace CQRSProject.CQRS.Commands
{
    public class RemoveProductCommand
    {
        public RemoveProductCommand(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
    }
}
