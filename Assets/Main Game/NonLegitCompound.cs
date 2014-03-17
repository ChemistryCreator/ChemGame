using System;
using System.Collections;

public class NonLegitCompound : ICompound {

	public string Name {
		get;
		set;
	}

	private NonLegitCompound(string name) {
		this.Name = name;
	}

	public static NonLegitCompound parse(string data) {
		NonLegitCompound compound = new NonLegitCompound(data);
		return compound;
	}

	public bool Equals(ICompound compound) {
		//TODO: implement this
		return false;
	}
}
