////////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2018 Audiokinetic Inc. / All Rights Reserved
//
////////////////////////////////////////////////////////////////////////

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSoundBankByName : MonoBehaviour {

	public string NameOfBank = "";

	void Awake()
	{
		if(NameOfBank != "")
		{
			uint BankID = 0;
			AkSoundEngine.LoadBank(NameOfBank, AkSoundEngine.AK_DEFAULT_POOL_ID, out BankID);

		}
	}

}
