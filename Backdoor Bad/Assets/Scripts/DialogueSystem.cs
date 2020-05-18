using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueSystem : MonoBehaviour
{
    public Text startText;
    public Text employeeText;
    public Text customerText;
    public GameObject startButton;
    public GameObject yesButton;
    public GameObject middleButton;
    public GameObject noButton;
    public GameObject nextButton;
    public GameObject textBackDrop;
    public GameObject wifeRequestButton;
    public GameObject wifeResponseButton;
    public GameObject playerTextButton;
    //public GameObject badEnding;
    //public GameObject goodEnding;
    //public GameObject middleEnding;
    public Light phoneLight;
    public AudioSource doorSound;
    public AudioSource phoneSound;
    public AudioSource knockSound;
    public GameObject employee;
    public GameObject customer;
    public string opening = "It's the start of a new day at your job being the Manager of a Malmart during the COVID-19 crisis." +
        " Life has been strange and difficult since this virus hit, but your store is one essential front for the wellbeing of the public." +
        " A new shipment of essential goods should be arriving soon.";
    public string employeeRequest = "Hey Boss, the new shipment of toilet paper, hand sanitizer, and water bottles arrived. I was thinkin' Boss, I've been kinda running low on hand sanitizer" +
        " and toilet paper at home. Can I take some from storage before we put it out on the shelves? I'll pay regular price of course.";
    public string noEmployeeResponse = "Oh, aight. I'll go stock up the shelves then.";
    public string middleEmployeeResponse = "Of course Boss, I won't take more than I need.";
    public string yesEmployeeResponse = "Thank you Boss, I'll go ring it up right now and bring it to my car.";
    public string familyRequest = "Hey Honey I just noticed that we are out of bottle water at home, can you bring some home after your shift?";
    public string yesFamilyResponse = "Thanks sweetie, you just saved me some time from going outside today.";
    public string middleFamilyResponse = "I understand sweetie, thank you!";
    public string noFamilyResponse = "It's ok honey, I'll go outside and get it myself, see you at home.";
    public string customerRequestText = "Hello sir, one of your employees brought me here to ask you a question. What time do you restock? I wanted to come as early as possible since things are so hard to get nowadays";
    public string noCustomerResponse = "How rude! I'm trying to protect my family, have you no soul!";
    public string yesCustomerResponse = "Why thank you Sir! I'll be there to hopefully get first pickings.";
    public string middleCustomerResponse = "Oh certainly. I would've probably bought excess but you're right, I should be courteous and leave for other people too.";
    public int response = 0;
    public int interaction = 0;
    public int noPress = 0;
    public int yesPress = 0;
    public int middlePress = 0;
    public GameObject customer4;
    public GameObject customer3;
    public GameObject customer2;



    private void Awake()
    {
        employee.GetComponent<MeshRenderer>().enabled = false;
        employeeText.GetComponent<Text>().enabled = false;
        customer.GetComponent<MeshRenderer>().enabled = false;
        customerText.GetComponent<Text>().enabled = false;
        yesButton.GetComponent<Button>().enabled = false;
        yesButton.GetComponent<Image>().enabled = false;
        yesButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponent<Button>().enabled = false;
        noButton.GetComponent<Image>().enabled = false;
        middleButton.GetComponent<Button>().enabled = false;
        middleButton.GetComponent<Image>().enabled = false;
        middleButton.GetComponentInChildren<Text>().enabled = false;
        nextButton.GetComponent<Button>().enabled = false;
        nextButton.GetComponent<Image>().enabled = false;
        nextButton.GetComponentInChildren<Text>().enabled = false;
        textBackDrop.GetComponent<Image>().enabled = false;
        wifeRequestButton.GetComponent<Button>().enabled = false;
        wifeRequestButton.GetComponent<Image>().enabled = false;
        wifeRequestButton.GetComponentInChildren<Text>().enabled = false;
        wifeResponseButton.GetComponent<Button>().enabled = false;
        wifeResponseButton.GetComponent<Image>().enabled = false;
        wifeResponseButton.GetComponentInChildren<Text>().enabled = false;
        playerTextButton.GetComponent<Button>().enabled = false;
        playerTextButton.GetComponent<Image>().enabled = false;
        playerTextButton.GetComponentInChildren<Text>().enabled = false;
        //goodEnding.GetComponent<MeshRenderer>().enabled = false;
        //badEnding.GetComponent<MeshRenderer>().enabled = false;
        //middleEnding.GetComponent<MeshRenderer>().enabled = false;

        phoneLight.GetComponent<Light>().enabled = false;
        startText.text = "";
        startText.text = opening;
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (response == 2)
        {
            Destroy(customer4);

            Destroy(customer3);

            Destroy(customer2);
        }
        if (response == 1)
        {
            Destroy(customer4);
        }
    }

    public void startDay()
    {
        StartCoroutine(dayStart());
    }

    public void yesButtonScript()
    {
        response = 1;
        yesPress += 1;
        if (interaction == 0)
        {
            employeeText.text = yesEmployeeResponse;
        }

        else if (interaction == 1)
        {
            playerTextButton.GetComponent<Button>().enabled = true;
            playerTextButton.GetComponent<Image>().enabled = true;
            playerTextButton.GetComponentInChildren<Text>().text = "Yes, I'll take what I can";
            playerTextButton.GetComponentInChildren<Text>().enabled = true;
            wifeResponseButton.GetComponent<Button>().enabled = true;
            wifeResponseButton.GetComponent<Image>().enabled = true;
            wifeResponseButton.GetComponentInChildren<Text>().text = yesFamilyResponse;
            wifeResponseButton.GetComponentInChildren<Text>().enabled = true;
        }

        else if (interaction == 2)
        {
            customerText.text = yesCustomerResponse;
        }

        yesButton.GetComponent<Button>().enabled = false;
        yesButton.GetComponent<Image>().enabled = false;
        yesButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponent<Button>().enabled = false;
        noButton.GetComponent<Image>().enabled = false;
        middleButton.GetComponent<Button>().enabled = false;
        middleButton.GetComponent<Image>().enabled = false;
        middleButton.GetComponentInChildren<Text>().enabled = false;
        nextButton.GetComponent<Button>().enabled = true;
        nextButton.GetComponent<Image>().enabled = true;
        nextButton.GetComponentInChildren<Text>().enabled = true;
    }

    public void noButtonScript()
    {
        response = 1;
        noPress += 1;
        if (interaction == 0)
        {
            employeeText.text = noEmployeeResponse;
        }

        else if (interaction == 1)
        {
            playerTextButton.GetComponent<Button>().enabled = true;
            playerTextButton.GetComponent<Image>().enabled = true;
            playerTextButton.GetComponentInChildren<Text>().text = "No, I can't. I'm sorry.";
            playerTextButton.GetComponentInChildren<Text>().enabled = true;
            wifeResponseButton.GetComponent<Button>().enabled = true;
            wifeResponseButton.GetComponent<Image>().enabled = true;
            wifeResponseButton.GetComponentInChildren<Text>().text = noFamilyResponse;
            wifeResponseButton.GetComponentInChildren<Text>().enabled = true;
        }

        else if (interaction == 2)
        {
            customerText.text = noCustomerResponse;
        }

        yesButton.GetComponent<Button>().enabled = false;
        yesButton.GetComponent<Image>().enabled = false;
        yesButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponent<Button>().enabled = false;
        noButton.GetComponent<Image>().enabled = false;
        middleButton.GetComponent<Button>().enabled = false;
        middleButton.GetComponent<Image>().enabled = false;
        middleButton.GetComponentInChildren<Text>().enabled = false;
        nextButton.GetComponent<Button>().enabled = true;
        nextButton.GetComponent<Image>().enabled = true;
        nextButton.GetComponentInChildren<Text>().enabled = true;

    }

    public void middleButtonScript()
    {
        response = 3;
        middlePress += 1;
        if (interaction == 0)
        {
            employeeText.text = middleEmployeeResponse;

        }

        else if (interaction == 1)
        {
            playerTextButton.GetComponent<Button>().enabled = true;
            playerTextButton.GetComponent<Image>().enabled = true;
            playerTextButton.GetComponentInChildren<Text>().text = "Yes,but not too much";
            playerTextButton.GetComponentInChildren<Text>().enabled = true;
            wifeResponseButton.GetComponent<Button>().enabled = true;
            wifeResponseButton.GetComponent<Image>().enabled = true;
            wifeResponseButton.GetComponentInChildren<Text>().text = middleFamilyResponse;
            wifeResponseButton.GetComponentInChildren<Text>().enabled = true;
        }

        else if (interaction == 2)
        {
            customerText.text = middleCustomerResponse;
        }

        yesButton.GetComponent<Button>().enabled = false;
        yesButton.GetComponent<Image>().enabled = false;
        yesButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponentInChildren<Text>().enabled = false;
        noButton.GetComponent<Button>().enabled = false;
        noButton.GetComponent<Image>().enabled = false;
        middleButton.GetComponent<Button>().enabled = false;
        middleButton.GetComponent<Image>().enabled = false;
        middleButton.GetComponentInChildren<Text>().enabled = false;
        nextButton.GetComponent<Button>().enabled = true;
        nextButton.GetComponent<Image>().enabled = true;
        nextButton.GetComponentInChildren<Text>().enabled = true;
    }

    public void nextInteraction()
    {
        if (interaction == 0)
        {
            interaction += 1;
            employeeText.text = "";
            doorSound.Play(0);
            employee.GetComponent<MeshRenderer>().enabled = false;
            employeeText.GetComponent<Text>().enabled = false;
            StartCoroutine(wifeCall());
        }

        else if (interaction == 1)
        {
            interaction += 1;
            textBackDrop.GetComponent<Image>().enabled = false;
            wifeRequestButton.GetComponent<Button>().enabled = false;
            wifeRequestButton.GetComponent<Image>().enabled = false;
            wifeRequestButton.GetComponentInChildren<Text>().enabled = false;
            wifeResponseButton.GetComponent<Button>().enabled = false;
            wifeResponseButton.GetComponent<Image>().enabled = false;
            wifeResponseButton.GetComponentInChildren<Text>().enabled = false;
            playerTextButton.GetComponent<Button>().enabled = false;
            playerTextButton.GetComponent<Image>().enabled = false;
            playerTextButton.GetComponentInChildren<Text>().enabled = false;
            phoneLight.GetComponent<Light>().enabled = false;
            StartCoroutine(customerEncounter());
        }

        else if (interaction == 2)
        {
            doorSound.Play(0);
            customer.GetComponent<MeshRenderer>().enabled = false;
            customerText.GetComponent<Text>().enabled = false;
            if (yesPress >= 2)
            {
                //goodEnding.GetComponent<MeshRenderer>().enabled = true;
            }

            else if (noPress >= 2)

            {
                //badEnding.GetComponent<MeshRenderer>().enabled = true;
            }

            else if (middlePress >= 2)
            {
                //middleEnding.GetComponent<MeshRenderer>().enabled = true;
            }

            else if (yesPress == 1 && noPress == 1 && middlePress == 1)
            {
                //middleEnding.GetComponent<MeshRenderer>().enabled = true;
            }
            
        }
        nextButton.GetComponent<Button>().enabled = false;
        nextButton.GetComponent<Image>().enabled = false;
        nextButton.GetComponentInChildren<Text>().enabled = false;
    }

    IEnumerator dayStart()
    {
        startText.GetComponent<Text>().enabled = false;
        startButton.GetComponentInChildren<Text>().enabled = false;
        startButton.GetComponent<Button>().enabled = false;
        startButton.GetComponent<Image>().enabled = false;
        startButton.GetComponent<Button>().enabled = false;
        yield return new WaitForSeconds(1);

        doorSound.Play(0);
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
        middleButton.GetComponent<Button>().enabled = true;
        middleButton.GetComponent<Image>().enabled = true;
        middleButton.GetComponentInChildren<Text>().enabled = true;

    }

    IEnumerator wifeCall()
    {
        yield return new WaitForSeconds(2f);
        phoneSound.Play(0);
        phoneLight.GetComponent<Light>().enabled = true;
        yield return new WaitForSeconds(1f);
        textBackDrop.GetComponent<Image>().enabled = true;
        wifeRequestButton.GetComponent<Button>().enabled = true;
        wifeRequestButton.GetComponent<Image>().enabled = true;
        wifeRequestButton.GetComponentInChildren<Text>().enabled = true;
        yield return new WaitForSeconds(1f);
        noButton.GetComponentInChildren<Text>().enabled = true;
        noButton.GetComponent<Button>().enabled = true;
        noButton.GetComponent<Image>().enabled = true;
        yesButton.GetComponent<Button>().enabled = true;
        yesButton.GetComponent<Image>().enabled = true;
        yesButton.GetComponentInChildren<Text>().enabled = true;
        middleButton.GetComponent<Button>().enabled = true;
        middleButton.GetComponent<Image>().enabled = true;
        middleButton.GetComponentInChildren<Text>().enabled = true;


    }

    IEnumerator customerEncounter()
    {
        yield return new WaitForSeconds(2f);
        knockSound.Play(0);
        yield return new WaitForSeconds(1f);
        doorSound.Play(0);
        yield return new WaitForSeconds(0.5f);
        customer.GetComponent<MeshRenderer>().enabled = true;
        customerText.GetComponent<Text>().text = customerRequestText;
        customerText.GetComponent<Text>().enabled = true;
        customerText.GetComponent<Text>().text = customerRequestText;
        customerText.GetComponent<Text>().enabled = true;
        yield return new WaitForSeconds(2);
        noButton.GetComponentInChildren<Text>().text = "Don't Tell";
        noButton.GetComponentInChildren<Text>().enabled = true;
        noButton.GetComponent<Button>().enabled = true;
        noButton.GetComponent<Image>().enabled = true;
        yesButton.GetComponent<Button>().enabled = true;
        yesButton.GetComponent<Image>().enabled = true;
        yesButton.GetComponentInChildren<Text>().text = "Tell Her";
        yesButton.GetComponentInChildren<Text>().enabled = true;
        middleButton.GetComponent<Button>().enabled = true;
        middleButton.GetComponent<Image>().enabled = true;
        middleButton.GetComponentInChildren<Text>().text = "Tell, but warn her";
        middleButton.GetComponentInChildren<Text>().enabled = true;
    }


}
