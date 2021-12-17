using System.Runtime.Serialization;

namespace Pip.Services.SampleFacade.Operations.Version1
{
	[DataContract]
	public class SessionSiteV1: ISessionSite
	{
		[DataMember(Name = "id")]
		public string Id { get; set; }
		[DataMember(Name = "name")]
		public string Name { get; set; }
	}
}
