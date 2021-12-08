using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    public bool redKey;
    public bool blueKey;
    public bool greenKey;
    public GameObject text;
    public GameObject Player;
    public bool killWallPiece;
    public GameObject wall;
    private SimplePlayerController keys;

    // Start is called before the first frame update
    void Start()
    {
        keys = Player.GetComponent<SimplePlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (redKey)
            if (keys.redKey)
                StartCoroutine("KeyCheck");

        if (blueKey)
            if (keys.blueKey)
                StartCoroutine("KeyCheck");

        if (greenKey)
            if (keys.greenKey)
                StartCoroutine("KeyCheck");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CharacterController controller = other.GetComponent<CharacterController>();

            if (controller != null)
                StartCoroutine("KeyCheck");

        }
    }

    IEnumerator KeyCheck()
    {
        if (redKey)
            keys.redKey = true;

        else if (blueKey)
            keys.blueKey = true;

        else if (greenKey)
            keys.greenKey = true;

        text.SetActive(true);
        gameObject.transform.parent.gameObject.GetComponentInParent<MeshRenderer>().enabled = false;
        gameObject.transform.parent.gameObject.GetComponentInParent<MeshCollider>().enabled = false;
        yield return new WaitForSeconds(0.8f);
        gameObject.transform.parent.gameObject.GetComponentInParent<MeshRenderer>().enabled = true;
        gameObject.transform.parent.gameObject.GetComponentInParent<MeshCollider>().enabled = true;
        text.SetActive(false);
        gameObject.transform.parent.gameObject.transform.parent.gameObject.SetActive(false);

        if (killWallPiece)
            Destroy(wall.transform.GetChild(0).gameObject);
    }

}
