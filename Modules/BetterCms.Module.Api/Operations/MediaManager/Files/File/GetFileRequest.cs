﻿using System.Runtime.Serialization;

using ServiceStack.ServiceHost;

namespace BetterCms.Module.Api.Operations.MediaManager.Files.File
{
    [Route("/files/{FileId}", Verbs = "GET")]
    [DataContract]
    public class GetFileRequest : RequestBase<GetFileModel>, IReturn<GetFileResponse>
    {
    }
}