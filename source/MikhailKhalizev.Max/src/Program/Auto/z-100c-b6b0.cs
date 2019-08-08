using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cb6322d2-1907-4553-8b46-7f06ef7299df")]
        public void Method_100c_b6b0()
        {
            ii(0x100c_b6b0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b6b5, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a698); /* call 0x10165d52 */
            ii(0x100c_b6ba, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b6bb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b6bc, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b6bd, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b6be, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b6bf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b6c1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b6c7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b6ca, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b6cd, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_b6d1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_b6d4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_b6d7, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x100c_b6da, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_b6dc, 5); calld(0x1007_678c, -0x5_4f55);          /* call 0x1007678c */
            ii(0x100c_b6e1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b6e4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_b6e7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b6e9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b6ea, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b6eb, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b6ec, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b6ed, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b6ee, 1); retd(); return;                         /* ret */
        }
    }
}
