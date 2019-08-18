using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9f96afcb-0877-48ea-bc70-8a9870eb77d8")]
        public void Method_100a_c0cb()
        {
            ii(0x100a_c0cb, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_c0d0, 5); calld(Definitions.sys_check_available_stack_size, 0xb_9c7d); /* call 0x10165d52 */
            ii(0x100a_c0d5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_c0d6, 1); pushd(esi);                             /* push esi */
            ii(0x100a_c0d7, 1); pushd(edi);                             /* push edi */
            ii(0x100a_c0d8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_c0d9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_c0db, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_c0e1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_c0e4, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_c0e7, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_c0ea, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100a_c0ef, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_c0f2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_c0f5, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_c0f8, 5); calld(0x1007_5e64, -0x3_6299);          /* call 0x10075e64 */
            ii(0x100a_c0fd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_c0ff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c102, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_c105, 5); calld(0x100b_7e44, 0xbd3a);             /* call 0x100b7e44 */
            ii(0x100a_c10a, 5); calld(0x100a_bbb8, -0x557);             /* call 0x100abbb8 */
            ii(0x100a_c10f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_c111, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c114, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_c117, 5); calld(0x100b_7ea0, 0xbd84);             /* call 0x100b7ea0 */
            ii(0x100a_c11c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_c11e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c121, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_c124, 5); calld(0x1007_6630, -0x3_5af9);          /* call 0x10076630 */
            ii(0x100a_c129, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_c12b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_c12c, 1); popd(edi);                              /* pop edi */
            ii(0x100a_c12d, 1); popd(esi);                              /* pop esi */
            ii(0x100a_c12e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_c12f, 1); retd(); return;                         /* ret */
        }
    }
}
