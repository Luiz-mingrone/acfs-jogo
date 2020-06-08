using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    public GameObject cubo;

    public float speed = 100f;
    private CharacterController characterController;
    private float jumpforce = 10f;
    private float gravidade = 30f;
    private Vector3 direcao = Vector3.zero;
   


    private void Update()
    {
        CharacterController controller = gameObject.GetComponent<CharacterController>();

        if (controller.isGrounded)
        {
            direcao = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            direcao = transform.TransformDirection(direcao);
            direcao *= speed;


        }


        if (Input.GetButton("Jump"))
        {
            direcao.y = jumpforce;

        }


        //gravidade
        direcao.y -= gravidade * Time.deltaTime;

        //andar
        controller.Move(direcao * Time.deltaTime);


        //limitador de altura
        if (transform.position.y > 4)
        {
            transform.position = new Vector3(transform.position.x, 4, transform.position.z);
        }
        if (transform.position.x<= -6.93f)
        {
            transform.position = new Vector3(-6.93f,transform.position.y,transform.position.z);
        }
        if (transform.position.x >= 6.9f)
        {
            transform.position = new Vector3(6.9f, transform.position.y, transform.position.z);
        }

        //reiniciar ao cair

        if (transform.position.y < -4)
        {

            transform.position = new Vector3(0, 2, transform.position.z);
            //speed = 0;
            //yield return new WaitForSeconds(1);
            //StartCoroutine(Cair());
        }


    }

    IEnumerator Cair()
    {

        speed = 0;
        jumpforce = 0;
        yield return new WaitForSeconds(1);
        speed = 10;
        jumpforce = 10;

    }

}
