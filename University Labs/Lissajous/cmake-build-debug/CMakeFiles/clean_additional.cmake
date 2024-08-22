# Additional clean files
cmake_minimum_required(VERSION 3.16)

if("${CONFIG}" STREQUAL "" OR "${CONFIG}" STREQUAL "Debug")
  file(REMOVE_RECURSE
  "CMakeFiles/Lissajous_autogen.dir/AutogenUsed.txt"
  "CMakeFiles/Lissajous_autogen.dir/ParseCache.txt"
  "Lissajous_autogen"
  )
endif()
