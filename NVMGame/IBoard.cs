namespace NVMGame
{
	public interface IBoard
	{
		int GridWidth { get; }
		int GridHeight { get; }
	}

	public class Board : IBoard
	{
		public int GridWidth { get; private set; }
		public int GridHeight { get; private set; }

		public Board(int gridWidth, int gridHeight)
		{
			GridWidth = gridWidth;
			GridHeight = gridHeight;
		}
	}
}