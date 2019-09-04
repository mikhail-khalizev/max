using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xafec-6cc40240")]
        public void Method_0000_afec()
        {
        l_0xafec:
            ii(0xafec, 3);    mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0xafef, 3);    mov(bx, 5);                               /* mov bx, 0x5 */
            ii(0xaff2, 3);    call(0x44e4, -0x6b11);                    /* call 0x44e4 */
            ii(0xaff5, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xaff7, 2);    if(jz(0xb01a, 0x21)) goto l_0xb01a;       /* jz 0xb01a */
            ii(0xaff9, 5);    mov(es, memw[ss, 0xaa]);                  /* mov es, [ss:0xaa] */
            ii(0xaffe, 3);    mov(di, 4);                               /* mov di, 0x4 */
            ii(0xb001, 5);    mov(eax, memd[es, di - 4]);               /* mov eax, [es:di-0x4] */
            ii(0xb006, 5);    mov(memd[cs, 0x79f8], eax);               /* mov [cs:0x79f8], eax */
            ii(0xb00b, 3);    rep(() => movsd());                       /* rep movsd */
            ii(0xb00e, 1);    push(ss);                                 /* push ss */
            ii(0xb00f, 1);    pop(ds);                                  /* pop ds */
            ii(0xb010, 3);    mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0xb013, 3);    mov(bx, 0xb);                             /* mov bx, 0xb */
            ii(0xb016, 3);    call(0x44e4, -0x6b35);                    /* call 0x44e4 */
            ii(0xb019, 1);    ret(); return;                            /* ret */
        l_0xb01a:
            ii(0xb01a, 5);    mov(memw[cs, 0x79f6], cx);                /* mov [cs:0x79f6], cx */
            ii(0xb01f, 3);    shl(cx, 2);                               /* shl cx, 0x2 */
            ii(0xb022, 2);    add(cx, di);                              /* add cx, di */
            ii(0xb024, 4);    movzx(ecx, cx);                           /* movzx ecx, cx */
            ii(0xb028, 2);    mov(ax, es);                              /* mov ax, es */
            ii(0xb02a, 4);    movzx(eax, ax);                           /* movzx eax, ax */
            ii(0xb02e, 4);    shl(eax, 4);                              /* shl eax, 0x4 */
            ii(0xb032, 4);    movzx(edi, di);                           /* movzx edi, di */
            ii(0xb036, 3);    add(edi, eax);                            /* add edi, eax */
            ii(0xb039, 3);    add(ecx, eax);                            /* add ecx, eax */
            ii(0xb03c, 2);    push(ecx);                                /* push ecx */
            ii(0xb03e, 2);    push(edi);                                /* push edi */
            ii(0xb040, 3);    call(0x3880, -0x77c3);                    /* call 0x3880 */
            ii(0xb043, 2);    push(0x38);                               /* push 0x38 */
            ii(0xb045, 1);    pop(es);                                  /* pop es */
            ii(0xb046, 2);    pop(edi);                                 /* pop edi */
            ii(0xb048, 2);    pop(ebx);                                 /* pop ebx */
        l_0xb04a:
            ii(0xb04a, 5);    call_far_abs(0x70, 0x5750);               /* call word 0x70:0x5750 */
            ii(0xb04f, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb051, 2);    if(jz(0xb065, 0x12)) goto l_0xb065;       /* jz 0xb065 */
        l_0xb053:
            ii(0xb053, 3);    cmp(edi, ebx);                            /* cmp edi, ebx */
            ii(0xb056, 2);    if(jb(0xb04a, -0xe)) goto l_0xb04a;       /* jb 0xb04a */
            ii(0xb058, 2);    if(jz(0xb065, 0xb)) goto l_0xb065;        /* jz 0xb065 */
            ii(0xb05a, 4);    sub(edi, 4);                              /* sub edi, 0x4 */
            ii(0xb05e, 5);    mov(memb_a32[es, edi], 0);                /* mov byte [es:edi], 0x0 */
            ii(0xb063, 2);    jmp(0xb053, -0x12); goto l_0xb053;        /* jmp 0xb053 */
        l_0xb065:
            ii(0xb065, 1);    push(ax);                                 /* push ax */
            ii(0xb066, 3);    call(0x3f1c, -0x714d);                    /* call 0x3f1c */
            ii(0xb069, 1);    pop(ax);                                  /* pop ax */
            ii(0xb06a, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb06c, 4);    if(jz_func(0xaf1b, -0x155)) return;       /* jz 0xaf1b */
            ii(0xb070, 5);    mov(cx, memw[cs, 0x79f6]);                /* mov cx, [cs:0x79f6] */
            ii(0xb075, 3);    jmp(0xafec, -0x8c); goto l_0xafec;        /* jmp 0xafec */
        }
    }
}
