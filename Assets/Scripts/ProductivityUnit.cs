using UnityEngine;

public class ProductivityUnit : Unit
{
    //novas variáveis
    private ResourcePile m_currentPile = null;
    public float ProdutivityMultiplier = 2;
    protected override void BuildingInRange()
    {
        if (m_currentPile == null)
        {
            ResourcePile pile = m_Target as ResourcePile;

            if (pile != null)
            {
                m_currentPile = pile;
                m_currentPile.ProductionSpeed *= ProdutivityMultiplier;
            }
        }
    }
    }
