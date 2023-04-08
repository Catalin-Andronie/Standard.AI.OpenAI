﻿// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

using System.Threading.Tasks;
using Standard.AI.OpenAI.Models.Services.Foundations.ExternalFiles;
using Standard.AI.OpenAI.Models.Services.Foundations.AIFiles;

namespace Standard.AI.OpenAI.Brokers.OpenAIs
{
    internal partial interface IOpenAIBroker
    {
        ValueTask<ExternalFile> DeleteFileByIdAsync(string fileId);
        ValueTask<ExternalFileResponse> PostFileFormAsync(
            ExternalFileRequest externalFileRequest);
    }
}