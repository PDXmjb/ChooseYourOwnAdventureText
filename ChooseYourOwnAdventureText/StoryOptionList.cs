using System;
using System.Collections.Generic;

namespace ChooseYourOwnAdventureText
{
    public class StoryOptionList
    {
        public string Id { get; private set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public List<StoryOption> Options { get; private set; }

        public StoryOptionList(string id, List<StoryOption> options)
        {
            Id = id;
            Options = options;
        }
    }
}