using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingController : MoveController
{
    private Vector2 _inputPositionPivot;
    [SerializeField] private AudioSource2 audio;
    //public AudioClip[] clip;

    protected override void OnPut(Vector3 pos)
    {
        var rigidbody = HoldingObject.GetComponent<Rigidbody>();
        rigidbody.useGravity = true;
        var direction = mainCamera.transform.TransformDirection(Vector3.forward).normalized;
        var delta = (pos.y - _inputPositionPivot.y) * 100f / Screen.height;
        rigidbody.AddForce((direction + Vector3.up) * 4.5f * delta);
        HoldingObject.transform.SetParent(null);
        _inputPositionPivot.y = pos.y;

        audio.Play(1);
    }

    protected override void OnHold()
    {
        _inputPositionPivot = InputPosition;

        audio.Play(0);
    }


}