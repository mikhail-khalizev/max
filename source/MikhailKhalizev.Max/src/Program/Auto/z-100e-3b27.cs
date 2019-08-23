using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_3b27-9b72a8db")]
        public void Method_100e_3b27()
        {
            ii(0x100e_3b27, 5); push(0x7c);                             /* push 0x7c */
            ii(0x100e_3b2c, 5); call(Definitions.sys_check_available_stack_size, 0x8_2221); /* call 0x10165d52 */
            ii(0x100e_3b31, 1); push(ebx);                              /* push ebx */
            ii(0x100e_3b32, 1); push(ecx);                              /* push ecx */
            ii(0x100e_3b33, 1); push(edx);                              /* push edx */
            ii(0x100e_3b34, 1); push(esi);                              /* push esi */
            ii(0x100e_3b35, 1); push(edi);                              /* push edi */
            ii(0x100e_3b36, 1); push(ebp);                              /* push ebp */
            ii(0x100e_3b37, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_3b39, 6); sub(esp, 0x60);                         /* sub esp, 0x60 */
            ii(0x100e_3b3f, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_3b42, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3b45, 4); mov(memb[ds, eax + 0x17], 0x1);         /* mov byte [eax+0x17], 0x1 */
            ii(0x100e_3b49, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3b4c, 3); mov(eax, memd[ds, eax + 0x26]);         /* mov eax, [eax+0x26] */
            ii(0x100e_3b4f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_3b52, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_3b54, 6); if(jle(0x100e_3dfc, 0x2a2)) goto l_0x100e_3dfc; /* jle 0x100e3dfc */
            ii(0x100e_3b5a, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100e_3b61, 2); jmp(0x100e_3b69, 0x6); goto l_0x100e_3b69; /* jmp 0x100e3b69 */
        l_0x100e_3b63:
            ii(0x100e_3b63, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_3b66, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
        l_0x100e_3b69:
            ii(0x100e_3b69, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_3b6c, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_3b6f, 4); cmp(ax, memw[ds, edx + 0x28]);          /* cmp ax, [edx+0x28] */
            ii(0x100e_3b73, 2); if(jge(0x100e_3bb9, 0x44)) goto l_0x100e_3bb9; /* jge 0x100e3bb9 */
            ii(0x100e_3b75, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_3b79, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_3b7c, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x100e_3b7f, 3); mov(eax, memd[ds, eax + 0x2c]);         /* mov eax, [eax+0x2c] */
            ii(0x100e_3b82, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_3b85, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100e_3b89, 2); if(jz(0x100e_3b9f, 0x14)) goto l_0x100e_3b9f; /* jz 0x100e3b9f */
            ii(0x100e_3b8b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3b8d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_3b90, 5); call(Definitions.my_dtor_d5, -0x279b);  /* call 0x100e13fa */
            ii(0x100e_3b95, 5); call(Definitions.sys_delete, 0x8_23ca); /* call 0x10165f64 */
            ii(0x100e_3b9a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_3b9d, 2); jmp(0x100e_3ba6, 0x7); goto l_0x100e_3ba6; /* jmp 0x100e3ba6 */
        l_0x100e_3b9f:
            ii(0x100e_3b9f, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x100e_3ba6:
            ii(0x100e_3ba6, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_3baa, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_3bad, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x100e_3bb0, 7); mov(memd[ds, eax + 0x2c], 0);           /* mov dword [eax+0x2c], 0x0 */
            ii(0x100e_3bb7, 2); jmp(0x100e_3b63, -0x56); goto l_0x100e_3b63; /* jmp 0x100e3b63 */
        l_0x100e_3bb9:
            ii(0x100e_3bb9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3bbc, 6); mov(memw[ds, eax + 0x28], 0);           /* mov word [eax+0x28], 0x0 */
            ii(0x100e_3bc2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3bc5, 4); cmp(memd[ds, eax + 0x44], 0);           /* cmp dword [eax+0x44], 0x0 */
            ii(0x100e_3bc9, 2); if(jz(0x100e_3c33, 0x68)) goto l_0x100e_3c33; /* jz 0x100e3c33 */
            ii(0x100e_3bcb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3bce, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100e_3bd1, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_3bd4, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100e_3bd8, 2); if(jz(0x100e_3bee, 0x14)) goto l_0x100e_3bee; /* jz 0x100e3bee */
            ii(0x100e_3bda, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3bdc, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_3bdf, 5); call(Definitions.my_dtor_d3, -0xbeb1);  /* call 0x100d7d33 */
            ii(0x100e_3be4, 5); call(Definitions.sys_delete, 0x8_237b); /* call 0x10165f64 */
            ii(0x100e_3be9, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_3bec, 2); jmp(0x100e_3bf5, 0x7); goto l_0x100e_3bf5; /* jmp 0x100e3bf5 */
        l_0x100e_3bee:
            ii(0x100e_3bee, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x100e_3bf5:
            ii(0x100e_3bf5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3bf8, 7); mov(memd[ds, eax + 0x44], 0);           /* mov dword [eax+0x44], 0x0 */
            ii(0x100e_3bff, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3c02, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x100e_3c05, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100e_3c08, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100e_3c0c, 2); if(jz(0x100e_3c22, 0x14)) goto l_0x100e_3c22; /* jz 0x100e3c22 */
            ii(0x100e_3c0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3c10, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_3c13, 5); call(Definitions.my_dtor_d3, -0xbee5);  /* call 0x100d7d33 */
            ii(0x100e_3c18, 5); call(Definitions.sys_delete, 0x8_2347); /* call 0x10165f64 */
            ii(0x100e_3c1d, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100e_3c20, 2); jmp(0x100e_3c29, 0x7); goto l_0x100e_3c29; /* jmp 0x100e3c29 */
        l_0x100e_3c22:
            ii(0x100e_3c22, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x100e_3c29:
            ii(0x100e_3c29, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3c2c, 7); mov(memd[ds, eax + 0x48], 0);           /* mov dword [eax+0x48], 0x0 */
        l_0x100e_3c33:
            ii(0x100e_3c33, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3c36, 4); cmp(memd[ds, eax + 0x4c], 0);           /* cmp dword [eax+0x4c], 0x0 */
            ii(0x100e_3c3a, 2); if(jz(0x100e_3c66, 0x2a)) goto l_0x100e_3c66; /* jz 0x100e3c66 */
            ii(0x100e_3c3c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3c3f, 3); mov(eax, memd[ds, eax + 0x4c]);         /* mov eax, [eax+0x4c] */
            ii(0x100e_3c42, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100e_3c45, 4); cmp(memd[ss, ebp - 0x24], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100e_3c49, 2); if(jz(0x100e_3c5f, 0x14)) goto l_0x100e_3c5f; /* jz 0x100e3c5f */
            ii(0x100e_3c4b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3c4d, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100e_3c50, 5); call(Definitions.my_dtor_d2, -0x1_571d); /* call 0x100ce538 */
            ii(0x100e_3c55, 5); call(Definitions.sys_delete, 0x8_230a); /* call 0x10165f64 */
            ii(0x100e_3c5a, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100e_3c5d, 2); jmp(0x100e_3c66, 0x7); goto l_0x100e_3c66; /* jmp 0x100e3c66 */
        l_0x100e_3c5f:
            ii(0x100e_3c5f, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
        l_0x100e_3c66:
            ii(0x100e_3c66, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3c69, 7); mov(memd[ds, eax + 0x4c], 0);           /* mov dword [eax+0x4c], 0x0 */
            ii(0x100e_3c70, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3c73, 4); cmp(memd[ds, eax + 0x50], 0);           /* cmp dword [eax+0x50], 0x0 */
            ii(0x100e_3c77, 6); if(jz(0x100e_3d19, 0x9c)) goto l_0x100e_3d19; /* jz 0x100e3d19 */
            ii(0x100e_3c7d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3c80, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x100e_3c83, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100e_3c86, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x100e_3c8a, 2); if(jz(0x100e_3ca0, 0x14)) goto l_0x100e_3ca0; /* jz 0x100e3ca0 */
            ii(0x100e_3c8c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3c8e, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100e_3c91, 5); call(Definitions.my_dtor_d2, -0x1_575e); /* call 0x100ce538 */
            ii(0x100e_3c96, 5); call(Definitions.sys_delete, 0x8_22c9); /* call 0x10165f64 */
            ii(0x100e_3c9b, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100e_3c9e, 2); jmp(0x100e_3ca7, 0x7); goto l_0x100e_3ca7; /* jmp 0x100e3ca7 */
        l_0x100e_3ca0:
            ii(0x100e_3ca0, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
        l_0x100e_3ca7:
            ii(0x100e_3ca7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3caa, 7); mov(memd[ds, eax + 0x50], 0);           /* mov dword [eax+0x50], 0x0 */
            ii(0x100e_3cb1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3cb4, 3); mov(eax, memd[ds, eax + 0x54]);         /* mov eax, [eax+0x54] */
            ii(0x100e_3cb7, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100e_3cba, 4); cmp(memd[ss, ebp - 0x34], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100e_3cbe, 2); if(jz(0x100e_3cd4, 0x14)) goto l_0x100e_3cd4; /* jz 0x100e3cd4 */
            ii(0x100e_3cc0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3cc2, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100e_3cc5, 5); call(Definitions.my_dtor_d2, -0x1_5792); /* call 0x100ce538 */
            ii(0x100e_3cca, 5); call(Definitions.sys_delete, 0x8_2295); /* call 0x10165f64 */
            ii(0x100e_3ccf, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100e_3cd2, 2); jmp(0x100e_3cdb, 0x7); goto l_0x100e_3cdb; /* jmp 0x100e3cdb */
        l_0x100e_3cd4:
            ii(0x100e_3cd4, 7); mov(memd[ss, ebp - 0x38], 0);           /* mov dword [ebp-0x38], 0x0 */
        l_0x100e_3cdb:
            ii(0x100e_3cdb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3cde, 7); mov(memd[ds, eax + 0x54], 0);           /* mov dword [eax+0x54], 0x0 */
            ii(0x100e_3ce5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3ce8, 3); mov(eax, memd[ds, eax + 0x58]);         /* mov eax, [eax+0x58] */
            ii(0x100e_3ceb, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100e_3cee, 4); cmp(memd[ss, ebp - 0x3c], 0);           /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x100e_3cf2, 2); if(jz(0x100e_3d08, 0x14)) goto l_0x100e_3d08; /* jz 0x100e3d08 */
            ii(0x100e_3cf4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3cf6, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100e_3cf9, 5); call(Definitions.my_dtor_d2, -0x1_57c6); /* call 0x100ce538 */
            ii(0x100e_3cfe, 5); call(Definitions.sys_delete, 0x8_2261); /* call 0x10165f64 */
            ii(0x100e_3d03, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100e_3d06, 2); jmp(0x100e_3d0f, 0x7); goto l_0x100e_3d0f; /* jmp 0x100e3d0f */
        l_0x100e_3d08:
            ii(0x100e_3d08, 7); mov(memd[ss, ebp - 0x40], 0);           /* mov dword [ebp-0x40], 0x0 */
        l_0x100e_3d0f:
            ii(0x100e_3d0f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3d12, 7); mov(memd[ds, eax + 0x58], 0);           /* mov dword [eax+0x58], 0x0 */
        l_0x100e_3d19:
            ii(0x100e_3d19, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3d1c, 3); mov(eax, memd[ds, eax + 0x5c]);         /* mov eax, [eax+0x5c] */
            ii(0x100e_3d1f, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100e_3d22, 4); cmp(memd[ss, ebp - 0x44], 0);           /* cmp dword [ebp-0x44], 0x0 */
            ii(0x100e_3d26, 2); if(jz(0x100e_3d3c, 0x14)) goto l_0x100e_3d3c; /* jz 0x100e3d3c */
            ii(0x100e_3d28, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3d2a, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x100e_3d2d, 5); call(Definitions.my_dtor_d2, -0x1_57fa); /* call 0x100ce538 */
            ii(0x100e_3d32, 5); call(Definitions.sys_delete, 0x8_222d); /* call 0x10165f64 */
            ii(0x100e_3d37, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100e_3d3a, 2); jmp(0x100e_3d43, 0x7); goto l_0x100e_3d43; /* jmp 0x100e3d43 */
        l_0x100e_3d3c:
            ii(0x100e_3d3c, 7); mov(memd[ss, ebp - 0x48], 0);           /* mov dword [ebp-0x48], 0x0 */
        l_0x100e_3d43:
            ii(0x100e_3d43, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3d46, 7); mov(memd[ds, eax + 0x5c], 0);           /* mov dword [eax+0x5c], 0x0 */
            ii(0x100e_3d4d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3d50, 3); mov(eax, memd[ds, eax + 0x60]);         /* mov eax, [eax+0x60] */
            ii(0x100e_3d53, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100e_3d56, 4); cmp(memd[ss, ebp - 0x4c], 0);           /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x100e_3d5a, 2); if(jz(0x100e_3d70, 0x14)) goto l_0x100e_3d70; /* jz 0x100e3d70 */
            ii(0x100e_3d5c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3d5e, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x100e_3d61, 5); call(Definitions.my_dtor_d2, -0x1_582e); /* call 0x100ce538 */
            ii(0x100e_3d66, 5); call(Definitions.sys_delete, 0x8_21f9); /* call 0x10165f64 */
            ii(0x100e_3d6b, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x100e_3d6e, 2); jmp(0x100e_3d77, 0x7); goto l_0x100e_3d77; /* jmp 0x100e3d77 */
        l_0x100e_3d70:
            ii(0x100e_3d70, 7); mov(memd[ss, ebp - 0x50], 0);           /* mov dword [ebp-0x50], 0x0 */
        l_0x100e_3d77:
            ii(0x100e_3d77, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3d7a, 7); mov(memd[ds, eax + 0x60], 0);           /* mov dword [eax+0x60], 0x0 */
            ii(0x100e_3d81, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3d84, 3); mov(eax, memd[ds, eax + 0x64]);         /* mov eax, [eax+0x64] */
            ii(0x100e_3d87, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x100e_3d8a, 4); cmp(memd[ss, ebp - 0x54], 0);           /* cmp dword [ebp-0x54], 0x0 */
            ii(0x100e_3d8e, 2); if(jz(0x100e_3da4, 0x14)) goto l_0x100e_3da4; /* jz 0x100e3da4 */
            ii(0x100e_3d90, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3d92, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x100e_3d95, 5); call(Definitions.my_dtor_d2, -0x1_5862); /* call 0x100ce538 */
            ii(0x100e_3d9a, 5); call(Definitions.sys_delete, 0x8_21c5); /* call 0x10165f64 */
            ii(0x100e_3d9f, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x100e_3da2, 2); jmp(0x100e_3dab, 0x7); goto l_0x100e_3dab; /* jmp 0x100e3dab */
        l_0x100e_3da4:
            ii(0x100e_3da4, 7); mov(memd[ss, ebp - 0x58], 0);           /* mov dword [ebp-0x58], 0x0 */
        l_0x100e_3dab:
            ii(0x100e_3dab, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3dae, 7); mov(memd[ds, eax + 0x64], 0);           /* mov dword [eax+0x64], 0x0 */
            ii(0x100e_3db5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3db8, 3); mov(eax, memd[ds, eax + 0x68]);         /* mov eax, [eax+0x68] */
            ii(0x100e_3dbb, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100e_3dbe, 4); cmp(memd[ss, ebp - 0x5c], 0);           /* cmp dword [ebp-0x5c], 0x0 */
            ii(0x100e_3dc2, 2); if(jz(0x100e_3dd8, 0x14)) goto l_0x100e_3dd8; /* jz 0x100e3dd8 */
            ii(0x100e_3dc4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3dc6, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x100e_3dc9, 5); call(Definitions.my_dtor_d2, -0x1_5896); /* call 0x100ce538 */
            ii(0x100e_3dce, 5); call(Definitions.sys_delete, 0x8_2191); /* call 0x10165f64 */
            ii(0x100e_3dd3, 3); mov(memd[ss, ebp - 0x60], eax);         /* mov [ebp-0x60], eax */
            ii(0x100e_3dd6, 2); jmp(0x100e_3ddf, 0x7); goto l_0x100e_3ddf; /* jmp 0x100e3ddf */
        l_0x100e_3dd8:
            ii(0x100e_3dd8, 7); mov(memd[ss, ebp - 0x60], 0);           /* mov dword [ebp-0x60], 0x0 */
        l_0x100e_3ddf:
            ii(0x100e_3ddf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3de2, 7); mov(memd[ds, eax + 0x68], 0);           /* mov dword [eax+0x68], 0x0 */
            ii(0x100e_3de9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3dec, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_3dee, 5); call(/* sys */ 0x1016_6990, 0x8_2b9d);  /* call 0x10166990 */
            ii(0x100e_3df3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3df6, 6); mov(memd[ds, eax], 0);                  /* mov dword [eax], 0x0 */
        l_0x100e_3dfc:
            ii(0x100e_3dfc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_3dfe, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_3dff, 1); pop(edi);                               /* pop edi */
            ii(0x100e_3e00, 1); pop(esi);                               /* pop esi */
            ii(0x100e_3e01, 1); pop(edx);                               /* pop edx */
            ii(0x100e_3e02, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_3e03, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_3e04, 1); ret();                                  /* ret */
        }
    }
}
