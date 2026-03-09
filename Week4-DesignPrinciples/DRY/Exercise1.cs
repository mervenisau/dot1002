void UpdateResourceText(Text resourceText, int amount)
{
    resourceText.text = "Amount: " + amount.ToString();
}

void UpdateGold(int amount)
{
    UpdateResourceText(goldText, amount);
}

void UpdateCrystal(int amount)
{
    UpdateResourceText(crystalText, amount);
}

void UpdateFood(int amount)
{
    UpdateResourceText(foodText, amount);
}