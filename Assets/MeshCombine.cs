using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter))]
//[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]

public class MeshCombine : MonoBehaviour
{
    [ContextMenu("Combine")]
    void Combine()
    {
        Quaternion OldRot = transform.rotation;
        Vector3 OldPos = transform.position;
        Vector3 OldScale = transform.localScale;

        transform.rotation = Quaternion.identity;
        transform.position = Vector3.zero;
        transform.localScale = Vector3.one;



        MeshFilter[] filters = GetComponentsInChildren<MeshFilter>();

        Debug.Log(name + "is combining" + filters.Length + "meshes!");

        Mesh finalMesh = new Mesh();
        GetComponent<MeshCollider>().sharedMesh = null;
        GetComponent<MeshCollider>().sharedMesh = finalMesh;



        CombineInstance[] combiners = new CombineInstance[filters.Length];


        for (int a = 0; a < filters.Length; a++)
        {
            if (filters[a].transform == transform)
                continue;


            combiners[a].subMeshIndex = 0;
            combiners[a].mesh = filters[a].sharedMesh;
            combiners[a].transform = filters[a].transform.localToWorldMatrix;
        }

        finalMesh.CombineMeshes(combiners);


        GetComponent<MeshFilter>().sharedMesh = finalMesh;



        transform.rotation = OldRot;
        transform.position = OldPos;
        transform.localScale = OldScale;


    }

}