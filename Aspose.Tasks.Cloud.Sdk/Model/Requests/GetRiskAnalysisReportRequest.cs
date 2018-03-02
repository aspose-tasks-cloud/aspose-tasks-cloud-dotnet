// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetRiskAnalysisReportRequest.cs">
//   Copyright (c) 2018 Aspose.Tasks for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Aspose.Tasks.Cloud.Sdk.Model.Requests 
{
    using System;
    using System.Collections.Generic;

    using Aspose.Tasks.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="Aspose.Tasks.Cloud.Sdk.Api.TasksApi.GetRiskAnalysisReport" /> operation.
    /// </summary>  
    public class GetRiskAnalysisReportRequest  
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRiskAnalysisReportRequest"/> class.
        /// </summary>        
        public GetRiskAnalysisReportRequest()
        {
        }


        /// <summary>
        /// The name of the file.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The uid of the task for which this risk will be applied in Monte Carlo simulation.
        /// </summary>  
        public int? TaskUid { get; set; }

        /// <summary>
        /// Gets or sets the probability distribution used in Monte Carlo simulation. The default value is ProbabilityDistributionType.Normal.
        /// </summary>  
        public ProbabilityDistributionType DistributionType { get; set; }

        /// <summary>
        /// The percentage of the most likely task duration which can happen in the best possible project scenario. The default value is 75, which means that if the estimated specified task duration is 4 days then the optimistic duration will be 3 days.
        /// </summary>  
        public int? Optimistic { get; set; }

        /// <summary>
        /// The percentage of the most likely task duration which can happen in the worst possible project scenario. The default value is 125, which means that if the estimated specified task duration is 4 days then the pessimistic duration will be 5 days.
        /// </summary>  
        public int? Pessimistic { get; set; }

        /// <summary>
        /// Gets or sets the confidence level that correspond to the percentage of the time the actual generated values will be within optimistic and pessimistic estimates. The default value is CL99.
        /// </summary>  
        public ConfidenceLevel ConfidenceLevel { get; set; }

        /// <summary>
        /// The number of iterations to use in Monte Carlo simulation. The default value is 100.
        /// </summary>  
        public int? Iterations { get; set; }

        /// <summary>
        /// The document storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// The folder storage.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// The resulting report fileName.
        /// </summary>  
        public string FileName { get; set; }
    }
}
