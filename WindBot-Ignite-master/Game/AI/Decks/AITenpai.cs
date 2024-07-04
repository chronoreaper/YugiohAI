using YGOSharp.OCGWrapper.Enums;
using System.Collections.Generic;
using WindBot;
using WindBot.Game;
using WindBot.Game.AI;
using static WindBot.MCST;
using static WindBot.NEAT;
using System.Linq;
using System;

namespace WindBot.Game.AI.Decks
{
    [Deck("Tenpai", "AI_Tenpai")]
    public class AITenpai : AIHardCodedBase
    {

        public AITenpai(GameAI ai, Duel duel)
            : base(ai, duel)
        {
            // Basically First Actions
            AddExecutor(ExecutorType.Activate, CardId.HeatWave);
            AddExecutor(ExecutorType.SpSummon, CardId.KashtiraFenrir);
            AddExecutor(ExecutorType.Activate, CardId.DimensionShifter);

            // Normal Priority
            AddExecutor(ExecutorType.Activate, CardId.PotofProsperity);
            AddExecutor(ExecutorType.Activate, CardId.SangenSummoning, SummoningActivate);
            AddExecutor(ExecutorType.Activate, CardId.SangenKaimen, KaimenActivate);
            AddExecutor(ExecutorType.Activate, CardId.TenpaiPaidra, PaidraActivate);
            AddExecutor(ExecutorType.Activate, CardId.TenpaiFadra, FadraActivate);
            AddExecutor(ExecutorType.Activate, CardId.TenpaiChundra, ChundraActivate);
            AddExecutor(ExecutorType.Summon, CardId.TenpaiPaidra);
            AddExecutor(ExecutorType.Summon, CardId.TenpaiFadra);
            AddExecutor(ExecutorType.Summon, CardId.TenpaiChundra);

            AddExecutor(ExecutorType.SpSummon, CardId.AncientFairyDragon, AncientFairySummon);
            AddExecutor(ExecutorType.SpSummon, CardId.BlackroseDragon, BlackroseSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.SangenpaiTranscendentDragion, TranscendentSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.SangenpaiBidentDragion, BidentSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.TridentDragion, TridentSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.BlackRoseMoonlightDragon, MoonlightSummon);

            AddExecutor(ExecutorType.SpSummon, CardId.UltimayaTzolkin, TzolkinSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.KuibeltTheBladeDragon, KuibeltSummon);

            AddExecutor(ExecutorType.SpSummon, CardId.HieraticSealsOfSpheres, SpheresSummon);
            AddExecutor(ExecutorType.Activate, CardId.HieraticSealsOfSpheres, SpheresActivate);
            AddExecutor(ExecutorType.SpSummon, CardId.WorldseadragonZealantis, ZealantisSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.SalamangreatRagingPhoenix, RagingPhoenixSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.PromethianPrincess, PrincessSummon);
            AddExecutor(ExecutorType.SpSummon, CardId.HiitaCharmerAblaze, HiidaSummon);
            AddExecutor(ExecutorType.Activate, CardId.SangenpaiTranscendentDragion);
            AddExecutor(ExecutorType.Activate, CardId.SangenpaiBidentDragion);
            AddExecutor(ExecutorType.Activate, CardId.TridentDragion);
            AddExecutor(ExecutorType.Activate, CardId.BlackRoseMoonlightDragon);
            AddExecutor(ExecutorType.Activate, CardId.BlackroseDragon);
            AddExecutor(ExecutorType.Activate, CardId.UltimayaTzolkin);
            AddExecutor(ExecutorType.Activate, CardId.KuibeltTheBladeDragon);
            AddExecutor(ExecutorType.Activate, CardId.AncientFairyDragon);
            AddExecutor(ExecutorType.Activate, CardId.WorldseadragonZealantis);
            AddExecutor(ExecutorType.Activate, CardId.SalamangreatRagingPhoenix);
            AddExecutor(ExecutorType.Activate, CardId.PromethianPrincess);
            AddExecutor(ExecutorType.Activate, CardId.HiitaCharmerAblaze);
            AddExecutor(ExecutorType.Activate, CardId.KashtiraFenrir);


            AddExecutor(ExecutorType.Activate, CardId.BystialMagnamhut, BystialActivate);
            AddExecutor(ExecutorType.Activate, CardId.BystialDruiswurm, BystialActivate);
            // Low Priority

            // Reactive
            AddExecutor(ExecutorType.Activate, CardId.CrossoutDesignator, CrossoutActivate);
            AddExecutor(ExecutorType.Activate, CardId.ForbiddenDroplet, DropletActivate);
            AddExecutor(ExecutorType.Activate, CardId.DimensionalBarrier, DefaultDimensionalBarrier);
            AddExecutor(ExecutorType.Activate, CardId.CrossoutDesignator, CosmicActivate);

            AddExecutor(ExecutorType.SpellSet, DefaultSpellSet);

            AddExecutor(ExecutorType.Repos, DefaultMonsterRepos);
            AddExecutor(ExecutorType.GoToBattlePhase);
        }


