#ifndef _THE_BRIDGE_H_
#define _THE_BRIDGE_H_

#include "..\DoThatForMe\DoThatForMe.h"

#if defined DLL_EXPORT
#define DECLDIR __declspec(dllexport)
#else
#define DECLDIR __declspec(dllimport)
#endif

extern "C" {
    DECLDIR bool Exists();

    DECLDIR Spatial::Rectangle* ConstructorRectangle();
}

#endif