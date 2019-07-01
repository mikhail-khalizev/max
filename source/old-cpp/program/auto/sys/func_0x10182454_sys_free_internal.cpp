FUNC_BEGIN(sys_free_internal, 0x5e77d28d86302df4, 0x20, ({0xff, 0x15, 0x20, 0xe8, 0x1b, 0x10, 0xc3}))
    II(0x10182454, 0x6)   calld_abs(memd_a32(ds, 0x101be820));  /* call dword near [0x101be820] */ /* Вызов 'sys_free_with_check_memory_corrupt'. */
    II(0x1018245a, 0x1)   retd();                               /* ret */
FUNC_END

