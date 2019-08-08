using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("77f66ca1-c6c3-4c47-9080-9946d51d63cc")]
        public void /* sys */ Method_1019_44f0()
        {
            ii(0x1019_44f0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_44f1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_44f3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_44f4, 3); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1019_44f7, 5); mov(ecx, 0x601);                        /* mov ecx, 0x601 */
            ii(0x1019_44fc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_44fe, 4); mov(memw_a32[ss, ebp - 0xc], bx);       /* mov [ebp-0xc], bx */
            ii(0x1019_4502, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1019_4505, 4); mov(memw_a32[ss, ebp - 0x18], dx);      /* mov [ebp-0x18], dx */
            ii(0x1019_4509, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x1019_450d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_450f, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1019_4512, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1019_4515, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1019_4518, 4); mov(memw_a32[ss, ebp - 0x10], ax);      /* mov [ebp-0x10], ax */
            ii(0x1019_451c, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1019_4521, 4); mov(memw_a32[ss, ebp - 0x20], cx);      /* mov [ebp-0x20], cx */
            ii(0x1019_4525, 5); calld(/* sys */ 0x1016_c606, -0x2_7f24); /* call 0x1016c606 */
            ii(0x1019_452a, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1019_452e, 3); setz(al);                               /* setz al */
            ii(0x1019_4531, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1019_4536, 3); lea(esp, ebp - 0x4);                    /* lea esp, [ebp-0x4] */
            ii(0x1019_4539, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_453a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_453b, 1); retd(); return;                         /* ret */
        }
    }
}
