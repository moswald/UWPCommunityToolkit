﻿// ******************************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
//
// ******************************************************************
using Newtonsoft.Json;

namespace Microsoft.Windows.Toolkit.Services.Twitter
{
    /// <summary>
    /// Twitter Timeline item.
    /// </summary>
    public class TwitterTimelineItem
    {
        /// <summary>
        /// Gets or sets time item was created.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets item Id.
        /// </summary>
        [JsonProperty("id_str")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets text of the status.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets user who posted the status.
        /// </summary>
        [JsonProperty("user")]
        public TwitterUser User { get; set; }
    }
}