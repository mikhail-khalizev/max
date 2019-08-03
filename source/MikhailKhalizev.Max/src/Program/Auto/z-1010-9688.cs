using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("61df382e-41a4-4965-920e-0b493e7b3848")]
        public void Method_1010_9688()
        {
            ii(0x1010_9688, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_968d, 5); calld(Definitions.sys_check_available_stack_size, 0x5c6c0); /* call 0x10165d52 */
            ii(0x1010_9692, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_9693, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_9694, 1); pushd(edx);                             /* push edx */
            ii(0x1010_9695, 1); pushd(esi);                             /* push esi */
            ii(0x1010_9696, 1); pushd(edi);                             /* push edi */
            ii(0x1010_9697, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_9698, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_969a, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_96a0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_96a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_96a6, 1); pushd(eax);                             /* push eax */
            ii(0x1010_96a7, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_96a9, 5); mov(ebx, 0xad);                         /* mov ebx, 0xad */
            ii(0x1010_96ae, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1010_96b3, 5); mov(eax, 0x22f);                        /* mov eax, 0x22f */
            ii(0x1010_96b8, 5); calld(0x100e_8ef1, -0x207cc);           /* call 0x100e8ef1 */
            ii(0x1010_96bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_96c0, 1); pushd(eax);                             /* push eax */
            ii(0x1010_96c1, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_96c3, 5); mov(ebx, 0xad);                         /* mov ebx, 0xad */
            ii(0x1010_96c8, 5); mov(edx, 0xa6);                         /* mov edx, 0xa6 */
            ii(0x1010_96cd, 5); mov(eax, 0x230);                        /* mov eax, 0x230 */
            ii(0x1010_96d2, 5); calld(0x100e_8ef1, -0x207e6);           /* call 0x100e8ef1 */
            ii(0x1010_96d7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_96d9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_96da, 1); popd(edi);                              /* pop edi */
            ii(0x1010_96db, 1); popd(esi);                              /* pop esi */
            ii(0x1010_96dc, 1); popd(edx);                              /* pop edx */
            ii(0x1010_96dd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_96de, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_96df, 1); retd(); return;                         /* ret */
        }
    }
}