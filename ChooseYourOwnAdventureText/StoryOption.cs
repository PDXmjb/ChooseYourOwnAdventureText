using System.Collections.Generic;

namespace ChooseYourOwnAdventureText
{
    public class StoryOption
    {
        public int Id { get; set; }
        public string OptionText { get; set; }
        public int LinkedStoryOptionId { get; set; }
    }
}