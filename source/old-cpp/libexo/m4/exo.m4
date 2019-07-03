AC_DEFUN([EXO_CHECK_SIZEOF],
[
	AC_CHECK_SIZEOF([$1])

	changequote(<<, >>)dnl
	dnl The name to #define.
	define(<<AC_TYPE_NAME>>, translit(sizeof_$1, [a-z *], [A-Z_P]))dnl
	dnl The cache variable name.
	define(<<AC_CV_NAME>>, translit(ac_cv_sizeof_$1, [ *], [_p]))dnl
	changequote([, ])dnl

	AC_SUBST(AC_TYPE_NAME, $AC_CV_NAME)

	undefine([AC_CV_NAME])dnl
	undefine([AC_TYPE_NAME])dnl
])

AC_DEFUN([EXO_CHECK_TYPE],
[
	AC_CHECK_TYPES([$1])

	changequote(<<, >>)dnl
	dnl The name to #define.
	define(<<AC_TYPE_NAME>>, translit(have_$1, [a-z *], [A-Z_P]))dnl
	dnl The cache variable name.
	changequote([, ])dnl

	AS_IF([test "x$ac_cv_type___int128" = xyes],
		[AC_SUBST(AC_TYPE_NAME, 1)],
		[AC_SUBST(AC_TYPE_NAME, 0)])

	undefine([AC_TYPE_NAME])dnl
])



dnl ----------------------------------------------------
dnl MULE_CHECK_EXCEPTIONS
dnl Checks for broken exception-handling. This is needed
dnl because exception handling is broken for some archs/
dnl compilers.
dnl ----------------------------------------------------
AC_DEFUN([MULE_CHECK_EXCEPTIONS],
[
	AC_LANG_ASSERT([C++])
	AC_MSG_CHECKING([for exception-handling])
	AC_RUN_IFELSE([
		AC_LANG_PROGRAM(,
		[[
			try {
				throw 1;
			} catch (int) {
				return 0;
			}
			return 1;
		]])
	], [
		AC_MSG_RESULT([yes])
	], [
		AC_MSG_RESULT([no])
		AC_MSG_ERROR([Exception handling does not work. Broken compiler?])
	], [
		AC_MSG_RESULT([undeterminable])
		AC_MSG_WARN(
			[Cross-compilation detected, so exception handling cannot be tested.
			Note that broken exception handling in your compiler may lead to unexpected crashes.])
	])
])


dnl ---------------------------------------------------------------------------
dnl MULE_CHECK_CXXABI
dnl
dnl This function will test the header <cxxabi.h> and abi::__cxa_demangle()
dnl ---------------------------------------------------------------------------
AC_DEFUN([MULE_CHECK_CXXABI],
[
	AC_LANG_ASSERT([C++])
	AC_MSG_CHECKING([for <cxxabi.h> and __cxa_demangle()])
	AC_LINK_IFELSE([
		AC_LANG_PROGRAM([[
			#include <cxxabi.h>
		]], [[
			int status;
			char * demangled = abi::__cxa_demangle("", 0, 0, &status);
			std::type_info *ti = abi::__cxa_current_exception_type();
		]])
	], [
		AC_DEFINE([HAVE_CXXABI], 1, [Define to 1 if you have the <cxxabi.h> header which declares abi::__cxa_demangle()])
		AC_MSG_RESULT([yes])
	], [
		AC_MSG_RESULT([no])
	])
])

dnl ---------------------------------------------------------------------------
dnl MULE_CHECK_EXECINFO
dnl
dnl This function will test the header <execinfo.h> and backtrace()
dnl ---------------------------------------------------------------------------
AC_DEFUN([MULE_CHECK_EXECINFO],
[
	AC_MSG_CHECKING([for <execinfo.h> and backtrace()])
	AC_LINK_IFELSE([
		AC_LANG_PROGRAM([[
			#include <execinfo.h>
		]], [[
			void * bt[1];
			int n = backtrace(&bt, 1);
			const char ** bt_syms = backtrace_symbols(bt, n);
		]])
	], [
		AC_DEFINE([HAVE_EXECINFO], 1, [Define to 1 if you have the <execinfo.h> header which declares backtrace()])
		AC_MSG_RESULT([yes])
	], [
		AC_MSG_RESULT([no])
	])
])

dnl ----------------------------------------------------
dnl MULE_CHECK_BFD
dnl check if bfd.h is on the system and usable
dnl ----------------------------------------------------
AC_DEFUN([MULE_CHECK_BFD],
[AC_REQUIRE([MULE_CHECK_NLS])dnl

	AC_MSG_CHECKING([for bfd])
	result=no
	for bfd_ldadd in "" "${LIBINTL}" "-ldl" "-ldl ${LIBINTL}"; do
		MULE_BACKUP([LIBS])
		MULE_BACKUP([LDFLAGS])
		MULE_PREPEND([LIBS], [-lbfd -liberty ${bfd_ldadd} ${ZLIB_LIBS}])
		MULE_APPEND([LDFLAGS], [${ZLIB_LDFLAGS}])
		AC_LINK_IFELSE([
			AC_LANG_PROGRAM([[
				#include <ansidecl.h>
				#include <bfd.h>
			]], [[
				char *dummy = bfd_errmsg(bfd_get_error());
			]])
		], [
			result=yes
			BFD_CPPFLAGS="-DHAVE_BFD"
			BFD_LIBS="-lbfd -liberty ${bfd_ldadd}"
			MULE_RESTORE([LIBS])
			MULE_RESTORE([LDFLAGS])
			break
		])
		MULE_RESTORE([LIBS])
		MULE_RESTORE([LDFLAGS])
	done

	AC_MSG_RESULT([$result])

	AS_IF([test "x$result" = xno],
		[MULE_WARNING([bfd.h not found or unusable, please install binutils development package if you are a developer or want to help testing aMule])])

AC_SUBST([BFD_CPPFLAGS])dnl
AC_SUBST([BFD_LIBS])dnl
])


