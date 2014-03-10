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
			switch (command)
			{
				case "M":
					_currentY++;
					break;
			}
		}

		public string CurrentPosition
		{
			get { return string.Format("{0} {1} {2}", _currentX, _currentY, _direction); }
		}
	}
}
