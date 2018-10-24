using System;
using System.Collections.Generic;

namespace BetterChoiceShared.Domain
{
	public class ListingDifferentModels
	{
		public ListingModelType ModelType { get; set; }

		public IList<string> ListingModels { get; set; }
	}
}
