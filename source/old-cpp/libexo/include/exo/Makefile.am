## Process this file with automake to produce Makefile.in

EXTRA_DIST = \
	math/cxx_types_int.hpp.in	\
	math/cxx_types_float.hpp.in	\
	linux/types.hpp.in	\
	linux/.internal


nobase_nodist_pkginclude_HEADERS = \
	math/cxx_types_int.hpp	\
	math/cxx_types_float.hpp	\
	linux/types.hpp	\
	linux/enums.hpp


BUILT_SOURCES = \
	linux/enums.hpp

CLEANFILES = \
	linux/enums.hpp

linux/enums.hpp:  Makefile linux/.internal/enums_hdr.hpp linux/.internal/enums_body.hpp
# @todo Сделать более универсально.
	echo '#ifdef EXO_LINUX_ENUMS_HPP_REQUIRE' > $@
	$(CXXCPP) -C -include $(srcdir)/linux/.internal/enums_hdr.hpp $(srcdir)/linux/.internal/enums_body.hpp | tail -n `wc -l < $(srcdir)/linux/.internal/enums_body.hpp` >> $@
	echo '#endif /* EXO_LINUX_ENUMS_HPP_REQUIRE */' >> $@


nobase_pkginclude_HEADERS = \
	abstract_base.hpp	\
	abstract_int.hpp	\
	attributes.hpp	\
	global.hpp	\
	exception.hpp	\
	memory_space.hpp	\
	process.hpp	\
	format_header/elf.hpp	\
	format_header/exe.hpp	\
	format_header/fat.hpp	\
	format_header/fat/fat.hpp	\
	format_header/fat/boot_sector.hpp	\
	format_header/fat/directory_entry.hpp	\
	format_header/fat/fat_item.hpp	\
	format_header/fat/types.hpp	\
	format_header/wav.hpp	\
	format_worker/fat.hpp	\
	containers/integrety/list_double_item.hpp	\
	linux.hpp	\
	linux/enums.hpp	\
	linux/exception.hpp	\
	linux/io.hpp	\
	linux/time.hpp	\
	linux/types.hpp	\
	math/tags.hpp	\
	math/std_types.hpp	\
	math/only_last_set.hpp	\
	math/round.hpp	\
	math/detail/int_double.hpp	\
	math/detail/int_single_class.hpp	\
	math/detail/int_single_bop.hpp	\
	util/auto_increment.hpp	\
	util/count_of.hpp	\
	util/delegate.hpp	\
	util/flags.hpp	\
	util/identificator.hpp	\
	util/implicit_cast.hpp	\
	util/used_space.hpp	\
	util/value_of_pointer_iterator.hpp	\
	util/type_helper.hpp	\
	syntax/base.hpp	\
	syntax/general.hpp	\
	syntax/string.hpp	\
	syntax/repeat.hpp	\
	syntax/sequence.hpp	\
	syntax/alternative.hpp	\
	syntax/ignore.hpp	\
	syntax/c99/syntax.hpp

IN_PROCESS = \
	math/safe.hpp	\
	math/safe_s.hpp	\
	math/safe_u.hpp	\
	math/sqrt.hpp	\
	memory_space_dyn.hpp	\
	math/only_last_set.hpp

