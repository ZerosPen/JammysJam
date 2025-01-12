using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PaperClose : MonoBehaviour
{
    public GameObject paper;
    public GameObject Recipe;
    public GameObject RecipeBlueberry;
    public GameObject RecipeApple;
    public void ClickToClosePaper(){
        paper.SetActive(false);
    }
    public void ClickToOpenPaper(){
        paper.SetActive(true);
    }
    public void ClickToCloseRecipe(){
        Recipe.SetActive(false);
        RecipeBlueberry.SetActive(false);
        RecipeApple.SetActive(false);
    }
    public void ClickToOpenRecipe(){
        Recipe.SetActive(true);
    }
    public void ClickToOpenRecipeBlueberry(){
        RecipeBlueberry.SetActive(true);
        Recipe.SetActive(false);
    }
    public void ClickToOpenRecipeApple(){
        RecipeApple.SetActive(true);
        RecipeBlueberry.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
