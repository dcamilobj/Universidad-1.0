﻿using UnityEngine;
using System.Collections;

public class GridItem : MonoBehaviour {

	public int x {
		get;
		private set;
	}

	public int y {
		get;
		private set;
	}

	[HideInInspector]
	public int id;

	public void OnItemPositionChanged(int newX, int newY)
	{
		x = newX;
		y = newY;
		gameObject.name = string.Format("Sprite [{0}] [{1}]",x,y);
	}

	void OnMouseDown()
	{
		print ("Click sobre este item!");
		if (OnMouseOverItemEventHandler != null) 
		{
			OnMouseOverItemEventHandler (this);
		}
	}

	public delegate void OnMouseOverItem(GridItem item);
	public static event OnMouseOverItem OnMouseOverItemEventHandler;
}