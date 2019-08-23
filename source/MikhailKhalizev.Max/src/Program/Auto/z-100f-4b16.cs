using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_4b16-f495e48d")]
        public void Method_100f_4b16()
        {
            ii(0x100f_4b16, 5); push(0x1c);                             /* push 0x1c */
            ii(0x100f_4b1b, 5); call(Definitions.sys_check_available_stack_size, 0x7_1232); /* call 0x10165d52 */
            ii(0x100f_4b20, 1); push(ebx);                              /* push ebx */
            ii(0x100f_4b21, 1); push(ecx);                              /* push ecx */
            ii(0x100f_4b22, 1); push(edx);                              /* push edx */
            ii(0x100f_4b23, 1); push(esi);                              /* push esi */
            ii(0x100f_4b24, 1); push(edi);                              /* push edi */
            ii(0x100f_4b25, 1); push(ebp);                              /* push ebp */
            ii(0x100f_4b26, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4b28, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x100f_4b2e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4b30, 5); mov(eax, memd[ds, 0x101b_878b]);        /* mov eax, [0x101b878b] */
            ii(0x100f_4b35, 5); call(0x100c_fb73, -0x2_4fc7);           /* call 0x100cfb73 */
            ii(0x100f_4b3a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4b3c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_4b41, 5); call(0x1013_ad71, 0x4_622b);            /* call 0x1013ad71 */
            ii(0x100f_4b46, 2); test(al, al);                           /* test al, al */
            ii(0x100f_4b48, 2); if(jz(0x100f_4b7f, 0x35)) goto l_0x100f_4b7f; /* jz 0x100f4b7f */
            ii(0x100f_4b4a, 5); call(0x1010_2acc, 0xdf7d);              /* call 0x10102acc */
            ii(0x100f_4b4f, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_4b51, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_4b53, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_4b58, 5); call(0x1007_6574, -0x7_e5e9);           /* call 0x10076574 */
            ii(0x100f_4b5d, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100f_4b60, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_4b63, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_4b68, 5); call(0x1007_6574, -0x7_e5f9);           /* call 0x10076574 */
            ii(0x100f_4b6d, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100f_4b70, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_4b73, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_4b78, 5); call(0x1010_1620, 0xcaa3);              /* call 0x10101620 */
            ii(0x100f_4b7d, 2); jmp(0x100f_4b89, 0xa); goto l_0x100f_4b89; /* jmp 0x100f4b89 */
        l_0x100f_4b7f:
            ii(0x100f_4b7f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_4b84, 5); call(0x1010_1374, 0xc7eb);              /* call 0x10101374 */
        l_0x100f_4b89:
            ii(0x100f_4b89, 7); cmp(memb[ds, 0x101c_37d0], 0);          /* cmp byte [0x101c37d0], 0x0 */
            ii(0x100f_4b90, 2); if(jz(0x100f_4b99, 0x7)) goto l_0x100f_4b99; /* jz 0x100f4b99 */
            ii(0x100f_4b92, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_4b94, 5); call(0x100f_4685, -0x514);              /* call 0x100f4685 */
        l_0x100f_4b99:
            ii(0x100f_4b99, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_4b9a, 1); pop(edi);                               /* pop edi */
            ii(0x100f_4b9b, 1); pop(esi);                               /* pop esi */
            ii(0x100f_4b9c, 1); pop(edx);                               /* pop edx */
            ii(0x100f_4b9d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_4b9e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_4b9f, 1); ret();                                  /* ret */
        }
    }
}
