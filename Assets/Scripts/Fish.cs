using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public int uniqueId;

    public GameObject vfxTouch;


    private void OnMouseDown()
    {
        GameObject vfx = Instantiate(vfxTouch, transform.position, Quaternion.identity) as GameObject;
        Destroy(vfx, 1f);

        GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].gameObjects.Remove(gameObject);
        GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].CheckFish(uniqueId);
        gameObject.SetActive(false);
    }
}
