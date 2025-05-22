using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;
    public Material mat;

    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);

        CreateCube();
        
    }

    public void CreateCube()
    {
        obj = new GameObject("Cube");

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;
        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;
        obj.AddComponent<BoxCollider>();

    }
}










    //public GameObject obj;

    //public Transform objTf;

    //public string changeName;






        //obj = GameObject.Find("Main Camera");

        //obj = GameObject.FindGameObjectWithTag("Player");

        //objTf = GameObject.FindGameObjectWithTag("Player").transform;

        //objTf.gameObject.SetActive(false);

        //Debug.Log($"이름 :  {obj.name}");
        //Debug.Log($"태그 : {obj.tag}");
        //Debug.Log($"위치 : {obj.transform.position}");
        //Debug.Log($"위치 : {obj.transform.rotation}");
        //Debug.Log($"위치 : {obj.transform.localScale}");

        //Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");
        //Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");

        //obj.GetComponent<MeshRenderer>().enabled = false;

        //obj.SetActive(false);