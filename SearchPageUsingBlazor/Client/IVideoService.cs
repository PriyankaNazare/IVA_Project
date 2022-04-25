using SearchPageUsingBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace SearchPageUsingBlazor.Client
{
    public interface IVideoService
    {
        Task<IEnumerable<VideoDetails>> GetDetails();
    }
}
