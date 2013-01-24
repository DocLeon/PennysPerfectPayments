namespace Penny.Tests
{
	public class Penny
	{
		public string SubmitOrder(Order order)
		{
			order.AmountCharged = 5;
			order.CardCharged = true;
			return Order._ok;
		}
	}
}