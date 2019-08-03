using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b903e5f6-dead-48c3-abb7-1f6330f3769b")]
        public void /* sys */ Method_1019_44a0()
        {
            ii(0x1019_44a0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_44a1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_44a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_44a4, 3); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1019_44a7, 5); mov(ecx, 0x600);                        /* mov ecx, 0x600 */
            ii(0x1019_44ac, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_44ae, 4); mov(memw_a32[ss, ebp - 0xc], bx);       /* mov [ebp-0xc], bx */
            ii(0x1019_44b2, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1019_44b5, 4); mov(memw_a32[ss, ebp - 0x18], dx);      /* mov [ebp-0x18], dx */
            ii(0x1019_44b9, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x1019_44bd, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_44bf, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1019_44c2, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1019_44c5, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1019_44c8, 4); mov(memw_a32[ss, ebp - 0x10], ax);      /* mov [ebp-0x10], ax */
            ii(0x1019_44cc, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1019_44d1, 4); mov(memw_a32[ss, ebp - 0x20], cx);      /* mov [ebp-0x20], cx */
            ii(0x1019_44d5, 5); calld(/* sys */ 0x1016_c606, -0x27ed4); /* call 0x1016c606 */
            ii(0x1019_44da, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1019_44de, 3); setz(al);                               /* setz al */
            ii(0x1019_44e1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1019_44e6, 3); lea(esp, ebp - 0x4);                    /* lea esp, [ebp-0x4] */
            ii(0x1019_44e9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_44ea, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_44eb, 1); retd(); return;                         /* ret */
        }
    }
}