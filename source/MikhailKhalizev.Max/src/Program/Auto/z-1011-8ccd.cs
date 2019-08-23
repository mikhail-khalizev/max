using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_8ccd-ab8cf378")]
        public void Method_1011_8ccd()
        {
            ii(0x1011_8ccd, 5); push(0x5c);                             /* push 0x5c */
            ii(0x1011_8cd2, 5); call(Definitions.sys_check_available_stack_size, 0x4_d07b); /* call 0x10165d52 */
            ii(0x1011_8cd7, 1); push(ebx);                              /* push ebx */
            ii(0x1011_8cd8, 1); push(ecx);                              /* push ecx */
            ii(0x1011_8cd9, 1); push(esi);                              /* push esi */
            ii(0x1011_8cda, 1); push(edi);                              /* push edi */
            ii(0x1011_8cdb, 1); push(ebp);                              /* push ebp */
            ii(0x1011_8cdc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_8cde, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1011_8ce4, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_8ce7, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_8cea, 4); or(memb[ss, ebp - 0x10], 0x1);          /* or byte [ebp-0x10], 0x1 */
            ii(0x1011_8cee, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_8cf1, 5); call(Definitions.my_ctor_0x101b_38f8, -0xa_2606); /* call 0x100766f0 */
            ii(0x1011_8cf6, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1011_8cf9, 4); and(memb[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
        l_0x1011_8cfd:
            ii(0x1011_8cfd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_8cff, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1011_8d04, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_8d07, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8d0a, 5); call(0x1007_6074, -0xa_2c9b);           /* call 0x10076074 */
            ii(0x1011_8d0f, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1011_8d12, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1011_8d16, 2); if(jz(0x1011_8d20, 0x8)) goto l_0x1011_8d20; /* jz 0x10118d20 */
            ii(0x1011_8d18, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8d1b, 5); call(0x1014_9fa8, 0x3_1288);            /* call 0x10149fa8 */
        l_0x1011_8d20:
            ii(0x1011_8d20, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8d23, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1011_8d27, 2); if(jz(0x1011_8d86, 0x5d)) goto l_0x1011_8d86; /* jz 0x10118d86 */
            ii(0x1011_8d29, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8d2c, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1011_8d2f, 3); mov(memb[ss, ebp - 0x38], al);          /* mov [ebp-0x38], al */
            ii(0x1011_8d32, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8d35, 4); cmp(memb[ds, eax + 0x4f], 0);           /* cmp byte [eax+0x4f], 0x0 */
            ii(0x1011_8d39, 2); if(jz(0x1011_8d46, 0xb)) goto l_0x1011_8d46; /* jz 0x10118d46 */
            ii(0x1011_8d3b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8d3e, 3); mov(al, memb[ds, eax + 0x4f]);          /* mov al, [eax+0x4f] */
            ii(0x1011_8d41, 2); dec(al);                                /* dec al */
            ii(0x1011_8d43, 3); mov(memb[ss, ebp - 0x38], al);          /* mov [ebp-0x38], al */
        l_0x1011_8d46:
            ii(0x1011_8d46, 4); cmp(memb[ss, ebp - 0x38], 0);           /* cmp byte [ebp-0x38], 0x0 */
            ii(0x1011_8d4a, 2); if(jz(0x1011_8d5b, 0xf)) goto l_0x1011_8d5b; /* jz 0x10118d5b */
            ii(0x1011_8d4c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8d4f, 3); mov(al, memb[ds, eax + 0x60]);          /* mov al, [eax+0x60] */
            ii(0x1011_8d52, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_8d57, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_8d59, 2); if(jnz(0x1011_8d86, 0x2b)) goto l_0x1011_8d86; /* jnz 0x10118d86 */
        l_0x1011_8d5b:
            ii(0x1011_8d5b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8d5e, 4); mov(memb[ds, eax + 0x3e], 0x1);         /* mov byte [eax+0x3e], 0x1 */
            ii(0x1011_8d62, 5); call(0x1012_0ab0, 0x7d49);              /* call 0x10120ab0 */
            ii(0x1011_8d67, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_8d69, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_8d6b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8d6e, 5); call(0x1014_eea8, 0x3_6135);            /* call 0x1014eea8 */
            ii(0x1011_8d73, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1011_8d77, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_8d79, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_8d7c, 5); call(0x1007_5f2c, -0xa_2e55);           /* call 0x10075f2c */
            ii(0x1011_8d81, 5); jmp(0x1011_912d, 0x3a7); goto l_0x1011_912d; /* jmp 0x1011912d */
        l_0x1011_8d86:
            ii(0x1011_8d86, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8d89, 3); mov(al, memb[ds, eax + 0x18]);          /* mov al, [eax+0x18] */
            ii(0x1011_8d8c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_8d8e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_8d91, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8d94, 5); call(0x1011_7fb8, -0xde1);              /* call 0x10117fb8 */
            ii(0x1011_8d99, 2); test(al, al);                           /* test al, al */
            ii(0x1011_8d9b, 6); if(jnz(0x1011_90e1, 0x340)) goto l_0x1011_90e1; /* jnz 0x101190e1 */
            ii(0x1011_8da1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8da4, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1011_8da8, 6); if(jz(0x1011_8e45, 0x97)) goto l_0x1011_8e45; /* jz 0x10118e45 */
            ii(0x1011_8dae, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8db1, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x1011_8db4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8db7, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1011_8dba, 2); if(jnz(0x1011_8e07, 0x4b)) goto l_0x1011_8e07; /* jnz 0x10118e07 */
            ii(0x1011_8dbc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8dbf, 3); mov(eax, memd[ds, eax + 0x25]);         /* mov eax, [eax+0x25] */
            ii(0x1011_8dc2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8dc5, 5); call(/* sys */ 0x1016_5df8, 0x4_d02e);  /* call 0x10165df8 */
            ii(0x1011_8dca, 1); cwde();                                 /* cwde */
            ii(0x1011_8dcb, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_8dcd, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1011_8dd0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8dd3, 3); mov(eax, memd[ds, eax + 0x29]);         /* mov eax, [eax+0x29] */
            ii(0x1011_8dd6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8dd9, 5); call(/* sys */ 0x1016_5df8, 0x4_d01a);  /* call 0x10165df8 */
            ii(0x1011_8dde, 1); cwde();                                 /* cwde */
            ii(0x1011_8ddf, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_8de1, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1011_8de4, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x1011_8de8, 4); movsx(eax, memw[ss, ebp - 0x40]);       /* movsx eax, word [ebp-0x40] */
            ii(0x1011_8dec, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1011_8dee, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_8df0, 2); if(jz(0x1011_8df9, 0x7)) goto l_0x1011_8df9; /* jz 0x10118df9 */
            ii(0x1011_8df2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8df5, 4); inc(memw[ds, eax + 0x16]);              /* inc word [eax+0x16] */
        l_0x1011_8df9:
            ii(0x1011_8df9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8dfc, 3); sar(memd[ds, eax + 0x25], 0x1);         /* sar dword [eax+0x25], 1 */
            ii(0x1011_8dff, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8e02, 3); sar(memd[ds, eax + 0x29], 0x1);         /* sar dword [eax+0x29], 1 */
            ii(0x1011_8e05, 2); jmp(0x1011_8e45, 0x3e); goto l_0x1011_8e45; /* jmp 0x10118e45 */
        l_0x1011_8e07:
            ii(0x1011_8e07, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1011_8e0c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8e0f, 5); call(0x1007_6d98, -0xa_207c);           /* call 0x10076d98 */
            ii(0x1011_8e14, 2); test(al, al);                           /* test al, al */
            ii(0x1011_8e16, 2); if(jz(0x1011_8e28, 0x10)) goto l_0x1011_8e28; /* jz 0x10118e28 */
            ii(0x1011_8e18, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8e1b, 3); mov(al, memb[ds, eax + 0x2c]);          /* mov al, [eax+0x2c] */
            ii(0x1011_8e1e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_8e23, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1011_8e26, 2); if(jnz(0x1011_8e2a, 0x2)) goto l_0x1011_8e2a; /* jnz 0x10118e2a */
        l_0x1011_8e28:
            ii(0x1011_8e28, 2); jmp(0x1011_8e45, 0x1b); goto l_0x1011_8e45; /* jmp 0x10118e45 */
        l_0x1011_8e2a:
            ii(0x1011_8e2a, 5); call(0x1010_2bf8, -0x1_6237);           /* call 0x10102bf8 */
            ii(0x1011_8e2f, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_8e31, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1011_8e33, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1011_8e38, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_8e3b, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1011_8e40, 5); call(0x1013_d5c0, 0x2_477b);            /* call 0x1013d5c0 */
        l_0x1011_8e45:
            ii(0x1011_8e45, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8e48, 3); mov(edx, memd[ds, eax + 0x25]);         /* mov edx, [eax+0x25] */
            ii(0x1011_8e4b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8e4e, 3); add(memd[ds, eax + 0x1d], edx);         /* add [eax+0x1d], edx */
            ii(0x1011_8e51, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8e54, 3); mov(edx, memd[ds, eax + 0x29]);         /* mov edx, [eax+0x29] */
            ii(0x1011_8e57, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8e5a, 3); add(memd[ds, eax + 0x21], edx);         /* add [eax+0x21], edx */
            ii(0x1011_8e5d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8e60, 3); mov(eax, memd[ds, eax + 0x1d]);         /* mov eax, [eax+0x1d] */
            ii(0x1011_8e63, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8e66, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_8e69, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8e6c, 3); mov(eax, memd[ds, eax + 0x17]);         /* mov eax, [eax+0x17] */
            ii(0x1011_8e6f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8e72, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_8e74, 3); mov(memd[ss, ebp - 0x20], edx);         /* mov [ebp-0x20], edx */
            ii(0x1011_8e77, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8e7a, 3); mov(eax, memd[ds, eax + 0x21]);         /* mov eax, [eax+0x21] */
            ii(0x1011_8e7d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8e80, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_8e83, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8e86, 3); mov(eax, memd[ds, eax + 0x19]);         /* mov eax, [eax+0x19] */
            ii(0x1011_8e89, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8e8c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_8e8e, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_8e91, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_8e94, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_8e97, 4); sub(ax, memw[ds, edx + 0x16]);          /* sub ax, [edx+0x16] */
            ii(0x1011_8e9b, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_8e9e, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1011_8ea1, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_8ea4, 4); sub(ax, memw[ds, edx + 0x18]);          /* sub ax, [edx+0x18] */
            ii(0x1011_8ea8, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_8eab, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_8eae, 3); mov(edx, memd[ds, edx + 0x18]);         /* mov edx, [edx+0x18] */
            ii(0x1011_8eb1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8eb4, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1011_8eb8, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1011_8ebb, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_8ebd, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1011_8ec0, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_8ec3, 3); mov(edx, memd[ds, edx + 0x1a]);         /* mov edx, [edx+0x1a] */
            ii(0x1011_8ec6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8ec9, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1011_8ecd, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1011_8ed0, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_8ed2, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_8ed5, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1011_8ed9, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1011_8edd, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1011_8edf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_8ee1, 2); if(jz(0x1011_8f32, 0x4f)) goto l_0x1011_8f32; /* jz 0x10118f32 */
            ii(0x1011_8ee3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8ee6, 4); test(memb[ds, eax + 0x12], 0x20);       /* test byte [eax+0x12], 0x20 */
            ii(0x1011_8eea, 2); if(jz(0x1011_8ef2, 0x6)) goto l_0x1011_8ef2; /* jz 0x10118ef2 */
            ii(0x1011_8eec, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1011_8ef0, 2); if(jnz(0x1011_8ef4, 0x2)) goto l_0x1011_8ef4; /* jnz 0x10118ef4 */
        l_0x1011_8ef2:
            ii(0x1011_8ef2, 2); jmp(0x1011_8f06, 0x12); goto l_0x1011_8f06; /* jmp 0x10118f06 */
        l_0x1011_8ef4:
            ii(0x1011_8ef4, 4); movsx(ebx, memw[ss, ebp - 0x28]);       /* movsx ebx, word [ebp-0x28] */
            ii(0x1011_8ef8, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1011_8efc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8eff, 5); call(0x1011_8457, -0xaad);              /* call 0x10118457 */
            ii(0x1011_8f04, 2); jmp(0x1011_8f25, 0x1f); goto l_0x1011_8f25; /* jmp 0x10118f25 */
        l_0x1011_8f06:
            ii(0x1011_8f06, 3); lea(edx, ebp - 0x44);                   /* lea edx, [ebp-0x44] */
            ii(0x1011_8f09, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8f0c, 5); call(0x1014_edfa, 0x3_5ee9);            /* call 0x1014edfa */
            ii(0x1011_8f11, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_8f13, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_8f16, 5); call(0x1008_ac18, -0x8_e303);           /* call 0x1008ac18 */
            ii(0x1011_8f1b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_8f1d, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_8f20, 5); call(0x1007_5f2c, -0xa_2ff9);           /* call 0x10075f2c */
        l_0x1011_8f25:
            ii(0x1011_8f25, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_8f28, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1011_8f2d, 5); call(0x1010_3752, -0x1_57e0);           /* call 0x10103752 */
        l_0x1011_8f32:
            ii(0x1011_8f32, 4); movsx(ebx, memw[ss, ebp - 0x24]);       /* movsx ebx, word [ebp-0x24] */
            ii(0x1011_8f36, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_8f3a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8f3d, 5); call(0x1014_9c2f, 0x3_0ced);            /* call 0x10149c2f */
            ii(0x1011_8f42, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8f45, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x1011_8f48, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8f4b, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1011_8f4e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_8f50, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8f53, 4); mov(memw[ds, eax + 0x1a], dx);          /* mov [eax+0x1a], dx */
            ii(0x1011_8f57, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8f5a, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1011_8f5d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8f60, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1011_8f63, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_8f65, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8f68, 4); mov(memw[ds, eax + 0x1c], dx);          /* mov [eax+0x1c], dx */
            ii(0x1011_8f6c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8f6f, 4); dec(memw[ds, eax + 0x16]);              /* dec word [eax+0x16] */
            ii(0x1011_8f73, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1011_8f77, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1011_8f7b, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1011_8f7d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_8f7f, 2); if(jz(0x1011_8f97, 0x16)) goto l_0x1011_8f97; /* jz 0x10118f97 */
            ii(0x1011_8f81, 5); call(0x100d_53f0, -0x4_3b96);           /* call 0x100d53f0 */
            ii(0x1011_8f86, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_8f88, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_8f8a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_8f8d, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1011_8f92, 5); call(0x1010_346f, -0x1_5b28);           /* call 0x1010346f */
        l_0x1011_8f97:
            ii(0x1011_8f97, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8f9a, 4); test(memb[ds, eax + 0x12], 0x20);       /* test byte [eax+0x12], 0x20 */
            ii(0x1011_8f9e, 2); if(jz(0x1011_8ff5, 0x55)) goto l_0x1011_8ff5; /* jz 0x10118ff5 */
            ii(0x1011_8fa0, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1011_8fa4, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1011_8fa8, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1011_8faa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_8fac, 2); if(jz(0x1011_8fbb, 0xd)) goto l_0x1011_8fbb; /* jz 0x10118fbb */
            ii(0x1011_8fae, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_8fb3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8fb6, 5); call(0x1007_1838, -0xa_7783);           /* call 0x10071838 */
        l_0x1011_8fbb:
            ii(0x1011_8fbb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8fbe, 5); cmp(memw[ds, eax + 0x8], 0x56);         /* cmp word [eax+0x8], 0x56 */
            ii(0x1011_8fc3, 2); if(jz(0x1011_8fcf, 0xa)) goto l_0x1011_8fcf; /* jz 0x10118fcf */
            ii(0x1011_8fc5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8fc8, 5); cmp(memw[ds, eax + 0x8], 0x57);         /* cmp word [eax+0x8], 0x57 */
            ii(0x1011_8fcd, 2); if(jnz(0x1011_8fd1, 0x2)) goto l_0x1011_8fd1; /* jnz 0x10118fd1 */
        l_0x1011_8fcf:
            ii(0x1011_8fcf, 2); jmp(0x1011_8fdb, 0xa); goto l_0x1011_8fdb; /* jmp 0x10118fdb */
        l_0x1011_8fd1:
            ii(0x1011_8fd1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8fd4, 5); cmp(memw[ds, eax + 0x8], 0x58);         /* cmp word [eax+0x8], 0x58 */
            ii(0x1011_8fd9, 2); if(jnz(0x1011_8ff0, 0x15)) goto l_0x1011_8ff0; /* jnz 0x10118ff0 */
        l_0x1011_8fdb:
            ii(0x1011_8fdb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8fde, 5); call(0x1012_0a5c, 0x7a79);              /* call 0x10120a5c */
            ii(0x1011_8fe3, 2); xor(al, 0x1);                           /* xor al, 0x1 */
            ii(0x1011_8fe5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_8fe8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8feb, 5); call(0x1014_9b07, 0x3_0b17);            /* call 0x10149b07 */
        l_0x1011_8ff0:
            ii(0x1011_8ff0, 5); jmp(0x1011_90aa, 0xb5); goto l_0x1011_90aa; /* jmp 0x101190aa */
        l_0x1011_8ff5:
            ii(0x1011_8ff5, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1011_8ff9, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1011_8ffd, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1011_8fff, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_9001, 2); if(jz(0x1011_905b, 0x58)) goto l_0x1011_905b; /* jz 0x1011905b */
            ii(0x1011_9003, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_9008, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_900b, 5); call(0x1007_1838, -0xa_77d8);           /* call 0x10071838 */
            ii(0x1011_9010, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_9012, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_9015, 5); call(0x1007_65d0, -0xa_2a4a);           /* call 0x100765d0 */
            ii(0x1011_901a, 5); call(0x1007_1838, -0xa_77e7);           /* call 0x10071838 */
            ii(0x1011_901f, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1011_9024, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_9027, 5); call(0x1007_6d98, -0xa_2294);           /* call 0x10076d98 */
            ii(0x1011_902c, 2); test(al, al);                           /* test al, al */
            ii(0x1011_902e, 2); if(jz(0x1011_903e, 0xe)) goto l_0x1011_903e; /* jz 0x1011903e */
            ii(0x1011_9030, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_9033, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x1011_9036, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_9039, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1011_903c, 2); if(jz(0x1011_9040, 0x2)) goto l_0x1011_9040; /* jz 0x10119040 */
        l_0x1011_903e:
            ii(0x1011_903e, 2); jmp(0x1011_905b, 0x1b); goto l_0x1011_905b; /* jmp 0x1011905b */
        l_0x1011_9040:
            ii(0x1011_9040, 5); call(0x1010_2bf8, -0x1_644d);           /* call 0x10102bf8 */
            ii(0x1011_9045, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_9047, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1011_9049, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1011_904e, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_9051, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1011_9056, 5); call(0x1013_d5c0, 0x2_4565);            /* call 0x1013d5c0 */
        l_0x1011_905b:
            ii(0x1011_905b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_905e, 5); call(0x1014_f12b, 0x3_60c8);            /* call 0x1014f12b */
            ii(0x1011_9063, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_9066, 3); mov(edx, memd[ds, edx + 0x14]);         /* mov edx, [edx+0x14] */
            ii(0x1011_9069, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_906c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_906f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_9071, 3); mov(bl, memb[ds, eax + 0x2a]);          /* mov bl, [eax+0x2a] */
            ii(0x1011_9074, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_9076, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_9079, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_907b, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1011_907d, 2); if(jnz(0x1011_90aa, 0x2b)) goto l_0x1011_90aa; /* jnz 0x101190aa */
            ii(0x1011_907f, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1011_9084, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_9089, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_908c, 5); call(0x1011_890d, -0x784);              /* call 0x1011890d */
            ii(0x1011_9091, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1011_9096, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_9099, 5); call(0x1007_6d98, -0xa_2306);           /* call 0x10076d98 */
            ii(0x1011_909e, 2); test(al, al);                           /* test al, al */
            ii(0x1011_90a0, 2); if(jz(0x1011_90aa, 0x8)) goto l_0x1011_90aa; /* jz 0x101190aa */
            ii(0x1011_90a2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_90a5, 5); call(0x1010_094d, -0x1_875d);           /* call 0x1010094d */
        l_0x1011_90aa:
            ii(0x1011_90aa, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_90ad, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x1011_90b0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_90b3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_90b5, 2); if(jnz(0x1011_90bf, 0x8)) goto l_0x1011_90bf; /* jnz 0x101190bf */
            ii(0x1011_90b7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_90ba, 5); call(0x1011_8758, -0x967);              /* call 0x10118758 */
        l_0x1011_90bf:
            ii(0x1011_90bf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_90c1, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1011_90c6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_90c9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_90cc, 5); call(0x1007_6074, -0xa_305d);           /* call 0x10076074 */
            ii(0x1011_90d1, 2); test(al, al);                           /* test al, al */
            ii(0x1011_90d3, 2); if(jz(0x1011_90e1, 0xc)) goto l_0x1011_90e1; /* jz 0x101190e1 */
            ii(0x1011_90d5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_90d8, 5); call(0x1014_9fa8, 0x3_0ecb);            /* call 0x10149fa8 */
            ii(0x1011_90dd, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
        l_0x1011_90e1:
            ii(0x1011_90e1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_90e4, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1011_90e7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_90ec, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_90ee, 2); if(jz(0x1011_90f9, 0x9)) goto l_0x1011_90f9; /* jz 0x101190f9 */
            ii(0x1011_90f0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_90f3, 4); cmp(memb[ds, eax + 0x3e], 0x5);         /* cmp byte [eax+0x3e], 0x5 */
            ii(0x1011_90f7, 2); if(jz(0x1011_90fb, 0x2)) goto l_0x1011_90fb; /* jz 0x101190fb */
        l_0x1011_90f9:
            ii(0x1011_90f9, 2); jmp(0x1011_9104, 0x9); goto l_0x1011_9104; /* jmp 0x10119104 */
        l_0x1011_90fb:
            ii(0x1011_90fb, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_9102, 2); if(jz(0x1011_9106, 0x2)) goto l_0x1011_9106; /* jz 0x10119106 */
        l_0x1011_9104:
            ii(0x1011_9104, 2); jmp(0x1011_910c, 0x6); goto l_0x1011_910c; /* jmp 0x1011910c */
        l_0x1011_9106:
            ii(0x1011_9106, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1011_910a, 2); if(jz(0x1011_910e, 0x2)) goto l_0x1011_910e; /* jz 0x1011910e */
        l_0x1011_910c:
            ii(0x1011_910c, 2); jmp(0x1011_9113, 0x5); goto l_0x1011_9113; /* jmp 0x10119113 */
        l_0x1011_910e:
            ii(0x1011_910e, 5); jmp(0x1011_8cfd, -0x416); goto l_0x1011_8cfd; /* jmp 0x10118cfd */
        l_0x1011_9113:
            ii(0x1011_9113, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1011_9117, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_9119, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_911c, 5); call(0x1007_5f2c, -0xa_31f5);           /* call 0x10075f2c */
            ii(0x1011_9121, 2); jmp(0x1011_912d, 0xa); goto l_0x1011_912d; /* jmp 0x1011912d */
        //  ii(0x1011_9123, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1011_9125, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
        //  ii(0x1011_9128, 5); call(0x1007_5f2c, -0xa_3201);           /* call 0x10075f2c */
        l_0x1011_912d:
            ii(0x1011_912d, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1011_9130, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_9132, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_9133, 1); pop(edi);                               /* pop edi */
            ii(0x1011_9134, 1); pop(esi);                               /* pop esi */
            ii(0x1011_9135, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_9136, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_9137, 1); ret();                                  /* ret */
        }
    }
}
