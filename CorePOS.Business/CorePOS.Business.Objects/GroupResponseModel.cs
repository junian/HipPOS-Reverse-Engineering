using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CorePOS.Business.Objects;

public class GroupResponseModel : StatusCodeResponse
{
	[CompilerGenerated]
	private List<GroupsPostDataModel> list_0;

	public List<GroupsPostDataModel> groupResponseList
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
		[CompilerGenerated]
		set
		{
			list_0 = value;
		}
	}

	public GroupResponseModel()
	{
		Class2.oOsq41PzvTVMr();
		// base._002Ector();
	}
}
