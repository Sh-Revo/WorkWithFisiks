using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSphere : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private Image image;

    void FixedUpdate()
    {
        if (EnterSphere.flag == true)
        {
            rigidbody.AddForce(rigidbody.transform.right * _speed, ForceMode.Impulse);
            EnterSphere.flag = false;
            Destroy(gameObject, 10);
            MoveCamera();
        }
    }

    private void MoveCamera()
    {
        Camera cam = Camera.main;
        cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, -50);
        image.gameObject.SetActive(false);
    }
}
