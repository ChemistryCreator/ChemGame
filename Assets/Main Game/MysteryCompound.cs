using System;
using System.Collections;

public class MysteryCompound {

	public string Name {
		get;
		set;
	}
	
	public int FreezingPoint {
		get;
		set;
	}

	public int BoilingPoint {
		get;
		set;
	}

	public MysteryCompound(
		string name,
		int freezingPoint, 
		int boilingPoint
		) {
		this.Name = name;
		this.FreezingPoint = freezingPoint;
		this.BoilingPoint = boilingPoint;
	}

	public static MysteryCompound parse(string data) {
		/*
		This is what a typical data would look like:
		water,0,100
		*/
		MysteryCompound compound;

		string[] dataAsArray = data.Split (',');
		try {
			compound = new MysteryCompound (
				dataAsArray [0], 
				int.Parse(dataAsArray [1]), 
				int.Parse(dataAsArray [2])
				);
		} catch (Exception e) {
			throw new Exception(String.Format("Cannot create compound with given data: {0}", data));
		}

		return compound;
	}
}
