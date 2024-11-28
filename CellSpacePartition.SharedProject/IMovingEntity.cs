using Stride.Core.Mathematics;

namespace CellSpacePartitionLib
{
	/// <summary>
	/// A simple moving entity with position and old position
	/// </summary>
	public interface IMovingEntity
	{
		Vector2 Position { get; }

		Vector2 OldPosition { get; }
	}
}