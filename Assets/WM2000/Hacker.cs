using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	int level;

	enum Screen {
		MainMenu,
		Library,
		PoliceStation,
		Password,
		Win
	};

	Screen currentScreen;

  // Start is called before the first frame update
  void Start() {
		ShowMainMenu();
  }

  void ShowMainMenu() {
		currentScreen = Screen.MainMenu;

		Terminal.ClearScreen();
		Terminal.WriteLine("Welcome to SimHacks");
		Terminal.WriteLine("  Press 1 to hack the Library");
		Terminal.WriteLine("  Press 2 to hack the Police Station");
  }

	void OnUserInput(string input) {
		print(input);

		if (input == "exit") { // user can always go to the main menu
			ShowMainMenu();
		}

		// main menu controls
		if (currentScreen == Screen.MainMenu) {
			RunMenuControls(input);
		}

		// library controls
		if (currentScreen == Screen.Library) {
			if (input == "Elle Book") {
				Terminal.ClearScreen();
				Terminal.WriteLine("Welcome to Larry Library");
				Terminal.WriteLine("  Access Granted");
			}
		}

		// police station controls
		if (currentScreen == Screen.PoliceStation) {
			if (input == "Brutality") {
				Terminal.ClearScreen();
				Terminal.WriteLine("Welcome to The Police Station");
				Terminal.WriteLine("  Access Granted");
			}
		}
	}

	void RunMenuControls(string input) {
		if (input == "1") {
			ShowLibrary();
		} else if (input == "2") {
			ShowPoliceStation();
		}
	}

	void ShowLibrary() {
		currentScreen = Screen.Library;

		Terminal.ClearScreen();
		Terminal.WriteLine("Welcome to Larry Library");
		Terminal.WriteLine("Please enter your authentication key");
		Terminal.WriteLine("or 'exit' to return to the menu:");
	} 

	void ShowPoliceStation() {
		currentScreen = Screen.PoliceStation;

		Terminal.ClearScreen();
		Terminal.WriteLine("Welcome to The Police Station");
		Terminal.WriteLine("Please enter your authentication key");
		Terminal.WriteLine("or 'exit' to return to the menu:");
	}

	void StartGame(int level) {

	}

  // Update is called once per frame
  void Update() {
        
  }
}
