namespace SorcererCoderNet.Models
{
    public class Challenge
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Difficulty { get; set; }
        public string Language { get; set; }
        // Additional properties as needed

        // To represent topics covered by Challenge
        public IList<string> TopicTags { get; set; }


        // To indicate which companies have
        // presented a challenge during an interview
        public IList<string> CompanyTags { get; set; }
    }


    public interface IChallenge
    {
        Challenge Get(int id);
        IEnumerable<Challenge> GetAll();
        Challenge Add(Challenge challenge);

        // other functionality Update and Delete
    }

    public class ChallengeRepository : IChallenge
    {
        private List<Challenge> challenges = new List<Challenge>();
        public ChallengeRepository()
        {
            challenges.Add(new Challenge()
            {
                Id = 1,
                Title = "Sort an Array",
                Description = "Given a size of an integer array and its elements. Sort array in ascending order.",
                CompanyTags = ["Amazon", "Google"],
                Difficulty = "Easy",
                Language = "C++",
                TopicTags = ["Array", "Sorting"]
            });
            challenges.Add(new Challenge()
            {
                Id = 2,
                Title = "Binary Search",
                Description = "Given a size of an integer array and its elements and one value. Use binary search to find this value in array.",
                CompanyTags = ["Microsoft", "Google"],
                Difficulty = "Easy",
                Language = "C++",
                TopicTags = ["Array", "Binary Search"]
            });
        }

        public Challenge Get(int id)
        {
            return this.challenges.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Challenge> GetAll() { 
            return this.challenges; 
        }

        public Challenge Add(Challenge challenge) { 
            this.challenges.Add (challenge);
            return challenge;
        }
    }
}
