cmake_minimum_required(VERSION 3.28)
project(Mieszkanie)

set(CMAKE_CXX_STANDARD 17)

add_executable(Mieszkanie main.cpp
        mieszkanie_podstawowe.cpp
        mieszkanie_podstawowe.h
        tablica_ogloszen.cpp
        tablica_ogloszen.h)
