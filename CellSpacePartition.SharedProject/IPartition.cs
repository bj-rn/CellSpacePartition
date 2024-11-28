using Stride.Core.Mathematics;


namespace CellSpacePartitionLib
{
	public interface IPartition<T> where T : IMovingEntity
	{
		RectangleF CellSpace { get; }

		void Add(T ent);

		void Remove(T ent);

		void Update(T ent);

		List<T> CalculateNeighbors(Vector2 targetPos, float queryRadius, bool fastQuery = false);

		T NearestNeighbor(Vector2 targetPos, float queryRadius);

		void Clear();

		// void RenderCells(IPrimitive primitive);

		// void RenderCellIntersections(IPrimitive primitive, Vector2 targetPos, float queryRadius, Color color);
	}
}
