using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_09ee-430b9567")]
        public void Method_100b_09ee()
        {
            ii(0x100b_09ee, 5); push(0x28);                             /* push 0x28 */
            ii(0x100b_09f3, 5); call(Definitions.sys_check_available_stack_size, 0xb_535a); /* call 0x10165d52 */
            ii(0x100b_09f8, 1); push(ebx);                              /* push ebx */
            ii(0x100b_09f9, 1); push(ecx);                              /* push ecx */
            ii(0x100b_09fa, 1); push(edx);                              /* push edx */
            ii(0x100b_09fb, 1); push(esi);                              /* push esi */
            ii(0x100b_09fc, 1); push(edi);                              /* push edi */
            ii(0x100b_09fd, 1); push(ebp);                              /* push ebp */
            ii(0x100b_09fe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_0a00, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_0a06, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_0a09, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0a0c, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_0a0f, 5); call(0x100b_7c44, 0x7230);              /* call 0x100b7c44 */
            ii(0x100b_0a14, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x100b_0a17, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_0a19, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_0a1b, 5); call(0x100b_7b28, 0x7108);              /* call 0x100b7b28 */
            ii(0x100b_0a20, 2); jmp(0x100b_0a2a, 0x8); goto l_0x100b_0a2a; /* jmp 0x100b0a2a */
        l_0x100b_0a22:
            ii(0x100b_0a22, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_0a25, 5); call(0x1007_6bf8, -0x3_9e32);           /* call 0x10076bf8 */
        l_0x100b_0a2a:
            ii(0x100b_0a2a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0a2c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_0a2f, 5); call(0x1013_ad71, 0x8_a33d);            /* call 0x1013ad71 */
            ii(0x100b_0a34, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0a36, 2); if(jz(0x100b_0a60, 0x28)) goto l_0x100b_0a60; /* jz 0x100b0a60 */
            ii(0x100b_0a38, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_0a3b, 5); call(0x100b_7a14, 0x6fd4);              /* call 0x100b7a14 */
            ii(0x100b_0a40, 5); call(0x100b_7d68, 0x7323);              /* call 0x100b7d68 */
            ii(0x100b_0a45, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_0a47, 2); if(jz(0x100b_0a5e, 0x15)) goto l_0x100b_0a5e; /* jz 0x100b0a5e */
            ii(0x100b_0a49, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_0a4c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_0a4f, 5); call(0x100b_7a14, 0x6fc0);              /* call 0x100b7a14 */
            ii(0x100b_0a54, 5); call(0x100b_7d68, 0x730f);              /* call 0x100b7d68 */
            ii(0x100b_0a59, 5); call(0x1015_27b8, 0xa_1d5a);            /* call 0x101527b8 */
        l_0x100b_0a5e:
            ii(0x100b_0a5e, 2); jmp(0x100b_0a22, -0x3e); goto l_0x100b_0a22; /* jmp 0x100b0a22 */
        l_0x100b_0a60:
            ii(0x100b_0a60, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0a63, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_0a66, 5); call(0x1013_a6f4, 0x8_9c89);            /* call 0x1013a6f4 */
            ii(0x100b_0a6b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0a6d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0a70, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0a73, 5); call(0x1013_ad71, 0x8_a2f9);            /* call 0x1013ad71 */
            ii(0x100b_0a78, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0a7a, 2); if(jz(0x100b_0a9c, 0x20)) goto l_0x100b_0a9c; /* jz 0x100b0a9c */
            ii(0x100b_0a7c, 5); call(0x1008_a79c, -0x2_62e5);           /* call 0x1008a79c */
            ii(0x100b_0a81, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_0a83, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_0a85, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0a88, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0a8b, 5); call(0x1007_65d0, -0x3_a4c0);           /* call 0x100765d0 */
            ii(0x100b_0a90, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_0a92, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_0a97, 5); call(0x100a_53ac, -0xb6f0);             /* call 0x100a53ac */
        l_0x100b_0a9c:
            ii(0x100b_0a9c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0a9e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0aa1, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_0aa4, 5); call(0x1013_ad71, 0x8_a2c8);            /* call 0x1013ad71 */
            ii(0x100b_0aa9, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0aab, 2); if(jz(0x100b_0ac7, 0x1a)) goto l_0x100b_0ac7; /* jz 0x100b0ac7 */
            ii(0x100b_0aad, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0ab0, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_0ab3, 5); call(0x1008_a7dc, -0x2_62dc);           /* call 0x1008a7dc */
            ii(0x100b_0ab8, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_0abb, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_0abe, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100b_0ac1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_0ac4, 3); call_abs(memd[ds, edx + 0x48]);         /* call dword [edx+0x48] */
        l_0x100b_0ac7:
            ii(0x100b_0ac7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0ac9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0acc, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0acf, 5); call(0x1007_6630, -0x3_a4a4);           /* call 0x10076630 */
            ii(0x100b_0ad4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0ad6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0ad9, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0adc, 5); call(0x100b_7cfc, 0x721b);              /* call 0x100b7cfc */
            ii(0x100b_0ae1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0ae3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0ae6, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_0ae9, 5); call(0x1008_a898, -0x2_6256);           /* call 0x1008a898 */
            ii(0x100b_0aee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0af0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0af3, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100b_0af6, 5); call(0x1008_afe4, -0x2_5b17);           /* call 0x1008afe4 */
            ii(0x100b_0afb, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_0afe, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_0b03, 5); call(0x100a_5e27, -0xace1);             /* call 0x100a5e27 */
            ii(0x100b_0b08, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0b0a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_0b0d, 5); call(0x100b_7650, 0x6b3e);              /* call 0x100b7650 */
            ii(0x100b_0b12, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0b14, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_0b15, 1); pop(edi);                               /* pop edi */
            ii(0x100b_0b16, 1); pop(esi);                               /* pop esi */
            ii(0x100b_0b17, 1); pop(edx);                               /* pop edx */
            ii(0x100b_0b18, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_0b19, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_0b1a, 1); ret();                                  /* ret */
        }
    }
}
