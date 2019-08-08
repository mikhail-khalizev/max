using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a8960279-14c8-4363-b5c3-93c0942bc8c5")]
        public void Method_100c_b63c()
        {
            ii(0x100c_b63c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_b641, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a70c); /* call 0x10165d52 */
            ii(0x100c_b646, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b647, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b648, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b649, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b64a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b64c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b652, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b655, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b658, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100c_b65b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_b65e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_b662, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_b665, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100c_b668, 6); add(ebx, 0x17c);                        /* add ebx, 0x17c */
            ii(0x100c_b66e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_b670, 5); calld(0x100c_b77c, 0x107);              /* call 0x100cb77c */
            ii(0x100c_b675, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b677, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b678, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b679, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b67a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b67b, 1); retd(); return;                         /* ret */
        }
    }
}
