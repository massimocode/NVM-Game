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

		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_RM_Its_Final_Position_Should_Be_1_0_E()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("RM");
			Assert.AreEqual("1 0 E", piece.CurrentPosition);
		}

		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_RMLLM_Its_Final_Position_Should_Be_0_0_W()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("RMLLM");
			Assert.AreEqual("0 0 W", piece.CurrentPosition);
		}

		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_MRRM_Its_Final_Position_Should_Be_0_0_S()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("MRRM");
			Assert.AreEqual("0 0 S", piece.CurrentPosition);
		}
    }
}
