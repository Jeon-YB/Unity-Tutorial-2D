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

        //Debug.Log($"�̸� :  {obj.name}");
        //Debug.Log($"�±� : {obj.tag}");
        //Debug.Log($"��ġ : {obj.transform.position}");
        //Debug.Log($"��ġ : {obj.transform.rotation}");
        //Debug.Log($"��ġ : {obj.transform.localScale}");

        //Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}");
        //Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}");

        //obj.GetComponent<MeshRenderer>().enabled = false;

        //obj.SetActive(false);