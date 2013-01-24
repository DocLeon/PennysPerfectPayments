using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Penny.Tests
{
	[TestFixture]
    public class Customer_can_order_music
    {
		private string _result;
		private readonly Penny _penny;
		private readonly Order _order;

		public Customer_can_order_music()
		{
			_penny = new Penny();
			_order = new Order();
		}

		[SetUp]
		public void SetUp()
		{
			_order.CardCharged = false;
			_result = _penny.SubmitOrder(_order);
		}

		[Test]
		public void Should_get_an_ok_when_submitting_an_order()
		{
			Assert.That(_result,Is.EqualTo(Order._ok));
		}

		[Test]
		public void Should_charge_my_card()
		{
			Assert.IsTrue(_order.CardCharged);
		}

		[Test]
		public void Should_charge_five_pounds()
		{
			Assert.That(_order.AmountCharged, Is.EqualTo(5));
		}
    }
}
