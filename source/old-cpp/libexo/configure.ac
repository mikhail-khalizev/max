# Обработайте этот файл программой 'autoconf' для создания скрипта 'configure'.

AC_PREREQ([2.68])
AC_INIT([exo], [0.1], [micky53@mail.ru], [libexo])

AC_CONFIG_SRCDIR([include/exo/memory_space.hpp])
AC_CONFIG_HEADERS([config.h])
AC_CONFIG_AUX_DIR([build])
AC_CONFIG_MACRO_DIR([m4])
AC_LANG([C++])

AM_INIT_AUTOMAKE([1.11 -Wall -Werror subdir-objects color-tests dist-xz no-dist-gzip parallel-tests foreign])
AM_SILENT_RULES([yes])

dnl this allows us specify individual liking flags for each target
AM_PROG_CC_C_O


# Internationalization

# IT_PROG_INTLTOOL([0.35.0])

## AM_GNU_GETTEXT_VERSION([0.17])
## AM_GNU_GETTEXT([external])

# GETTEXT_PACKAGE=elfview
# AC_SUBST(GETTEXT_PACKAGE)
# AC_DEFINE_UNQUOTED(GETTEXT_PACKAGE, ["$GETTEXT_PACKAGE"], [GETTEXT package name])
# AM_GLIB_GNU_GETTEXT


# Initialize libtool

LT_PREREQ(2.4)
LT_INIT([disable-static])
AC_SUBST([LIBTOOL_DEPS])

# По умолчанию - visibility default.
#lt_prog_compiler_pic_CXX="$lt_prog_compiler_pic_CXX  -fvisibility=hidden -fvisibility-inlines-hidden  -DEXO_DLL"
lt_prog_compiler_pic_CXX="$lt_prog_compiler_pic_CXX  -fvisibility-inlines-hidden  -DEXO_DLL"


# --- Проверка программ. --- #

# AC_PROG_CXX - Уже вызвана в LT_INIT
PKG_PROG_PKG_CONFIG


# Флаги компилятора.

CXXFLAGS_NEW=$CXXFLAGS

AS_IF([test "$GXX" = "yes"], [
    CXXFLAGS_NEW="$CXXFLAGS_NEW \
    -std=c++11 \
    -fnon-call-exceptions -fno-strict-aliasing \
    -Wall -Wextra -Weffc++ \
    -Winit-self -Wmissing-declarations -Wpointer-arith -Wconversion -Wsign-conversion -Wsign-compare -Woverloaded-virtual -Wcast-qual -Wcast-align \
    -Werror=non-virtual-dtor -Werror=return-type -Werror=uninitialized -Werror=old-style-cast -Werror=logical-op"
])


# --- Проверка библиотек. --- #

#AC_SEARCH_LIBS([dlopen], [dl])


# --- Проверка заголовочных файлов. --- #

# AC_CHECK_HEADERS_ONCE([features.h sys/cdefs.h])

# AC_CHECK_HEADERS_ONCE([fcntl.h stddef.h stdlib.h string.h sys/file.h
#    sys/ioctl.h sys/socket.h sys/time.h unistd.h iconv.h])


# --- Проверка определений типов, структур и характеристик компилятора. --- #

EXO_CHECK_TYPE([__int128])
EXO_CHECK_TYPE([__float80])
EXO_CHECK_TYPE([__float128])

EXO_CHECK_SIZEOF([dev_t])
EXO_CHECK_SIZEOF([ino_t])
EXO_CHECK_SIZEOF([mode_t])
EXO_CHECK_SIZEOF([nlink_t])
EXO_CHECK_SIZEOF([uid_t])
EXO_CHECK_SIZEOF([gid_t])
EXO_CHECK_SIZEOF([off_t])
#EXO_CHECK_SIZEOF([blksize_t])
#EXO_CHECK_SIZEOF([blkcnt_t])

EXO_CHECK_SIZEOF([clockid_t])


MULE_CHECK_EXCEPTIONS
MULE_CHECK_CXXABI

#AC_CHECK_DECLS_ONCE([__FUNCTION__, __PRETTY_FUNCTION__])


# --- Проверка библиотечных функций. --- #

#AC_FUNC_STRNLEN  dnl Должна вызываться ранее, чем AC_CHECK_HEADERS.
#AS_IF([test "$ac_cv_func_strnlen_working" = yes],
#    [AC_DEFINE(HAVE_STRNLEN, 1, [Define to 1 if you have a working strnlen function.])])

# AC_FUNC_FORK
# AC_FUNC_MMAP
# AC_FUNC_MALLOC
# AC_FUNC_REALLOC
# AC_FUNC_MEMCMP
# AC_CHECK_FUNCS([memmove munmap strerror dlsym])


# --- Создание выходных файлов. --- #

CXXFLAGS=$CXXFLAGS_NEW

AC_CONFIG_FILES([
Makefile
src/Makefile
test/Makefile
include/exo/Makefile
include/exo/linux/types.hpp
include/exo/math/cxx_types_int.hpp
include/exo/math/cxx_types_float.hpp
])

# po/Makefile.in

AC_OUTPUT

