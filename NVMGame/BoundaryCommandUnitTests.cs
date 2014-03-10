using NUnit.Framework;

namespace NVMGame
{
	[TestFixture]
    public class BoundaryCommandUnitTests
    {
		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_LM_Its_Final_Position_Should_Be_0_0_W()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("LM");
			Assert.AreEqual("0 0 W", piece.CurrentPosition);
		}

		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_MMMMM_Its_Final_Position_Should_Be_0_4_N()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("MMMMM");
			Assert.AreEqual("0 4 N", piece.CurrentPosition);
		}

		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_RMMMMM_Its_Final_Position_Should_Be_4_0_E()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("RMMMMM");
			Assert.AreEqual("4 0 E", piece.CurrentPosition);
		}

		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_RRM_Its_Final_Position_Should_Be_0_4_S()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("RRM");
			Assert.AreEqual("0 0 S", piece.CurrentPosition);
		}
    }
}
