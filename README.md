## Poker Probability Simulator

This repository contains a C# script designed to calculate statistical probabilities in Poker. Originally conceived for a mathematics presentation, the script focuses on analyzing the probability of drawing a straight flush in solitary gameplay.

### Background

During a math presentation, the objective was to illustrate the rarity of certain Poker hands, particularly the probability of drawing a straight flush when playing alone. With a minimal chance of approximately 0.0279%, it becomes impractical for humans to engage in enough rounds to observe this event naturally. To overcome this limitation, a C# script was developed to provide comprehensive insights into these probabilities.

### Features

- Semi efficient C# script that simulates many, many rounds of poker to show that {\displaystyle {9 \choose 1}{4 \choose 1}{46 \choose 2}} is in fact correct. 

### Usage

1. Clone or download the repository.
2. Ensure you have a C# compiler installed on your system.
3. Open a terminal or command prompt and navigate to the directory containing the script (`straightflush.cs`).
4. Compile the script using the following command:

   ```bash
   csc straightflush.cs
   ```

5. Run the compiled executable to execute the script.
6. Review the output in the terminal to analyze the probability outcomes.
7. Customize parameters or expand the script as needed for further analysis.

### Contribution

Contributions are welcome! Feel free to fork the repository, make improvements, and submit pull requests.

### License

This project is licensed under the [MIT License](LICENSE).

---

Feel free to adjust or expand upon this README to better suit the specifics of your project!
