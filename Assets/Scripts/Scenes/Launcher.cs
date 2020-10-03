using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace Com.Bcvggn.IvyHacks2020
{
	public class Launcher : MonoBehaviour
	{
		#region Private Serializable Fields

		#endregion


		#region Private Fields

		/// <summary>
	    /// This client's version number. Users are separated from each other by gameVersion (which allows you to make breaking changes).
	    /// </summary>
		string gameVersion = "1";

		#endregion


		#region MonoBehaviour CallBacks
		
		void Awake() 
		{
	    	PhotonNetwork.AutomaticallySyncScene = true;
		}

	    // Start is called before the first frame update
	    void Start() {}

	    #endregion


	    #region Public Methods
	    public void Connect()
	    {
	    	if (PhotonNetwork.IsConnected)
	    	{
	    		PhotonNetwork.JoinRandomRoom();
	    	}	
	    	else
	    	{
	    		PhotonNetwork.ConnectUsingSettings();
	    		PhotonNetwork.GameVersion = gameVersion;
	    	}
	    }
	    #endregion
	}
}