        // Choose Go first or second
        public override bool OnSelectHand()
        {
            bool choice = false;
            return choice;
        }


        // Assume no extra deck side
        public override void OnChangeSide(IList<int> _main, IList<int> _extra, IList<int> _side)
        {
            IList<int> pool = new List<int>(_main);
            pool = pool.Concat(_side).ToList();
            int mainCount = _main.Count();
            int sideCount = _side.Count();

            _main.Clear();
            _side.Clear();

            Archetypes enemyDeck = GetEnemyDeckType();

            {
                int[] minMain =
                {
               
                };

                AddCardsToList(_main, pool, mainCount, minMain);
            }

            switch(enemyDeck)
            {
                case Archetypes.SnakeEyes:
                    if (winResult == 0) // win
                    {
                        int[] toAdd =
                        {
                         
                        };
                        AddCardsToList(_main, pool, mainCount, toAdd);
                    }
                    else // lose
                    {
                        int[] toAdd =
{

                        };
                        AddCardsToList(_main, pool, mainCount, toAdd);
                    }
                    break;
            }



            // Fill out the remaining main deck and side deck slots.
            AddCardsToList(_main, pool, mainCount);
            AddCardsToList(_side, pool, sideCount);

            postSide = true;
        }



        public override bool OnSelectYesNo(long desc)
        {
            var option = Util.GetOptionFromDesc(desc);
            var cardId = Util.GetCardIdFromDesc(desc);
            if (cardId == CardId.SangenKaimen)
                return true;
            return base.OnSelectYesNo(desc);
        }

