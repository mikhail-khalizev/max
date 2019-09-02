using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e3ad-6d0bf579")]
        public void Method_1009_e3ad()
        {
            ii(0x1009_e3ad, 5); push(0x20);                             /* push 0x20 */
            ii(0x1009_e3b2, 5); call(Definitions.sys_check_available_stack_size, 0xc_799b); /* call 0x10165d52 */
            ii(0x1009_e3b7, 1); push(ebx);                              /* push ebx */
            ii(0x1009_e3b8, 1); push(ecx);                              /* push ecx */
            ii(0x1009_e3b9, 1); push(esi);                              /* push esi */
            ii(0x1009_e3ba, 1); push(edi);                              /* push edi */
            ii(0x1009_e3bb, 1); push(ebp);                              /* push ebp */
            ii(0x1009_e3bc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_e3be, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_e3c4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_e3c7, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_e3ca, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_e3cd, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x1009_e3d0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_e3d3, 5); call(0x1007_6d98, -0x2_7640);           /* call 0x10076d98 */
            ii(0x1009_e3d8, 2); test(al, al);                           /* test al, al */
            ii(0x1009_e3da, 2); if(jz(0x1009_e3e4, 8)) goto l_0x1009_e3e4; /* jz 0x1009e3e4 */
            ii(0x1009_e3dc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_e3df, 5); call(0x1009_e31c, -0xc8);               /* call 0x1009e31c */
        l_0x1009_e3e4:
            ii(0x1009_e3e4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_e3e6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_e3e7, 1); pop(edi);                               /* pop edi */
            ii(0x1009_e3e8, 1); pop(esi);                               /* pop esi */
            ii(0x1009_e3e9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_e3ea, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_e3eb, 1); ret();                                  /* ret */
        }
    }
}
