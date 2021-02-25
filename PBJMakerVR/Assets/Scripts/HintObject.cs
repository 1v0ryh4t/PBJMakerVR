using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintObject : MonoBehaviour
{
    /**
     * This script makes an object flash yellow and a text box pops up with a prompt. The flashing and text should disappear when picked up
     * This script should be attached to the gameobject associated with it
     * */


    public bool isHinting = false;

    private Color objectColor;

    // Start is called before the first frame update
    void Start()
    {
        objectColor = gameObject.GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHinting)
            ShowHint();
        else
            HideHint();
    }

    public void SetIsHinting(bool b)
    {
        isHinting = b;
    }

    //should flash and display hint
    private void ShowHint()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.Lerp(objectColor, Color.yellow, 0.5f);
    }

    //should stop flash and hint
    private void HideHint()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = objectColor;
    }
}
