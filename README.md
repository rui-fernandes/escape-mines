# Escape Mines
A console application of the escape mines board game.

![alt text](https://images-na.ssl-images-amazon.com/images/I/61UZ1SeWj6L.jpg "Escape Mines")

## Usage

1. About the settings

  - The first line should define the board size
  - The second line should contain a list of mines (i.e. list of co-ordinates separated
by a space)
  - The third line of the file should contain the exit point.
  - The fourth line of the file should contain the starting position of the turtle.
  - The fifth line to the end of the file should contain a series of moves.

    - Example
        ```
        5 4        
        1,1 1,3 3,3
        4 2
        0 1 N
        R M L M M
        R M M M
        ```

    - Where
        ```
        R = Rotate 90 degrees to the right
        L = Rotate 90 degrees to the left
        N = North direction
        S = South direction
        W = West direction
        E = East direction
        M = Move
       ```

2. Run the Game

    without specifying a settings file
      
       dotnet run -c Release

    specifying a settings file
        
        dotnet run -c Release .\Settings\GameSettings.txt
