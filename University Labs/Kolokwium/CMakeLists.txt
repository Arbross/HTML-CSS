cmake_minimum_required(VERSION 3.27)
project(Kolokwium)

set(CMAKE_CXX_STANDARD 17)

add_executable(Kolokwium main.cpp
        drukarka.cpp
        drukarka.h
        drukarkakolorowa.cpp
        drukarkakolorowa.h)
