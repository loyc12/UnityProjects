using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
pos			generalized
worldPos	blocks (relative to world)
blockPos	blocks (relative to chunk)
chunkPos	chunks (relative to world)
*/

//coordinate system to avoid using floats
public class Coords
{
	public int	x;
	public int	y;
	public int	z;

	public	Coords (int _x, int _y, int _z)
	{
		x = _x;
		y = _y;
		z = _z;
	}

	public float	SphereDistance(Coords pos)
	{
		int	x = pos.x - this.x;
		int	y = pos.y - this.y;
		int	z = pos.z - this.z;

		int	dsquare = (x * x) + (y * y) + (z * z);

		return (Mathf.Sqrt(dsquare));
	}

	public Coords	AddPos(Coords pos)
	{
		int	x = pos.x + this.x;
		int	y = pos.y + this.y;
		int	z = pos.z + this.z;

		return (new Coords(x, y, z));
	}

	public Vector3	ToVector3()
	{
		return (new Vector3(this.x, this.y, this.z));
	}

	public Vector2	ToVector2()
	{
		return (new Vector2(this.x, this.z));
	}
}

