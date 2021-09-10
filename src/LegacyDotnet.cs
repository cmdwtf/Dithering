/*
 * Copyright © 2021 Chris Marc Dailey (nitz)
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */


#if !NET5_0_OR_GREATER
// see https://stackoverflow.com/a/64749403
namespace System.Runtime.CompilerServices
{
	internal static class IsExternalInit { }
}
#endif // !NET_5_0_OR_GREATER
