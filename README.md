# SimpleChess

## Goal
SimpleChess is exactly that, a simple chess application for two players to play locally. I'm making it in order to get experience building a full game application from start to finish as well as a chance to learn Windows Forms.

## TODO
## Future Features
- Drag pieces 

## Class Structure
- Driver
- Board
- Square
- Player
- Game
- Piece
    - Pawn
    - Rook
    - Knight
    - Bishop
    - Queen
    - King

## Class Diagrams
- Board
    - Attributes
        - 2d array of squares, each with information about which piece is on it
    - Methods
        - bool IsLegalMove(Piece, Square)
        - bool IsPromotion(Piece, Square)
        - bool IsCheckmate(Piece, Square)
        - bool IsCheck(Piece, Square)
- Piece
    - Attributes
        - Move pattern
        - Promotable
    - Methods
- Game
    - Attributes
        - Two players
    - Methods


## Driver
- Create window
- Init game
    - Init players
    - Init board
        - Init pieces
- Draw components
    - board
    - pieces
    - score area
    - active player
    - turn count
- Game loop until game ends
- Play again?
    - Restart at "init game" if yes
    - Close if no

## Game Loop
- Move selection
    - Listen for resignation by either player
    - Active player clicks piece
    - Active piece & potential moves are highlighted
    - Active player clicks piece
        - If the move is not valid, go back to beginning of move selection
            - Alert player of invalid move reason
        - Move piece
- Move execution
    - Check for capture
        - If so, delete captured piece, recalculate score
    - Move piece
    - Check for promotion
        - Prompt player for promotion
        - Delete current piece object
        - Create newly promoted piece object
    - Check for checkmate
        - If so, alert players & end game
    - Check for check
        - If so, alert players (noise)
    