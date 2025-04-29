using UnityEngine;

public class playerScript : MonoBehaviour
{
    private bool facingLeft=true;

    private float floatProgress=0;

    public SpriteRenderer mySprite;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

        }
        else if (Input.GetKey(KeyCode.D))
        {
            facingLeft=false;
        }
        else if (Input.GetKey(KeyCode.S))
        {

        }
        else if (Input.GetKey(KeyCode.A))
        {
            facingLeft=true;
        }

        mySprite.flipX=facingLeft;
    }
}
