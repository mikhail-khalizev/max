include(../../general.pri)

TEMPLATE = app
CONFIG += testcase

INCLUDEPATH += ../../src/ ../../src/module/http_server

SOURCES += \
    test_http_server.cpp
OBJECTS += ${shell cd $$OUT_PWD/../../src/ && ls *.o | grep -v main | sed -e \'s|\\(.*\\)|../../src/\\1|\'}
