using UnityEngine;
using System.Collections;

public class HGDouble : HGObject {
	private static double randSeed = Random.Range (0f, 100f);

	private double _value;
	public double Value
	{
		get { 
			return _value - randSeed;
		}
		set { 
			_value = value + randSeed;
		}
	}

	public HGDouble() 
	{

	}

	public HGDouble(double value) 
	{
		this.Value = value;
	}

	public static double operator + (HGDouble v1, HGDouble v2)  
	{  
		return v1.Value + v2.Value;  
	}

	public static double operator + (double v1, HGDouble v2)  
	{  
		return v1 + v2.Value;  
	}

	public static double operator + (HGDouble v1, double v2)  
	{  
		return v1.Value + v2;  
	}

	public static double operator - (HGDouble v1, HGDouble v2)  
	{  
		return v1.Value - v2.Value;  
	}

	public static double operator - (HGDouble v1, double v2)  
	{  
		return v1.Value - v2;  
	}

	public static double operator - (double v1, HGDouble v2)  
	{  
		return v1 - v2.Value;  
	}
}
