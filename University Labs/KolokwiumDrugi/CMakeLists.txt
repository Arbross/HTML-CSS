cmake_minimum_required(VERSION 3.28)
project(KolokwiumDrugi_C__)

set(CMAKE_CXX_STANDARD 17)

add_executable(KolokwiumDrugi_C__ main.cpp
        stacjameteo.h
        stacjameteo.cpp
        stacjameteous.h
        stacjameteous.cpp)
