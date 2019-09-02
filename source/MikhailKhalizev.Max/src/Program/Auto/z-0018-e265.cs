using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e265-97394712")]
        public void Method_0018_e265()
        {
            ii(0x18_e265, 3); call(0x18_e070, -0x1f8);                  /* call 0xe070 */
            ii(0x18_e268, 4); if(jb_func(0x18_e2b3, 0x47)) return;      /* jb 0xe2b3 */
            ii(0x18_e26c, 2); if(jcxz_func(0x18_e2b3, 0x45)) return;    /* jcxz 0xe2b3 */
            ii(0x18_e26e, 2); push(0x20);                               /* push 0x20 */
            ii(0x18_e270, 1); pop(es);                                  /* pop es */
            ii(0x18_e271, 6); cmp(memb[es, 0x2f], 3);                   /* cmp byte [es:0x2f], 0x3 */
            ii(0x18_e277, 2); if(jb(0x18_e2aa, 0x31)) goto l_0x18_e2aa; /* jb 0xe2aa */
            ii(0x18_e279, 2); push(eax);                                /* push eax */
            ii(0x18_e27b, 4); mov(ax, memw_a32[ss, ebp + 0x1c]);        /* mov ax, [ebp+0x1c] */
            ii(0x18_e27f, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x18_e281, 4); shl(eax, 0x10);                           /* shl eax, 0x10 */
            ii(0x18_e285, 4); mov(ax, memw_a32[ss, ebp + 0x18]);        /* mov ax, [ebp+0x18] */
            ii(0x18_e289, 3); mov(dl, memb[ds, bx + 6]);                /* mov dl, [bx+0x6] */
            ii(0x18_e28c, 3); and(dl, 0x70);                            /* and dl, 0x70 */
            ii(0x18_e28f, 4); test(cx, 0xfff0);                         /* test cx, 0xfff0 */
            ii(0x18_e293, 2); if(jz(0x18_e29c, 7)) goto l_0x18_e29c;    /* jz 0xe29c */
            ii(0x18_e295, 4); shr(eax, 0xc);                            /* shr eax, 0xc */
            ii(0x18_e299, 3); or(dl, 0x80);                             /* or dl, 0x80 */
        l_0x18_e29c:
            ii(0x18_e29c, 2); mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x18_e29e, 4); shr(eax, 0x10);                           /* shr eax, 0x10 */
            ii(0x18_e2a2, 2); or(al, dl);                               /* or al, dl */
            ii(0x18_e2a4, 3); mov(memb[ds, bx + 6], al);                /* mov [bx+0x6], al */
            ii(0x18_e2a7, 3); if(jmp_func(0x18_e067, -0x243)) return;   /* jmp 0xe067 */
        l_0x18_e2aa:
            ii(0x18_e2aa, 4); mov(ax, memw_a32[ss, ebp + 0x18]);        /* mov ax, [ebp+0x18] */
            ii(0x18_e2ae, 2); mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x18_e2b0, 3); if(jmp_func(0x18_e067, -0x24c)) return;   /* jmp 0xe067 */
        }
    }
}
