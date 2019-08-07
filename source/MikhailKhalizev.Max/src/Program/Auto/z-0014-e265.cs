using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3d404ac3-fd3b-4154-99f1-7bc5990d7700")]
        public void Method_0014_e265()
        {
            ii(0x14_e265, 3); callw(0x14_e070, -0x1f8);                 /* call 0xe070 */
            ii(0x14_e268, 4); if(jbw(0x14_e2b3, 0x47)) goto l_0x14_e2b3; /* jb 0xe2b3 */
            ii(0x14_e26c, 2); if(jcxzw(0x14_e2b3, 0x45)) goto l_0x14_e2b3; /* jcxz 0xe2b3 */
            ii(0x14_e26e, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x14_e270, 1); popw(es);                                 /* pop es */
            ii(0x14_e271, 6); cmp(memb_a16[es, 0x2f], 0x3);             /* cmp byte [es:0x2f], 0x3 */
            ii(0x14_e277, 2); if(jbw(0x14_e2aa, 0x31)) goto l_0x14_e2aa; /* jb 0xe2aa */
            ii(0x14_e279, 2); pushd(eax);                               /* push eax */
            ii(0x14_e27b, 4); mov(ax, memw_a32[ss, ebp + 0x1c]);        /* mov ax, [ebp+0x1c] */
            ii(0x14_e27f, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x14_e281, 4); shl(eax, 0x10);                           /* shl eax, 0x10 */
            ii(0x14_e285, 4); mov(ax, memw_a32[ss, ebp + 0x18]);        /* mov ax, [ebp+0x18] */
            ii(0x14_e289, 3); mov(dl, memb_a16[ds, bx + 0x6]);          /* mov dl, [bx+0x6] */
            ii(0x14_e28c, 3); and(dl, 0x70);                            /* and dl, 0x70 */
            ii(0x14_e28f, 4); test(cx, 0xfff0);                         /* test cx, 0xfff0 */
            ii(0x14_e293, 2); if(jzw(0x14_e29c, 0x7)) goto l_0x14_e29c; /* jz 0xe29c */
            ii(0x14_e295, 4); shr(eax, 0xc);                            /* shr eax, 0xc */
            ii(0x14_e299, 3); or(dl, 0x80);                             /* or dl, 0x80 */
        l_0x14_e29c:
            ii(0x14_e29c, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x14_e29e, 4); shr(eax, 0x10);                           /* shr eax, 0x10 */
            ii(0x14_e2a2, 2); or(al, dl);                               /* or al, dl */
            ii(0x14_e2a4, 3); mov(memb_a16[ds, bx + 0x6], al);          /* mov [bx+0x6], al */
            ii(0x14_e2a7, 3); jmpw_func(0x14_e067, -0x243); return;     /* jmp 0xe067 */
        l_0x14_e2aa:
            ii(0x14_e2aa, 4); mov(ax, memw_a32[ss, ebp + 0x18]);        /* mov ax, [ebp+0x18] */
            ii(0x14_e2ae, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x14_e2b0, 3); jmpw_func(0x14_e067, -0x24c); return;     /* jmp 0xe067 */
        l_0x14_e2b3:
            ii(0x14_e2b3, 3); jmpw_func(0x14_e062, -0x254); return;     /* jmp 0xe062 */
        }
    }
}
