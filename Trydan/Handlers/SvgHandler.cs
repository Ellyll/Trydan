using System;
using System.Web;

namespace Trydan.Handlers
{
	public class SvgHandler : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "image/svg+xml";

			byte[] fileData = System.IO.File.ReadAllBytes(context.Request.PhysicalPath);
			context.Response.BinaryWrite(fileData);
		}
		
		public bool IsReusable
		{
			get
			{
				return false;
			}
		}
	}
}
