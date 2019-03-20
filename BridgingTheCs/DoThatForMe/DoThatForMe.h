#ifndef _DO_THAT_FOR_ME_DLL_H_
#define _DO_THAT_FOR_ME_DLL_H_

#if defined DLL_EXPORT
#define DECLDIR __declspec(dllexport)
#else
#define DECLDIR __declspec(dllimport)
#endif

extern "C" {
	DECLDIR bool Exists();
}

#endif
