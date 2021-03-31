using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// カメラの追跡機能
public class FollowTarget : MonoBehaviour
{
    public Transform target; // 追跡対象
    public Vector3 offset = new Vector3(0f, 2.5f, -4f); // 追跡対象とカメラの位置関係

    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
