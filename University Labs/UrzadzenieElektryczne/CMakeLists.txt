cmake_minimum_required(VERSION 3.27)
project(UrzadzenieElektryczne)

set(CMAKE_CXX_STANDARD 17)

add_executable(UrzadzenieElektryczne main.cpp
        urzadzenie_elektryczne.cpp
        urzadzenie_elektryczne.h
        tv.cpp
        tv.h)
