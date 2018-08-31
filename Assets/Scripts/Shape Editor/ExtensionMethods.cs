using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods {
    public static Vector2 ToXZ(this Vector3 v3)
    {
        return new Vector2(v3.x, v3.z);
    }

    public static Vector2 ToYZ(this Vector3 v3) {
        return new Vector2(v3.y, v3.z);
    }

    public static Vector2 ToXY(this Vector3 v3) {
        return new Vector2(v3.x, v3.y);
    }
}
