using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a370-f5e2b528")]
        public void Method_1009_a370()
        {
            ii(0x1009_a370, 5); push(0x38);                             /* push 0x38 */
            ii(0x1009_a375, 5); call(Definitions.sys_check_available_stack_size, 0xc_b9d8); /* call 0x10165d52 */
            ii(0x1009_a37a, 1); push(ebx);                              /* push ebx */
            ii(0x1009_a37b, 1); push(ecx);                              /* push ecx */
            ii(0x1009_a37c, 1); push(edx);                              /* push edx */
            ii(0x1009_a37d, 1); push(esi);                              /* push esi */
            ii(0x1009_a37e, 1); push(edi);                              /* push edi */
            ii(0x1009_a37f, 1); push(ebp);                              /* push ebp */
            ii(0x1009_a380, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a382, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1009_a388, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_a38b, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1009_a390, 5); call(Definitions.sys_new, 0xc_ba6b);    /* call 0x10165e00 */
            ii(0x1009_a395, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1009_a398, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_a39b, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1009_a39e, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1009_a3a2, 2); if(jz(0x1009_a3c7, 0x23)) goto l_0x1009_a3c7; /* jz 0x1009a3c7 */
            ii(0x1009_a3a4, 3); lea(edx, memd[ss, ebp - 24]);           /* lea edx, [ebp-0x18] */
            ii(0x1009_a3a7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_a3aa, 5); call(0x100a_2d3d, 0x898e);              /* call 0x100a2d3d */
            ii(0x1009_a3af, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_a3b1, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_a3b4, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_a3b7, 5); call(Definitions.my_ctor_c12, 0xbcb0);  /* call 0x100a606c */
            ii(0x1009_a3bc, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1009_a3bf, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1009_a3c2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_a3c5, 2); jmp(0x1009_a3cd, 6); goto l_0x1009_a3cd; /* jmp 0x1009a3cd */
        l_0x1009_a3c7:
            ii(0x1009_a3c7, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_a3ca, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1009_a3cd:
            ii(0x1009_a3cd, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_a3d0, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_a3d3, 5); call(0x1008_a914, -0xfac4);             /* call 0x1008a914 */
            ii(0x1009_a3d8, 5); mov(edx, 0x3e);                         /* mov edx, 0x3e */
            ii(0x1009_a3dd, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_a3e0, 5); call(0x1008_a7dc, -0xfc09);             /* call 0x1008a7dc */
            ii(0x1009_a3e5, 5); call(0x100a_63bc, 0xbfd2);              /* call 0x100a63bc */
            ii(0x1009_a3ea, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_a3ed, 5); call(0x1008_a838, -0xfbba);             /* call 0x1008a838 */
            ii(0x1009_a3f2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_a3f4, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_a3f9, 5); call(0x100a_4d50, 0xa952);              /* call 0x100a4d50 */
            ii(0x1009_a3fe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a400, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_a403, 5); call(0x1008_8cbc, -0x1_174c);           /* call 0x10088cbc */
            ii(0x1009_a408, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a40a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_a40b, 1); pop(edi);                               /* pop edi */
            ii(0x1009_a40c, 1); pop(esi);                               /* pop esi */
            ii(0x1009_a40d, 1); pop(edx);                               /* pop edx */
            ii(0x1009_a40e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_a40f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_a410, 1); ret();                                  /* ret */
        }
    }
}
