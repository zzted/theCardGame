# C# Card Game Demo

This is a demo project for a card game implemented in C# with a simple graphical user interface (GUI). The game allows you to draw cards, assign them to body parts (Head, Arms, Legs, Body, and Internal Organs), and display card effects.

## Requirements

Before running the project, make sure you have the following installed:

- **[Visual Studio](https://visualstudio.microsoft.com/)** (Community, Professional, or Enterprise edition)
  - Ensure **.NET Desktop Development** workload is installed.
- **[Git](https://git-scm.com/downloads)** (for cloning the repository)

## Clone the Repository

1. Open Visual Studio.
2. Go to **File > Open > Project from GitHub** or click on **Clone a repository** from the Visual Studio start page.
3. Paste the GitHub repository URL:
[https://github.com/yourusername/repository-name.git](https://github.com/zzted/theCardGame.git)
Replace `yourusername/repository-name` with the correct repository path.
4. Choose a local folder to clone the project to and click **Clone**.

Alternatively, you can clone the repository via the Git command line:

```bash
git clone https://github.com/yourusername/repository-name.git
```

## Set Up the Project
1. Open the cloned repository in Visual Studio.
2. In Visual Studio, click Build > Build Solution or press Ctrl + Shift + B to compile the project.


## Run the Project
To run the demo:

Press F5 or click on Debug > Start Debugging to launch the application.
The GUI should open with the card game interface.


## Key Features
- Draw Cards: Click the Draw Card button to draw cards from the pool and add them to the deck.
- Assign Cards to Body Parts: Cards can be assigned to Head, Arms, Legs, Body, or Internal Organs by clicking the respective buttons.
- View Card Effects: Each card has an associated effect, which you can view, modify, and save.
- Save Card Effects: You can modify and save the effects of the cards assigned to body parts.

## Notes
- Ensure that Visual Studio is up to date and has the required extensions for Git integration.
- If you encounter any errors related to missing packages, you may need to manually restore NuGet packages using the NuGet Package Manager.
