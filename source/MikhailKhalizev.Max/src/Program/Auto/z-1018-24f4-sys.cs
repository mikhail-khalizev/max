using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4aa86abb-2ffc-4568-8385-a770eb063b1b")]
        public void /* sys */ Method_1018_24f4()
        {
            ii(0x1018_24f4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_24f5, 3); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1018_24f8, 5); mov(ecx, 0x600);                        /* mov ecx, 0x600 */
            ii(0x1018_24fd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_24ff, 5); mov(memw_a32[ss, esp + 0x30], bx);      /* mov [esp+0x30], bx */
            ii(0x1018_2504, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1018_2507, 5); mov(memw_a32[ss, esp + 0x24], dx);      /* mov [esp+0x24], dx */
            ii(0x1018_250c, 5); mov(memw_a32[ss, esp + 0x20], ax);      /* mov [esp+0x20], ax */
            ii(0x1018_2511, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_2513, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_2515, 4); mov(memd_a32[ss, esp + 0x18], edx);     /* mov [esp+0x18], edx */
            ii(0x1018_2519, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1018_251b, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1018_251e, 4); lea(edx, esp + 0x1c);                   /* lea edx, [esp+0x1c] */
            ii(0x1018_2522, 5); mov(memw_a32[ss, esp + 0x2c], ax);      /* mov [esp+0x2c], ax */
            ii(0x1018_2527, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1018_252c, 5); mov(memw_a32[ss, esp + 0x1c], cx);      /* mov [esp+0x1c], cx */
            ii(0x1018_2531, 5); calld(/* sys */ 0x1016_c606, -0x15f30); /* call 0x1016c606 */
            ii(0x1018_2536, 5); cmp(memd_a32[ss, esp + 0x18], 0);       /* cmp dword [esp+0x18], 0x0 */
            ii(0x1018_253b, 3); setz(al);                               /* setz al */
            ii(0x1018_253e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_2543, 1); dec(eax);                               /* dec eax */
            ii(0x1018_2544, 3); add(esp, 0x38);                         /* add esp, 0x38 */
            ii(0x1018_2547, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_2548, 1); retd(); return;                         /* ret */
        }
    }
}
