/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Provides information for filtering topic detection jobs. For more information, see
    /// .
    /// </summary>
    public partial class TopicsDetectionJobFilter
    {
        private string _jobName;
        private JobStatus _jobStatus;
        private DateTime? _submitTimeAfter;
        private DateTime? _submitTimeBefore;

        /// <summary>
        /// Gets and sets the property JobName.
        /// </summary>
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// Filters the list of topic detection jobs based on job status. Returns only jobs with
        /// the specified status.
        /// </para>
        /// </summary>
        public JobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTimeAfter. 
        /// <para>
        /// Filters the list of jobs based on the time that the job was submitted for processing.
        /// Only returns jobs submitted after the specified time. Jobs are returned in ascending
        /// order, oldest to newest.
        /// </para>
        /// </summary>
        public DateTime SubmitTimeAfter
        {
            get { return this._submitTimeAfter.GetValueOrDefault(); }
            set { this._submitTimeAfter = value; }
        }

        // Check to see if SubmitTimeAfter property is set
        internal bool IsSetSubmitTimeAfter()
        {
            return this._submitTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubmitTimeBefore. 
        /// <para>
        /// Filters the list of jobs based on the time that the job was submitted for processing.
        /// Only returns jobs submitted before the specified time. Jobs are returned in descending
        /// order, newest to oldest.
        /// </para>
        /// </summary>
        public DateTime SubmitTimeBefore
        {
            get { return this._submitTimeBefore.GetValueOrDefault(); }
            set { this._submitTimeBefore = value; }
        }

        // Check to see if SubmitTimeBefore property is set
        internal bool IsSetSubmitTimeBefore()
        {
            return this._submitTimeBefore.HasValue; 
        }

    }
}