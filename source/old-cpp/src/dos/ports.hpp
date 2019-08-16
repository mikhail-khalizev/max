#ifndef OPENMAX_DOS_PORTS_HPP_INCLUDED
#define OPENMAX_DOS_PORTS_HPP_INCLUDED

#include <exo/global.hpp>

namespace raw_program {
namespace dos {

void inb(uint_<8> &, uint_<16> port);

void outb(uint_<16> port, uint_<8>);
void outw(uint_<16> port, uint_<16>);
void outd(uint_<16> port, uint_<32>);


struct pal_struct
{
    uint_<8> rgb[3];
};

extern pal_struct pal[256];
/** Bit 6-7 indicates the number of lines on the display: 1:  400, 2: 350, 3: 480. */
extern uint_<8> vga_misc_output;

// +
enum class kbd_keys
{
    none = 0,

    esc = 1,
    _1 = 2,
    _2 = 3,
    _3 = 4,
    _4 = 5,
    _5 = 6,
    _6 = 7,
    _7 = 8,
    _8 = 9,
    _9 = 10,
    _0 = 11,
    period = 52,
    minus = 12,
    equals = 13,

    q = 16,
    w = 17,
    e = 18,
    r = 19,
    t = 20,
    y = 21,
    u = 22,
    i = 23,
    o = 24,
    p = 25,

    a = 30,
    s = 31,
    d = 32,
    f = 33,
    g = 34,
    h = 35,
    j = 36,
    k = 37,
    l = 38,

    z = 44,
    x = 45,
    c = 46,
    v = 47,
    b = 48,
    n = 49,
    m = 50,

    backspace = 14,
    tab = 15,
    leftbracket = 26,
    rightbracket = 27,
    enter = 28,

    leftalt = 56,
    leftctrl = 29,
    leftshift = 42,
    rightshift = 54,

    semicolon = 39,
    quote = 40,
    grave = 41,
    backslash = 43,
    comma = 51,
    slash = 53,
    space = 57,
    capslock = 58,
    numlock = 69,
    scrolllock = 70,

    f1 = 59,
    f2 = 60,
    f3 = 61,
    f4 = 62,
    f5 = 63,
    f6 = 64,
    f7 = 65,
    f8 = 66,
    f9 = 67,
    f10 = 68,
    f11 = 87,
    f12 = 88,

    kp0 = 82,
    kp1 = 79,
    kp2 = 80,
    kp3 = 81,
    kp4 = 75,
    kp5 = 76,
    kp6 = 77,
    kp7 = 71,
    kp8 = 72,
    kp9 = 73,

    kpminus = 74,
    kpplus = 78,
    kpmultiply = 55,
    kpperiod = 83,

    extra_lt_gt = 86,

/*
 * kpenter,
 * rightctrl,
 * kpdivide,
 * rightalt,
 * home,
 * up,
 * pageup,
 * left,
 * right,
 * end,
 * down,
 * pagedown,
 * insert,
 * delete,
 * pause,
 * printscreen
 */
};

extern kbd_keys key_pressed;

} /* namespace dos */
} /* namespace raw_program */

#endif /* OPENMAX_DOS_PORTS_HPP_INCLUDED */

