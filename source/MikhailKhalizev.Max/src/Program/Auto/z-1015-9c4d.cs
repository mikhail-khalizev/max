using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("083ee24c-4fea-4dd1-ad39-377a8061927b")]
        public void Method_1015_9c4d()
        {
            ii(0x1015_9c4d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_9c52, 5); calld(Definitions.sys_check_available_stack_size, 0xc0fb); /* call 0x10165d52 */
            ii(0x1015_9c57, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_9c58, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_9c59, 1); pushd(esi);                             /* push esi */
            ii(0x1015_9c5a, 1); pushd(edi);                             /* push edi */
            ii(0x1015_9c5b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_9c5c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9c5e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_9c64, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_9c67, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_9c6a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_9c6d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_9c70, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_9c75, 5); calld(0x100f_448c, -0x6_57ee);          /* call 0x100f448c */
            ii(0x1015_9c7a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_9c7d, 4); cmp(memb_a32[ds, eax + 0x57], 0x7);     /* cmp byte [eax+0x57], 0x7 */
            ii(0x1015_9c81, 2); if(jnzd(0x1015_9c8c, 0x9)) goto l_0x1015_9c8c; /* jnz 0x10159c8c */
            ii(0x1015_9c83, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_9c86, 4); mov(memb_a32[ds, eax + 0x57], 0);       /* mov byte [eax+0x57], 0x0 */
            ii(0x1015_9c8a, 2); jmpd(0x1015_9c93, 0x7); goto l_0x1015_9c93; /* jmp 0x10159c93 */
        l_0x1015_9c8c:
            ii(0x1015_9c8c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_9c8f, 4); mov(memb_a32[ds, eax + 0x57], 0x7);     /* mov byte [eax+0x57], 0x7 */
        l_0x1015_9c93:
            ii(0x1015_9c93, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9c95, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_9c96, 1); popd(edi);                              /* pop edi */
            ii(0x1015_9c97, 1); popd(esi);                              /* pop esi */
            ii(0x1015_9c98, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_9c99, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_9c9a, 1); retd(); return;                         /* ret */
        }
    }
}
