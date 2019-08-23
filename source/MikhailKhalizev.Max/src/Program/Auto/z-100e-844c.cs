using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_844c-f5bb2df7")]
        public void Method_100e_844c()
        {
            ii(0x100e_844c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_8451, 5); call(Definitions.sys_check_available_stack_size, 0x7_d8fc); /* call 0x10165d52 */
            ii(0x100e_8456, 1); push(ebx);                              /* push ebx */
            ii(0x100e_8457, 1); push(ecx);                              /* push ecx */
            ii(0x100e_8458, 1); push(esi);                              /* push esi */
            ii(0x100e_8459, 1); push(edi);                              /* push edi */
            ii(0x100e_845a, 1); push(ebp);                              /* push ebp */
            ii(0x100e_845b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_845d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_8463, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_8466, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_8469, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x100e_8470, 2); if(jz(0x100e_8486, 0x14)) goto l_0x100e_8486; /* jz 0x100e8486 */
            ii(0x100e_8472, 5); mov(edx, 0x101b_60f0);                  /* mov edx, 0x101b60f0 */
            ii(0x100e_8477, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_847a, 5); call(Definitions.sys_call_dtor_arr, 0x7_db39); /* call 0x10165fb8 */
            ii(0x100e_847f, 5); call(Definitions.sys_delete_arr, 0x7_db54); /* call 0x10165fd8 */
            ii(0x100e_8484, 2); jmp(0x100e_84a7, 0x21); goto l_0x100e_84a7; /* jmp 0x100e84a7 */
        l_0x100e_8486:
            ii(0x100e_8486, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_848b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_848e, 5); call(0x100c_d916, -0x1_ab7d);           /* call 0x100cd916 */
            ii(0x100e_8493, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_8496, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x100e_849d, 2); if(jz(0x100e_84a7, 0x8)) goto l_0x100e_84a7; /* jz 0x100e84a7 */
            ii(0x100e_849f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_84a2, 5); call(Definitions.sys_delete, 0x7_dabd); /* call 0x10165f64 */
        l_0x100e_84a7:
            ii(0x100e_84a7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_84aa, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_84ad, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_84b0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_84b2, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_84b3, 1); pop(edi);                               /* pop edi */
            ii(0x100e_84b4, 1); pop(esi);                               /* pop esi */
            ii(0x100e_84b5, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_84b6, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_84b7, 1); ret();                                  /* ret */
        }
    }
}
