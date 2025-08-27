// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LevelingOrder.cs">
//   Copyright (c) 2025 Aspose.Tasks for Cloud
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

namespace Aspose.Tasks.Cloud.Sdk.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Defines the possible values of leveling order.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LevelingOrder
    {
        /// <summary>
        /// The following properties are taken into account: predecessor relationships, total 
        /// slack (a task with higher total slack is delayed first), start date, priority.
        /// This is the default value.
        /// </summary>
        Standard = 1,

        /// <summary>
        /// Tasks are delayed in Id ascending order.
        /// </summary>
        IdOnly = 2,

        /// <summary>
        /// The priority is considered first, then the same properties as in Standard.
        /// </summary>
        PriorityThenStandard = 3
    }
}