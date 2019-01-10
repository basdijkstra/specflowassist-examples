using TechTalk.SpecFlow.Assist.Attributes;

namespace SpecFlowAssistExamples.DataEntities
{
    public class Album
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }

        [TableAliases("AlbumLength")]
        public int LengthInMinutes { get; set; }

        public string RecordLabel { get; set; }
    }
}
