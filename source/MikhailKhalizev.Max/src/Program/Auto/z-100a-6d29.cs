using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_6d29-20852ab1")]
        public void Method_100a_6d29()
        {
            ii(0x100a_6d29, 5); push(0x34);                             /* push 0x34 */
            ii(0x100a_6d2e, 5); call(Definitions.sys_check_available_stack_size, 0xb_f01f); /* call 0x10165d52 */
            ii(0x100a_6d33, 1); push(ebx);                              /* push ebx */
            ii(0x100a_6d34, 1); push(ecx);                              /* push ecx */
            ii(0x100a_6d35, 1); push(esi);                              /* push esi */
            ii(0x100a_6d36, 1); push(edi);                              /* push edi */
            ii(0x100a_6d37, 1); push(ebp);                              /* push ebp */
            ii(0x100a_6d38, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_6d3a, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100a_6d40, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_6d43, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_6d46, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_6d4b, 5); call(0x1007_6338, -0x3_0a18);           /* call 0x10076338 */
            ii(0x100a_6d50, 3); lea(ebx, memd[ss, ebp - 0x14]);         /* lea ebx, [ebp-0x14] */
            ii(0x100a_6d53, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_6d55, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_6d57, 5); call(0x1007_64b8, -0x3_08a4);           /* call 0x100764b8 */
            ii(0x100a_6d5c, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100a_6d63, 2); jmp(0x100a_6d6d, 0x8); goto l_0x100a_6d6d; /* jmp 0x100a6d6d */
        l_0x100a_6d65:
            ii(0x100a_6d65, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_6d68, 5); call(0x1007_6bf8, -0x3_0175);           /* call 0x10076bf8 */
        l_0x100a_6d6d:
            ii(0x100a_6d6d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6d6f, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_6d72, 5); call(0x1013_ad71, 0x9_3ffa);            /* call 0x1013ad71 */
            ii(0x100a_6d77, 2); test(al, al);                           /* test al, al */
            ii(0x100a_6d79, 2); if(jz(0x100a_6dcc, 0x51)) goto l_0x100a_6dcc; /* jz 0x100a6dcc */
            ii(0x100a_6d7b, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_6d7e, 5); call(0x1007_63a0, -0x3_09e3);           /* call 0x100763a0 */
            ii(0x100a_6d83, 5); call(0x1007_6204, -0x3_0b84);           /* call 0x10076204 */
            ii(0x100a_6d88, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100a_6d8b, 2); if(jnz(0x100a_6dca, 0x3d)) goto l_0x100a_6dca; /* jnz 0x100a6dca */
            ii(0x100a_6d8d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_6d90, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6d93, 5); call(0x1008_abbc, -0x1_c1dc);           /* call 0x1008abbc */
            ii(0x100a_6d98, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_6d9a, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_6d9d, 5); call(0x1007_636c, -0x3_0a36);           /* call 0x1007636c */
            ii(0x100a_6da2, 5); call(0x100a_601a, -0xd8d);              /* call 0x100a601a */
            ii(0x100a_6da7, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_6daa, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100a_6dae, 2); if(jz(0x100a_6db9, 0x9)) goto l_0x100a_6db9; /* jz 0x100a6db9 */
            ii(0x100a_6db0, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_6db3, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x100a_6db7, 2); if(jge(0x100a_6dca, 0x11)) goto l_0x100a_6dca; /* jge 0x100a6dca */
        l_0x100a_6db9:
            ii(0x100a_6db9, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_6dbc, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_6dbf, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_6dc2, 5); call(0x1007_6408, -0x3_09bf);           /* call 0x10076408 */
            ii(0x100a_6dc7, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x100a_6dca:
            ii(0x100a_6dca, 2); jmp(0x100a_6d65, -0x67); goto l_0x100a_6d65; /* jmp 0x100a6d65 */
        l_0x100a_6dcc:
            ii(0x100a_6dcc, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_6dcf, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_6dd2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6dd4, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_6dd7, 5); call(0x1007_5f6c, -0x3_0e70);           /* call 0x10075f6c */
            ii(0x100a_6ddc, 2); jmp(0x100a_6de8, 0xa); goto l_0x100a_6de8; /* jmp 0x100a6de8 */
        //  ii(0x100a_6dde, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100a_6de0, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
        //  ii(0x100a_6de3, 5); call(0x1007_5f6c, -0x3_0e7c);           /* call 0x10075f6c */
        l_0x100a_6de8:
            ii(0x100a_6de8, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100a_6deb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_6ded, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_6dee, 1); pop(edi);                               /* pop edi */
            ii(0x100a_6def, 1); pop(esi);                               /* pop esi */
            ii(0x100a_6df0, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_6df1, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_6df2, 1); ret();                                  /* ret */
        }
    }
}
