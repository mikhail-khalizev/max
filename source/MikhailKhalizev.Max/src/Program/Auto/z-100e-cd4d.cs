using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_cd4d-839f17f8")]
        public void Method_100e_cd4d()
        {
            ii(0x100e_cd4d, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100e_cd52, 5); calld(Definitions.sys_check_available_stack_size, 0x7_8ffb); /* call 0x10165d52 */
            ii(0x100e_cd57, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_cd58, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_cd59, 1); pushd(esi);                             /* push esi */
            ii(0x100e_cd5a, 1); pushd(edi);                             /* push edi */
            ii(0x100e_cd5b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_cd5c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_cd5e, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100e_cd64, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_cd67, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_cd6a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cd6e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cd70, 2); if(jzd(0x100e_cd7b, 0x9)) goto l_0x100e_cd7b; /* jz 0x100ecd7b */
            ii(0x100e_cd72, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_cd76, 5); if(jmpd_func(0x100e_d760, 0x9e5)) return; /* jmp 0x100ed760 */
        l_0x100e_cd7b:
            ii(0x100e_cd7b, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100e_cd80, 5); calld(0x1007_5fdc, -0x7_6da9);          /* call 0x10075fdc */
            ii(0x100e_cd85, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_cd88, 5); if(jmpd_func(0x100e_d734, 0x9a7)) return; /* jmp 0x100ed734 */
        }
    }
}
