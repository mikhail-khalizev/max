FUNC_BEGIN(/* sys */ 0x1016c5f6, 0x7c0c224f2e9d47c1, 0x20, ({0xdd, 0x44, 0x24, 0xc, 0xdd, 0x44, 0x24, 0x4, 0xe8, 0x9d, 0xfe, 0xff, 0xff, 0xc2, 0x10, 0}))
    II(0x1016c5f6, 0x4)   fld(memq_a32(ss, esp + 0xc));         /* fld qword [esp+0xc] */
    II(0x1016c5fa, 0x4)   fld(memq_a32(ss, esp + 0x4));         /* fld qword [esp+0x4] */
    II(0x1016c5fe, 0x5)   calld(/* sys */ 0x1016c4a0, -0x163);  /* call 0x1016c4a0 */
    II(0x1016c603, 0x3)   retd(0x10);                           /* ret 0x10 */
FUNC_END

