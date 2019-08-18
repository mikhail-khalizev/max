using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("79f5c1bb-1f61-4153-9b1c-f74e717f63d0")]
        public void Method_0018_e3d5()
        {
            ii(0x18_e3d5, 4); mov(al, memb_a32[ss, ebp + 0x14]);        /* mov al, [ebp+0x14] */
            ii(0x18_e3d9, 2); xor(ah, ah);                              /* xor ah, ah */
            ii(0x18_e3db, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x18_e3dd, 2); cmp(al, 0x10);                            /* cmp al, 0x10 */
            ii(0x18_e3df, 2); if(jbew(0x18_e3fb, 0x1a)) goto l_0x18_e3fb; /* jbe 0xe3fb */
            ii(0x18_e3e1, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x18_e3e3, 1); popw(ds);                                 /* pop ds */
            ii(0x18_e3e4, 3); shl(si, 0x3);                             /* shl si, 0x3 */
            ii(0x18_e3e7, 1); lodsw_a16();                              /* lodsw */
            ii(0x18_e3e8, 4); mov(memw_a32[ss, ebp + 0x18], ax);        /* mov [ebp+0x18], ax */
            ii(0x18_e3ec, 3); mov(ax, memw_a16[ds, si + 0x4]);          /* mov ax, [si+0x4] */
            ii(0x18_e3ef, 4); mov(memw_a32[ss, ebp + 0x1a], ax);        /* mov [ebp+0x1a], ax */
            ii(0x18_e3f3, 1); lodsw_a16();                              /* lodsw */
            ii(0x18_e3f4, 4); mov(memw_a32[ss, ebp + 0x1c], ax);        /* mov [ebp+0x1c], ax */
            ii(0x18_e3f8, 3); if(jmpw_func(0x18_e067, -0x394)) return;  /* jmp 0xe067 */
        l_0x18_e3fb:
            ii(0x18_e3fb, 3); callw(0x18_e868, 0x46a);                  /* call 0xe868 */
            ii(0x18_e3fe, 3); imul(si, si, 0x1c);                       /* imul si, si, 0x1c */
            ii(0x18_e401, 5); mov(eax, memd_a16[ds, si + 0x423f]);      /* mov eax, [si+0x423f] */
            ii(0x18_e406, 5); mov(memd_a32[ss, ebp + 0x18], eax);       /* mov [ebp+0x18], eax */
            ii(0x18_e40b, 4); mov(ax, memw_a16[ds, si + 0x4243]);       /* mov ax, [si+0x4243] */
            ii(0x18_e40f, 4); mov(memw_a32[ss, ebp + 0x1c], ax);        /* mov [ebp+0x1c], ax */
            ii(0x18_e413, 3); if(jmpw_func(0x18_e067, -0x3af)) return;  /* jmp 0xe067 */
        }
    }
}
