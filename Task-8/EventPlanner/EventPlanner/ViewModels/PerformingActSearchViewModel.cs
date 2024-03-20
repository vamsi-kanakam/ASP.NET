using EventPlanner.Models;

namespace EventPlanner.ViewModels
{
    public class PerformingActSearchViewModel
    {
        public PerformingAct PerformingAct {  get; set; }
        public string SearchError { get; set; }
        public List<PerformingAct> ResultList { get; set; }

        public PerformingActSearchViewModel()
        {
            ResultList = new List<PerformingAct> ();
        }
    }
}
