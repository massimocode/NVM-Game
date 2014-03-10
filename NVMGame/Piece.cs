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
		
		public string CurrentPosition
		{
			get { return string.Format("{0} {1} {2}", _currentX, _currentY, _direction); }
		}

		private void MoveForward()
		{
			switch (_direction)
			{
				case Direction.N:
					IncrementY();
					break;
				case Direction.S:
					DecrementY();
					break;
				case Direction.E:
					IncrementX();
					break;
				case Direction.W:
					DecrementX();
					break;
			}
		}

		private void TurnRight()
		{
			_direction = _direction == Direction.W ? Direction.N : _direction + 1;
		}

		private void TurnLeft()
		{
			_direction = _direction == Direction.N ? Direction.W : _direction - 1;
		}

		private void IncrementY()
		{
			_currentY = _currentY == (board.GridHeight - 1) ? _currentY : _currentY + 1;
		}

		private void DecrementY()
		{
			_currentY = _currentY == 0 ? 0 : _currentY - 1;
		}

		private void IncrementX()
		{
			_currentX = _currentX == (board.GridWidth - 1) ? _currentX : _currentX + 1;
		}

		private void DecrementX()
		{
			_currentX = _currentX == 0 ? 0 : _currentX - 1;
		}
	}
}
