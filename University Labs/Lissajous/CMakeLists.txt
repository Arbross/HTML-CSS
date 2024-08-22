cmake_minimum_required(VERSION 3.28)
project(Lissajous)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_AUTOMOC ON)
set(CMAKE_AUTORCC ON)
set(CMAKE_AUTOUIC ON)

set(CMAKE_PREFIX_PATH "/Users/admin/Qt/6.7.0/macos/lib/cmake/Qt6")

find_package(Qt6 COMPONENTS
        Core
        Gui
        Widgets
        REQUIRED)

add_executable(Lissajous main.cpp
        sterowanie.cpp
        sterowanie.h
        Model.cpp
        Model.h
        Wyswietanie.cpp
        Wyswietanie.h)
target_link_libraries(Lissajous
        Qt6::Core
        Qt6::Gui
        Qt6::Widgets
)
