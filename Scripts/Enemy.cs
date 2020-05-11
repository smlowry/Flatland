using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
        public float speed = 1f;
        public Transform target;

        void Start()
        {
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }

        void Update()
        {

            var dist = Vector3.Distance(target.position, transform.position);

            if (dist < 7)
            {

                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

                Vector2 direction = target.position - transform.position;

                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

                Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
            }
        }

}
