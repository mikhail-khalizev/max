using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6b9570b3-b0ef-434a-9d9c-9de7a0ea0dc7")]
        public void Method_1007_1ff5()
        {
            ii(0x1007_1ff5, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1007_1ffa, 5); calld(Definitions.sys_check_available_stack_size, 0xf_3d53); /* call 0x10165d52 */
            ii(0x1007_1fff, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_2000, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_2001, 1); pushd(edx);                             /* push edx */
            ii(0x1007_2002, 1); pushd(esi);                             /* push esi */
            ii(0x1007_2003, 1); pushd(edi);                             /* push edi */
            ii(0x1007_2004, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_2005, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2007, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_200d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_2010, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_2013, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_2016, 2); if(jmpd_func(0x1007_2040, 0x28)) return; /* jmp 0x10072040 */
            ii(0x1007_2018, 7); mov(memd_a32[ss, ebp - 0xc], 0xffff_fffd); /* mov dword [ebp-0xc], 0xfffffffd */
            ii(0x1007_201f, 2); if(jmpd_func(0x1007_2067, 0x46)) return; /* jmp 0x10072067 */
            ii(0x1007_2021, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x1007_2028, 2); if(jmpd_func(0x1007_2067, 0x3d)) return; /* jmp 0x10072067 */
        }
    }
}
