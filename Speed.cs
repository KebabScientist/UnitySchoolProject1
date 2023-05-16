using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public Rigidbody car;
    public Text speedometer;

    void Update()
    {
        // Get the speed of the car in km/h
        float speed = car.velocity.magnitude * 3.6f;

        // Update the speedometer text
        speedometer.text = string.Format("{0:0} km/h", speed);
    }
}
