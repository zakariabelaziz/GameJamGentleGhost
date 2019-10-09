using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory {

	public Conduct _conductMemory { get; set; }
	public string _nameVictimOrKiller { get; set; }
	private string _descriptionObject { get; set; }
	private string _descriptionVictimOrKiller { get; set; }
	private string _descriptionHatVictimOrKiller { get; set; }

    public Memory()
	{
		int rndConduct = Random.Range(0,1);
		_conductMemory = (Conduct)rndConduct;
	}

}
