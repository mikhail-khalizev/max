using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3af1a3f5-a840-44e4-98ba-53f6e5e97c9d")]
        public void Method_1015_c858()
        {
            ii(0x1015_c858, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1015_c85d, 5); calld(Definitions.sys_check_available_stack_size, 0x94f0); /* call 0x10165d52 */
            ii(0x1015_c862, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_c863, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_c864, 1); pushd(edx);                             /* push edx */
            ii(0x1015_c865, 1); pushd(esi);                             /* push esi */
            ii(0x1015_c866, 1); pushd(edi);                             /* push edi */
            ii(0x1015_c867, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_c868, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_c86a, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1015_c870, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_c873, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_c876, 3); mov(al, memb_a32[ds, eax + 0x29]);      /* mov al, [eax+0x29] */
            ii(0x1015_c879, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_c87b, 5); add(eax, 0xc8);                         /* add eax, 0xc8 */
            ii(0x1015_c880, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_c883, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_c886, 5); calld(0x1014_9b07, -0x12d84);           /* call 0x10149b07 */
            ii(0x1015_c88b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_c88d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_c88e, 1); popd(edi);                              /* pop edi */
            ii(0x1015_c88f, 1); popd(esi);                              /* pop esi */
            ii(0x1015_c890, 1); popd(edx);                              /* pop edx */
            ii(0x1015_c891, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_c892, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_c893, 1); retd(); return;                         /* ret */
        }
    }
}
