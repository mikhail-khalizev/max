using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_e07b-ec1b92ad")]
        public void Method_1008_e07b()
        {
            ii(0x1008_e07b, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_e080, 5); call(Definitions.sys_check_available_stack_size, 0xd_7ccd); /* call 0x10165d52 */
            ii(0x1008_e085, 1); push(ebx);                              /* push ebx */
            ii(0x1008_e086, 1); push(ecx);                              /* push ecx */
            ii(0x1008_e087, 1); push(edx);                              /* push edx */
            ii(0x1008_e088, 1); push(esi);                              /* push esi */
            ii(0x1008_e089, 1); push(edi);                              /* push edi */
            ii(0x1008_e08a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_e08b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_e08d, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_e093, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_e096, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e098, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e09b, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_e09e, 5); call(0x1013_ad71, 0xa_ccce);            /* call 0x1013ad71 */
            ii(0x1008_e0a3, 2); test(al, al);                           /* test al, al */
            ii(0x1008_e0a5, 2); if(jz(0x1008_e0b8, 0x11)) goto l_0x1008_e0b8; /* jz 0x1008e0b8 */
            ii(0x1008_e0a7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e0aa, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_e0ad, 5); call(0x1007_6574, -0x1_7b3e);           /* call 0x10076574 */
            ii(0x1008_e0b2, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1008_e0b6, 2); if(jnz(0x1008_e0ba, 2)) goto l_0x1008_e0ba; /* jnz 0x1008e0ba */
        l_0x1008_e0b8:
            ii(0x1008_e0b8, 2); jmp(0x1008_e0cb, 0x11); goto l_0x1008_e0cb; /* jmp 0x1008e0cb */
        l_0x1008_e0ba:
            ii(0x1008_e0ba, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e0bd, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_e0c0, 5); call(0x1007_6574, -0x1_7b51);           /* call 0x10076574 */
            ii(0x1008_e0c5, 4); cmp(memb[ds, eax + 0x3d], 0x16);        /* cmp byte [eax+0x3d], 0x16 */
            ii(0x1008_e0c9, 2); if(jnz(0x1008_e0cd, 2)) goto l_0x1008_e0cd; /* jnz 0x1008e0cd */
        l_0x1008_e0cb:
            ii(0x1008_e0cb, 2); jmp(0x1008_e0ec, 0x1f); goto l_0x1008_e0ec; /* jmp 0x1008e0ec */
        l_0x1008_e0cd:
            ii(0x1008_e0cd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e0d0, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_e0d3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_e0d6, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1008_e0d9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e0dc, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_e0df, 5); call(0x1007_65d0, -0x1_7b14);           /* call 0x100765d0 */
            ii(0x1008_e0e4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_e0e6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_e0e9, 3); call_abs(memd[ds, ebx + 0x2c]);         /* call dword [ebx+0x2c] */
        l_0x1008_e0ec:
            ii(0x1008_e0ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e0ee, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e0f1, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_e0f4, 5); call(0x1013_ad71, 0xa_cc78);            /* call 0x1013ad71 */
            ii(0x1008_e0f9, 2); test(al, al);                           /* test al, al */
            ii(0x1008_e0fb, 2); if(jz(0x1008_e16b, 0x6e)) goto l_0x1008_e16b; /* jz 0x1008e16b */
            ii(0x1008_e0fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e0ff, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e102, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_e105, 5); call(0x1013_ad71, 0xa_cc67);            /* call 0x1013ad71 */
            ii(0x1008_e10a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_e10c, 2); if(jz(0x1008_e11b, 0xd)) goto l_0x1008_e11b; /* jz 0x1008e11b */
            ii(0x1008_e10e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e111, 5); call(0x1008_d461, -0xcb5);              /* call 0x1008d461 */
            ii(0x1008_e116, 5); jmp(0x1008_e1ac, 0x91); goto l_0x1008_e1ac; /* jmp 0x1008e1ac */
        l_0x1008_e11b:
            ii(0x1008_e11b, 5); call(0x1008_ac50, -0x34d0);             /* call 0x1008ac50 */
            ii(0x1008_e120, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_e122, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_e124, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_e127, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e12a, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_e12d, 5); call(0x1007_6574, -0x1_7bbe);           /* call 0x10076574 */
            ii(0x1008_e132, 5); call(0x1015_2962, 0xc_482b);            /* call 0x10152962 */
            ii(0x1008_e137, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e13a, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_e13d, 5); call(0x1007_6574, -0x1_7bce);           /* call 0x10076574 */
            ii(0x1008_e142, 5); call(0x1015_26ac, 0xc_4565);            /* call 0x101526ac */
            ii(0x1008_e147, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_e149, 2); if(jnz(0x1008_e16b, 0x20)) goto l_0x1008_e16b; /* jnz 0x1008e16b */
            ii(0x1008_e14b, 5); call(0x1008_a79c, -0x39b4);             /* call 0x1008a79c */
            ii(0x1008_e150, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_e152, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_e154, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e157, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_e15a, 5); call(0x1007_65d0, -0x1_7b8f);           /* call 0x100765d0 */
            ii(0x1008_e15f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_e161, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_e166, 5); call(0x100a_53ac, 0x1_7241);            /* call 0x100a53ac */
        l_0x1008_e16b:
            ii(0x1008_e16b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e16d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e170, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_e173, 5); call(0x1007_6630, -0x1_7b48);           /* call 0x10076630 */
            ii(0x1008_e178, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e17a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e17d, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_e180, 5); call(0x1008_afe4, -0x31a1);             /* call 0x1008afe4 */
            ii(0x1008_e185, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e187, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e18a, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_e18d, 5); call(0x1008_afe4, -0x31ae);             /* call 0x1008afe4 */
            ii(0x1008_e192, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e194, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e197, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1008_e19a, 5); call(0x1009_c8f8, 0xe759);              /* call 0x1009c8f8 */
            ii(0x1008_e19f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_e1a2, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_e1a7, 5); call(0x100a_5e27, 0x1_7c7b);            /* call 0x100a5e27 */
        l_0x1008_e1ac:
            ii(0x1008_e1ac, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_e1ae, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_e1af, 1); pop(edi);                               /* pop edi */
            ii(0x1008_e1b0, 1); pop(esi);                               /* pop esi */
            ii(0x1008_e1b1, 1); pop(edx);                               /* pop edx */
            ii(0x1008_e1b2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_e1b3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_e1b4, 1); ret();                                  /* ret */
        }
    }
}
