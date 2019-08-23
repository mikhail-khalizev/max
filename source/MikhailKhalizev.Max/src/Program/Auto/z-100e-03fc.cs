using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_03fc-37d5ddf9")]
        public void Method_100e_03fc()
        {
            ii(0x100e_03fc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_0401, 5); calld(Definitions.sys_check_available_stack_size, 0x8_594c); /* call 0x10165d52 */
            ii(0x100e_0406, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0407, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0408, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0409, 1); pushd(edi);                             /* push edi */
            ii(0x100e_040a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_040b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_040d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0413, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0416, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_0419, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_041e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0421, 5); calld(Definitions.my_dtor_0x101b_6edc, 0x5_a81f); /* call 0x1013ac45 */
            ii(0x100e_0426, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0429, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_042c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_042f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_0432, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0434, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0435, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0436, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0437, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0438, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0439, 1); retd();                                 /* ret */
        }
    }
}
