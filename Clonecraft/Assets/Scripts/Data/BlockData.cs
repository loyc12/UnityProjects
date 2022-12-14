using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockID : byte
{
	AIR		= 0,
	GRASS	= 1,
	DIRT	= 2,
	STONE	= 3,
	ROCK	= 4,
	SLATE	= 5,
	MARBLE	= 6,
	SAND	= 7,
	GRAVEL	= 8,
	SNOW	= 9,
	WATER	= 10,
	LAVA	= 11,
	ACID	= 12,
	GLASS	= 13
}

[System.Serializable]
public class	BlockType
{
	public string 			blockName;

	public bool				isSolid;
	public bool				isOpaque;				//!isTransparent
	public bool				isMonofaced;

	public static BlockID	maxID = (BlockID)13;		// Max Index --- DE-HARDCODE ME

	[Header("Textures")]
	public Sprite	icon;
	public int		topFaceTexture;
	public int		bottomFaceTexture;
	public int		frontFaceTexture;
	public int		backFaceTexture;
	public int		leftFaceTexture;
	public int		rightFaceTexture;

	public int		GetTextureId(int faceIndex)
	{
		if (isMonofaced)
			return topFaceTexture;
		switch (faceIndex)
		{
			case 0:
				return (topFaceTexture);
			case 1:
				return (bottomFaceTexture);
			case 2:
				return (frontFaceTexture);
			case 3:
				return (backFaceTexture);
			case 4:
				return (leftFaceTexture);
			case 5:
				return (rightFaceTexture);
			default:
				Debug.Log("Error in BlockType.GetTextureID() : invalide face index given");
				return (0);
		}
	}
}