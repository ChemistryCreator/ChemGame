using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public sealed class ChemGame {
	//Singleton stuff
	private static volatile ChemGame instance;
	private static object syncRoot = new System.Object();

	//Game stuff
	private static bool isLoaded = false;
	private static List<ICompound> compounds;
	private static int numLegitCompounds = 0;

	public ICompound mysteryCompound;
	public ICompound[] compoundChoices;

	private ChemGame() { 
		if (!isLoaded) {
			//throw new Exception("You must call loadAssets() first");
			//If, for some crazy reason, loadAssets() hasn't been called, call it!
			ChemGame.loadAssets();
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

	public List<ICompound> Compounds {
		get {
			return ChemGame.compounds;
		}
	}

	public void prepareForNewGame() {
		//TODO: set the values for mysteryCompound and compoundChoices
	}

	public static void loadAssets() {
		ChemGame.compounds = new List<ICompound> ();
		ChemGame.loadLegitCompounds();
		ChemGame.loadNonLegitCompounds();

		ChemGame.isLoaded = true;
	}

	private static void loadLegitCompounds() {
		String path = "Assets/Main Game/legitcompounds.txt";
		StreamReader reader = new StreamReader (path);

		String currentLine;
		while (!reader.EndOfStream) {
				currentLine = reader.ReadLine ();
				LegitCompound compound = LegitCompound.parse (currentLine);
				ChemGame.compounds.Add (compound);
				ChemGame.numLegitCompounds++;
		}
		reader.Close ();
	}

	private static void loadNonLegitCompounds() {
		String path = "Assets/Main Game/nonlegitcompounds.txt";
		StreamReader reader = new StreamReader (path);
		
		String currentLine;
		while (!reader.EndOfStream) {
			currentLine = reader.ReadLine ();
			NonLegitCompound compound = NonLegitCompound.parse (currentLine);
			ChemGame.compounds.Add (compound);
		}
		reader.Close ();
	}
}
