namespace BlottEnDag
{

    public class QuestionAndAnswer
    {
        // These need to be properties for JsonSerializer to work
        public string Question { get; set; }
        public bool Answer { get; set; }
    }

}
