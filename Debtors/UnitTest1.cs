using NUnit.Framework;

namespace Debtors.BL.UnitTests
{
	[TestFixture]

	public class TestBase
	{
		[SetUp]
		public void Setup()
		{
			//����� ������ ������
			//�������� ����������
			//������� ������
		}

		[TearDown]
		public void TearDown()
		{
			//����� ������� �����
			//�������� ����������
			//������� ������
		}

		[OneTimeSetUp]
		public void OneTimeSetup()
		{
			//���� ��� ����� �����
			//������������� ����������, ��������� ��������, �������� �������

		}

		[OneTimeTearDown]
		public void OneTimeTearDown()
		{
			//���� ��� ����� ���� ������
		}

		[Test]
		[TestCase(" @mail.ru ")]
		public void TestEmailValidation(string phone)
		{
			
			Assert.Pass();
		}
	}
}