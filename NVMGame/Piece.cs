namespace NVMGame
{
	public class Piece
	{
		private readonly IBoard board;
		private Direction _direction;
		private int _currentX;
		private int _currentY;

		public Piece(IBoard board)
		{
			this.board = board;
		}

		public void Move(string command)
		{
			
		}

		public string CurrentPosition
		{
			get { return ""; }
		}
	}
}
