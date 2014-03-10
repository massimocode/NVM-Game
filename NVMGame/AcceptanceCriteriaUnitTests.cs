using NUnit.Framework;

namespace NVMGame
{
	[TestFixture]
	public class AcceptanceCriteriaUnitTests
    {
		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_MRMLMRM_Its_Position_Should_Be_2_2_E()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("MRMLMRM");
			
			Assert.AreEqual("2 2 E", piece.CurrentPosition);
		}

		[Test]
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_RMMMLMM_Its_Position_Should_Be_3_2_N()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("RMMMLMM");

			Assert.AreEqual("3 2 N", piece.CurrentPosition);
		}

		[Test] // Duplicate of an existing test in the BoundaryCommandUnitTests.cs file
		public void When_A_New_Piece_Is_Created_On_A_5_By_5_Board_And_Given_The_Command_MMMMM_Its_Position_Should_Be_0_0_N()
		{
			var piece = new Piece(new Board(5, 5));

			piece.Move("MMMMM");

			Assert.AreEqual("0 4 N", piece.CurrentPosition);
		}
    }
}
