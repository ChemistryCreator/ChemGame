﻿using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public sealed class ChemGame {
	//Singleton stuff
	private static volatile ChemGame instance;
	private static object syncRoot = new System.Object();

	private Random random;

	//Game stuff
	private static bool isLoaded = false;
	private static List<ICompound> compounds;
	private static int numLegitCompounds = 0;

	public ICompound chosenCompound;
	public ICompound mysteryCompound;
	public ICompound[] compoundChoices = new ICompound[4];

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
						instance.random = new Random();
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
		this.mysteryCompound = compounds[random.Next (0, ChemGame.numLegitCompounds - 1)];
		this.compoundChoices [0] = this.mysteryCompound;

		for (int i = 1; i < this.compoundChoices.Length; i++) {
			int index;
			bool isTaken = false;
			//do {
				index = random.Next (0, ChemGame.compounds.Count);

				for(int j = 0; j < i; j++) {
					if(this.compoundChoices[j].Equals(ChemGame.compounds[index])) {
						isTaken = true;
						break;
					}
				}
			//} while (isTaken);
			this.compoundChoices[i] = compounds[index];
		}

		this.Shuffle (this.compoundChoices);
	}

	private void Shuffle(ICompound[] compounds) {
		int maxIndex = compounds.Length - 1;
		for (int i = 0; i < 50; i++) {
			int a = random.Next(0, maxIndex);
			int b = random.Next(0, maxIndex);
			ICompound temp = compounds[a];
			compounds[a] = compounds[b];
			compounds[b] = temp;
		}
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
