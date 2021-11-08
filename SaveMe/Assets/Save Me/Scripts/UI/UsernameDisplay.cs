using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class UsernameDisplay : MonoBehaviour
{
    [SerializeField] PhotonView playerPV;
    [SerializeField] TMP_Text text;

    void Start()
    {
        if (playerPV.IsMine) //if we are this, disable the name on the top of the player
        {
            gameObject.SetActive(false);
        }
        text.text = playerPV.Owner.NickName;
    }
}
