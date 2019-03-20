#include "DoThatForMe.h"

void Spatial::Rectangle::SetPosition(float x, float y) {
    this->x = x;
    this->y = y;
}

void Spatial::Rectangle::SetDimensions(float width, float height) {
    this->width = width;
    this->height = height;
}

bool Spatial::Rectangle::PointIsInside(float x, float y) {
    return (x > this->x
            && x < this->x + this->width
            && y > this->y
            && y < this->y + this->height);
}