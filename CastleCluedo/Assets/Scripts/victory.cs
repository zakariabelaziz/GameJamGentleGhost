using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory : MonoBehaviour
{
    [SerializeField]
	public List<ghost> ghostsInGame = new List<ghost>();
    public GameObject random;

	// Start is called before the first frame update
	void Start()
	{
        GenerateGhostList();
       
	}


	// Update is called once per frame
	void Update()
    {
        if(ghostsInGame.Count > 0)
        {
            checkForWin();
            checkforLose();
        }
        else
        {
            Debug.Log("hello there ?  general kenobi");
            GenerateGhostList();
        }
		
    }

	private void checkforLose() {
		int size = ghostsInGame.Count;
		int badGuys = 0;

		foreach (ghost g in ghostsInGame)
		{
			if (g._conduct.Equals(Conduct.BAD))
			{
				badGuys = badGuys++;
			}
		}

		double percent = (badGuys / size);
		if (percent >= 0.66) {
			Debug.Log("Game over");
			//APPEAR GAME OVER MESSAGE
		}
	}

    private bool checkForWin()
	{
        if(ghostsInGame.Count < 1)
		{
            //WIN MESSAGE
		}
		return ghostsInGame.Count < 1;
	}

    private void GenerateGhostList()
    {
        List<ghost> ghostsFirstGeneration = new List<ghost>();
        ghostsFirstGeneration.Add(ghost.GenerateRandomPNJGhost());
        ghostsFirstGeneration.Add(ghost.GenerateRandomPNJGhost());
        ghostsFirstGeneration.Add(ghost.GenerateRandomPNJGhost());
        ghostsFirstGeneration.Add(ghost.GenerateRandomPNJGhost());

        ghostsInGame = ghostsFirstGeneration;
    }
        
}

