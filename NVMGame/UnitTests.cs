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

		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_M_Its_Position_Should_Be_0_1_N()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("M");

			Assert.AreEqual("0 1 N", piece.CurrentPosition);
		}

		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_R_Its_Position_Should_Be_0_0_E()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("R");

			Assert.AreEqual("0 0 E", piece.CurrentPosition);
		}
    }
}
