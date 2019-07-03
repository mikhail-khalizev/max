## Process this file with automake to produce Makefile.in

ACLOCAL_AMFLAGS = -I m4 --install

libtool: $(LIBTOOL_DEPS)
	$(SHELL) ./config.status libtool


SUBDIRS = include/exo src test
EXTRA_DIST = doc

#po

#INTLTOOL_FILES = \
#	intltool-extract.in \
#	intltool-merge.in \
#	intltool-update.in

#EXTRA_DIST = $(INTLTOOL_FILES)

#DISTCLEANFILES = \
#	intltool-extract \
#	intltool-merge \
#	intltool-update \
#	po/.intltool-merge-cache


#pkginclude_HEADERS = export-config.h

#install-data-hook:
#	-cd $(DESTDIR)$(pkgincludedir) && mv export-config.h config.h

