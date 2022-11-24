using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*	IDEAS

	Implement a spherical render distance (via distance between two chunks)





*/

public static class	WorldData
{

	public static readonly int	RenderDistance = 4;	//in chunk

	public static readonly int	WorldSize = 32;		//in chunk
	public static int			WorldVoxelSize		//in voxel
	{
		get { return WorldSize * ChunkSize; }
	}

	public static readonly int	WorldHeight = 1;	//in chunk
	public static int			WorldVoxelHeight	//in voxel
	{
		get { return WorldHeight * ChunkSize; }
	}

	public static readonly int	ChunkSize = 16;			//in voxel
	//public static readonly int	VoxelSize = 1;			//in unit / unimplemented
	public static readonly int	TextureAtlasSize = 16;	//in face
	public static float			NormalizedTextureSize	//over 1
	{
		get {return 1f / (float)TextureAtlasSize;}
	}
}
