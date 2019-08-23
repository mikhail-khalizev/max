using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_8b93-6bf114f7")]
        public void Method_100f_8b93()
        {
            ii(0x100f_8b93, 5); push(0x38);                             /* push 0x38 */
            ii(0x100f_8b98, 5); call(Definitions.sys_check_available_stack_size, 0x6_d1b5); /* call 0x10165d52 */
            ii(0x100f_8b9d, 1); push(ebx);                              /* push ebx */
            ii(0x100f_8b9e, 1); push(ecx);                              /* push ecx */
            ii(0x100f_8b9f, 1); push(edx);                              /* push edx */
            ii(0x100f_8ba0, 1); push(esi);                              /* push esi */
            ii(0x100f_8ba1, 1); push(edi);                              /* push edi */
            ii(0x100f_8ba2, 1); push(ebp);                              /* push ebp */
            ii(0x100f_8ba3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_8ba5, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100f_8bab, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_8bae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_8bb0, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x100f_8bb5, 5); call(0x1013_ad71, 0x4_21b7);            /* call 0x1013ad71 */
            ii(0x100f_8bba, 2); test(al, al);                           /* test al, al */
            ii(0x100f_8bbc, 2); if(jz(0x100f_8bc7, 0x9)) goto l_0x100f_8bc7; /* jz 0x100f8bc7 */
            ii(0x100f_8bbe, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100f_8bc5, 2); jmp(0x100f_8be0, 0x19); goto l_0x100f_8be0; /* jmp 0x100f8be0 */
        l_0x100f_8bc7:
            ii(0x100f_8bc7, 5); mov(ecx, 0x1052);                       /* mov ecx, 0x1052 */
            ii(0x100f_8bcc, 5); mov(ebx, StringDefinitions.GamemgrCpp9); /* mov ebx, 0x101a267c */
            ii(0x100f_8bd1, 5); mov(edx, StringDefinitions.TempTapeNotEqual02); /* mov edx, 0x101a2688 */
            ii(0x100f_8bd6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_8bd8, 5); call(Definitions.sys_assert, 0x6_d1b5); /* call 0x10165d92 */
            ii(0x100f_8bdd, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x100f_8be0:
            ii(0x100f_8be0, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x100f_8be5, 5); mov(ebx, 0x3e1);                        /* mov ebx, 0x3e1 */
            ii(0x100f_8bea, 5); mov(edx, 0x3de);                        /* mov edx, 0x3de */
            ii(0x100f_8bef, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_8bf4, 5); call(0x1013_daea, 0x4_4ef1);            /* call 0x1013daea */
            ii(0x100f_8bf9, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x100f_8bfe, 5); call(0x1007_6574, -0x8_268f);           /* call 0x10076574 */
            ii(0x100f_8c03, 4); mov(dx, memw[ds, eax + 0x1a]);          /* mov dx, [eax+0x1a] */
            ii(0x100f_8c07, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8c0a, 4); mov(memw[ds, eax + 0x41], dx);          /* mov [eax+0x41], dx */
            ii(0x100f_8c0e, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x100f_8c13, 5); call(0x1007_6574, -0x8_26a4);           /* call 0x10076574 */
            ii(0x100f_8c18, 4); mov(dx, memw[ds, eax + 0x1c]);          /* mov dx, [eax+0x1c] */
            ii(0x100f_8c1c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8c1f, 4); mov(memw[ds, eax + 0x43], dx);          /* mov [eax+0x43], dx */
            ii(0x100f_8c23, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x100f_8c28, 5); call(0x1007_6600, -0x8_262d);           /* call 0x10076600 */
            ii(0x100f_8c2d, 5); call(0x1015_f2cc, 0x6_669a);            /* call 0x1015f2cc */
            ii(0x100f_8c32, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_8c34, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x100f_8c39, 5); call(0x1007_6630, -0x8_260e);           /* call 0x10076630 */
            ii(0x100f_8c3e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_8c40, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8c43, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x100f_8c46, 5); call(0x1007_6a34, -0x8_2217);           /* call 0x10076a34 */
            ii(0x100f_8c4b, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_8c52, 2); if(jz(0x100f_8c5c, 0x8)) goto l_0x100f_8c5c; /* jz 0x100f8c5c */
            ii(0x100f_8c54, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8c57, 5); call(0x1012_ae8d, 0x3_2231);            /* call 0x1012ae8d */
        l_0x100f_8c5c:
            ii(0x100f_8c5c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8c5f, 5); cmp(memw[ds, eax + 0x8], 0x3d);         /* cmp word [eax+0x8], 0x3d */
            ii(0x100f_8c64, 2); if(jnz(0x100f_8c88, 0x22)) goto l_0x100f_8c88; /* jnz 0x100f8c88 */
            ii(0x100f_8c66, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8c69, 4); mov(dx, memw[ds, eax + 0x1a]);          /* mov dx, [eax+0x1a] */
            ii(0x100f_8c6d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8c70, 4); cmp(dx, memw[ds, eax + 0x41]);          /* cmp dx, [eax+0x41] */
            ii(0x100f_8c74, 2); if(jnz(0x100f_8c86, 0x10)) goto l_0x100f_8c86; /* jnz 0x100f8c86 */
            ii(0x100f_8c76, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8c79, 4); mov(dx, memw[ds, eax + 0x1c]);          /* mov dx, [eax+0x1c] */
            ii(0x100f_8c7d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8c80, 4); cmp(dx, memw[ds, eax + 0x43]);          /* cmp dx, [eax+0x43] */
            ii(0x100f_8c84, 2); if(jz(0x100f_8c88, 0x2)) goto l_0x100f_8c88; /* jz 0x100f8c88 */
        l_0x100f_8c86:
            ii(0x100f_8c86, 2); jmp(0x100f_8c8d, 0x5); goto l_0x100f_8c8d; /* jmp 0x100f8c8d */
        l_0x100f_8c88:
            ii(0x100f_8c88, 5); jmp(0x100f_8d31, 0xa4); goto l_0x100f_8d31; /* jmp 0x100f8d31 */
        l_0x100f_8c8d:
            ii(0x100f_8c8d, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x100f_8c92, 5); call(Definitions.sys_new, 0x6_d169);    /* call 0x10165e00 */
            ii(0x100f_8c97, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_8c9a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_8c9d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_8ca0, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_8ca4, 2); if(jz(0x100f_8ccb, 0x25)) goto l_0x100f_8ccb; /* jz 0x100f8ccb */
            ii(0x100f_8ca6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8ca9, 3); mov(ebx, memd[ds, eax + 0x41]);         /* mov ebx, [eax+0x41] */
            ii(0x100f_8cac, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_8caf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8cb2, 3); mov(edx, memd[ds, eax + 0x3f]);         /* mov edx, [eax+0x3f] */
            ii(0x100f_8cb5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_8cb8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_8cbb, 5); call(Definitions.my_ctor_c20, 0x2_1296); /* call 0x10119f56 */
            ii(0x100f_8cc0, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_8cc3, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_8cc6, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_8cc9, 2); jmp(0x100f_8cd1, 0x6); goto l_0x100f_8cd1; /* jmp 0x100f8cd1 */
        l_0x100f_8ccb:
            ii(0x100f_8ccb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_8cce, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x100f_8cd1:
            ii(0x100f_8cd1, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x100f_8cd4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8cd7, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x100f_8cda, 5); call(0x1007_6a34, -0x8_22ab);           /* call 0x10076a34 */
            ii(0x100f_8cdf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8ce2, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x100f_8ce5, 5); call(0x1007_69d8, -0x8_2312);           /* call 0x100769d8 */
            ii(0x100f_8cea, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_8ced, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_8cf0, 3); mov(ecx, memd[ds, eax + 0x2]);          /* mov ecx, [eax+0x2] */
            ii(0x100f_8cf3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8cf6, 4); mov(ax, memw[ds, eax + 0x43]);          /* mov ax, [eax+0x43] */
            ii(0x100f_8cfa, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_8cfd, 4); sub(ax, memw[ds, edx + 0x1c]);          /* sub ax, [edx+0x1c] */
            ii(0x100f_8d01, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_8d04, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8d07, 4); mov(ax, memw[ds, eax + 0x41]);          /* mov ax, [eax+0x41] */
            ii(0x100f_8d0b, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_8d0e, 4); sub(ax, memw[ds, edx + 0x1a]);          /* sub ax, [edx+0x1a] */
            ii(0x100f_8d12, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_8d15, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_8d18, 3); call_abs(memd[ds, ecx + 0x44]);         /* call dword [ecx+0x44] */
            ii(0x100f_8d1b, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_8d22, 2); if(jz(0x100f_8d2c, 0x8)) goto l_0x100f_8d2c; /* jz 0x100f8d2c */
            ii(0x100f_8d24, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8d27, 5); call(0x1012_ae8d, 0x3_2161);            /* call 0x1012ae8d */
        l_0x100f_8d2c:
            ii(0x100f_8d2c, 5); call(0x100f_f5c1, 0x6890);              /* call 0x100ff5c1 */
        l_0x100f_8d31:
            ii(0x100f_8d31, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8d34, 5); call(0x1016_3378, 0x6_a63f);            /* call 0x10163378 */
            ii(0x100f_8d39, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8d3c, 5); call(0x1010_19b8, 0x8c77);              /* call 0x101019b8 */
            ii(0x100f_8d41, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_8d43, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_8d44, 1); pop(edi);                               /* pop edi */
            ii(0x100f_8d45, 1); pop(esi);                               /* pop esi */
            ii(0x100f_8d46, 1); pop(edx);                               /* pop edx */
            ii(0x100f_8d47, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_8d48, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_8d49, 1); ret();                                  /* ret */
        }
    }
}
