using System.Data.SqlClient;

namespace EShop.Transactions
{
    public class AddItemTransaction
    {
        public void AddItem(int orderId, string sku, int quantity)
        {
            var insertStatement = "insert into items(OrderID, Sku, Quantity)" +
                                  $" values ({orderId}, {sku}, {quantity})";

            using (var connection = new SqlConnection("blah-blah-blah"))
            using (var command = new SqlCommand(insertStatement, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
