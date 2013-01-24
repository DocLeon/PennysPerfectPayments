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
		private bool _cardCharged;
		private const string _ok = "OK";

		[SetUp]
		public void SetUp()
		{
			_cardCharged = false;
			_result = SubmitOrder(ref _cardCharged);
		}

		[Test]
		public void Should_get_an_ok_when_submitting_an_order()
		{
			Assert.That(_result,Is.EqualTo(_ok));
		}

		[Test]
		public void Should_charge_my_card()
		{
			Assert.IsTrue(_cardCharged);
		}

		private string SubmitOrder(ref bool cardCharged)
		{
			cardCharged = true;
			return _ok;
		}
    }
}
