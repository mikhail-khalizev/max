using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c7337a02-47f7-488e-8442-28d40b417e12")]
        public void Method_0000_afec()
        {
        l_0xafec:
            ii(0xafec, 3);    mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0xafef, 3);    mov(bx, 0x5);                             /* mov bx, 0x5 */
            ii(0xaff2, 3);    callw(0x44e4, -0x6b11);                   /* call 0x44e4 */
            ii(0xaff5, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xaff7, 2);    if(jzw(0xb01a, 0x21)) goto l_0xb01a;      /* jz 0xb01a */
            ii(0xaff9, 5);    mov(es, memw_a16[ss, 0xaa]);              /* mov es, [ss:0xaa] */
            ii(0xaffe, 3);    mov(di, 0x4);                             /* mov di, 0x4 */
            ii(0xb001, 5);    mov(eax, memd_a16[es, di - 0x4]);         /* mov eax, [es:di-0x4] */
            ii(0xb006, 5);    mov(memd_a16[cs, 0x79f8], eax);           /* mov [cs:0x79f8], eax */
            ii(0xb00b, 3);    rep_a16(() => movsd_a16());               /* rep movsd */
            ii(0xb00e, 1);    pushw(ss);                                /* push ss */
            ii(0xb00f, 1);    popw(ds);                                 /* pop ds */
            ii(0xb010, 3);    mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0xb013, 3);    mov(bx, 0xb);                             /* mov bx, 0xb */
            ii(0xb016, 3);    callw(0x44e4, -0x6b35);                   /* call 0x44e4 */
            ii(0xb019, 1);    retw();                                   /* ret */
        l_0xb01a:
            ii(0xb01a, 5);    mov(memw_a16[cs, 0x79f6], cx);            /* mov [cs:0x79f6], cx */
            ii(0xb01f, 3);    shl(cx, 0x2);                             /* shl cx, 0x2 */
            ii(0xb022, 2);    add(cx, di);                              /* add cx, di */
            ii(0xb024, 4);    movzx(ecx, cx);                           /* movzx ecx, cx */
            ii(0xb028, 2);    mov(ax, es);                              /* mov ax, es */
            ii(0xb02a, 4);    movzx(eax, ax);                           /* movzx eax, ax */
            ii(0xb02e, 4);    shl(eax, 0x4);                            /* shl eax, 0x4 */
            ii(0xb032, 4);    movzx(edi, di);                           /* movzx edi, di */
            ii(0xb036, 3);    add(edi, eax);                            /* add edi, eax */
            ii(0xb039, 3);    add(ecx, eax);                            /* add ecx, eax */
            ii(0xb03c, 2);    pushd(ecx);                               /* push ecx */
            ii(0xb03e, 2);    pushd(edi);                               /* push edi */
            ii(0xb040, 3);    callw(0x3880, -0x77c3);                   /* call 0x3880 */
            ii(0xb043, 2);    pushw(0x38);                              /* push 0x38 */
            ii(0xb045, 1);    popw(es);                                 /* pop es */
            ii(0xb046, 2);    popd(edi);                                /* pop edi */
            ii(0xb048, 2);    popd(ebx);                                /* pop ebx */
        l_0xb04a:
            ii(0xb04a, 5);    callw_far_abs(0x70, 0x5750);              /* call word 0x70:0x5750 */
            ii(0xb04f, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb051, 2);    if(jzw(0xb065, 0x12)) goto l_0xb065;      /* jz 0xb065 */
        l_0xb053:
            ii(0xb053, 3);    cmp(edi, ebx);                            /* cmp edi, ebx */
            ii(0xb056, 2);    if(jbw(0xb04a, -0xe)) goto l_0xb04a;      /* jb 0xb04a */
            ii(0xb058, 2);    if(jzw(0xb065, 0xb)) goto l_0xb065;       /* jz 0xb065 */
            ii(0xb05a, 4);    sub(edi, 0x4);                            /* sub edi, 0x4 */
            ii(0xb05e, 5);    mov(memb_a32[es, edi], 0);                /* mov byte [es:edi], 0x0 */
            ii(0xb063, 2);    goto l_0xb053;                            /* jmp 0xb053 */
        l_0xb065:
            ii(0xb065, 1);    pushw(ax);                                /* push ax */
            ii(0xb066, 3);    callw(0x3f1c, -0x714d);                   /* call 0x3f1c */
            ii(0xb069, 1);    popw(ax);                                 /* pop ax */
            ii(0xb06a, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb06c, 4);    jzw_func(0xaf1b, -0x155);                 /* jz 0xaf1b */
            ii(0xb070, 5);    mov(cx, memw_a16[cs, 0x79f6]);            /* mov cx, [cs:0x79f6] */
            ii(0xb075, 3);    goto l_0xafec;                            /* jmp 0xafec */
        }
    }
}
