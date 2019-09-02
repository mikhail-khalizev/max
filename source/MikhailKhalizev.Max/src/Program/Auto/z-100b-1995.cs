using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_1995-34dc8622")]
        public void Method_100b_1995()
        {
            ii(0x100b_1995, 5); push(0x34);                             /* push 0x34 */
            ii(0x100b_199a, 5); call(Definitions.sys_check_available_stack_size, 0xb_43b3); /* call 0x10165d52 */
            ii(0x100b_199f, 1); push(ebx);                              /* push ebx */
            ii(0x100b_19a0, 1); push(ecx);                              /* push ecx */
            ii(0x100b_19a1, 1); push(edx);                              /* push edx */
            ii(0x100b_19a2, 1); push(esi);                              /* push esi */
            ii(0x100b_19a3, 1); push(edi);                              /* push edi */
            ii(0x100b_19a4, 1); push(ebp);                              /* push ebp */
            ii(0x100b_19a5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_19a7, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100b_19ad, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_19b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_19b2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_19b5, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_19b8, 5); call(0x1013_ad71, 0x8_93b4);            /* call 0x1013ad71 */
            ii(0x100b_19bd, 2); test(al, al);                           /* test al, al */
            ii(0x100b_19bf, 2); if(jz(0x100b_19d9, 0x18)) goto l_0x100b_19d9; /* jz 0x100b19d9 */
            ii(0x100b_19c1, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_19c4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_19c7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_19ca, 5); call(0x1007_6574, -0x3_b45b);           /* call 0x10076574 */
            ii(0x100b_19cf, 5); call(0x1015_27ed, 0xa_0e19);            /* call 0x101527ed */
            ii(0x100b_19d4, 5); jmp(0x100b_1a63, 0x8a); goto l_0x100b_1a63; /* jmp 0x100b1a63 */
        l_0x100b_19d9:
            ii(0x100b_19d9, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x100b_19de, 5); call(Definitions.sys_new, 0xb_441d);    /* call 0x10165e00 */
            ii(0x100b_19e3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_19e6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_19e9, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_19ec, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100b_19f0, 2); if(jz(0x100b_1a1d, 0x2b)) goto l_0x100b_1a1d; /* jz 0x100b1a1d */
            ii(0x100b_19f2, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x100b_19f5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_19f8, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_19fb, 5); call(0x1008_a520, -0x2_74e0);           /* call 0x1008a520 */
            ii(0x100b_1a00, 5); call(0x100a_ca34, -0x4fd1);             /* call 0x100aca34 */
            ii(0x100b_1a05, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_1a07, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_1a0a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1a0d, 5); call(Definitions.my_ctor_c12, -0xb9a6); /* call 0x100a606c */
            ii(0x100b_1a12, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_1a15, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_1a18, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_1a1b, 2); jmp(0x100b_1a23, 6); goto l_0x100b_1a23; /* jmp 0x100b1a23 */
        l_0x100b_1a1d:
            ii(0x100b_1a1d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_1a20, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x100b_1a23:
            ii(0x100b_1a23, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x100b_1a26, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_1a29, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_1a2c, 5); call(0x1008_a898, -0x2_7199);           /* call 0x1008a898 */
            ii(0x100b_1a31, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_1a34, 3); mov(edx, memd[ds, eax + 0x11]);         /* mov edx, [eax+0x11] */
            ii(0x100b_1a37, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_1a3a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_1a3d, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_1a40, 5); call(0x1008_a7dc, -0x2_7269);           /* call 0x1008a7dc */
            ii(0x100b_1a45, 5); call(0x100a_63bc, -0xb68e);             /* call 0x100a63bc */
            ii(0x100b_1a4a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_1a4d, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_1a50, 5); call(0x1008_a838, -0x2_721d);           /* call 0x1008a838 */
            ii(0x100b_1a55, 5); mov(ebx, 0x101c_3180);                  /* mov ebx, 0x101c3180 */
            ii(0x100b_1a5a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1a5c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_1a5e, 5); call(0x100a_4d50, -0xcd13);             /* call 0x100a4d50 */
        l_0x100b_1a63:
            ii(0x100b_1a63, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_1a65, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_1a66, 1); pop(edi);                               /* pop edi */
            ii(0x100b_1a67, 1); pop(esi);                               /* pop esi */
            ii(0x100b_1a68, 1); pop(edx);                               /* pop edx */
            ii(0x100b_1a69, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_1a6a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_1a6b, 1); ret();                                  /* ret */
        }
    }
}