        public override IList<ClientCard> OnSelectCard(IList<ClientCard> _cards, int min, int max, long hint, bool cancelable)
        {
            if (AI.HaveSelectedCards())
                return null;

            ClientCard currentCard = GetCurrentCardResolveInChain();
            IList<ClientCard> selected = new List<ClientCard>();

            #region AI Selected
            if (currentCard != null)
            {
                if (CardId.SangenSummoning == currentCard.Id)
                {
                    if (!HasPerformedPreviously(ExecutorType.Summon))
                    {
                        if (!Bot.HasInHand(CardId.TenpaiPaidra))
                            selected.Add(_cards.Where(x => x.Id == CardId.TenpaiPaidra).FirstOrDefault());
                    }
                    if (!Bot.HasInHand(CardId.TenpaiChundra))
                        selected.Add(_cards.Where(x => x.Id == CardId.TenpaiChundra).FirstOrDefault());


                    // Field spell gy target
                    selected.Add(_cards.Where(x => x.Id == CardId.TridentDragion).FirstOrDefault());
                    selected.Add(_cards.Where(x => x.Id == CardId.SangenpaiTranscendentDragion).FirstOrDefault());
                    selected.Add(_cards.Where(x => x.Id == CardId.SangenpaiBidentDragion).FirstOrDefault());
                }
                else if (CardId.SangenKaimen == currentCard.Id)
                {

                }
                else if (CardId.TenpaiPaidra == currentCard.Id)
                {
                    if (hint == HintMsg.SpSummon)
                        selected.Concat(TenpaiBattlePhaseSynchro(_cards));
                    // Add to Hand
                    if (!Bot.HasInHand(CardId.SangenKaimen))
                        selected.Add(_cards.Where(x => x.Id == CardId.SangenKaimen).FirstOrDefault());
                    if (!Bot.HasInHand(CardId.SangenSummoning))
                        selected.Add(_cards.Where(x => x.Id == CardId.SangenSummoning).FirstOrDefault());
                }
                else if (CardId.TenpaiChundra == currentCard.Id)
                {
                    if (hint == HintMsg.SpSummon)
                        selected.Concat(TenpaiBattlePhaseSynchro(_cards));
                    // Special from deck
                    if (!Bot.HasInHand(CardId.SangenKaimen) && !HasPerformedPreviously(CardId.SangenKaimen))
                        selected.Add(_cards.Where(x => x.Id == CardId.TenpaiPaidra).FirstOrDefault());
                    if (!Bot.HasInMonstersZone(CardId.TenpaiFadra))
                        selected.Add(_cards.Where(x => x.Id == CardId.TenpaiFadra).FirstOrDefault());
                    if (!Bot.HasInMonstersZone(CardId.TenpaiPaidra))
                        selected.Add(_cards.Where(x => x.Id == CardId.TenpaiPaidra).FirstOrDefault());
                }
                else if (CardId.TenpaiFadra == currentCard.Id)
                {
                    if (hint == HintMsg.SpSummon)
                        selected.Concat(TenpaiBattlePhaseSynchro(_cards));
                    // Special from gy
                    if (!Bot.HasInMonstersZone(CardId.TenpaiChundra))
                        selected.Add(_cards.Where(x => x.Id == CardId.TenpaiChundra).FirstOrDefault());
                }
                else if (CardId.SangenpaiBidentDragion == currentCard.Id)
                {
                    selected.Add(_cards.Where(x => x.Id == CardId.TenpaiFadra).FirstOrDefault());
                }
                else if (CardId.SangenpaiTranscendentDragion == currentCard.Id)
                {

                }
                else if (CardId.TridentDragion == currentCard.Id)
                {
                    if (hint == HintMsg.Target)
                    {
                        selected.Add(_cards.Where(x => x.Id == CardId.SangenSummoning).FirstOrDefault());
                        selected.Add(_cards.Where(x => x.Id == CardId.SangenpaiTranscendentDragion).FirstOrDefault());
                    }
                }
                else if (CardId.KuibeltTheBladeDragon == currentCard.Id)
                {

                }
                else if (CardId.PotofProsperity == currentCard.Id)
                {
                    if (hint == HintMsg.Remove)
                    {
                        if (Duel.Turn == 1)
                        {
                            selected.Add(_cards.Where(x => x.Id == CardId.HiitaCharmerAblaze).FirstOrDefault());
                            selected.Add(_cards.Where(x => x.Id == CardId.WorldseadragonZealantis).FirstOrDefault());
                            selected.Add(_cards.Where(x => x.Id == CardId.SalamangreatRagingPhoenix).FirstOrDefault());
                        }
                        else
                        {
                            selected.Add(_cards.Where(x => x.Id == CardId.CrystalWingSynchroDragon).FirstOrDefault());
                            selected.Add(_cards.Where(x => x.Id == CardId.UltimayaTzolkin).FirstOrDefault());
                            selected.Add(_cards.Where(x => x.Id == CardId.AncientFairyDragon).FirstOrDefault());
                        }

                        _cards = _cards.OrderBy(x => (
                            x.Id == CardId.HieraticSealsOfSpheres ||
                            x.Id == CardId.SangenpaiBidentDragion ||
                            x.Id == CardId.SangenpaiTranscendentDragion ||
                            x.Id == CardId.TridentDragion) ?
                            1 : 0
                            ).ToList();
                    }
                    else if (hint == HintMsg.AddToHand)
                    {
                        if (!Bot.HasInHand(CardId.TenpaiPaidra))
                            selected.Add(_cards.Where(x => x.Id == CardId.TenpaiPaidra).FirstOrDefault());
                        if (!Bot.HasInHand(CardId.TenpaiChundra))
                            selected.Add(_cards.Where(x => x.Id == CardId.TenpaiPaidra).FirstOrDefault());
                        if (!Bot.HasInHand(CardId.SangenKaimen))
                            selected.Add(_cards.Where(x => x.Id == CardId.SangenKaimen).FirstOrDefault());
                        if (!Bot.HasInHand(CardId.SangenSummoning))
                            selected.Add(_cards.Where(x => x.Id == CardId.SangenSummoning).FirstOrDefault());
                    }
                }
            }
            #endregion

            return SelectMinimum(selected, _cards, min, max, hint);
        }

