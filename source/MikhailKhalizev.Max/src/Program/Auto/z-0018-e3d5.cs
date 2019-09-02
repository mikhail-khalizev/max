using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e3d5-85fac53c")]
        public void Method_0018_e3d5()
        {
            ii(0x18_e3d5, 4); mov(al, memb_a32[ss, ebp + 20]);          /* mov al, [ebp+0x14] */
            ii(0x18_e3d9, 2); xor(ah, ah);                              /* xor ah, ah */
            ii(0x18_e3db, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x18_e3dd, 2); cmp(al, 0x10);                            /* cmp al, 0x10 */
            ii(0x18_e3df, 2); if(jbe(0x18_e3fb, 0x1a)) goto l_0x18_e3fb; /* jbe 0xe3fb */
            ii(0x18_e3e1, 2); push(0x10);                               /* push 0x10 */
            ii(0x18_e3e3, 1); pop(ds);                                  /* pop ds */
            ii(0x18_e3e4, 3); shl(si, 3);                               /* shl si, 0x3 */
            ii(0x18_e3e7, 1); lodsw();                                  /* lodsw */
            ii(0x18_e3e8, 4); mov(memw_a32[ss, ebp + 24], ax);          /* mov [ebp+0x18], ax */
            ii(0x18_e3ec, 3); mov(ax, memw[ds, si + 4]);                /* mov ax, [si+0x4] */
            ii(0x18_e3ef, 4); mov(memw_a32[ss, ebp + 26], ax);          /* mov [ebp+0x1a], ax */
            ii(0x18_e3f3, 1); lodsw();                                  /* lodsw */
            ii(0x18_e3f4, 4); mov(memw_a32[ss, ebp + 28], ax);          /* mov [ebp+0x1c], ax */
            ii(0x18_e3f8, 3); if(jmp_func(0x18_e067, -0x394)) return;   /* jmp 0xe067 */
        l_0x18_e3fb:
            ii(0x18_e3fb, 3); call(0x18_e868, 0x46a);                   /* call 0xe868 */
            ii(0x18_e3fe, 3); imul(si, si, 0x1c);                       /* imul si, si, 0x1c */
            ii(0x18_e401, 5); mov(eax, memd[ds, si + 16959]);           /* mov eax, [si+0x423f] */
            ii(0x18_e406, 5); mov(memd_a32[ss, ebp + 24], eax);         /* mov [ebp+0x18], eax */
            ii(0x18_e40b, 4); mov(ax, memw[ds, si + 16963]);            /* mov ax, [si+0x4243] */
            ii(0x18_e40f, 4); mov(memw_a32[ss, ebp + 28], ax);          /* mov [ebp+0x1c], ax */
            ii(0x18_e413, 3); if(jmp_func(0x18_e067, -0x3af)) return;   /* jmp 0xe067 */
        }
    }
}
