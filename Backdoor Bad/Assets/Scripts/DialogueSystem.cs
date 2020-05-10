using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueSystem : MonoBehaviour
{
    public Text startText;
    public Text employeeText;
    public GameObject startButton;
    public GameObject yesButton;
    public GameObject noButton;
    public AudioSource sound;
    public GameObject employee;
    public string opening = "It's the start of a new day at your job being the Manager of a Malmart during the COVID-19 crisis." +
        " Life has been strange and difficult since this virus hit, but your store is one essential front for the wellbeing of the public." +
        " A new shipment of essential goods should be arriving soon.";
    public string employeeRequest = "Hey Boss, the new shipment of toilet paper, hand sanitizer, and water bottles arrived. I was thinkin' Boss, I've been kinda running low on hand sanitizer" +
        " and toilet paper at home. Can I take some from storage before we put it out on the shelves? I'll pay regular price of course.";
    public string noEmployeeResponse = "Oh, aight. I'll go stock up the shelves then.";
    public string yesEmployeeResponse = "Thank you Boss, I'll go ring it up right now and bring it to my car.";
    public int response = 0;



    private void Awake()
    {
        employee.GetComponent<MeshRenderer>().enabled = false;
        employeeText.GetComponent<Text>().enabled = false;
        yesButton.GetComponent<Button>().enabled = false;
        yesButton.GetComponent<Image>().enabled = false;
        yesButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponent<Button>().enabled = false;
        noButton.GetComponent<Image>().enabled = false;
        sound = GetComponent<AudioSource>();
        startText.text = "";
        startText.text = opening;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startDay()
    {
        StartCoroutine(dayStart());
    }

    public void yesButtonScript()
    {
        response = 1;
        employeeText.text = yesEmployeeResponse;
        yesButton.GetComponent<Button>().enabled = false;
        yesButton.GetComponent<Image>().enabled = false;
        yesButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponent<Button>().enabled = false;
        noButton.GetComponent<Image>().enabled = false;
    }

    public void noButtonScript()
    {
        response = 2;
        employeeText.text = noEmployeeResponse;
        noButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponent<Button>().enabled = false;
        noButton.GetComponent<Image>().enabled = false;
        yesButton.GetComponent<Button>().enabled = false;
        yesButton.GetComponent<Image>().enabled = false;
        yesButton.GetComponentInChildren<Text>().enabled = false;
    }

    IEnumerator dayStart()
    {
        startText.GetComponent<Text>().enabled = false;
        startButton.GetComponentInChildren<Text>().enabled = false;
        startButton.GetComponent<Button>().enabled = false;
        startButton.GetComponent<Image>().enabled = false;
        startButton.GetComponent<Button>().enabled = false;
        yield return new WaitForSeconds(1);

        sound.Play(0);
        yield return new WaitForSeconds(0.5f);
        employee.GetComponent<MeshRenderer>().enabled = true;
        employeeText.GetComponent<Text>().enabled = true;
        employeeText.text = employeeRequest;
        yield return new WaitForSeconds(2);
        noButton.GetComponentInChildren<Text>().enabled = true;
        noButton.GetComponent<Button>().enabled = true;
        noButton.GetComponent<Image>().enabled = true;
        yesButton.GetComponent<Button>().enabled = true;
        yesButton.GetComponent<Image>().enabled = true;
        yesButton.GetComponentInChildren<Text>().enabled = true;

    }
}
