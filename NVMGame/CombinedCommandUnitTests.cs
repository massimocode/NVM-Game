using NUnit.Framework;

namespace NVMGame
{
	[TestFixture]
    public class CombinedCommandUnitTests
    {
		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_MMMM_Its_Final_Position_Should_Be_0_4_N()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("MMMM");
			Assert.AreEqual("0 4 N", piece.CurrentPosition);
		}
    }
}
