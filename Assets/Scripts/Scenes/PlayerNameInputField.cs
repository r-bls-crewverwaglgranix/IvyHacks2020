using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Photon.Pun;
using Photon.Realtime;

namespace Com.Bcgvvn.IvyHacks2020 
{
	[RequireComponent(typeof(InputField))]

	public class PlayerNameInputField : MonoBehaviour
	{
		#region Private Constants

		const string playernamePrefKey = "PlyaerName";

		#endregion


		#region MonoBehaviour CallBacks

	    // Start is called before the first frame update
	    void Start()
	    {
	    	string defaultname = string.Empty;
	    	InputField _inputField = this.GetComponent<InputField>();
	    	if (_inputField!=null)
	    	{
	    		if (PlayerPrefs.HasKey(playernamePrefKey))
	    		{
	    			defaultName = PlayerPrefs.GetString(playernamePrefKey);
	    			_inputField.text = defaultName;
	    		}
	    	}

	    	PhotonNetwork.NickName = defaultName;
	        
	    }
	    #endregion


	    #region Public Methods

	    public void SetPlayerName(string value)
	    {
	    	if (string.IsNullOrEmpty(value))
	    	{
	    		Debug.LogError("Player Name is null or empty");
	    		return;
	    	}
	    	PhotonNetwork.NickName = value;

	    	PlayerPrefs.SetString(playernamePrefKey, value);
	    }

	    #endregion

	}
}