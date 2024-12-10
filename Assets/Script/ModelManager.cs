using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MonoBehaviour
{
    public void ScaleModel()
    {
        transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
    }

    public void ScaleDownModel()
    {
        transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
    }

    public void RotateModel()
    {
        transform.Rotate(new Vector3(0, 20f, 0));
    }
}
