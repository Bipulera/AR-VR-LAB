using UnityEngine;
using System.Collections;

public class TrafficManager : MonoBehaviour
{
    [SerializeField] Transform[] lane;
    [SerializeField] GameObject[] trafficVehicle;

    [SerializeField] CarController carController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(TrafficSpawner());
    }

    // Update is called once per frame
    IEnumerator TrafficSpawner()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {   
            if (carController.CarSpeed() > 20f)
            {
                SpawnTrafficVehicle();
            }
            yield return new WaitForSeconds(2f);
        }
    }
    void SpawnTrafficVehicle()
    {
        int randomLaneIndex = Random.Range(0, lane.Length);
        int randomTrafficVehicleIndex = Random.Range(0, trafficVehicle.Length);
        Instantiate(trafficVehicle[randomTrafficVehicleIndex], lane[randomLaneIndex].position, Quaternion.identity);
            
    }
}
