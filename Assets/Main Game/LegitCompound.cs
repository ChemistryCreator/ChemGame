﻿using System;
using System.Collections;

public class LegitCompound : ICompound {

	public enum CompoundState { Gas, Liquid, Solid };

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
	
	private LegitCompound(
		string name,
		int freezingPoint, 
		int boilingPoint
		) {
		this.Name = name;
		this.FreezingPoint = freezingPoint;
		this.BoilingPoint = boilingPoint;
	}
	
	public static LegitCompound parse(string data) {
		/*
		This is what a typical data would look like:
		water,0,100
		*/
		LegitCompound compound;
		
		string[] dataAsArray = data.Split (',');
		try {
			compound = new LegitCompound (
				dataAsArray [0], 
				int.Parse(dataAsArray [1]), 
				int.Parse(dataAsArray [2])
				);
		} catch {
			throw new Exception(String.Format("Cannot create compound with given data: {0}", data));
		}
		
		return compound;
	}

	public CompoundState GetState(int temperature) {
		//TODO: add logic here
		return CompoundState.Liquid;
	}

	public bool Equals(ICompound compound) {
		//TODO: correct this
		/*
		if (compound == null) {
			return false;
		}
		return this.Name == compound.Name
			&& this.BoilingPoint == compound.BoilingPoint
			&& this.FreezingPoint == compound.FreezingPoint;
		*/
		return false;
	}
}