        private IList<ClientCard> TenpaiBattlePhaseSynchro(IList<ClientCard> _cards)
        {
            IList<ClientCard> selected = new List<ClientCard>();
            if (!HasPerformedPreviously(CardId.SangenpaiBidentDragion))
                selected.Add(_cards.FirstOrDefault(x => x.Id == CardId.SangenpaiBidentDragion));
            if (!HasPerformedPreviously(CardId.SangenpaiTranscendentDragion))
                selected.Add(_cards.FirstOrDefault(x => x.Id == CardId.SangenpaiTranscendentDragion));
            if (!HasPerformedPreviously(CardId.TridentDragion))
                selected.Add(_cards.FirstOrDefault(x => x.Id == CardId.TridentDragion));
            return selected;
        }

        public override IList<ClientCard> OnCardSorting(IList<ClientCard> cards)
        {
            return base.OnCardSorting(cards);
        }


        public override int OnSelectOption(IList<long> options)
        {
            foreach(long desc in options)
            {
                var option = Util.GetOptionFromDesc(desc);
                var cardId = Util.GetCardIdFromDesc(desc);
            }

            if (options.Count == 2)
            {
                var hint = options[0];
                var cardId = Util.GetCardIdFromDesc(options[1]);

                if (cardId == CardId.TenpaiPaidra)
                {
                    return 0; // 0 = to hand, 1 = set to field
                }
            }

            return base.OnSelectOption(options);
        }

        public override IList<ClientCard> OnSelectSum(IList<ClientCard> cards, int sum, int min, int max, long hint, bool mode)
        {
            return base.OnSelectSum(cards, sum, min, max, hint, mode);
        }

        public override int OnAnnounceCard(IList<int> avail)
        {
            return base.OnAnnounceCard(avail);
        }

        /// <summary>
        /// Decide which card should the attacker attack.
        /// </summary>
        /// <param name="attacker">Card that attack.</param>
        /// <param name="defenders">Cards that defend.</param>
        /// <returns>BattlePhaseAction including the target, or null (in this situation, GameAI will check the next attacker)</returns>
        public override BattlePhaseAction OnSelectAttackTarget(ClientCard attacker, IList<ClientCard> defenders)
        {
            BattlePhaseAction willAttack = base.OnSelectAttackTarget(attacker, defenders);
            if (willAttack != null)
                return willAttack;

            // Always attack for now
            ClientCard toAttack = defenders[0];
            return AI.Attack(attacker, toAttack);//toAttack == null if it is a direct attack

            //return null;
        }


        #region Generic Actions

        #endregion


        #region Generic Monsters



        #endregion


        #region Generic Spells

        #endregion


        #region Generic Traps
        #endregion

        #region Tenpai
        public bool SummoningActivate()
        {
            if (Bot.GetFieldSpellCard() != null)
                return false;
            return true;
        }

        public bool KaimenActivate()
        {
            if (Duel.Phase == DuelPhase.Battle || Duel.Phase == DuelPhase.BattleStart)
                return true;
            return false;
        }

        public bool ChundraActivate()
        {
            var option = Util.GetOptionFromDesc(ActivateDescription);
            if (option == 0)
                return TenpaiSynchroBattle();

            return true;
        }

        public bool PaidraActivate()
        {
            var option = Util.GetOptionFromDesc(ActivateDescription);
            if (option == 1)
                return TenpaiSynchroBattle();

            return true;
        }

