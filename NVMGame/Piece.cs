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

		public void Move(string commands)
		{
			foreach (var command in commands.ToCharArray())
			{
				switch (command)
				{
					case 'M':
						MoveForward();
						break;
					case 'R':
						TurnRight();
						break;
					case 'L':
						TurnLeft();
						break;
				}
			}
		}

		private void MoveForward()
		{
			switch (_direction)
			{
				case Direction.N:
					_currentY++;
					break;
				case Direction.S:
					_currentY--;
					break;
				case Direction.E:
					_currentX++;
					break;
				case Direction.W:
					_currentX--;
					break;
			}
		}

		public string CurrentPosition
		{
			get { return string.Format("{0} {1} {2}", _currentX, _currentY, _direction); }
		}

		public void TurnRight()
		{
			_direction = _direction == Direction.W ? Direction.N : _direction + 1;
		}

		public void TurnLeft()
		{
			_direction = _direction == Direction.N ? Direction.W : _direction - 1;
		}
	}
}
