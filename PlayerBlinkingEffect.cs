using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlinkingEffect : MonoBehaviour
{
    public float spriteBlinkingTimer = 0.0f;
    public float spriteBlinkingMiniDuration = 0.1f;
    public float spriteBlinkingTotalTimer = 0.0f;
    public float spriteBlinkingTotalDuration = 10f;
    public bool startBlinking = true;
    void Update()
    {
        if (startBlinking == true)
        {
            SpriteBlinkingEffect();
        }
    }
    private void SpriteBlinkingEffect()
    {
        GameObject.FindGameObjectWithTag("Obstacle").GetComponent<EdgeCollider2D>().enabled = false;
        spriteBlinkingTotalTimer += Time.deltaTime;
        if (spriteBlinkingTotalTimer >= spriteBlinkingTotalDuration)
        {
            gameObject.GetComponent<PlayerBlinkingEffect>().enabled = false;
            spriteBlinkingTotalTimer = 0.0f;
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;   // according to 
                                                                             //your sprite
            return;
        }

        spriteBlinkingTimer += Time.deltaTime;
        if (spriteBlinkingTimer >= spriteBlinkingMiniDuration)
        {
            spriteBlinkingTimer = 0.0f;
            if (this.gameObject.GetComponent<SpriteRenderer>().enabled == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;  //make changes
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().enabled = true;   //make changes
            }
        }
    }
}
