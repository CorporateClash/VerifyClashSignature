using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyClashSignature
{
	class Program
	{
		static void Main(string[] args)
		{
			// Let's assume they didn't care about surrounding the argument in quotations, or even if they did.
			var fullargs = String.Join(" ", args).Replace("\"", "");
			if (AuthenticodeTools.IsTrusted(fullargs) && AuthenticodeTools.IsSignedByAltis(fullargs))
			{
				Environment.Exit(0);
			}
			Environment.Exit(1);
		}
	}
}
