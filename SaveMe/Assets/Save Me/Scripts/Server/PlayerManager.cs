using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Photon.Pun;

public class PlayerManager : MonoBehaviour
{
    PhotonView PV;

    private void Awake()
    {
        PV = GetComponent<PhotonView>();
    }

    void Start()
    {
        if (PV.IsMine)
        {
            CreateController(); 
        }
    }
    void CreateController()
    {
        Debug.Log("Instantiated player controller.");

        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","PlayerController"), Vector3.zero, Quaternion.identity);
    }
}
