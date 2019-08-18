using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e086fcc2-f22d-4dd3-bc9f-af295d70c55c")]
        public void Method_100b_7294()
        {
            ii(0x100b_7294, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_7299, 5); calld(Definitions.sys_check_available_stack_size, 0xa_eab4); /* call 0x10165d52 */
            ii(0x100b_729e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_729f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_72a0, 1); pushd(esi);                             /* push esi */
            ii(0x100b_72a1, 1); pushd(edi);                             /* push edi */
            ii(0x100b_72a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_72a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_72a5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_72ab, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_72ae, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_72b1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_72b6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_72b9, 5); calld(0x1008_8a84, -0x2_e83a);          /* call 0x10088a84 */
            ii(0x100b_72be, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_72c1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_72c4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_72c7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_72ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_72cc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_72cd, 1); popd(edi);                              /* pop edi */
            ii(0x100b_72ce, 1); popd(esi);                              /* pop esi */
            ii(0x100b_72cf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_72d0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_72d1, 1); retd(); return;                         /* ret */
        }
    }
}
