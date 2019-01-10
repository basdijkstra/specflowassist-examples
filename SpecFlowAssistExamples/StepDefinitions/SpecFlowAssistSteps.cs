using SpecFlowAssistExamples.DataEntities;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowAssistExamples.StepDefinitions
{
    [Binding]
    public class SpecFlowAssistSteps
    {
        private Album myAlbum;
        private IEnumerable<Album> albumCollection;

        [Given(@"the following album exists")]
        public void GivenTheFollowingAlbumExists(Table table)
        {
            myAlbum = table.CreateInstance<Album>();
        }

        [Given(@"the following album collection exists")]
        public void GivenTheFollowingAlbumCollectionExists(Table table)
        {
            albumCollection = table.CreateSet<Album>();
        }
        
        [When(@"the album is rereleased")]
        public void WhenTheAlbumIsRereleased()
        {
            myAlbum.ReleaseYear = DateTime.Now.Year;
        }

        [When(@"all albums in the collection are rereleased")]
        public void WhenAllAlbumsInTheCollectionAreRereleased()
        {
            foreach (Album album in albumCollection)
            {
                album.ReleaseYear = DateTime.Now.Year;
            }
        }
        
        [Then(@"the new album details should be")]
        public void ThenTheNewAlbumDetailsShouldBe(Table table)
        {
            table.CompareToInstance(myAlbum);
        }

        [Then(@"the updated album collection should equal")]
        public void ThenTheUpdatedAlbumCollectionShouldEqual(Table table)
        {
            table.CompareToSet(albumCollection);
        }
    }
}
