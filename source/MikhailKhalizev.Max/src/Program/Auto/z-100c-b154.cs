using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b154-b19a04cb")]
        public void Method_100c_b154()
        {
            ii(0x100c_b154, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_b159, 5); calld(Definitions.sys_check_available_stack_size, 0x9_abf4); /* call 0x10165d52 */
            ii(0x100c_b15e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b15f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b160, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b161, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b162, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b163, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b165, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_b16b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b16e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b171, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_b174, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b177, 5); calld(0x1007_6cd0, -0x5_44ac);          /* call 0x10076cd0 */
            ii(0x100c_b17c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b17f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100c_b182, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b185, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b188, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_b18b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_b18e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b190, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b191, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b192, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b193, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b194, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b195, 1); retd();                                 /* ret */
        }
    }
}
