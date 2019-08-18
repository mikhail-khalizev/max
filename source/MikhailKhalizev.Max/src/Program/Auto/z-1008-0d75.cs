using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cb18277c-64bd-466d-a87c-066134b32ef0")]
        public void Method_1008_0d75()
        {
            ii(0x1008_0d75, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_0d7a, 5); calld(Definitions.sys_check_available_stack_size, 0xe_4fd3); /* call 0x10165d52 */
            ii(0x1008_0d7f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_0d80, 1); pushd(esi);                             /* push esi */
            ii(0x1008_0d81, 1); pushd(edi);                             /* push edi */
            ii(0x1008_0d82, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_0d83, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_0d85, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_0d8b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_0d8e, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1008_0d91, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1008_0d94, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1008_0d98, 2); if(jnzd(0x1008_0dab, 0x11)) goto l_0x1008_0dab; /* jnz 0x10080dab */
            ii(0x1008_0d9a, 5); calld(0x1008_b0e4, 0xa345);             /* call 0x1008b0e4 */
            ii(0x1008_0d9f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_0da1, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1008_0da3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_0da6, 5); calld(0x100a_297d, 0x2_1bd2);           /* call 0x100a297d */
        l_0x1008_0dab:
            ii(0x1008_0dab, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_0dad, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_0dae, 1); popd(edi);                              /* pop edi */
            ii(0x1008_0daf, 1); popd(esi);                              /* pop esi */
            ii(0x1008_0db0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_0db1, 1); retd(); return;                         /* ret */
        }
    }
}
