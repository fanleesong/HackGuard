using UnityEngine;
using System.Collections;

public class HGFloat : HGObject {
	private static float randSeed = Random.Range (1f, 100f);

	private float _value;
	public float Value
	{
		get { 
			return _value - randSeed;
		}
		set { 
			_value = value + randSeed;
		}
	}

	public HGFloat() 
	{

	}

	public HGFloat(float value) 
	{
		this.Value = value;
	}

	public static float operator + (HGFloat v1, HGFloat v2)  
	{  
		return v1.Value + v2.Value;  
	}

	public static float operator + (float v1, HGFloat v2)  
	{  
		return v1 + v2.Value;  
	}

	public static float operator + (HGFloat v1, float v2)  
	{  
		return v1.Value + v2;  
	}

	public static float operator - (HGFloat v1, HGFloat v2)  
	{  
		return v1.Value - v2.Value;  
	}

	public static float operator - (HGFloat v1, float v2)  
	{  
		return v1.Value - v2;  
	}

	public static float operator - (float v1, HGFloat v2)  
	{  
		return v1 - v2.Value;  
	}
}
