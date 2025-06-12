using RimWorld;
using Verse;

namespace Vomit_Pills
{
    public class IngestionOutcomeDoer_Vomit : IngestionOutcomeDoer
    {
        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested, int ingestedCount)
        {
            pawn.jobs.StopAll();
            pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit));
        }
    }
}
