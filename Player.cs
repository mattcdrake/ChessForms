using System;

public enum Color {White, Black};

public class Player
{
	Color color;
	int score;

	public Player(Color color)
	{
        this.color = color;
		this.score = 0;
	}
}
