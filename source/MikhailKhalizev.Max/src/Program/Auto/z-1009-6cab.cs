using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_6cab-99fbc952")]
        public void Method_1009_6cab()
        {
            ii(0x1009_6cab, 5); push(0x60);                             /* push 0x60 */
            ii(0x1009_6cb0, 5); call(Definitions.sys_check_available_stack_size, 0xc_f09d); /* call 0x10165d52 */
            ii(0x1009_6cb5, 1); push(ecx);                              /* push ecx */
            ii(0x1009_6cb6, 1); push(esi);                              /* push esi */
            ii(0x1009_6cb7, 1); push(edi);                              /* push edi */
            ii(0x1009_6cb8, 1); push(ebp);                              /* push ebp */
            ii(0x1009_6cb9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_6cbb, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1009_6cc1, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_6cc4, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1009_6cc7, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1009_6cca, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_6ccd, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_6cd0, 5); call(0x1009_c6c8, 0x59f3);              /* call 0x1009c6c8 */
            ii(0x1009_6cd5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6cd7, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_6cda, 5); call(0x1009_c5dc, 0x58fd);              /* call 0x1009c5dc */
            ii(0x1009_6cdf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_6ce1, 1); push(eax);                              /* push eax */
            ii(0x1009_6ce2, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1009_6ce4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_6ce6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6ce8, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_6ceb, 5); call(0x1008_b148, -0xbba8);             /* call 0x1008b148 */
            ii(0x1009_6cf0, 2); jmp(0x1009_6cfa, 0x8); goto l_0x1009_6cfa; /* jmp 0x10096cfa */
        l_0x1009_6cf2:
            ii(0x1009_6cf2, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_6cf5, 5); call(0x1007_6bf8, -0x2_0102);           /* call 0x10076bf8 */
        l_0x1009_6cfa:
            ii(0x1009_6cfa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6cfc, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_6cff, 5); call(0x1013_ad71, 0xa_406d);            /* call 0x1013ad71 */
            ii(0x1009_6d04, 2); test(al, al);                           /* test al, al */
            ii(0x1009_6d06, 2); if(jz(0x1009_6d52, 0x4a)) goto l_0x1009_6d52; /* jz 0x10096d52 */
            ii(0x1009_6d08, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_6d0b, 5); call(0x1009_c4f8, 0x57e8);              /* call 0x1009c4f8 */
            ii(0x1009_6d10, 5); call(0x1009_c4c4, 0x57af);              /* call 0x1009c4c4 */
            ii(0x1009_6d15, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1009_6d18, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_6d1b, 5); call(0x1009_c4f8, 0x57d8);              /* call 0x1009c4f8 */
            ii(0x1009_6d20, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1009_6d23, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_6d26, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1009_6d29, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1009_6d2c, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_6d2f, 3); call_abs(memd[ds, ebx + 0x1c]);         /* call dword [ebx+0x1c] */
            ii(0x1009_6d32, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_6d35, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_6d38, 5); call(0x1010_82ce, 0x7_1591);            /* call 0x101082ce */
            ii(0x1009_6d3d, 2); test(al, al);                           /* test al, al */
            ii(0x1009_6d3f, 2); if(jz(0x1009_6d50, 0xf)) goto l_0x1009_6d50; /* jz 0x10096d50 */
            ii(0x1009_6d41, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6d43, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_6d46, 5); call(0x1009_ba6c, 0x4d21);              /* call 0x1009ba6c */
            ii(0x1009_6d4b, 5); jmp(0x1009_6dfb, 0xab); goto l_0x1009_6dfb; /* jmp 0x10096dfb */
        l_0x1009_6d50:
            ii(0x1009_6d50, 2); jmp(0x1009_6cf2, -0x60); goto l_0x1009_6cf2; /* jmp 0x10096cf2 */
        l_0x1009_6d52:
            ii(0x1009_6d52, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1009_6d57, 5); call(Definitions.sys_new, 0xc_f0a4);    /* call 0x10165e00 */
            ii(0x1009_6d5c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_6d5f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_6d62, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_6d65, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1009_6d69, 2); if(jz(0x1009_6dab, 0x40)) goto l_0x1009_6dab; /* jz 0x10096dab */
            ii(0x1009_6d6b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_6d6e, 1); push(eax);                              /* push eax */
            ii(0x1009_6d6f, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_6d72, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1009_6d75, 5); call(0x1007_5e64, -0x2_0f16);           /* call 0x10075e64 */
            ii(0x1009_6d7a, 1); push(eax);                              /* push eax */
            ii(0x1009_6d7b, 5); mov(ecx, 0x27);                         /* mov ecx, 0x27 */
            ii(0x1009_6d80, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_6d83, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_6d86, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_6d89, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x1009_6d8c, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_6d8f, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x1009_6d92, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_6d95, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_6d98, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_6d9b, 5); call(0x1008_c999, -0xa407);             /* call 0x1008c999 */
            ii(0x1009_6da0, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_6da3, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_6da6, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1009_6da9, 2); jmp(0x1009_6db1, 0x6); goto l_0x1009_6db1; /* jmp 0x10096db1 */
        l_0x1009_6dab:
            ii(0x1009_6dab, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_6dae, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
        l_0x1009_6db1:
            ii(0x1009_6db1, 3); mov(edx, memd[ss, ebp - 0x44]);         /* mov edx, [ebp-0x44] */
            ii(0x1009_6db4, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_6db7, 5); call(0x1009_c7e0, 0x5a24);              /* call 0x1009c7e0 */
            ii(0x1009_6dbc, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_6dbf, 5); call(0x1009_c73c, 0x5978);              /* call 0x1009c73c */
            ii(0x1009_6dc4, 3); mov(ebx, memd[ss, ebp - 0xc]);          /* mov ebx, [ebp-0xc] */
            ii(0x1009_6dc7, 3); add(ebx, 0x21);                         /* add ebx, 0x21 */
            ii(0x1009_6dca, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6dcc, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_6dce, 5); call(0x1009_c698, 0x58c5);              /* call 0x1009c698 */
            ii(0x1009_6dd3, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_6dd6, 5); call(0x1009_c73c, 0x5961);              /* call 0x1009c73c */
            ii(0x1009_6ddb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6ddd, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_6de2, 5); call(0x100a_4d50, 0xdf69);              /* call 0x100a4d50 */
            ii(0x1009_6de7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6de9, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_6dec, 5); call(0x1009_b9ec, 0x4bfb);              /* call 0x1009b9ec */
            ii(0x1009_6df1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6df3, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_6df6, 5); call(0x1009_ba6c, 0x4c71);              /* call 0x1009ba6c */
        l_0x1009_6dfb:
            ii(0x1009_6dfb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_6dfd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_6dfe, 1); pop(edi);                               /* pop edi */
            ii(0x1009_6dff, 1); pop(esi);                               /* pop esi */
            ii(0x1009_6e00, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_6e01, 1); ret();                                  /* ret */
        }
    }
}
