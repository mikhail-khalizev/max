using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("37b3a21a-7665-4c7d-8d79-af9466355d63")]
        public void Method_100e_0878()
        {
            ii(0x100e_0878, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_087d, 5); calld(Definitions.sys_check_available_stack_size, 0x8_54d0); /* call 0x10165d52 */
            ii(0x100e_0882, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0883, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0884, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0885, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0886, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0887, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0889, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_088f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0892, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_0895, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_0899, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_089c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_089f, 6); add(edx, 0x1cf);                        /* add edx, 0x1cf */
            ii(0x100e_08a5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_08a7, 5); calld(0x1007_678c, -0x6_a120);          /* call 0x1007678c */
            ii(0x100e_08ac, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_08af, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_08b2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_08b4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_08b5, 1); popd(edi);                              /* pop edi */
            ii(0x100e_08b6, 1); popd(esi);                              /* pop esi */
            ii(0x100e_08b7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_08b8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_08b9, 1); retd(); return;                         /* ret */
        }
    }
}
