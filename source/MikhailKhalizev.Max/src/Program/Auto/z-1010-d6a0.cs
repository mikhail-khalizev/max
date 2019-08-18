using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8f06ce15-bffd-47b3-a6e0-4457e20ed257")]
        public void Method_1010_d6a0()
        {
            ii(0x1010_d6a0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_d6a5, 5); calld(Definitions.sys_check_available_stack_size, 0x5_86a8); /* call 0x10165d52 */
            ii(0x1010_d6aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_d6ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_d6ac, 1); pushd(edx);                             /* push edx */
            ii(0x1010_d6ad, 1); pushd(esi);                             /* push esi */
            ii(0x1010_d6ae, 1); pushd(edi);                             /* push edi */
            ii(0x1010_d6af, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_d6b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_d6b2, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_d6b8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_d6bb, 5); calld(/* sys */ 0x1016_5e9b, 0x5_87db); /* call 0x10165e9b */
            ii(0x1010_d6c0, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1010_d6c3, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1010_d6c6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_d6c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d6cb, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
            ii(0x1010_d6cf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d6d2, 7); mov(memd_a32[ds, eax + 0x4], 0x1);      /* mov dword [eax+0x4], 0x1 */
            ii(0x1010_d6d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_d6db, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_d6dc, 1); popd(edi);                              /* pop edi */
            ii(0x1010_d6dd, 1); popd(esi);                              /* pop esi */
            ii(0x1010_d6de, 1); popd(edx);                              /* pop edx */
            ii(0x1010_d6df, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_d6e0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_d6e1, 1); retd(); return;                         /* ret */
        }
    }
}
