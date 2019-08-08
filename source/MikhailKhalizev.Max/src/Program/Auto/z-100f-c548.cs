using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b7ab418b-d83b-4c2e-a2b4-dad262858311")]
        public void Method_100f_c548()
        {
            ii(0x100f_c548, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100f_c54d, 5); calld(Definitions.sys_check_available_stack_size, 0x6_9800); /* call 0x10165d52 */
            ii(0x100f_c552, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_c553, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_c554, 1); pushd(esi);                             /* push esi */
            ii(0x100f_c555, 1); pushd(edi);                             /* push edi */
            ii(0x100f_c556, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_c557, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_c559, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_c55f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_c562, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100f_c565, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c568, 3); mov(al, memb_a32[ds, eax + 0x14]);      /* mov al, [eax+0x14] */
            ii(0x100f_c56b, 2); sub(al, 0x9);                           /* sub al, 0x9 */
            ii(0x100f_c56d, 3); add(al, memb_a32[ss, ebp - 0x4]);       /* add al, [ebp-0x4] */
            ii(0x100f_c570, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x100f_c573, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x100f_c578, 5); calld(0x1010_61bb, 0x9c3e);             /* call 0x101061bb */
            ii(0x100f_c57d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_c580, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_c583, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_c585, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_c586, 1); popd(edi);                              /* pop edi */
            ii(0x100f_c587, 1); popd(esi);                              /* pop esi */
            ii(0x100f_c588, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_c589, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_c58a, 1); retd(); return;                         /* ret */
        }
    }
}
