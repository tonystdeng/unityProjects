using UnityEngine;

public class mazeScript : MonoBehaviour
{
    public GameObject roomParent;
    public GameObject room;
    void Start()
    {
        room =Instantiate(roomParent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
