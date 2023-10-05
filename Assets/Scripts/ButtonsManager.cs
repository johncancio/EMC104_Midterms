using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonsManager : MonoBehaviour
{
    public Transform targetObject;
    public float duration = .25f;
    private bool objectOut = false;
    public void ScaleObject()
    {
        if (objectOut)
        {
            targetObject.DOScale(new Vector3(1f, 1f, 1f), duration);
            targetObject.GetComponent<Renderer>().material.DOFade(1f, duration);
        } else
        {
            targetObject.DOScale(new Vector3(0.7f, 0.7f, 0.7f), duration);
            targetObject.GetComponent<Renderer>().material.DOFade(0f, duration);
        }

        objectOut = !objectOut;
    }

    public void ZoomObject()
    {
        if (objectOut)
        {
            targetObject.DOScale(new Vector3(1f, 1f, 1f), duration);
        } else
        {
            targetObject.DOScale(new Vector3(0f, 0f, 0f), duration);
        }

        objectOut = !objectOut;
    }

    public void fadeUpObject()
    {
        if (objectOut)
        {
            targetObject.DOMove(new Vector3(4.19591f, 0.1374873f, 0f), duration);
            targetObject.GetComponent<Renderer>().material.DOFade(1f, duration);
        } else
        {
            targetObject.DOMove(new Vector3(4.19591f, -0.8625127f, 0f), duration);
            targetObject.GetComponent<Renderer>().material.DOFade(0f, duration);
        }

        objectOut = !objectOut;
    }

    public void fadeRightObject()
    {
        if (objectOut)
        {
            targetObject.DOMove(new Vector3(4.19591f, 0.1374873f, 0f), duration);
            targetObject.GetComponent<Renderer>().material.DOFade(1f, duration);
        }
        else
        {
            targetObject.DOMove(new Vector3(2.69591f, 0.1374873f, -9.38773e-07f), duration);
            targetObject.GetComponent<Renderer>().material.DOFade(0f, duration);
        }

        objectOut = !objectOut;
    }

    public void flipVerticalObect()
    {
        if (objectOut)
        {
            targetObject.DORotate(new Vector3(0f, 0f, 0f), duration);
            targetObject.GetComponent<Renderer>().material.DOFade(1f, duration);
        } else
        {
            targetObject.DORotate(new Vector3(-90f, 0f, 0f), duration);
            targetObject.GetComponent<Renderer>().material.DOFade(0f, duration);
        }

        objectOut = !objectOut;
    }

    public void flipHorizontalObject()
    {
        if (objectOut)
        {
            targetObject.DORotate(new Vector3(0f, 0f, 0f), duration);
            targetObject.GetComponent<Renderer>().material.DOFade(1f, duration);
        }
        else
        {
            targetObject.DORotate(new Vector3(0f, -90f, 0f), duration);
            targetObject.GetComponent<Renderer>().material.DOFade(0f, duration);
        }

        objectOut = !objectOut;
    }
}
