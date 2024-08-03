using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Vector2 moveInput;
    Rigidbody2D rb;
    public GameObject mark;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        PhotonNetwork.SendRate = 60;
        PhotonNetwork.SerializationRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(GetComponent<PhotonView>().IsMine == true)
        {
            rb.velocity = new Vector2(moveInput.x * 10f, rb.velocity.y);
        }
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
