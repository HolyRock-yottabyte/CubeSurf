using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject mainCube;
    int Height;

    // Start is called before the first frame update
    void Start()
    {
        mainCube = GameObject.Find("MainCube");
    }

    // Update is called once per frame
    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, Height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -Height, 0);
    }

    public void decreaseHeight()
    {
        Height--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect" && other.gameObject.GetComponent<CollectableCube>().GetisCollected() == false)
        {
            Height += 1;
            other.gameObject.GetComponent<CollectableCube>().MakeCollected();
            other.gameObject.GetComponent<CollectableCube>().ConfigIndex(Height);
            other.gameObject.transform.parent = mainCube.transform;
        }
    }
}
