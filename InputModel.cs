using Microsoft.ML.Data;

namespace recommender
{
    public class InputModel
    {
        [LoadColumn(0)] public float UserId { get; set; }
        [LoadColumn(1)] public string ISBN { get; set; }
        [LoadColumn(2)] public float Rating { get; set; }
    }
}