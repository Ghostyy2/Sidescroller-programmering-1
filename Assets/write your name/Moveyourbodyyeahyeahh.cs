using UnityEditor.VersionControl;
using UnityEngine;

public class Moveyourbodyyeahyeahh : MonoBehaviour

{
    public float Gravitypersecound = 160.0f;
    public float MovementSpeedpersecond = 10.0f;
    public float grundlevel = 0.0f;
  void Update()
    {
        Vector3 Gravityposition = transform.position;
        Gravityposition.y -= Gravitypersecound * Time.deltaTime;
        if (Gravityposition.y < grundlevel) { Gravityposition.y = grundlevel; }
        transform.position = Gravityposition;

        //up
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 characterposition = transform.position;
            characterposition.y += MovementSpeedpersecond * Time.deltaTime;
            transform.position = characterposition;
        }

        //left
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 characterposition = transform.position;
            characterposition.x -= MovementSpeedpersecond * Time.deltaTime;
            transform.position = characterposition;
        }

        //down
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 characterposition = transform.position;
            characterposition.y -= MovementSpeedpersecond * Time.deltaTime;
            transform.position = characterposition;
        }

        //right
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 characterposition = transform.position;
            characterposition.x += MovementSpeedpersecond * Time.deltaTime;
            transform.position = characterposition;
        }

    }
}


