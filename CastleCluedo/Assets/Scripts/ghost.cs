using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost
{
	public Conduct _conduct { get; set; }
	public string _name { get; set; }
	public Memory _memory { get; set; }
	public PlayableStatus _playableStatus { get; set; }

    public static ghost GenerateRandomPNJGhost() {
		ghost randomGhost = new ghost();

		randomGhost._playableStatus = PlayableStatus.PNJ;

		int rndMemory = Random.Range(0, memoriesBank.Count - 1);
		randomGhost._memory = memoriesBank[rndMemory];

		//memory has a conduct style.
		//if memory of dead is bad, it's because the ghost memory how was killed. So conduct ghost is NICE.
		//at the inverse, the memory is nice, because serial killer is a bitch and he like kill, it's a great memory for him.
		//conduct ghost is BAD in this case.

		randomGhost._conduct = randomGhost._memory._conductMemory;


		int rndName = Random.Range(0, nameBank.Count - 1);
		randomGhost._name = nameBank[rndName];

		return randomGhost;
	}

	public static readonly List<Memory> memoriesBank = new List<Memory>()
	{
		new Memory(),
		new Memory(),
		new Memory(),
		new Memory()
	};

	public static readonly List<string> nameBank = new List<string>()
	{
		"Pierre",
        "Paul",
        "Jacques"
	};

}
