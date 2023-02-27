using TMPro;
using UnityEngine;

public class CardHandler : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI cardNameText;
    [SerializeField]
    private TextMeshProUGUI cardDescText;
    [SerializeField]
    private TextMeshProUGUI attackText;
    [SerializeField]
    private TextMeshProUGUI healthText;
    [SerializeField]
    private TextMeshProUGUI spawnEnergyText;
    [SerializeField]
    private TextMeshProUGUI moveEnergyText;
    [SerializeField]
    private MeshRenderer meshRenderer;

    private int cardIndex;

    public GameCard cardSO;

    [HideInInspector]
    public int cardId;
    [HideInInspector]
    public Material cardMaterial;
    [HideInInspector]
    public string cardName;
    [HideInInspector]
    public string cardDesc;
    [HideInInspector]
    public int attack;
    [HideInInspector]
    public int health;
    [HideInInspector]
    public int spawnEnergy;
    [HideInInspector]
    public int moveEnergy;
    [HideInInspector]
    public GameCard.Properties property;

    private GenericUnitCard genericUnit;

    private void Awake()
    {
        // genericUnit = GetComponent<GenericUnitCard>();

        cardId = cardSO.cardId;

        cardMaterial = cardSO.cardMaterial;
        meshRenderer.material = cardMaterial;

        cardName = cardSO.cardName;
        cardNameText.text = cardName;

        cardDesc = cardSO.cardDesc;
        cardDescText.text = cardDesc;

        attack = cardSO.cardPower;
        attackText.text = attack.ToString();

        health = cardSO.cardHealth;
        healthText.text = health.ToString();

        spawnEnergy = cardSO.spawnEnergy;
        spawnEnergyText.text = spawnEnergy.ToString();

        moveEnergy = cardSO.moveEnergy;
        moveEnergyText.text = moveEnergy.ToString();
    }

    public int GetIndex()
    {
        return cardIndex;
    }

    public void SetIndex(int value)
    {
        cardIndex = value;
    }

    public void IncrementIndex(int amount = 1)
    {
        cardIndex += amount;
    }

    public void DecrementIndex(int amount = 1)
    {
        cardIndex -= amount;
    }
}
