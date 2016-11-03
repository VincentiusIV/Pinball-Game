using UnityEngine;
using System.Collections;

public class OnCollision : MonoBehaviour
{
    private GameObject _GCObject;
    private GameController gameController;

    public bool playSound;
    public bool changeMaterial;
    public bool changeLight;
    public bool spawnExtraBall;
    
    public Material[] materials;
    public GameObject light;
    public Transform ballSpawnPosition;
    public GameObject ball;

    private Renderer rend;
    private AudioSource audio;

    void Awake()
    {
        _GCObject = GameObject.FindWithTag("GameController");
        gameController = _GCObject.GetComponent<GameController>();

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.material = materials[0];
    }
	void OnCollisionEnter(Collision col)
    {
        Score();
        PlaySound();
        ChangeMaterial();
        SpawnNewBall();
        ChangeLight();
    }

    void OnCollisionExit(Collision col)
    {
        if(changeMaterial)
        {
            rend.material = materials[0];
        }
        if(changeLight)
        {
            StartCoroutine(turnOffLight());
        }
    }

    void Score()
    {
        gameController.AddScore(5);
    }
    void PlaySound()
    {
        if(playSound)
        {
            audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }

    void ChangeMaterial()
    {
        if(changeMaterial)
        {
            rend.material = materials[1];
        }
    }

    void SpawnNewBall()
    {
        if(spawnExtraBall)
        {
            Instantiate(ball, ballSpawnPosition.position , ballSpawnPosition.rotation);
            gameController.Announce();
            gameController.AddScore(10);
        }
    }

    void ChangeLight()
    {
        light.SetActive(true);
    }

    IEnumerator turnOffLight()
    {
        yield return new WaitForSeconds(1.0f);
        light.SetActive(false);

    }
}
