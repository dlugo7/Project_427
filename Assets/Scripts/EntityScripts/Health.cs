﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public float maxHealth;
    public float currentHealth;
    public Image hpBar;
    private bool wait;


    public float maxEnergy;
    public float currentEnergy;

    [SerializeField] Image imgHP;
    [SerializeField] Image imgEN;

    // Use this for initialization
    void Start () {
        currentHealth = maxHealth;
        currentEnergy = maxEnergy;
    }
	
	// Update is called once per frame
	void Update () {

        if (transform.tag == "Player")
        {
            imgHP.fillAmount = currentHealth / maxHealth;
            imgEN.fillAmount = currentEnergy / maxEnergy;
        }


    // Use this for initialization
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            currentHealth -= 5;
        }

        hpBar.fillAmount = currentHealth / maxHealth;

    }

    public void takeDamage(float num)
    {


        currentHealth -= num;

        Debug.Log(currentHealth);
        if(currentHealth <= 0)

        if (!wait) { currentHealth -= num; }

        //Debug.Log(currentHealth);
        if (currentHealth <= 0)

        {
            //Debug.Log("He a Dead Boi Now");
        }
    }


    public void getHealth(float num)
    {
        currentHealth += num;
        
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }

    }

    public void getMana(float num)
    {
        currentEnergy += num;

        if (currentEnergy >= maxEnergy)
        {
            currentEnergy = maxEnergy;
        }
    }




    public void giveHealth(float giveAmount)
    {
        currentHealth += giveAmount;
    }



    public void Iframess()
    {
        StartCoroutine("Invincible");
    }

    private IEnumerator Invincible()
    {
        wait = true;
        yield return new WaitForSeconds(1f);
        wait = false;
    }

}
