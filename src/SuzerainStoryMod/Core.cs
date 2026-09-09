using MelonLoader;
using SuzerainModdingKit;

[assembly: MelonInfo(typeof(SuzerainStoryMod.Core), "Suzerain Story Mod", "0.1.0", "AmazighOasisAzul", null)]
[assembly: MelonGame("Torpor Games", "Suzerain")]

namespace SuzerainStoryMod;

internal sealed class Core : MelonMod
{
    public override void OnInitializeMelon()
    {
        Events.OnEvaluateStep += OnEvaluateStep;
        Events.OnDecisionShow += OnDecisionShow;
        Events.OnDecisionFinished += OnDecisionFinished;

        CivicListeningTourDecision.Init();
        LoggerInstance.Msg("Suzerain Story Mod initialized.");
    }

    private static void OnEvaluateStep(object sender, EventArgs e) => CivicListeningTourDecision.OnEvaluateStep();

    private static void OnDecisionShow(object sender, EventArgs e) => CivicListeningTourDecision.OnDecisionShow();

    private static void OnDecisionFinished(object sender, Events.DecisionFinishedEventArgs e) =>
        CivicListeningTourDecision.OnDecisionFinished(e.SelectedOptionInfo);
}
