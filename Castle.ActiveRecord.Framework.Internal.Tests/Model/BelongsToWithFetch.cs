using System;
using System.Collections.Generic;
using System.Text;

namespace Castle.ActiveRecord.Framework.Internal.Tests.Model
{
	class BelongsToWithFetch
	{
	}
}

// Copyright 2004-2011 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.ActiveRecord.Framework.Internal.Tests.Model
{
	using System;

	[ActiveRecord(Lazy = false)]
	public class BelongsToClassAFetch : ActiveRecordBase
	{
		private int id;
		private ClassA classA;

		[PrimaryKey]
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		[BelongsTo("classa_id", Fetch=FetchEnum.Join)]
		public ClassA ClassA
		{
			get { return classA; }
			set { classA = value; }
		}
	}
}
