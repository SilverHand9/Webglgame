using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Camera camera;
    [SerializeField] float Speed ,stopYDiricrion, Skyspeed;
    [SerializeField] bool ControlerMouse, _Ydirection;
    Vector3 Direction;
    float ZDirection, YDirection , SpeedLastUpdate;

    private void Start()
    {
        SpeedLastUpdate = Speed;
    }
    void Update()
    {
        #region Mouse
        //float horizontal = Input.GetAxisRaw("Horizontal");
        //float distance = Mathf.Clamp(transform.rotation.z, 10, 100f);
        //Vector3 Direction = new Vector3(0f, horizontal, 0f).normalized;

        if (ControlerMouse)
        {
            float mouseY = Input.GetAxis("Mouse Y")*Speed;
            float mouseX = Input.GetAxis("Mouse X")*Speed;
            //mouseY = Mathf.Clamp(mouseY,-20,30);
            Direction = new Vector3(0f, mouseX, 0f).normalized;
            Vector3 mouseDirection = new Vector3(mouseY, 0f, 0f).normalized;
            mouseDirection.x = Mathf.Clamp(mouseDirection.x, -20f, 45f);
            if (Input.GetKey(KeyCode.Mouse1))
            {
                Speed = SpeedLastUpdate;
                if (camera.orthographicSize <= 100)
                {
                    camera.orthographicSize++;

                }

                //ZDirection = -1f;
            }
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Speed = SpeedLastUpdate;
                if (camera.orthographicSize <= 100)
                {
                    camera.orthographicSize--;

                }
            }
            if (_Ydirection)
            {
                
                camera.transform.Rotate(mouseDirection * Speed/ stopYDiricrion * Time.deltaTime);

            }
            gameObject.transform.Rotate(Direction * Speed * Time.deltaTime);

        }
        #endregion

        #region Key
        else
        {
            Direction = new Vector3(0f, YDirection, ZDirection).normalized;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Speed = SpeedLastUpdate;

                YDirection = 1f;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                Speed = SpeedLastUpdate;
                YDirection = -1f;

            }
            else if (Input.GetKey(KeyCode.UpArrow) && transform.rotation.z <= 60)
            {

                Speed = SpeedLastUpdate;
                if (camera.orthographicSize <= 100)
                {
                    camera.orthographicSize++;

                }

                //ZDirection = -1f;
            }
            else if (Input.GetKey(KeyCode.DownArrow) && transform.rotation.z >= -20)
            {

                Speed = SpeedLastUpdate;
                if (camera.orthographicSize >= 10)
                {
                    camera.orthographicSize--;

                }
                //ZDirection = 1f;


            }
            else
            {
                Speed = 0;
                ZDirection = 0f;
                YDirection = 0f;
            }
            gameObject.transform.Rotate(Direction * Speed * Time.deltaTime);

        }




        /*if(transform.rotation.z >= 20&& transform.rotation.z <= -90)
        {
            Speed = 0;

        }
        else
        {

        }*/
        #endregion



    }
    private void FixedUpdate()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * Skyspeed);

    }
}
