using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("63afa522-e50f-45f9-b9b6-b2617f890748")]
        public void Method_1012_5d1f()
        {
            ii(0x1012_5d1f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_5d24, 5); calld(Definitions.sys_check_available_stack_size, 0x4_0029); /* call 0x10165d52 */
            ii(0x1012_5d29, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_5d2a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_5d2b, 1); pushd(edx);                             /* push edx */
            ii(0x1012_5d2c, 1); pushd(esi);                             /* push esi */
            ii(0x1012_5d2d, 1); pushd(edi);                             /* push edi */
            ii(0x1012_5d2e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_5d2f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_5d31, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_5d37, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_5d39, 5); mov(al, memb_a32[ds, 0x101c_59c8]);     /* mov al, [0x101c59c8] */
            ii(0x1012_5d3e, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_5d41, 2); if(jnzd(0x1012_5d52, 0xf)) goto l_0x1012_5d52; /* jnz 0x10125d52 */
            ii(0x1012_5d43, 5); mov(eax, 0x101c_59f0);                  /* mov eax, 0x101c59f0 */
            ii(0x1012_5d48, 5); calld(0x1010_744d, -0x1_e900);          /* call 0x1010744d */
            ii(0x1012_5d4d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_5d50, 2); jmpd(0x1012_5d5a, 0x8); goto l_0x1012_5d5a; /* jmp 0x10125d5a */
        l_0x1012_5d52:
            ii(0x1012_5d52, 5); calld(0x1012_5920, -0x437);             /* call 0x10125920 */
            ii(0x1012_5d57, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1012_5d5a:
            ii(0x1012_5d5a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_5d5d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_5d5f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_5d60, 1); popd(edi);                              /* pop edi */
            ii(0x1012_5d61, 1); popd(esi);                              /* pop esi */
            ii(0x1012_5d62, 1); popd(edx);                              /* pop edx */
            ii(0x1012_5d63, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_5d64, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_5d65, 1); retd(); return;                         /* ret */
        }
    }
}
