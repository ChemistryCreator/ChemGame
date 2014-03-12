using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class ChemGame {
	//Singleton stuff
	private static volatile ChemGame instance;
	private static object syncRoot = new System.Object();

	//Game stuff
	private static bool isLoaded = false;

	private ChemGame() { 
		if (!isLoaded) {
			throw new Exception("You must call loadAssets() first");
		}
	}
	
	public static ChemGame Instance {
		get {
			if (instance == null) {
				lock (syncRoot) {
					if (instance == null) {
						instance = new ChemGame();
					}
				}
			}
			return instance;
		}
	}

	public static List<MysteryCompound> Compounds {
		get;
		set;
	}

	public static void loadAssets() {
		ChemGame.Compounds = new List<MysteryCompound> ();
		String path = "Assets/Main Game/compounds.txt";
		StreamReader reader = new StreamReader (path);
		
		String currentLine;
		while (!reader.EndOfStream) {
			currentLine = reader.ReadLine();
			MysteryCompound compound = MysteryCompound.parse(currentLine); //TODO: implement parse
			ChemGame.Compounds.Add(compound);
		}
		reader.Close ();
		ChemGame.isLoaded = true;
	}
}
