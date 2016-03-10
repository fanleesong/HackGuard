using UnityEngine;
using System.Collections;

public class HGInt : HGObject {
	private static int randSeed = Random.Range (0, 100);

	private int _value;
	public int Value
	{
		get { 
			return _value - randSeed;
		}
		set { 
			_value = value + randSeed;
		}
	}

	public HGInt() 
	{

	}

	public HGInt(int value) 
	{
		this.Value = value;
	}

	public static int operator + (HGInt v1, HGInt v2)  
	{  
		return v1.Value + v2.Value;  
	}

	public static int operator + (int v1, HGInt v2)  
	{  
		return v1 + v2.Value;  
	}

	public static int operator + (HGInt v1, int v2)  
	{  
		return v1.Value + v2;  
	}

	public static int operator - (HGInt v1, HGInt v2)  
	{  
		return v1.Value - v2.Value;  
	}

	public static int operator - (HGInt v1, int v2)  
	{  
		return v1.Value - v2;  
	}

	public static int operator - (int v1, HGInt v2)  
	{  
		return v1 - v2.Value;  
	}

}