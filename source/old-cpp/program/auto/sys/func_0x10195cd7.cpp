FUNC_BEGIN(/* sys */ 0x10195cd7, 0xa16fb441025, 0x20, ({0x8b, 0x4, 0x24}))
    II(0x10195cd7, 0x3)   mov(eax, memd_a32(ss, esp));          /* mov eax, [esp] */
    II(0x10195cda, 0)     jmpd_func(/* sys */ 0x10195cda, 0);   /* Принудительное завершение функции. */
FUNC_END

