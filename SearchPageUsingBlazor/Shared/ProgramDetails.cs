using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPageUsingBlazor.Shared
{
    public class VideoDetails
    {
        public string ProgramType { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public int Year { get; set; }
        //public string[] Cast { get; set; }
        //public string[] Producers { get; set; }
        //public string[] Directors { get; set; }
        //public string Description { get; set; }


    }

    public class ProgramSource
    {
        public string ProgramType { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public int year { get; set; }
    }

    public class ProgramHit
    {
        public ProgramSource Source { get; set; }
        //public float Score { get; set; }
        //public string Id { get; set; }
    }

    public class ProgramSearchResult
    {
        //public int Took { get; set; }
        public ProgramHit[] Hits { get; set; }
    }

    //public class UIResponseDTo
    //{
    //    public string ProgramType { get; set; }
    //    public string Title { get; set; }
    //}

    //var progresult = await Http.GetFromJsonAsync<ProgramSearchResult>("https://ee.iva-api.com/api/Entertainment/Search/?Title=ABC&token=sdfsdfd");

    //List<UIResponseDTo> arr = new List<UIResponseDTo>();
    //foreach(var hit from progresult.Hits){
    //    var res = new UIResponseDTo
    //    {
    //        ProgramType = hit.Source.ProgramType,
    //        Title = hit.Source.Title
    //    };
    //     arr.Add(res);
    //}

    //return this arr to UI;
}
