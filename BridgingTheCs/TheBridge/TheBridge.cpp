#define DLL_EXPORT

#include "TheBridge.h"

DECLDIR bool Exists()
{
    return true;
}

DECLDIR Spatial::Rectangle* ConstructorRectangle() {
    return new Spatial::Rectangle();
}

DECLDIR void DestructorRectangle(Spatial::Rectangle* rectangle) {
    if (rectangle != nullptr) {
        delete rectangle;
        rectangle = nullptr;
    }
}

DECLDIR void SetPosition(Spatial::Rectangle* rectangle, float x, float y) {
    rectangle->SetPosition(x, y);
}

DECLDIR void SetDimensions(Spatial::Rectangle* rectangle, float width, float height) {
    rectangle->SetDimensions(width, height);
}

DECLDIR bool PointIsInside(Spatial::Rectangle* rectangle, float x, float y) {
    return rectangle->PointIsInside(x, y);
}