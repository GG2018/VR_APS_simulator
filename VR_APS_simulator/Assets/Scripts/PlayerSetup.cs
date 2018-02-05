﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Oculus.Avatar;

public class PlayerSetup : NetworkBehaviour {

	[SerializeField]
	Behaviour[] ComponentToDisable;
	[SerializeField]
	OvrAvatar avatar;

	// Use this for initialization
	void Start () {
		if (!isLocalPlayer) {
			for (int i = 0; i < ComponentToDisable.Length; i++)
				ComponentToDisable [i].enabled = false;
		}
		avatar.ShowFirstPerson = false;
		avatar.ShowThirdPerson = true;
	}
}
