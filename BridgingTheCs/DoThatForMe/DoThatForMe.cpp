#include "DoThatForMe.h"

void Spatial::Rectangle::SetPosition(float x, float y) {
    this->_x = x;
    this->_y = y;
}

void Spatial::Rectangle::SetDimensions(float width, float height) {
    this->_width = width;
    this->_height = height;
}

bool Spatial::Rectangle::PointIsInside(float x, float y) {
    return (x > this->_x
            && x < this->_x + this->_width
            && y > this->_y
            && y < this->_y + this->_height);
}