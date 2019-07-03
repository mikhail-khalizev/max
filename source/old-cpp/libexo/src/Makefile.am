## Process this file with automake to produce Makefile.in

# Here are a set of rules to help you update your library version information:
# 1. Start with version information of ‘0:0:0’ for each libtool library.
# 2. Update the version information only immediately before a public release of your soft
#    ware. More frequent updates are unnecessary, and only guarantee that the current
#    interface number gets larger faster.
# 3. If the library source code has changed at all since the last update, then increment
#    revision (‘c:r:a’ becomes ‘c:r + 1:a’).
# 4. If any interfaces have been added, removed, or changed since the last update, increment
#    current, and set revision to 0.
# 5. If any interfaces have been added since the last public release, then increment age.
# 6. If any interfaces have been removed or changed since the last public release, then set
#    age to 0.

LIB_LT_CURRENT = 0
LIB_LT_REVISION = 0
LIB_LT_AGE = 0



AM_CPPFLAGS = -I$(top_srcdir)/include -I$(top_builddir)/include -DEXO_DLL_EXPORTS

lib_LTLIBRARIES = libexo.la
libexo_la_LDFLAGS = -version-info $(LIB_LT_CURRENT):$(LIB_LT_REVISION):$(LIB_LT_AGE)
#libexo_la_LDFLAGS += -export-symbols $(srcdir)/libexo.sym
libexo_la_LDFLAGS += -lrt

#EXTRA_DIST = libexo.sym

libexo_la_SOURCES = \
	linux.cpp	\
	linux/io.cpp	\
	linux/time.cpp	\
	linux/time_internal.hpp	\
	linux/exception.cpp	\
	memory_space.cpp	\
	format_header/fat/boot_sector.cpp

IN_PROCESS = \
	memory_space_dyn.cpp
