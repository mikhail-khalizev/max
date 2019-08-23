using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_4c63-424f7146")]
        public void Method_1016_4c63()
        {
            ii(0x1016_4c63, 5); push(0x138);                            /* push 0x138 */
            ii(0x1016_4c68, 5); call(Definitions.sys_check_available_stack_size, 0x10e5); /* call 0x10165d52 */
            ii(0x1016_4c6d, 1); push(ebx);                              /* push ebx */
            ii(0x1016_4c6e, 1); push(ecx);                              /* push ecx */
            ii(0x1016_4c6f, 1); push(esi);                              /* push esi */
            ii(0x1016_4c70, 1); push(edi);                              /* push edi */
            ii(0x1016_4c71, 1); push(ebp);                              /* push ebp */
            ii(0x1016_4c72, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4c74, 6); sub(esp, 0x108);                        /* sub esp, 0x108 */
            ii(0x1016_4c7a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_4c7d, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_4c80, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1016_4c85, 5); mov(edx, 0x6cc);                        /* mov edx, 0x6cc */
            ii(0x1016_4c8a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4c8d, 5); call(0x100d_68a3, -0x8_e3ef);           /* call 0x100d68a3 */
            ii(0x1016_4c92, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_4c95, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1016_4c98, 6); mov(memd[ss, ebp - 0xb8], eax);         /* mov [ebp-0xb8], eax */
            ii(0x1016_4c9e, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_4ca1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_4ca3, 3); mov(al, memb[ds, edx + 0x26]);          /* mov al, [edx+0x26] */
            ii(0x1016_4ca6, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4ca9, 4); mov(memw[ds, edx + 0x41], ax);          /* mov [edx+0x41], ax */
            ii(0x1016_4cad, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4cb0, 7); mov(memd[ds, eax + 0x13], 0x101b_75b8); /* mov dword [eax+0x13], 0x101b75b8 */
            ii(0x1016_4cb7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_4cba, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4cbd, 3); mov(memd[ds, edx + 0x19], eax);         /* mov [edx+0x19], eax */
            ii(0x1016_4cc0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_4cc3, 5); call(0x1007_611c, -0xe_ebac);           /* call 0x1007611c */
            ii(0x1016_4cc8, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4ccb, 3); mov(memd[ds, edx + 0x1d], eax);         /* mov [edx+0x1d], eax */
            ii(0x1016_4cce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4cd1, 4); mov(memb[ds, eax + 0x70], 0);           /* mov byte [eax+0x70], 0x0 */
            ii(0x1016_4cd5, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1016_4cda, 5); call(0x1012_0d94, -0x4_3f4b);           /* call 0x10120d94 */
            ii(0x1016_4cdf, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1016_4ce4, 5); call(/* sys */ 0x1016_a24c, 0x5563);    /* call 0x1016a24c */
            ii(0x1016_4ce9, 3); lea(ecx, memd[ss, ebp - 0x10]);         /* lea ecx, [ebp-0x10] */
            ii(0x1016_4cec, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1016_4cef, 3); add(ebx, 0x43);                         /* add ebx, 0x43 */
            ii(0x1016_4cf2, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4cf5, 3); mov(edx, memd[ds, edx + 0x1d]);         /* mov edx, [edx+0x1d] */
            ii(0x1016_4cf8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4cfb, 3); mov(eax, memd[ds, eax + 0x19]);         /* mov eax, [eax+0x19] */
            ii(0x1016_4cfe, 5); call(0x1016_4b5c, -0x1a7);              /* call 0x10164b5c */
            ii(0x1016_4d03, 3); lea(ecx, memd[ss, ebp - 0x14]);         /* lea ecx, [ebp-0x14] */
            ii(0x1016_4d06, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1016_4d09, 3); add(ebx, 0x45);                         /* add ebx, 0x45 */
            ii(0x1016_4d0c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4d0f, 3); mov(edx, memd[ds, edx + 0x19]);         /* mov edx, [edx+0x19] */
            ii(0x1016_4d12, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4d15, 3); mov(eax, memd[ds, eax + 0x1d]);         /* mov eax, [eax+0x1d] */
            ii(0x1016_4d18, 5); call(0x1016_4b5c, -0x1c1);              /* call 0x10164b5c */
            ii(0x1016_4d1d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4d20, 4); mov(ax, memw[ds, eax + 0x45]);          /* mov ax, [eax+0x45] */
            ii(0x1016_4d24, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1016_4d27, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1016_4d2a, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_4d2c, 4); mov(memw[ds, ebx + 0x17], dx);          /* mov [ebx+0x17], dx */
            ii(0x1016_4d30, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4d33, 3); mov(edx, memd[ds, edx + 0x41]);         /* mov edx, [edx+0x41] */
            ii(0x1016_4d36, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_4d39, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4d3c, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1016_4d3f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_4d42, 5); call(Definitions.my_min, -0xd_b5c3);    /* call 0x10089784 */
            ii(0x1016_4d47, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4d4a, 4); mov(memw[ds, edx + 0x17], ax);          /* mov [edx+0x17], ax */
            ii(0x1016_4d4e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4d51, 4); mov(ax, memw[ds, eax + 0x43]);          /* mov ax, [eax+0x43] */
            ii(0x1016_4d55, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1016_4d58, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1016_4d5b, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_4d5d, 4); mov(memw[ds, ebx + 0x3d], dx);          /* mov [ebx+0x3d], dx */
            ii(0x1016_4d61, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4d64, 3); mov(edx, memd[ds, edx + 0x43]);         /* mov edx, [edx+0x43] */
            ii(0x1016_4d67, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_4d6a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4d6d, 3); mov(eax, memd[ds, eax + 0x3b]);         /* mov eax, [eax+0x3b] */
            ii(0x1016_4d70, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_4d73, 5); call(Definitions.my_min, -0xd_b5f4);    /* call 0x10089784 */
            ii(0x1016_4d78, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4d7b, 4); mov(memw[ds, edx + 0x3d], ax);          /* mov [edx+0x3d], ax */
            ii(0x1016_4d7f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4d82, 3); mov(eax, memd[ds, eax + 0x19]);         /* mov eax, [eax+0x19] */
            ii(0x1016_4d85, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1016_4d88, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_4d8b, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1016_4d8e, 6); mov(al, memb[ds, eax + 0x101c_81d5]);   /* mov al, [eax+0x101c81d5] */
            ii(0x1016_4d94, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1016_4d97, 2); jmp(0x1016_4dbc, 0x23); goto l_0x1016_4dbc; /* jmp 0x10164dbc */
        l_0x1016_4d99:
            ii(0x1016_4d99, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4d9c, 6); mov(memw[ds, eax + 0x21], 0x21e);       /* mov word [eax+0x21], 0x21e */
            ii(0x1016_4da2, 2); jmp(0x1016_4ded, 0x49); goto l_0x1016_4ded; /* jmp 0x10164ded */
        l_0x1016_4da4:
            ii(0x1016_4da4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4da7, 6); mov(memw[ds, eax + 0x21], 0x21f);       /* mov word [eax+0x21], 0x21f */
            ii(0x1016_4dad, 2); jmp(0x1016_4ded, 0x3e); goto l_0x1016_4ded; /* jmp 0x10164ded */
        l_0x1016_4daf:
            ii(0x1016_4daf, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4db2, 6); mov(memw[ds, eax + 0x21], 0x220);       /* mov word [eax+0x21], 0x220 */
            ii(0x1016_4db8, 2); jmp(0x1016_4ded, 0x33); goto l_0x1016_4ded; /* jmp 0x10164ded */
        l_0x1016_4dba:
            ii(0x1016_4dba, 2); jmp(0x1016_4ded, 0x31); goto l_0x1016_4ded; /* jmp 0x10164ded */
        l_0x1016_4dbc:
            ii(0x1016_4dbc, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1016_4dbf, 6); mov(memb[ss, ebp - 0xc0], al);          /* mov [ebp-0xc0], al */
            ii(0x1016_4dc5, 7); cmp(memb[ss, ebp - 0xc0], 0x2);         /* cmp byte [ebp-0xc0], 0x2 */
            ii(0x1016_4dcc, 2); if(jb(0x1016_4de2, 0x14)) goto l_0x1016_4de2; /* jb 0x10164de2 */
            ii(0x1016_4dce, 7); cmp(memb[ss, ebp - 0xc0], 0x2);         /* cmp byte [ebp-0xc0], 0x2 */
            ii(0x1016_4dd5, 2); if(jbe(0x1016_4da4, -0x33)) goto l_0x1016_4da4; /* jbe 0x10164da4 */
            ii(0x1016_4dd7, 7); cmp(memb[ss, ebp - 0xc0], 0x3);         /* cmp byte [ebp-0xc0], 0x3 */
            ii(0x1016_4dde, 2); if(jz(0x1016_4daf, -0x31)) goto l_0x1016_4daf; /* jz 0x10164daf */
            ii(0x1016_4de0, 2); jmp(0x1016_4dba, -0x28); goto l_0x1016_4dba; /* jmp 0x10164dba */
        l_0x1016_4de2:
            ii(0x1016_4de2, 7); cmp(memb[ss, ebp - 0xc0], 0x1);         /* cmp byte [ebp-0xc0], 0x1 */
            ii(0x1016_4de9, 2); if(jz(0x1016_4d99, -0x52)) goto l_0x1016_4d99; /* jz 0x10164d99 */
            ii(0x1016_4deb, 2); jmp(0x1016_4dba, -0x33); goto l_0x1016_4dba; /* jmp 0x10164dba */
        l_0x1016_4ded:
            ii(0x1016_4ded, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4df0, 4); mov(dx, memw[ds, eax + 0x17]);          /* mov dx, [eax+0x17] */
            ii(0x1016_4df4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4df7, 4); mov(memw[ds, eax + 0x3f], dx);          /* mov [eax+0x3f], dx */
            ii(0x1016_4dfb, 5); call(0x100d_6124, -0x8_ecdc);           /* call 0x100d6124 */
            ii(0x1016_4e00, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_4e02, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_4e04, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4e07, 5); call(0x100d_6adf, -0x8_e32d);           /* call 0x100d6adf */
            ii(0x1016_4e0c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4e0f, 3); add(edx, 0x23);                         /* add edx, 0x23 */
            ii(0x1016_4e12, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4e15, 5); call(0x100d_6a11, -0x8_e409);           /* call 0x100d6a11 */
            ii(0x1016_4e1a, 5); call(0x100f_fc13, -0x6_520c);           /* call 0x100ffc13 */
            ii(0x1016_4e1f, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1016_4e24, 5); call(Definitions.sys_new, 0xfd7);       /* call 0x10165e00 */
            ii(0x1016_4e29, 6); mov(memd[ss, ebp - 0xac], eax);         /* mov [ebp-0xac], eax */
            ii(0x1016_4e2f, 6); mov(eax, memd[ss, ebp - 0xac]);         /* mov eax, [ebp-0xac] */
            ii(0x1016_4e35, 6); mov(memd[ss, ebp - 0xb0], eax);         /* mov [ebp-0xb0], eax */
            ii(0x1016_4e3b, 7); cmp(memd[ss, ebp - 0xb0], 0);           /* cmp dword [ebp-0xb0], 0x0 */
            ii(0x1016_4e42, 2); if(jz(0x1016_4e78, 0x34)) goto l_0x1016_4e78; /* jz 0x10164e78 */
            ii(0x1016_4e44, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1016_4e49, 1); push(eax);                              /* push eax */
            ii(0x1016_4e4a, 5); mov(ecx, 0x1d);                         /* mov ecx, 0x1d */
            ii(0x1016_4e4f, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1016_4e54, 5); mov(edx, 0x8d);                         /* mov edx, 0x8d */
            ii(0x1016_4e59, 6); mov(eax, memd[ss, ebp - 0xac]);         /* mov eax, [ebp-0xac] */
            ii(0x1016_4e5f, 5); call(0x100d_7bdc, -0x8_d288);           /* call 0x100d7bdc */
            ii(0x1016_4e64, 6); mov(memd[ss, ebp - 0xb4], eax);         /* mov [ebp-0xb4], eax */
            ii(0x1016_4e6a, 6); mov(eax, memd[ss, ebp - 0xb4]);         /* mov eax, [ebp-0xb4] */
            ii(0x1016_4e70, 6); mov(memd[ss, ebp - 0xc4], eax);         /* mov [ebp-0xc4], eax */
            ii(0x1016_4e76, 2); jmp(0x1016_4e84, 0xc); goto l_0x1016_4e84; /* jmp 0x10164e84 */
        l_0x1016_4e78:
            ii(0x1016_4e78, 6); mov(eax, memd[ss, ebp - 0xb0]);         /* mov eax, [ebp-0xb0] */
            ii(0x1016_4e7e, 6); mov(memd[ss, ebp - 0xc4], eax);         /* mov [ebp-0xc4], eax */
        l_0x1016_4e84:
            ii(0x1016_4e84, 6); mov(eax, memd[ss, ebp - 0xc4]);         /* mov eax, [ebp-0xc4] */
            ii(0x1016_4e8a, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4e8d, 3); mov(memd[ds, edx + 0x64], eax);         /* mov [edx+0x64], eax */
            ii(0x1016_4e90, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4e93, 3); add(edx, 0x23);                         /* add edx, 0x23 */
            ii(0x1016_4e96, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4e99, 3); mov(eax, memd[ds, eax + 0x64]);         /* mov eax, [eax+0x64] */
            ii(0x1016_4e9c, 5); call(0x100d_7d74, -0x8_d12d);           /* call 0x100d7d74 */
            ii(0x1016_4ea1, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1016_4ea6, 5); call(Definitions.sys_new, 0xf55);       /* call 0x10165e00 */
            ii(0x1016_4eab, 6); mov(memd[ss, ebp - 0xa0], eax);         /* mov [ebp-0xa0], eax */
            ii(0x1016_4eb1, 6); mov(eax, memd[ss, ebp - 0xa0]);         /* mov eax, [ebp-0xa0] */
            ii(0x1016_4eb7, 6); mov(memd[ss, ebp - 0xa4], eax);         /* mov [ebp-0xa4], eax */
            ii(0x1016_4ebd, 7); cmp(memd[ss, ebp - 0xa4], 0);           /* cmp dword [ebp-0xa4], 0x0 */
            ii(0x1016_4ec4, 2); if(jz(0x1016_4efa, 0x34)) goto l_0x1016_4efa; /* jz 0x10164efa */
            ii(0x1016_4ec6, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1016_4ecb, 1); push(eax);                              /* push eax */
            ii(0x1016_4ecc, 5); mov(ecx, 0x3c);                         /* mov ecx, 0x3c */
            ii(0x1016_4ed1, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1016_4ed6, 5); mov(edx, 0x1c);                         /* mov edx, 0x1c */
            ii(0x1016_4edb, 6); mov(eax, memd[ss, ebp - 0xa0]);         /* mov eax, [ebp-0xa0] */
            ii(0x1016_4ee1, 5); call(0x100d_7bdc, -0x8_d30a);           /* call 0x100d7bdc */
            ii(0x1016_4ee6, 6); mov(memd[ss, ebp - 0xa8], eax);         /* mov [ebp-0xa8], eax */
            ii(0x1016_4eec, 6); mov(eax, memd[ss, ebp - 0xa8]);         /* mov eax, [ebp-0xa8] */
            ii(0x1016_4ef2, 6); mov(memd[ss, ebp - 0xc8], eax);         /* mov [ebp-0xc8], eax */
            ii(0x1016_4ef8, 2); jmp(0x1016_4f06, 0xc); goto l_0x1016_4f06; /* jmp 0x10164f06 */
        l_0x1016_4efa:
            ii(0x1016_4efa, 6); mov(eax, memd[ss, ebp - 0xa4]);         /* mov eax, [ebp-0xa4] */
            ii(0x1016_4f00, 6); mov(memd[ss, ebp - 0xc8], eax);         /* mov [ebp-0xc8], eax */
        l_0x1016_4f06:
            ii(0x1016_4f06, 6); mov(eax, memd[ss, ebp - 0xc8]);         /* mov eax, [ebp-0xc8] */
            ii(0x1016_4f0c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4f0f, 3); mov(memd[ds, edx + 0x68], eax);         /* mov [edx+0x68], eax */
            ii(0x1016_4f12, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4f15, 3); add(edx, 0x23);                         /* add edx, 0x23 */
            ii(0x1016_4f18, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4f1b, 3); mov(eax, memd[ds, eax + 0x68]);         /* mov eax, [eax+0x68] */
            ii(0x1016_4f1e, 5); call(0x100d_7d74, -0x8_d1af);           /* call 0x100d7d74 */
            ii(0x1016_4f23, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1016_4f28, 5); call(Definitions.sys_new, 0xed3);       /* call 0x10165e00 */
            ii(0x1016_4f2d, 6); mov(memd[ss, ebp - 0x94], eax);         /* mov [ebp-0x94], eax */
            ii(0x1016_4f33, 6); mov(eax, memd[ss, ebp - 0x94]);         /* mov eax, [ebp-0x94] */
            ii(0x1016_4f39, 6); mov(memd[ss, ebp - 0x98], eax);         /* mov [ebp-0x98], eax */
            ii(0x1016_4f3f, 7); cmp(memd[ss, ebp - 0x98], 0);           /* cmp dword [ebp-0x98], 0x0 */
            ii(0x1016_4f46, 2); if(jz(0x1016_4f7c, 0x34)) goto l_0x1016_4f7c; /* jz 0x10164f7c */
            ii(0x1016_4f48, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1016_4f4d, 1); push(eax);                              /* push eax */
            ii(0x1016_4f4e, 5); mov(ecx, 0x3c);                         /* mov ecx, 0x3c */
            ii(0x1016_4f53, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1016_4f58, 5); mov(edx, 0xdf);                         /* mov edx, 0xdf */
            ii(0x1016_4f5d, 6); mov(eax, memd[ss, ebp - 0x94]);         /* mov eax, [ebp-0x94] */
            ii(0x1016_4f63, 5); call(0x100d_7bdc, -0x8_d38c);           /* call 0x100d7bdc */
            ii(0x1016_4f68, 6); mov(memd[ss, ebp - 0x9c], eax);         /* mov [ebp-0x9c], eax */
            ii(0x1016_4f6e, 6); mov(eax, memd[ss, ebp - 0x9c]);         /* mov eax, [ebp-0x9c] */
            ii(0x1016_4f74, 6); mov(memd[ss, ebp - 0xcc], eax);         /* mov [ebp-0xcc], eax */
            ii(0x1016_4f7a, 2); jmp(0x1016_4f88, 0xc); goto l_0x1016_4f88; /* jmp 0x10164f88 */
        l_0x1016_4f7c:
            ii(0x1016_4f7c, 6); mov(eax, memd[ss, ebp - 0x98]);         /* mov eax, [ebp-0x98] */
            ii(0x1016_4f82, 6); mov(memd[ss, ebp - 0xcc], eax);         /* mov [ebp-0xcc], eax */
        l_0x1016_4f88:
            ii(0x1016_4f88, 6); mov(eax, memd[ss, ebp - 0xcc]);         /* mov eax, [ebp-0xcc] */
            ii(0x1016_4f8e, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4f91, 3); mov(memd[ds, edx + 0x6c], eax);         /* mov [edx+0x6c], eax */
            ii(0x1016_4f94, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4f97, 3); add(edx, 0x23);                         /* add edx, 0x23 */
            ii(0x1016_4f9a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4f9d, 3); mov(eax, memd[ds, eax + 0x6c]);         /* mov eax, [eax+0x6c] */
            ii(0x1016_4fa0, 5); call(0x100d_7d74, -0x8_d231);           /* call 0x100d7d74 */
            ii(0x1016_4fa5, 5); mov(eax, 0x2f);                         /* mov eax, 0x2f */
            ii(0x1016_4faa, 5); call(Definitions.sys_new, 0xe51);       /* call 0x10165e00 */
            ii(0x1016_4faf, 6); mov(memd[ss, ebp - 0x88], eax);         /* mov [ebp-0x88], eax */
            ii(0x1016_4fb5, 6); mov(eax, memd[ss, ebp - 0x88]);         /* mov eax, [ebp-0x88] */
            ii(0x1016_4fbb, 6); mov(memd[ss, ebp - 0x8c], eax);         /* mov [ebp-0x8c], eax */
            ii(0x1016_4fc1, 7); cmp(memd[ss, ebp - 0x8c], 0);           /* cmp dword [ebp-0x8c], 0x0 */
            ii(0x1016_4fc8, 6); if(jz(0x1016_5059, 0x8b)) goto l_0x1016_5059; /* jz 0x10165059 */
            ii(0x1016_4fce, 5); call(0x1016_5d04, 0xd31);               /* call 0x10165d04 */
            ii(0x1016_4fd3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_4fd8, 1); push(eax);                              /* push eax */
            ii(0x1016_4fd9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_4fdb, 1); push(eax);                              /* push eax */
            ii(0x1016_4fdc, 5); push(0x3ea);                            /* push 0x3ea */
            ii(0x1016_4fe1, 5); push(0x3e9);                            /* push 0x3e9 */
            ii(0x1016_4fe6, 5); push(0x3e8);                            /* push 0x3e8 */
            ii(0x1016_4feb, 5); mov(eax, 0x21e);                        /* mov eax, 0x21e */
            ii(0x1016_4ff0, 1); push(eax);                              /* push eax */
            ii(0x1016_4ff1, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x1016_4ff6, 1); push(eax);                              /* push eax */
            ii(0x1016_4ff7, 5); mov(ecx, 0xaa);                         /* mov ecx, 0xaa */
            ii(0x1016_4ffc, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1016_5001, 5); mov(edx, 0x8d);                         /* mov edx, 0x8d */
            ii(0x1016_5006, 6); lea(eax, memd[ss, ebp - 0xdc]);         /* lea eax, [ebp-0xdc] */
            ii(0x1016_500c, 5); call(0x1008_b148, -0xd_9ec9);           /* call 0x1008b148 */
            ii(0x1016_5011, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_5013, 5); mov(eax, 0x69);                         /* mov eax, 0x69 */
            ii(0x1016_5018, 1); push(eax);                              /* push eax */
            ii(0x1016_5019, 5); mov(ecx, 0x10b);                        /* mov ecx, 0x10b */
            ii(0x1016_501e, 5); mov(ebx, 0x59);                         /* mov ebx, 0x59 */
            ii(0x1016_5023, 5); mov(edx, 0x2c);                         /* mov edx, 0x2c */
            ii(0x1016_5028, 6); lea(eax, memd[ss, ebp - 0xec]);         /* lea eax, [ebp-0xec] */
            ii(0x1016_502e, 5); call(0x1008_b148, -0xd_9eeb);           /* call 0x1008b148 */
            ii(0x1016_5033, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_5035, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_5038, 6); mov(eax, memd[ss, ebp - 0x88]);         /* mov eax, [ebp-0x88] */
            ii(0x1016_503e, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_5040, 5); call(0x100d_7706, -0x8_d93f);           /* call 0x100d7706 */
            ii(0x1016_5045, 6); mov(memd[ss, ebp - 0x90], eax);         /* mov [ebp-0x90], eax */
            ii(0x1016_504b, 6); mov(eax, memd[ss, ebp - 0x90]);         /* mov eax, [ebp-0x90] */
            ii(0x1016_5051, 6); mov(memd[ss, ebp - 0xf0], eax);         /* mov [ebp-0xf0], eax */
            ii(0x1016_5057, 2); jmp(0x1016_5065, 0xc); goto l_0x1016_5065; /* jmp 0x10165065 */
        l_0x1016_5059:
            ii(0x1016_5059, 6); mov(eax, memd[ss, ebp - 0x8c]);         /* mov eax, [ebp-0x8c] */
            ii(0x1016_505f, 6); mov(memd[ss, ebp - 0xf0], eax);         /* mov [ebp-0xf0], eax */
        l_0x1016_5065:
            ii(0x1016_5065, 6); mov(eax, memd[ss, ebp - 0xf0]);         /* mov eax, [ebp-0xf0] */
            ii(0x1016_506b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_506e, 3); mov(memd[ds, edx + 0x60], eax);         /* mov [edx+0x60], eax */
            ii(0x1016_5071, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1016_5076, 5); call(Definitions.sys_new, 0xd85);       /* call 0x10165e00 */
            ii(0x1016_507b, 3); mov(memd[ss, ebp - 0x7c], eax);         /* mov [ebp-0x7c], eax */
            ii(0x1016_507e, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x1016_5081, 3); mov(memd[ss, ebp - 0x80], eax);         /* mov [ebp-0x80], eax */
            ii(0x1016_5084, 4); cmp(memd[ss, ebp - 0x80], 0);           /* cmp dword [ebp-0x80], 0x0 */
            ii(0x1016_5088, 2); if(jz(0x1016_50bb, 0x31)) goto l_0x1016_50bb; /* jz 0x101650bb */
            ii(0x1016_508a, 5); mov(eax, 0x59);                         /* mov eax, 0x59 */
            ii(0x1016_508f, 1); push(eax);                              /* push eax */
            ii(0x1016_5090, 5); mov(ecx, 0x116);                        /* mov ecx, 0x116 */
            ii(0x1016_5095, 5); mov(ebx, 0x151);                        /* mov ebx, 0x151 */
            ii(0x1016_509a, 5); mov(edx, 0x150);                        /* mov edx, 0x150 */
            ii(0x1016_509f, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x1016_50a2, 5); call(Definitions.my_ctor_c17, -0x9_6c98); /* call 0x100ce40f */
            ii(0x1016_50a7, 6); mov(memd[ss, ebp - 0x84], eax);         /* mov [ebp-0x84], eax */
            ii(0x1016_50ad, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1016_50b3, 6); mov(memd[ss, ebp - 0xf4], eax);         /* mov [ebp-0xf4], eax */
            ii(0x1016_50b9, 2); jmp(0x1016_50c4, 0x9); goto l_0x1016_50c4; /* jmp 0x101650c4 */
        l_0x1016_50bb:
            ii(0x1016_50bb, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x1016_50be, 6); mov(memd[ss, ebp - 0xf4], eax);         /* mov [ebp-0xf4], eax */
        l_0x1016_50c4:
            ii(0x1016_50c4, 6); mov(eax, memd[ss, ebp - 0xf4]);         /* mov eax, [ebp-0xf4] */
            ii(0x1016_50ca, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_50cd, 3); mov(memd[ds, edx + 0x54], eax);         /* mov [edx+0x54], eax */
            ii(0x1016_50d0, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1016_50d5, 5); call(Definitions.sys_new, 0xd26);       /* call 0x10165e00 */
            ii(0x1016_50da, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x1016_50dd, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x1016_50e0, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
            ii(0x1016_50e3, 4); cmp(memd[ss, ebp - 0x74], 0);           /* cmp dword [ebp-0x74], 0x0 */
            ii(0x1016_50e7, 2); if(jz(0x1016_5114, 0x2b)) goto l_0x1016_5114; /* jz 0x10165114 */
            ii(0x1016_50e9, 5); mov(eax, 0x59);                         /* mov eax, 0x59 */
            ii(0x1016_50ee, 1); push(eax);                              /* push eax */
            ii(0x1016_50ef, 5); mov(ecx, 0x11);                         /* mov ecx, 0x11 */
            ii(0x1016_50f4, 5); mov(ebx, 0x153);                        /* mov ebx, 0x153 */
            ii(0x1016_50f9, 5); mov(edx, 0x152);                        /* mov edx, 0x152 */
            ii(0x1016_50fe, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x1016_5101, 5); call(Definitions.my_ctor_c17, -0x9_6cf7); /* call 0x100ce40f */
            ii(0x1016_5106, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
            ii(0x1016_5109, 3); mov(eax, memd[ss, ebp - 0x78]);         /* mov eax, [ebp-0x78] */
            ii(0x1016_510c, 6); mov(memd[ss, ebp - 0xf8], eax);         /* mov [ebp-0xf8], eax */
            ii(0x1016_5112, 2); jmp(0x1016_511d, 0x9); goto l_0x1016_511d; /* jmp 0x1016511d */
        l_0x1016_5114:
            ii(0x1016_5114, 3); mov(eax, memd[ss, ebp - 0x74]);         /* mov eax, [ebp-0x74] */
            ii(0x1016_5117, 6); mov(memd[ss, ebp - 0xf8], eax);         /* mov [ebp-0xf8], eax */
        l_0x1016_511d:
            ii(0x1016_511d, 6); mov(eax, memd[ss, ebp - 0xf8]);         /* mov eax, [ebp-0xf8] */
            ii(0x1016_5123, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_5126, 3); mov(memd[ds, edx + 0x58], eax);         /* mov [edx+0x58], eax */
            ii(0x1016_5129, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1016_512e, 5); call(Definitions.sys_new, 0xccd);       /* call 0x10165e00 */
            ii(0x1016_5133, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
            ii(0x1016_5136, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x1016_5139, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x1016_513c, 4); cmp(memd[ss, ebp - 0x68], 0);           /* cmp dword [ebp-0x68], 0x0 */
            ii(0x1016_5140, 2); if(jz(0x1016_516d, 0x2b)) goto l_0x1016_516d; /* jz 0x1016516d */
            ii(0x1016_5142, 5); mov(eax, 0x7d);                         /* mov eax, 0x7d */
            ii(0x1016_5147, 1); push(eax);                              /* push eax */
            ii(0x1016_5148, 5); mov(ecx, 0x52);                         /* mov ecx, 0x52 */
            ii(0x1016_514d, 5); mov(ebx, 0x14f);                        /* mov ebx, 0x14f */
            ii(0x1016_5152, 5); mov(edx, 0x14e);                        /* mov edx, 0x14e */
            ii(0x1016_5157, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x1016_515a, 5); call(Definitions.my_ctor_c17, -0x9_6d50); /* call 0x100ce40f */
            ii(0x1016_515f, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x1016_5162, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x1016_5165, 6); mov(memd[ss, ebp - 0xfc], eax);         /* mov [ebp-0xfc], eax */
            ii(0x1016_516b, 2); jmp(0x1016_5176, 0x9); goto l_0x1016_5176; /* jmp 0x10165176 */
        l_0x1016_516d:
            ii(0x1016_516d, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1016_5170, 6); mov(memd[ss, ebp - 0xfc], eax);         /* mov [ebp-0xfc], eax */
        l_0x1016_5176:
            ii(0x1016_5176, 6); mov(eax, memd[ss, ebp - 0xfc]);         /* mov eax, [ebp-0xfc] */
            ii(0x1016_517c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_517f, 3); mov(memd[ds, edx + 0x48], eax);         /* mov [edx+0x48], eax */
            ii(0x1016_5182, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1016_5187, 5); call(Definitions.sys_new, 0xc74);       /* call 0x10165e00 */
            ii(0x1016_518c, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x1016_518f, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1016_5192, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1016_5195, 4); cmp(memd[ss, ebp - 0x5c], 0);           /* cmp dword [ebp-0x5c], 0x0 */
            ii(0x1016_5199, 2); if(jz(0x1016_51c6, 0x2b)) goto l_0x1016_51c6; /* jz 0x101651c6 */
            ii(0x1016_519b, 5); mov(eax, 0x7d);                         /* mov eax, 0x7d */
            ii(0x1016_51a0, 1); push(eax);                              /* push eax */
            ii(0x1016_51a1, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x1016_51a6, 5); mov(ebx, 0x14b);                        /* mov ebx, 0x14b */
            ii(0x1016_51ab, 5); mov(edx, 0x14a);                        /* mov edx, 0x14a */
            ii(0x1016_51b0, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1016_51b3, 5); call(Definitions.my_ctor_c17, -0x9_6da9); /* call 0x100ce40f */
            ii(0x1016_51b8, 3); mov(memd[ss, ebp - 0x60], eax);         /* mov [ebp-0x60], eax */
            ii(0x1016_51bb, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x1016_51be, 6); mov(memd[ss, ebp - 0x100], eax);        /* mov [ebp-0x100], eax */
            ii(0x1016_51c4, 2); jmp(0x1016_51cf, 0x9); goto l_0x1016_51cf; /* jmp 0x101651cf */
        l_0x1016_51c6:
            ii(0x1016_51c6, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1016_51c9, 6); mov(memd[ss, ebp - 0x100], eax);        /* mov [ebp-0x100], eax */
        l_0x1016_51cf:
            ii(0x1016_51cf, 6); mov(eax, memd[ss, ebp - 0x100]);        /* mov eax, [ebp-0x100] */
            ii(0x1016_51d5, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_51d8, 3); mov(memd[ds, edx + 0x4c], eax);         /* mov [edx+0x4c], eax */
            ii(0x1016_51db, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1016_51e0, 5); call(Definitions.sys_new, 0xc1b);       /* call 0x10165e00 */
            ii(0x1016_51e5, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1016_51e8, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1016_51eb, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1016_51ee, 4); cmp(memd[ss, ebp - 0x50], 0);           /* cmp dword [ebp-0x50], 0x0 */
            ii(0x1016_51f2, 2); if(jz(0x1016_521f, 0x2b)) goto l_0x1016_521f; /* jz 0x1016521f */
            ii(0x1016_51f4, 5); mov(eax, 0x7d);                         /* mov eax, 0x7d */
            ii(0x1016_51f9, 1); push(eax);                              /* push eax */
            ii(0x1016_51fa, 5); mov(ecx, 0x93);                         /* mov ecx, 0x93 */
            ii(0x1016_51ff, 5); mov(ebx, 0x14d);                        /* mov ebx, 0x14d */
            ii(0x1016_5204, 5); mov(edx, 0x14c);                        /* mov edx, 0x14c */
            ii(0x1016_5209, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1016_520c, 5); call(Definitions.my_ctor_c17, -0x9_6e02); /* call 0x100ce40f */
            ii(0x1016_5211, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x1016_5214, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1016_5217, 6); mov(memd[ss, ebp - 0x104], eax);        /* mov [ebp-0x104], eax */
            ii(0x1016_521d, 2); jmp(0x1016_5228, 0x9); goto l_0x1016_5228; /* jmp 0x10165228 */
        l_0x1016_521f:
            ii(0x1016_521f, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x1016_5222, 6); mov(memd[ss, ebp - 0x104], eax);        /* mov [ebp-0x104], eax */
        l_0x1016_5228:
            ii(0x1016_5228, 6); mov(eax, memd[ss, ebp - 0x104]);        /* mov eax, [ebp-0x104] */
            ii(0x1016_522e, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_5231, 3); mov(memd[ds, edx + 0x50], eax);         /* mov [edx+0x50], eax */
            ii(0x1016_5234, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1016_5239, 5); call(Definitions.sys_new, 0xbc2);       /* call 0x10165e00 */
            ii(0x1016_523e, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1016_5241, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1016_5244, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1016_5247, 4); cmp(memd[ss, ebp - 0x44], 0);           /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1016_524b, 2); if(jz(0x1016_5278, 0x2b)) goto l_0x1016_5278; /* jz 0x10165278 */
            ii(0x1016_524d, 5); mov(eax, 0x2b);                         /* mov eax, 0x2b */
            ii(0x1016_5252, 1); push(eax);                              /* push eax */
            ii(0x1016_5253, 5); mov(ecx, 0x8d);                         /* mov ecx, 0x8d */
            ii(0x1016_5258, 5); mov(ebx, 0x155);                        /* mov ebx, 0x155 */
            ii(0x1016_525d, 5); mov(edx, 0x154);                        /* mov edx, 0x154 */
            ii(0x1016_5262, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1016_5265, 5); call(Definitions.my_ctor_c17, -0x9_6e5b); /* call 0x100ce40f */
            ii(0x1016_526a, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1016_526d, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1016_5270, 6); mov(memd[ss, ebp - 0x108], eax);        /* mov [ebp-0x108], eax */
            ii(0x1016_5276, 2); jmp(0x1016_5281, 0x9); goto l_0x1016_5281; /* jmp 0x10165281 */
        l_0x1016_5278:
            ii(0x1016_5278, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1016_527b, 6); mov(memd[ss, ebp - 0x108], eax);        /* mov [ebp-0x108], eax */
        l_0x1016_5281:
            ii(0x1016_5281, 6); mov(eax, memd[ss, ebp - 0x108]);        /* mov eax, [ebp-0x108] */
            ii(0x1016_5287, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_528a, 3); mov(memd[ds, edx + 0x5c], eax);         /* mov [edx+0x5c], eax */
            ii(0x1016_528d, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1016_5290, 5); call(0x100d_5224, -0x9_0071);           /* call 0x100d5224 */
            ii(0x1016_5295, 1); push(eax);                              /* push eax */
            ii(0x1016_5296, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1016_5299, 5); call(0x100d_5250, -0x9_004e);           /* call 0x100d5250 */
            ii(0x1016_529e, 1); push(eax);                              /* push eax */
            ii(0x1016_529f, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x1016_52a2, 5); call(0x100d_527c, -0x9_002b);           /* call 0x100d527c */
            ii(0x1016_52a7, 1); push(eax);                              /* push eax */
            ii(0x1016_52a8, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1016_52ab, 5); call(0x100d_52a8, -0x9_0008);           /* call 0x100d52a8 */
            ii(0x1016_52b0, 1); push(eax);                              /* push eax */
            ii(0x1016_52b1, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1016_52b6, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_52bb, 5); mov(edx, StringDefinitions.Done6);      /* mov edx, 0x101b2cd8 */
            ii(0x1016_52c0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_52c3, 3); mov(eax, memd[ds, eax + 0x4c]);         /* mov eax, [eax+0x4c] */
            ii(0x1016_52c6, 5); call(0x100c_ef64, -0x9_6367);           /* call 0x100cef64 */
            ii(0x1016_52cb, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1016_52ce, 5); call(0x100d_5224, -0x9_00af);           /* call 0x100d5224 */
            ii(0x1016_52d3, 1); push(eax);                              /* push eax */
            ii(0x1016_52d4, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x1016_52d7, 5); call(0x100d_5250, -0x9_008c);           /* call 0x100d5250 */
            ii(0x1016_52dc, 1); push(eax);                              /* push eax */
            ii(0x1016_52dd, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1016_52e0, 5); call(0x100d_527c, -0x9_0069);           /* call 0x100d527c */
            ii(0x1016_52e5, 1); push(eax);                              /* push eax */
            ii(0x1016_52e6, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1016_52e9, 5); call(0x100d_52a8, -0x9_0046);           /* call 0x100d52a8 */
            ii(0x1016_52ee, 1); push(eax);                              /* push eax */
            ii(0x1016_52ef, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1016_52f4, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_52f9, 5); mov(edx, StringDefinitions.Cancel7);    /* mov edx, 0x101b2cdd */
            ii(0x1016_52fe, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5301, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x1016_5304, 5); call(0x100c_ef64, -0x9_63a5);           /* call 0x100cef64 */
            ii(0x1016_5309, 5); mov(edx, 0x3e8);                        /* mov edx, 0x3e8 */
            ii(0x1016_530e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5311, 3); mov(eax, memd[ds, eax + 0x54]);         /* mov eax, [eax+0x54] */
            ii(0x1016_5314, 5); call(0x100d_5164, -0x9_01b5);           /* call 0x100d5164 */
            ii(0x1016_5319, 5); mov(edx, 0x3e9);                        /* mov edx, 0x3e9 */
            ii(0x1016_531e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5321, 3); mov(eax, memd[ds, eax + 0x58]);         /* mov eax, [eax+0x58] */
            ii(0x1016_5324, 5); call(0x100d_5164, -0x9_01c5);           /* call 0x100d5164 */
            ii(0x1016_5329, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1016_532e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5331, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x1016_5334, 5); call(0x100d_5134, -0x9_0205);           /* call 0x100d5134 */
            ii(0x1016_5339, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1016_533e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5341, 3); mov(eax, memd[ds, eax + 0x4c]);         /* mov eax, [eax+0x4c] */
            ii(0x1016_5344, 5); call(0x100d_5134, -0x9_0215);           /* call 0x100d5134 */
            ii(0x1016_5349, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x1016_534e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5351, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1016_5354, 5); call(0x100d_5134, -0x9_0225);           /* call 0x100d5134 */
            ii(0x1016_5359, 5); mov(edx, 0x701b);                       /* mov edx, 0x701b */
            ii(0x1016_535e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5361, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x1016_5364, 5); call(0x100d_5164, -0x9_0205);           /* call 0x100d5164 */
            ii(0x1016_5369, 5); mov(edx, 0x700d);                       /* mov edx, 0x700d */
            ii(0x1016_536e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5371, 3); mov(eax, memd[ds, eax + 0x4c]);         /* mov eax, [eax+0x4c] */
            ii(0x1016_5374, 5); call(0x100d_5164, -0x9_0215);           /* call 0x100d5164 */
            ii(0x1016_5379, 5); mov(edx, 0x703f);                       /* mov edx, 0x703f */
            ii(0x1016_537e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5381, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1016_5384, 5); call(0x100d_5164, -0x9_0225);           /* call 0x100d5164 */
            ii(0x1016_5389, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x1016_538e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5391, 3); mov(eax, memd[ds, eax + 0x54]);         /* mov eax, [eax+0x54] */
            ii(0x1016_5394, 5); call(0x100d_50d4, -0x9_02c5);           /* call 0x100d50d4 */
            ii(0x1016_5399, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x1016_539e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_53a1, 3); mov(eax, memd[ds, eax + 0x58]);         /* mov eax, [eax+0x58] */
            ii(0x1016_53a4, 5); call(0x100d_50d4, -0x9_02d5);           /* call 0x100d50d4 */
            ii(0x1016_53a9, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x1016_53ae, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_53b1, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x1016_53b4, 5); call(0x100d_50d4, -0x9_02e5);           /* call 0x100d50d4 */
            ii(0x1016_53b9, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x1016_53be, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_53c1, 3); mov(eax, memd[ds, eax + 0x4c]);         /* mov eax, [eax+0x4c] */
            ii(0x1016_53c4, 5); call(0x100d_50d4, -0x9_02f5);           /* call 0x100d50d4 */
            ii(0x1016_53c9, 5); mov(edx, 0x4e5);                        /* mov edx, 0x4e5 */
            ii(0x1016_53ce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_53d1, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1016_53d4, 5); call(0x100d_50d4, -0x9_0305);           /* call 0x100d50d4 */
            ii(0x1016_53d9, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_53dc, 3); mov(edx, memd[ds, edx + 0x35]);         /* mov edx, [edx+0x35] */
            ii(0x1016_53df, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_53e2, 3); mov(eax, memd[ds, eax + 0x54]);         /* mov eax, [eax+0x54] */
            ii(0x1016_53e5, 5); call(0x100c_f85c, -0x9_5b8e);           /* call 0x100cf85c */
            ii(0x1016_53ea, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_53ed, 3); mov(edx, memd[ds, edx + 0x35]);         /* mov edx, [edx+0x35] */
            ii(0x1016_53f0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_53f3, 3); mov(eax, memd[ds, eax + 0x58]);         /* mov eax, [eax+0x58] */
            ii(0x1016_53f6, 5); call(0x100c_f85c, -0x9_5b9f);           /* call 0x100cf85c */
            ii(0x1016_53fb, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_53fe, 3); mov(edx, memd[ds, edx + 0x35]);         /* mov edx, [edx+0x35] */
            ii(0x1016_5401, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5404, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x1016_5407, 5); call(0x100c_f85c, -0x9_5bb0);           /* call 0x100cf85c */
            ii(0x1016_540c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_540f, 3); mov(edx, memd[ds, edx + 0x35]);         /* mov edx, [edx+0x35] */
            ii(0x1016_5412, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5415, 3); mov(eax, memd[ds, eax + 0x4c]);         /* mov eax, [eax+0x4c] */
            ii(0x1016_5418, 5); call(0x100c_f85c, -0x9_5bc1);           /* call 0x100cf85c */
            ii(0x1016_541d, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_5420, 3); mov(edx, memd[ds, edx + 0x35]);         /* mov edx, [edx+0x35] */
            ii(0x1016_5423, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5426, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1016_5429, 5); call(0x100c_f85c, -0x9_5bd2);           /* call 0x100cf85c */
            ii(0x1016_542e, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_5433, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5436, 3); mov(eax, memd[ds, eax + 0x5c]);         /* mov eax, [eax+0x5c] */
            ii(0x1016_5439, 5); call(0x100d_5194, -0x9_02aa);           /* call 0x100d5194 */
            ii(0x1016_543e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5441, 3); mov(edx, memd[ds, eax + 0x35]);         /* mov edx, [eax+0x35] */
            ii(0x1016_5444, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5447, 3); mov(eax, memd[ds, eax + 0x5c]);         /* mov eax, [eax+0x5c] */
            ii(0x1016_544a, 5); call(0x100c_f85c, -0x9_5bf3);           /* call 0x100cf85c */
            ii(0x1016_544f, 5); mov(edx, 0x154);                        /* mov edx, 0x154 */
            ii(0x1016_5454, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5457, 3); mov(eax, memd[ds, eax + 0x5c]);         /* mov eax, [eax+0x5c] */
            ii(0x1016_545a, 5); call(0x100c_f2ba, -0x9_61a5);           /* call 0x100cf2ba */
            ii(0x1016_545f, 5); mov(edx, 0x155);                        /* mov edx, 0x155 */
            ii(0x1016_5464, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5467, 3); mov(eax, memd[ds, eax + 0x5c]);         /* mov eax, [eax+0x5c] */
            ii(0x1016_546a, 5); call(0x100c_f363, -0x9_610c);           /* call 0x100cf363 */
            ii(0x1016_546f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5472, 3); mov(eax, memd[ds, eax + 0x60]);         /* mov eax, [eax+0x60] */
            ii(0x1016_5475, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1016_5478, 3); mov(edx, memd[ss, ebp - 0x3c]);         /* mov edx, [ebp-0x3c] */
            ii(0x1016_547b, 3); mov(edx, memd[ds, edx + 0x27]);         /* mov edx, [edx+0x27] */
            ii(0x1016_547e, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1016_5481, 3); call_abs(memd[ds, edx + 0x4]);          /* call dword [edx+0x4] */
            ii(0x1016_5484, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_5487, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1016_548a, 4); sub(ax, memw[ds, edx + 0x45]);          /* sub ax, [edx+0x45] */
            ii(0x1016_548e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_5491, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5494, 3); mov(eax, memd[ds, eax + 0x60]);         /* mov eax, [eax+0x60] */
            ii(0x1016_5497, 5); call(0x100d_6f8b, -0x8_e511);           /* call 0x100d6f8b */
            ii(0x1016_549c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_549f, 4); mov(ax, memw[ds, eax + 0x45]);          /* mov ax, [eax+0x45] */
            ii(0x1016_54a3, 2); neg(eax);                               /* neg eax */
            ii(0x1016_54a5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_54a8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_54ab, 3); mov(eax, memd[ds, eax + 0x60]);         /* mov eax, [eax+0x60] */
            ii(0x1016_54ae, 5); call(0x100d_6f5c, -0x8_e557);           /* call 0x100d6f5c */
            ii(0x1016_54b3, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_54b6, 3); mov(edx, memd[ds, edx + 0x3d]);         /* mov edx, [edx+0x3d] */
            ii(0x1016_54b9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_54bc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_54bf, 3); mov(eax, memd[ds, eax + 0x60]);         /* mov eax, [eax+0x60] */
            ii(0x1016_54c2, 5); call(0x100d_778a, -0x8_dd3d);           /* call 0x100d778a */
            ii(0x1016_54c7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_54ca, 4); mov(ax, memw[ds, eax + 0x3d]);          /* mov ax, [eax+0x3d] */
            ii(0x1016_54ce, 2); neg(eax);                               /* neg eax */
            ii(0x1016_54d0, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_54d3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_54d6, 3); mov(eax, memd[ds, eax + 0x60]);         /* mov eax, [eax+0x60] */
            ii(0x1016_54d9, 5); call(0x100d_77b9, -0x8_dd25);           /* call 0x100d77b9 */
            ii(0x1016_54de, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_54e1, 3); mov(edx, memd[ds, edx + 0x3d]);         /* mov edx, [edx+0x3d] */
            ii(0x1016_54e4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_54e7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_54ea, 3); mov(eax, memd[ds, eax + 0x60]);         /* mov eax, [eax+0x60] */
            ii(0x1016_54ed, 5); call(0x100d_6f2d, -0x8_e5c5);           /* call 0x100d6f2d */
            ii(0x1016_54f2, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_54f5, 3); mov(edx, memd[ds, edx + 0x1f]);         /* mov edx, [edx+0x1f] */
            ii(0x1016_54f8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_54fb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_54fe, 3); mov(eax, memd[ds, eax + 0x60]);         /* mov eax, [eax+0x60] */
            ii(0x1016_5501, 5); call(0x100e_0adc, -0x8_4a2a);           /* call 0x100e0adc */
            ii(0x1016_5506, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5509, 3); mov(eax, memd[ds, eax + 0x60]);         /* mov eax, [eax+0x60] */
            ii(0x1016_550c, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1016_550f, 3); mov(edx, memd[ss, ebp - 0x38]);         /* mov edx, [ebp-0x38] */
            ii(0x1016_5512, 3); mov(edx, memd[ds, edx + 0x27]);         /* mov edx, [edx+0x27] */
            ii(0x1016_5515, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1016_5518, 3); call_abs(memd[ds, edx + 0x8]);          /* call dword [edx+0x8] */
            ii(0x1016_551b, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1016_5520, 1); push(eax);                              /* push eax */
            ii(0x1016_5521, 5); mov(eax, 0x68);                         /* mov eax, 0x68 */
            ii(0x1016_5526, 1); push(eax);                              /* push eax */
            ii(0x1016_5527, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_5529, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1016_552e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1016_5531, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1016_5534, 3); mov(ebx, memd[ds, ebx + 0x19]);         /* mov ebx, [ebx+0x19] */
            ii(0x1016_5537, 3); mov(ebx, memd[ds, ebx + 0x6]);          /* mov ebx, [ebx+0x6] */
            ii(0x1016_553a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_553d, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_5540, 3); mov(edx, memd[ds, edx + 0x31]);         /* mov edx, [edx+0x31] */
            ii(0x1016_5543, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_5546, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5549, 3); mov(eax, memd[ds, eax + 0x39]);         /* mov eax, [eax+0x39] */
            ii(0x1016_554c, 5); call(0x1012_b6af, -0x3_9ea2);           /* call 0x1012b6af */
            ii(0x1016_5551, 5); call(0x100d_531c, -0x9_023a);           /* call 0x100d531c */
            ii(0x1016_5556, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_555b, 1); push(eax);                              /* push eax */
            ii(0x1016_555c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1016_5561, 1); push(eax);                              /* push eax */
            ii(0x1016_5562, 2); push(0);                                /* push 0x0 */
            ii(0x1016_5564, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1016_5569, 1); push(eax);                              /* push eax */
            ii(0x1016_556a, 5); mov(eax, 0x6e);                         /* mov eax, 0x6e */
            ii(0x1016_556f, 1); push(eax);                              /* push eax */
            ii(0x1016_5570, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
            ii(0x1016_5575, 1); push(eax);                              /* push eax */
            ii(0x1016_5576, 5); mov(ecx, 0xa);                          /* mov ecx, 0xa */
            ii(0x1016_557b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_557e, 3); mov(eax, memd[ds, eax + 0x19]);         /* mov eax, [eax+0x19] */
            ii(0x1016_5581, 3); mov(ebx, memd[ds, eax + 0x6]);          /* mov ebx, [eax+0x6] */
            ii(0x1016_5584, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_5587, 3); imul(ebx, ebx, 0x33);                   /* imul ebx, ebx, 0x33 */
            ii(0x1016_558a, 6); mov(ebx, memd[ds, ebx + 0x101c_81d7]);  /* mov ebx, [ebx+0x101c81d7] */
            ii(0x1016_5590, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_5593, 3); mov(edx, memd[ds, edx + 0x31]);         /* mov edx, [edx+0x31] */
            ii(0x1016_5596, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_5599, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_559c, 3); mov(eax, memd[ds, eax + 0x39]);         /* mov eax, [eax+0x39] */
            ii(0x1016_559f, 5); call(0x100e_9ae5, -0x7_babf);           /* call 0x100e9ae5 */
            ii(0x1016_55a4, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1016_55a9, 1); push(eax);                              /* push eax */
            ii(0x1016_55aa, 5); mov(eax, 0xcf);                         /* mov eax, 0xcf */
            ii(0x1016_55af, 1); push(eax);                              /* push eax */
            ii(0x1016_55b0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_55b2, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1016_55b7, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1016_55ba, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_55bd, 3); mov(eax, memd[ds, eax + 0x1d]);         /* mov eax, [eax+0x1d] */
            ii(0x1016_55c0, 3); mov(ebx, memd[ds, eax + 0x6]);          /* mov ebx, [eax+0x6] */
            ii(0x1016_55c3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_55c6, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_55c9, 3); mov(edx, memd[ds, edx + 0x31]);         /* mov edx, [edx+0x31] */
            ii(0x1016_55cc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_55cf, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_55d2, 3); mov(eax, memd[ds, eax + 0x39]);         /* mov eax, [eax+0x39] */
            ii(0x1016_55d5, 5); call(0x1012_b6af, -0x3_9f2b);           /* call 0x1012b6af */
            ii(0x1016_55da, 5); call(0x100d_531c, -0x9_02c3);           /* call 0x100d531c */
            ii(0x1016_55df, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_55e4, 1); push(eax);                              /* push eax */
            ii(0x1016_55e5, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1016_55ea, 1); push(eax);                              /* push eax */
            ii(0x1016_55eb, 2); push(0);                                /* push 0x0 */
            ii(0x1016_55ed, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1016_55f2, 1); push(eax);                              /* push eax */
            ii(0x1016_55f3, 5); mov(eax, 0x6e);                         /* mov eax, 0x6e */
            ii(0x1016_55f8, 1); push(eax);                              /* push eax */
            ii(0x1016_55f9, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
            ii(0x1016_55fe, 1); push(eax);                              /* push eax */
            ii(0x1016_55ff, 5); mov(ecx, 0xbf);                         /* mov ecx, 0xbf */
            ii(0x1016_5604, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5607, 3); mov(eax, memd[ds, eax + 0x1d]);         /* mov eax, [eax+0x1d] */
            ii(0x1016_560a, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1016_560d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_5610, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1016_5613, 6); mov(ebx, memd[ds, eax + 0x101c_81d7]);  /* mov ebx, [eax+0x101c81d7] */
            ii(0x1016_5619, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_561c, 3); mov(edx, memd[ds, edx + 0x31]);         /* mov edx, [edx+0x31] */
            ii(0x1016_561f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_5622, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5625, 3); mov(eax, memd[ds, eax + 0x39]);         /* mov eax, [eax+0x39] */
            ii(0x1016_5628, 5); call(0x100e_9ae5, -0x7_bb48);           /* call 0x100e9ae5 */
            ii(0x1016_562d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5630, 5); call(0x1016_585f, 0x22a);               /* call 0x1016585f */
            ii(0x1016_5635, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5638, 6); mov(memd[ss, ebp - 0xbc], eax);         /* mov [ebp-0xbc], eax */
            ii(0x1016_563e, 6); mov(eax, memd[ss, ebp - 0xbc]);         /* mov eax, [ebp-0xbc] */
            ii(0x1016_5644, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_5646, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_5647, 1); pop(edi);                               /* pop edi */
            ii(0x1016_5648, 1); pop(esi);                               /* pop esi */
            ii(0x1016_5649, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_564a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_564b, 1); ret();                                  /* ret */
        }
    }
}
