using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d125d569-0734-4b3e-bf84-9c93b3d0eaa1")]
        public void Method_100e_7e92()
        {
            ii(0x100e_7e92, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_7e97, 5); calld(Definitions.sys_check_available_stack_size, 0x7_deb6); /* call 0x10165d52 */
            ii(0x100e_7e9c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_7e9d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_7e9e, 1); pushd(esi);                             /* push esi */
            ii(0x100e_7e9f, 1); pushd(edi);                             /* push edi */
            ii(0x100e_7ea0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_7ea1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_7ea3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_7ea9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_7eac, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_7eaf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_7eb2, 5); calld(0x100e_7ec8, 0x11);               /* call 0x100e7ec8 */
            ii(0x100e_7eb7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_7eba, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_7ebd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_7ec0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_7ec2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_7ec3, 1); popd(edi);                              /* pop edi */
            ii(0x100e_7ec4, 1); popd(esi);                              /* pop esi */
            ii(0x100e_7ec5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_7ec6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_7ec7, 1); retd(); return;                         /* ret */
        }
    }
}
