using SuzerainModdingKit;
using SuzerainModdingKit.StoryFragments.Decision;
using SuzerainModdingKit.VanillaData;

namespace SuzerainStoryMod;

/// <summary>
/// A minimal, isolated story fragment used to prove the project's SMK integration.
/// Text currently uses the English source catalog; SMK localization integration has not yet been documented.
/// </summary>
internal static class CivicListeningTourDecision
{
    internal const string ApproveVariable = "SuzerainStoryMod.CivicListeningTour_Approved";
    internal const string DeferVariable = "SuzerainStoryMod.CivicListeningTour_Deferred";

    private const string ApproveOption = "Authorize a nationwide listening tour.";
    private const string DeferOption = "Defer the proposal for now.";

    internal static readonly CustomDecisionFragment Data = new(
        name: "SuzerainStoryMod.CivicListeningTour",
        storyPack: SuzerainStoryPackInfo.Sordland,
        assignedTokenName: SuzerainTokenName.SordlandCityHolsord,
        title: "A Civic Listening Tour",
        description: "Your advisers propose a tour of the republic to hear concerns before the next policy agenda is set.",
        hubTitle: "A Civic Listening Tour",
        hubDescription: "Should the administration begin a listening tour?");

    internal static void Init()
    {
        Variables.Register(ApproveVariable);
        Variables.Register(DeferVariable);
    }

    internal static void OnEvaluateStep()
    {
        // SMK documents Sordland turn 1, step 2 as the first safe step for custom story fragments.
        if (!GameState.IsCurrentStoryPack(SuzerainStoryPackInfo.Sordland) ||
            GameState.CurrentTurnNum != 1 ||
            GameState.CurrentStepNum != 2 ||
            GameState.StoryFragmentExistsInCurrentStep(Data.Name) ||
            Variables.GetBool(ApproveVariable) ||
            Variables.GetBool(DeferVariable))
        {
            return;
        }

        _ = GameState.AddCustomStoryFragment(Data);
    }

    internal static void OnDecisionShow()
    {
        if (!Data.Name.Equals(DecisionManager.CurrentDecisionName, StringComparison.Ordinal))
        {
            return;
        }

        DecisionManager.AddOption(ApproveOption);
        DecisionManager.AddOption(DeferOption);
    }

    internal static void OnDecisionFinished(DecisionOptionInfo selectedOption)
    {
        if (!Data.Name.Equals(selectedOption.DecisionName, StringComparison.Ordinal))
        {
            return;
        }

        Variables.Set(ApproveVariable, ApproveOption.Equals(selectedOption.Text, StringComparison.Ordinal));
        Variables.Set(DeferVariable, DeferOption.Equals(selectedOption.Text, StringComparison.Ordinal));
    }
}
