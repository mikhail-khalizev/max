using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_5880-b05717d4")]
        public void Method_1011_5880()
        {
            ii(0x1011_5880, 5); push(0x24);                             /* push 0x24 */
            ii(0x1011_5885, 5); call(Definitions.sys_check_available_stack_size, 0x5_04c8); /* call 0x10165d52 */
            ii(0x1011_588a, 1); push(ebx);                              /* push ebx */
            ii(0x1011_588b, 1); push(ecx);                              /* push ecx */
            ii(0x1011_588c, 1); push(edx);                              /* push edx */
            ii(0x1011_588d, 1); push(esi);                              /* push esi */
            ii(0x1011_588e, 1); push(edi);                              /* push edi */
            ii(0x1011_588f, 1); push(ebp);                              /* push ebp */
            ii(0x1011_5890, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5892, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_5898, 5); mov(eax, 0x101b_af7c);                  /* mov eax, 0x101baf7c */
            ii(0x1011_589d, 5); call(/* sys */ 0x1016_611f, 0x5_087d);  /* call 0x1016611f */
            ii(0x1011_58a2, 5); mov(ebx, 0x101b_66dc);                  /* mov ebx, 0x101b66dc */
            ii(0x1011_58a7, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1011_58ac, 5); mov(eax, 0x101c_52bc);                  /* mov eax, 0x101c52bc */
            ii(0x1011_58b1, 5); call(Definitions.sys_call_ctor_arr_v2, 0x5_06ba); /* call 0x10165f70 */
            ii(0x1011_58b6, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_58b9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_58bc, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_58bf, 10); mov(memd[ds, 0x101b_af84], 0x1);       /* mov dword [0x101baf84], 0x1 */
            ii(0x1011_58c9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_58cb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_58cc, 1); pop(edi);                               /* pop edi */
            ii(0x1011_58cd, 1); pop(esi);                               /* pop esi */
            ii(0x1011_58ce, 1); pop(edx);                               /* pop edx */
            ii(0x1011_58cf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_58d0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_58d1, 1); ret();                                  /* ret */
        }
    }
}