        public bool FadraActivate()
        {
            var option = Util.GetOptionFromDesc(ActivateDescription);
            if (option == 1)
                return TenpaiSynchroBattle();

            return true;
        }

        bool TenpaiSynchroBattle()
        {
            if (Duel.LastChainPlayer == 0)
                return false;

            // Check if all monsters have attacked
            if (Bot.GetMonsters().Any(x => !x.Attacked))
                return false;

            return true;
        }

        public bool TranscendentSummon()
        {
            if (Duel.Turn == 1)
                return false;

            if (Duel.Phase == DuelPhase.Main1)
            {
                if (!AccessToKaimen())
                    return false;
            }

            return true;
        }

        public bool BidentSummon()
        {
            if (Duel.Turn == 1)
                return false;

            if (Duel.Phase == DuelPhase.Main1)
            {
                if (!AccessToKaimen())
                    return false;
            }

            return true;
        }

        public bool TridentSummon()
        {
            if (Duel.Turn == 1)
                return false;

            if (Duel.Phase == DuelPhase.Main1)
            {
                return false;
            }

            return true;
        }

        public bool AccessToKaimen()
        {
            if (HasPerformedPreviously(CardId.SangenKaimen))
                return false;

            if (Bot.HasInHand(CardId.SangenKaimen))
                return true;
            return false;
        }

        #endregion

        #region Extra deck
        public bool BlackroseSummon()
        {
            if (Duel.Turn == 1)
                return false;

            if (Duel.Phase == DuelPhase.Main1)
            {
                if (!AccessToKaimen())
                    return false;
            }

            if (Enemy.GetFieldCount() >= 5)
                return true;

            return false;
        }

        public bool MoonlightSummon()
        {
            if (Duel.Phase == DuelPhase.Main1)
            {
                return false;
            }

            return false;
        }

        public bool TzolkinSummon()
        {
            if (Duel.Turn != 1)
                return false;

            return true;
        }

        public bool KuibeltSummon()
        {
            if (Duel.Turn == 1)
                return false;
            if (!AccessToKaimen())
                return false;
            if (Enemy.GetMonsters().Where(x => x.Attack >= 2700).Count() >= 2)
                return true;
            return false;
        }

        public bool AncientFairySummon()
        {
            if (Duel.Turn != 1)
                return false;
            if (Bot.HasInHand(CardId.TenpaiFadra))
                return true;
            return false;
        }

        public bool SpheresSummon()
        {
            if (Duel.Turn == 1 || Duel.Phase == DuelPhase.Main2)
                return true;
            return false;
        }

        public bool SpheresActivate()
        {
            int[] targets =
            {
                CardId.SnakeEyeFlamberge,
                CardId.PromethianPrincess,
                CardId.SalamangreatRagingPhoenix,
                CardId.AccesscodeTalker,
                CardId.WorldseadragonZealantis
            };

            if (Enemy.HasInHandOrInSpellZone(targets))
                return true;

            return false;
        }

        public bool ZealantisSummon()
        {
            if (Bot.HasInMonstersZone(CardId.SalamangreatRagingPhoenix) && Bot.GetMonsterCount() >= 2)
                return true;
            return false;
        }

        public bool RagingPhoenixSummon()
        {
            if (Bot.HasInMonstersZone(CardId.PromethianPrincess) && Bot.GetMonsterCount() >= 2 && Enemy.GetMonsterCount() >= 1)
                return true;
            return false;
        }

        public bool PrincessSummon()
        {
            if (Bot.GetLinkMaterialWorth() >= 4 && Enemy.GetMonsterCount() > 1)
                return true;
            if (!Bot.HasInMonstersZone(CardId.TenpaiChundra) && !Bot.HasInMonstersZone(CardId.TenpaiFadra))
                return true;

            return false;
        }

        public bool HiidaSummon()
        {
            if (!Enemy.GetGraveyardMonsters().Any(x => x.HasAttribute(CardAttribute.Fire)))
                return false;
            if (!AccessToKaimen() || previousActionsEnemy.Any(x => x.cardId == CardId.DimensionalBarrier))
                return true;

            return false;
        }


        #endregion
    }
}
