using UnityEngine;

public class main : MonoBehaviour
{

    public GameObject player;
    private SpriteRenderer playerSprite;

    public GameObject maze;
    private GameObject room;

    private bool facingLeft=true;
    void Start()
    {
        playerSprite = player.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        room=maze.GetComponent<mazeScript>().room;
        float secondsPast=Time.deltaTime;
        float speed=secondsPast*5;

        Vector3 change=Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            change += new Vector3(0,-speed,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            change += new Vector3(-speed,0,0);
            facingLeft=false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            change += new Vector3(0,speed,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            change += new Vector3(speed,0,0);
            facingLeft=true;
        }

        if (change.x!=0f && change.y!=0f)
        {
            change*=.7f;
        }

        // room.transform.position+=new Vector3(change.x,0,0);
        // if (player.transform.position.x!=0)
        // {
        //     room.transform.position-=new Vector3(change.x,0,0);
        //     player.transform.position=Vector3.zero;
        // }
        // room.transform.position+=new Vector3(0,change.y,0);
        // if (player.transform.position.y!=0)
        // {
        //     room.transform.position-=new Vector3(0,change.y,0);
        //     player.transform.position=Vector3.zero;
        // }
        room.transform.position+=change;

        playerSprite.flipX=facingLeft;
    }


}
