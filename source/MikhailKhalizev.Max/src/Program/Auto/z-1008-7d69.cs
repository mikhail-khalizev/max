using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_7d69-72ae525a")]
        public void Method_1008_7d69()
        {
            ii(0x1008_7d69, 5); push(0x20);                             /* push 0x20 */
            ii(0x1008_7d6e, 5); call(Definitions.sys_check_available_stack_size, 0xd_dfdf); /* call 0x10165d52 */
            ii(0x1008_7d73, 1); push(ebx);                              /* push ebx */
            ii(0x1008_7d74, 1); push(ecx);                              /* push ecx */
            ii(0x1008_7d75, 1); push(edx);                              /* push edx */
            ii(0x1008_7d76, 1); push(esi);                              /* push esi */
            ii(0x1008_7d77, 1); push(edi);                              /* push edi */
            ii(0x1008_7d78, 1); push(ebp);                              /* push ebp */
            ii(0x1008_7d79, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_7d7b, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_7d81, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_7d84, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7d86, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_7d89, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_7d8c, 5); call(0x1013_ad71, 0xb_2fe0);            /* call 0x1013ad71 */
            ii(0x1008_7d91, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7d93, 2); if(jz(0x1008_7dba, 0x25)) goto l_0x1008_7dba; /* jz 0x10087dba */
            ii(0x1008_7d95, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_7d97, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_7d9a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_7d9d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_7da0, 5); call(0x1007_6574, -0x1_1831);           /* call 0x10076574 */
            ii(0x1008_7da5, 5); call(0x1015_2962, 0xc_abb8);            /* call 0x10152962 */
            ii(0x1008_7daa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_7dad, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_7db0, 5); call(0x1007_65d0, -0x1_17e5);           /* call 0x100765d0 */
            ii(0x1008_7db5, 5); call(0x100a_b50c, 0x2_3752);            /* call 0x100ab50c */
        l_0x1008_7dba:
            ii(0x1008_7dba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7dbc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_7dbf, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7dc2, 5); call(0x1013_ad71, 0xb_2faa);            /* call 0x1013ad71 */
            ii(0x1008_7dc7, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7dc9, 2); if(jz(0x1008_7dde, 0x13)) goto l_0x1008_7dde; /* jz 0x10087dde */
            ii(0x1008_7dcb, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_7dce, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_7dd1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7dd4, 5); call(0x1007_6574, -0x1_1865);           /* call 0x10076574 */
            ii(0x1008_7dd9, 5); call(0x1015_27b8, 0xc_a9da);            /* call 0x101527b8 */
        l_0x1008_7dde:
            ii(0x1008_7dde, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7de0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_7de3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7de6, 5); call(0x1007_6630, -0x1_17bb);           /* call 0x10076630 */
            ii(0x1008_7deb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7ded, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_7df0, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_7df3, 5); call(0x1007_6630, -0x1_17c8);           /* call 0x10076630 */
            ii(0x1008_7df8, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_7dfb, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_7e00, 5); call(0x100a_5e27, 0x1_e022);            /* call 0x100a5e27 */
            ii(0x1008_7e05, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7e07, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_7e08, 1); pop(edi);                               /* pop edi */
            ii(0x1008_7e09, 1); pop(esi);                               /* pop esi */
            ii(0x1008_7e0a, 1); pop(edx);                               /* pop edx */
            ii(0x1008_7e0b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_7e0c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_7e0d, 1); ret();                                  /* ret */
        }
    }
}
