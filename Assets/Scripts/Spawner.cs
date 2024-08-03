using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject Player = PhotonNetwork.Instantiate("Player", new Vector3(0, 0, 0), Quaternion.identity);
        Player.GetComponent<Player>().mark.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
