using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBounds : MonoBehaviour
{
    public static GameBounds inst { get; private set; }

    public Transform point1;
    public Transform point2;

    public Vector2 Min
    {
        get
        {
            return new Vector2(Mathf.Min(point1.position.x, point2.position.x), Mathf.Min(point1.position.y, point2.position.y));
        }
    }
    public Vector2 Max
    {
        get
        {
            return new Vector2(Mathf.Max(point1.position.x, point2.position.x), Mathf.Max(point1.position.y, point2.position.y));
        }
    }

    private void Awake()
    {
        inst = this;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(new Vector3(Min.x, Min.y), new Vector3(Max.x, Min.y));
        Gizmos.DrawLine(new Vector3(Min.x, Max.y), new Vector3(Max.x, Max.y));
        Gizmos.DrawLine(new Vector3(Min.x, Min.y), new Vector3(Min.x, Max.y));
        Gizmos.DrawLine(new Vector3(Max.x, Min.y), new Vector3(Max.x, Max.y));
    }
}
