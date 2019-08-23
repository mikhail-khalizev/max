using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_a0cd-9409c6f6")]
        public void Method_100b_a0cd()
        {
            ii(0x100b_a0cd, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_a0d2, 5); calld(Definitions.sys_check_available_stack_size, 0xa_bc7b); /* call 0x10165d52 */
            ii(0x100b_a0d7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_a0d8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_a0d9, 1); pushd(edx);                             /* push edx */
            ii(0x100b_a0da, 1); pushd(esi);                             /* push esi */
            ii(0x100b_a0db, 1); pushd(edi);                             /* push edi */
            ii(0x100b_a0dc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_a0dd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_a0df, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_a0e5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_a0e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a0eb, 3); add(eax, 0x29);                         /* add eax, 0x29 */
            ii(0x100b_a0ee, 5); calld(0x1013_a794, 0x8_06a1);           /* call 0x1013a794 */
            ii(0x100b_a0f3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a0f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a0f8, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100b_a0fb, 5); calld(0x1013_a794, 0x8_0694);           /* call 0x1013a794 */
            ii(0x100b_a100, 3); sub(edx, 0xa);                          /* sub edx, 0xa */
            ii(0x100b_a103, 3); lea(ebx, edx + eax);                    /* lea ebx, [edx+eax] */
            ii(0x100b_a106, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100b_a10c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_a10f, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100b_a114, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_a117, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100b_a11a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_a11d, 3); sub(ebx, 0xa);                          /* sub ebx, 0xa */
            ii(0x100b_a120, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100b_a122, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100b_a125, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_a128, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_a12a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_a12b, 1); popd(edi);                              /* pop edi */
            ii(0x100b_a12c, 1); popd(esi);                              /* pop esi */
            ii(0x100b_a12d, 1); popd(edx);                              /* pop edx */
            ii(0x100b_a12e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_a12f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_a130, 1); retd();                                 /* ret */
        }
    }
}
