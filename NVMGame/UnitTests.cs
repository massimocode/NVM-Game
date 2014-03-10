using NUnit.Framework;

namespace NVMGame
{
	[TestFixture]
    public class UnitTests
    {
		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_Its_Position_Should_Be_0_0_N()
		{
			var piece = new Piece(new Board(5, 5));

			Assert.AreEqual("0 0 N", piece.CurrentPosition);
		}
    }
}
