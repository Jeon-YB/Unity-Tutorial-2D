using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;

    public float rotSpeed = 30f; // 자전 속도

    public float revolutionSpeed = 100f; // 공전 속도

    public bool isRevolution = false;

    void Update()
    {
        if (isRevolution == true)
        {
            transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime); // 자기 자신이 회전하는 기능
            
        }

        if (isRevolution == true)
        {
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }


        
    }
}
