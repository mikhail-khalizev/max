FUNC_BEGIN(sys_round, 0x91d2e9eaeafcb002, 0x20, ({0x50, 0x9b, 0xd9, 0x3c, 0x24, 0x9b, 0xff, 0x34, 0x24, 0xc6, 0x44, 0x24, 0x1, 0x1f, 0xd9, 0x2c, 0x24, 0xd9, 0xfc, 0xd9, 0x6c, 0x24, 0x4, 0x9b, 0x8d, 0x64, 0x24, 0x8, 0xc3}))
    II(0x1016607e, 0x1)   pushd(eax);                           /* push eax */
    II(0x1016607f, 0x1)   wait();                               /* wait */
    II(0x10166080, 0x3)   fnstcw(memw_a32(ss, esp));            /* fnstcw word [esp] */
    II(0x10166083, 0x1)   wait();                               /* wait */
    II(0x10166084, 0x3)   pushd(memd_a32(ss, esp));             /* push dword [esp] */
    II(0x10166087, 0x5)   mov(memb_a32(ss, esp + 0x1), 0x1f);   /* mov byte [esp+0x1], 0x1f */
    II(0x1016608c, 0x3)   fldcw(memw_a32(ss, esp));             /* fldcw word [esp] */
    II(0x1016608f, 0x2)   frndint();                            /* frndint */
    II(0x10166091, 0x4)   fldcw(memw_a32(ss, esp + 0x4));       /* fldcw word [esp+0x4] */
    II(0x10166095, 0x1)   wait();                               /* wait */
    II(0x10166096, 0x4)   lea(esp, esp + 0x8);                  /* lea esp, [esp+0x8] */
    II(0x1016609a, 0x1)   retd();                               /* ret */
FUNC_END

