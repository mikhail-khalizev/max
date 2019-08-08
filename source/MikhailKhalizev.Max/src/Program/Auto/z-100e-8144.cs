using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("18e7845f-aacc-4d8d-a17a-f2970db24d68")]
        public void Method_100e_8144()
        {
            ii(0x100e_8144, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_8149, 5); calld(Definitions.sys_check_available_stack_size, 0x7_dc04); /* call 0x10165d52 */
            ii(0x100e_814e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_814f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_8150, 1); pushd(esi);                             /* push esi */
            ii(0x100e_8151, 1); pushd(edi);                             /* push edi */
            ii(0x100e_8152, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_8153, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_8155, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_815b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_815e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_8161, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_8166, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_8169, 5); calld(0x100e_8104, -0x6a);              /* call 0x100e8104 */
            ii(0x100e_816e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_8171, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_8174, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_8177, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_817a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_817c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_817d, 1); popd(edi);                              /* pop edi */
            ii(0x100e_817e, 1); popd(esi);                              /* pop esi */
            ii(0x100e_817f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_8180, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_8181, 1); retd(); return;                         /* ret */
        }
    }
}
