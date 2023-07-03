﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace nuff.PersonalizedBedrooms
{
    class CompPersonalizedBedroom : ThingComp
    {
        CompProperties_PersonalizedBedroom Props => props as CompProperties_PersonalizedBedroom;

        public HashSet<RoomDesireDef> possibleDesires;
        public HashSet<RoomDesireDef> activeDesires;

        public HashSet<TraitDef> traitCache;

        public int desireSlots;

        public int cachedBedroomWealth = -1;

        public override void Initialize(CompProperties props)
        {
            base.Initialize(props);
            //cache pawn traits
            //fill desire slots
        }

        public void ReInitialize()
        {
            //todo
        }

        public void checkIfTraitsChanged()
        {
            //compare current traits to traitCache
            //if current traits != traitCache:
            //make list of missing traits
            //make list of added traits
            //remove all desires associated with missing traits
            //fill missing desire slots

            //maybe do this on birthdays?
        }

        public void activateTraitDesires()
        {
            //select as many trait-associated desires as possible for each desire tier
        }

        public void activateGeneDesires()
        {
            //select as many gene-associated desires as possible for each desire tier
            //will require BioTech
            //maybe this takes priority over Trait desires?
        }

        public void activateIdeoDesires()
        {
            //select as many ideologion-associated desires as possible for each desire tier
            //will require Ideology
        }

        public void activateTitleDesires()
        {
            //select as many royalty title-associated desires as possible for each desire tier
            //will require royalty
            //higher titles will probably raise the desire slots for each tier
        }

        public void activateGenericDesires()
        {
            //fill remaining desire slots for each desire tier with generic desires
        }
    }
}