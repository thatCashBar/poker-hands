﻿using poker_hand_card_service.Models;

namespace poker_hand_card_service.Interfaces
{
    public interface ICardService
    {
        PlayerHand[] GetCards();
        Winner EvaluateCards(PlayerHand[] playerHands);
    }
}
