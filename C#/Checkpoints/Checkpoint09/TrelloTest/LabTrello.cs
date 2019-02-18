using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TrelloTest
{
    [TestClass]
    public class LabTrello
    {
        [TestMethod]
        public void get_all_boards()
        {
            var ts = new TrelloService();
            List<TrelloBoard> result = ts.GetAllBoards().Result;
        }

        [TestMethod]
        public void get_all_lists_for_a_specific_board()
        {
            var ts = new TrelloService();
            List<TrelloList> result = ts.GetAllListsForBoard("5c179294823ef289ed9e6153").Result;
        }

        [TestMethod]
        public void add_a_post_to_a_specific_list()
        {
            var ts = new TrelloService();
            ts.CreateAcardOnAlist("5c179294823ef289ed9e6154", "en post", "beskrivning").Wait;
        }
    }
}
