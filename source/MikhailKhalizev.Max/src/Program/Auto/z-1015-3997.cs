using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_3997-2ea25534")]
        public void Method_1015_3997()
        {
            ii(0x1015_3997, 5); push(0x64);                             /* push 0x64 */
            ii(0x1015_399c, 5); call(Definitions.sys_check_available_stack_size, 0x1_23b1); /* call 0x10165d52 */
            ii(0x1015_39a1, 1); push(ebx);                              /* push ebx */
            ii(0x1015_39a2, 1); push(ecx);                              /* push ecx */
            ii(0x1015_39a3, 1); push(edx);                              /* push edx */
            ii(0x1015_39a4, 1); push(esi);                              /* push esi */
            ii(0x1015_39a5, 1); push(edi);                              /* push edi */
            ii(0x1015_39a6, 1); push(ebp);                              /* push ebp */
            ii(0x1015_39a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_39a9, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1015_39af, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_39b2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_39b5, 5); cmp(memw[ds, eax + 0x8], 0x38);         /* cmp word [eax+0x8], 0x38 */
            ii(0x1015_39ba, 2); if(jz(0x1015_39c6, 0xa)) goto l_0x1015_39c6; /* jz 0x101539c6 */
            ii(0x1015_39bc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_39bf, 5); cmp(memw[ds, eax + 0x8], 0x4a);         /* cmp word [eax+0x8], 0x4a */
            ii(0x1015_39c4, 2); if(jnz(0x1015_39d3, 0xd)) goto l_0x1015_39d3; /* jnz 0x101539d3 */
        l_0x1015_39c6:
            ii(0x1015_39c6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_39c9, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1015_39cc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_39cf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_39d1, 2); if(jnz(0x1015_39d8, 0x5)) goto l_0x1015_39d8; /* jnz 0x101539d8 */
        l_0x1015_39d3:
            ii(0x1015_39d3, 5); jmp(0x1015_3c3f, 0x267); goto l_0x1015_3c3f; /* jmp 0x10153c3f */
        l_0x1015_39d8:
            ii(0x1015_39d8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_39db, 5); cmp(memw[ds, eax + 0x8], 0x4a);         /* cmp word [eax+0x8], 0x4a */
            ii(0x1015_39e0, 2); if(jnz(0x1015_39eb, 0x9)) goto l_0x1015_39eb; /* jnz 0x101539eb */
            ii(0x1015_39e2, 7); mov(memd[ss, ebp - 0x24], 0x2a);        /* mov dword [ebp-0x24], 0x2a */
            ii(0x1015_39e9, 2); jmp(0x1015_39f2, 0x7); goto l_0x1015_39f2; /* jmp 0x101539f2 */
        l_0x1015_39eb:
            ii(0x1015_39eb, 7); mov(memd[ss, ebp - 0x24], 0x29);        /* mov dword [ebp-0x24], 0x29 */
        l_0x1015_39f2:
            ii(0x1015_39f2, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1015_39f5, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_39f8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_39fb, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1015_39fe, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_3a01, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3a04, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1015_3a07, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_3a0a, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_3a0f, 5); call(0x1010_3541, -0x5_04d3);           /* call 0x10103541 */
            ii(0x1015_3a14, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_3a16, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_3a19, 5); call(0x1007_64b8, -0xd_d566);           /* call 0x100764b8 */
        l_0x1015_3a1e:
            ii(0x1015_3a1e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3a20, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_3a23, 5); call(0x1013_ad71, -0x1_8cb7);           /* call 0x1013ad71 */
            ii(0x1015_3a28, 2); test(al, al);                           /* test al, al */
            ii(0x1015_3a2a, 2); if(jz(0x1015_3a3e, 0x12)) goto l_0x1015_3a3e; /* jz 0x10153a3e */
            ii(0x1015_3a2c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_3a2f, 5); call(0x1007_63a0, -0xd_d694);           /* call 0x100763a0 */
            ii(0x1015_3a34, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x1015_3a38, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x1015_3a3c, 2); if(jnz(0x1015_3a40, 0x2)) goto l_0x1015_3a40; /* jnz 0x10153a40 */
        l_0x1015_3a3e:
            ii(0x1015_3a3e, 2); jmp(0x1015_3a4a, 0xa); goto l_0x1015_3a4a; /* jmp 0x10153a4a */
        l_0x1015_3a40:
            ii(0x1015_3a40, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_3a43, 5); call(0x1007_6bf8, -0xd_ce50);           /* call 0x10076bf8 */
            ii(0x1015_3a48, 2); jmp(0x1015_3a1e, -0x2c); goto l_0x1015_3a1e; /* jmp 0x10153a1e */
        l_0x1015_3a4a:
            ii(0x1015_3a4a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3a4c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_3a4f, 5); call(0x1013_ad71, -0x1_8ce3);           /* call 0x1013ad71 */
            ii(0x1015_3a54, 2); test(al, al);                           /* test al, al */
            ii(0x1015_3a56, 2); if(jz(0x1015_3a67, 0xf)) goto l_0x1015_3a67; /* jz 0x10153a67 */
            ii(0x1015_3a58, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3a5a, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_3a5d, 5); call(0x1007_5f6c, -0xd_daf6);           /* call 0x10075f6c */
            ii(0x1015_3a62, 5); jmp(0x1015_3c3f, 0x1d8); goto l_0x1015_3c3f; /* jmp 0x10153c3f */
        l_0x1015_3a67:
            ii(0x1015_3a67, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x1015_3a6b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_3a6e, 5); call(Definitions.my_ctor_0x101b_38f8, -0xd_d383); /* call 0x100766f0 */
            ii(0x1015_3a73, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_3a76, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1015_3a7a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_3a7d, 5); call(Definitions.my_ctor_0x101b_4184, -0xd_cf92); /* call 0x10076af0 */
            ii(0x1015_3a82, 5); call(0x1010_2b84, -0x5_0f03);           /* call 0x10102b84 */
            ii(0x1015_3a87, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_3a8c, 1); push(eax);                              /* push eax */
            ii(0x1015_3a8d, 5); call(0x1010_2ba4, -0x5_0eee);           /* call 0x10102ba4 */
            ii(0x1015_3a92, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_3a97, 1); push(eax);                              /* push eax */
            ii(0x1015_3a98, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_3a9a, 1); push(eax);                              /* push eax */
            ii(0x1015_3a9b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3a9e, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1015_3aa1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_3aa4, 1); push(eax);                              /* push eax */
            ii(0x1015_3aa5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3aa8, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1015_3aab, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_3aae, 1); push(eax);                              /* push eax */
            ii(0x1015_3aaf, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_3ab1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3ab4, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_3ab7, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_3ab9, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_3abc, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1015_3ac0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_3ac3, 5); call(0x1015_a2da, 0x6812);              /* call 0x1015a2da */
            ii(0x1015_3ac8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_3aca, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_3acd, 5); call(0x1008_ac18, -0xc_8eba);           /* call 0x1008ac18 */
            ii(0x1015_3ad2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3ad4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_3ad7, 5); call(0x1007_5f2c, -0xd_dbb0);           /* call 0x10075f2c */
            ii(0x1015_3adc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3ade, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3ae1, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1015_3ae4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_3ae7, 1); dec(eax);                               /* dec eax */
            ii(0x1015_3ae8, 5); call(0x1007_6e7c, -0xd_cc71);           /* call 0x10076e7c */
            ii(0x1015_3aed, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1015_3af0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3af2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3af5, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1015_3af8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_3afb, 1); dec(eax);                               /* dec eax */
            ii(0x1015_3afc, 5); call(0x1007_6e7c, -0xd_cc85);           /* call 0x10076e7c */
            ii(0x1015_3b01, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1015_3b04, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x1015_3b0a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_3b0d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3b10, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1015_3b13, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_3b16, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1015_3b19, 5); call(Definitions.my_min, -0xc_a39a);    /* call 0x10089784 */
            ii(0x1015_3b1e, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1015_3b21, 6); mov(edx, memd[ds, 0x101c_8172]);        /* mov edx, [0x101c8172] */
            ii(0x1015_3b27, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_3b2a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3b2d, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1015_3b30, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_3b33, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1015_3b36, 5); call(Definitions.my_min, -0xc_a3b7);    /* call 0x10089784 */
            ii(0x1015_3b3b, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1015_3b3e, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1015_3b41, 4); mov(memw[ss, ebp - 0x20], ax);          /* mov [ebp-0x20], ax */
            ii(0x1015_3b45, 2); jmp(0x1015_3b4e, 0x7); goto l_0x1015_3b4e; /* jmp 0x10153b4e */
        l_0x1015_3b47:
            ii(0x1015_3b47, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1015_3b4a, 4); inc(memw[ss, ebp - 0x20]);              /* inc word [ebp-0x20] */
        l_0x1015_3b4e:
            ii(0x1015_3b4e, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1015_3b52, 3); cmp(eax, memd[ss, ebp - 0x2c]);         /* cmp eax, [ebp-0x2c] */
            ii(0x1015_3b55, 6); if(jge(0x1015_3bdd, 0x82)) goto l_0x1015_3bdd; /* jge 0x10153bdd */
            ii(0x1015_3b5b, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1015_3b5e, 4); mov(memw[ss, ebp - 0x1e], ax);          /* mov [ebp-0x1e], ax */
            ii(0x1015_3b62, 2); jmp(0x1015_3b6b, 0x7); goto l_0x1015_3b6b; /* jmp 0x10153b6b */
        l_0x1015_3b64:
            ii(0x1015_3b64, 3); mov(eax, memd[ss, ebp - 0x1e]);         /* mov eax, [ebp-0x1e] */
            ii(0x1015_3b67, 4); inc(memw[ss, ebp - 0x1e]);              /* inc word [ebp-0x1e] */
        l_0x1015_3b6b:
            ii(0x1015_3b6b, 4); movsx(eax, memw[ss, ebp - 0x1e]);       /* movsx eax, word [ebp-0x1e] */
            ii(0x1015_3b6f, 3); cmp(eax, memd[ss, ebp - 0x28]);         /* cmp eax, [ebp-0x28] */
            ii(0x1015_3b72, 2); if(jge(0x1015_3bd8, 0x64)) goto l_0x1015_3bd8; /* jge 0x10153bd8 */
            ii(0x1015_3b74, 4); movsx(ebx, memw[ss, ebp - 0x1e]);       /* movsx ebx, word [ebp-0x1e] */
            ii(0x1015_3b78, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1015_3b7c, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_3b81, 5); call(0x1010_3541, -0x5_0645);           /* call 0x10103541 */
            ii(0x1015_3b86, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_3b88, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_3b8b, 5); call(0x1007_643c, -0xd_d754);           /* call 0x1007643c */
            ii(0x1015_3b90, 2); jmp(0x1015_3b9a, 0x8); goto l_0x1015_3b9a; /* jmp 0x10153b9a */
        l_0x1015_3b92:
            ii(0x1015_3b92, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_3b95, 5); call(0x1007_6bf8, -0xd_cfa2);           /* call 0x10076bf8 */
        l_0x1015_3b9a:
            ii(0x1015_3b9a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3b9c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_3b9f, 5); call(0x1013_ad71, -0x1_8e33);           /* call 0x1013ad71 */
            ii(0x1015_3ba4, 2); test(al, al);                           /* test al, al */
            ii(0x1015_3ba6, 2); if(jz(0x1015_3bd6, 0x2e)) goto l_0x1015_3bd6; /* jz 0x10153bd6 */
            ii(0x1015_3ba8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_3bab, 5); call(0x1007_63a0, -0xd_d810);           /* call 0x100763a0 */
            ii(0x1015_3bb0, 5); cmp(memw[ds, eax + 0x8], 0x39);         /* cmp word [eax+0x8], 0x39 */
            ii(0x1015_3bb5, 2); if(jnz(0x1015_3bd4, 0x1d)) goto l_0x1015_3bd4; /* jnz 0x10153bd4 */
            ii(0x1015_3bb7, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_3bba, 5); call(0x1007_63a0, -0xd_d81f);           /* call 0x100763a0 */
            ii(0x1015_3bbf, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_3bc2, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_3bc4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_3bc7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_3bca, 5); call(0x1007_6574, -0xd_d65b);           /* call 0x10076574 */
            ii(0x1015_3bcf, 5); call(0x1014_f634, -0x45a0);             /* call 0x1014f634 */
        l_0x1015_3bd4:
            ii(0x1015_3bd4, 2); jmp(0x1015_3b92, -0x44); goto l_0x1015_3b92; /* jmp 0x10153b92 */
        l_0x1015_3bd6:
            ii(0x1015_3bd6, 2); jmp(0x1015_3b64, -0x74); goto l_0x1015_3b64; /* jmp 0x10153b64 */
        l_0x1015_3bd8:
            ii(0x1015_3bd8, 5); jmp(0x1015_3b47, -0x96); goto l_0x1015_3b47; /* jmp 0x10153b47 */
        l_0x1015_3bdd:
            ii(0x1015_3bdd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3be0, 4); dec(memw[ds, eax + 0x52]);              /* dec word [eax+0x52] */
            ii(0x1015_3be4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3be7, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1015_3bea, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_3bed, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_3bef, 2); if(jnz(0x1015_3bfb, 0xa)) goto l_0x1015_3bfb; /* jnz 0x10153bfb */
            ii(0x1015_3bf1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3bf4, 7); mov(memb[ds, eax + 0xa6], 0);           /* mov byte [eax+0xa6], 0x0 */
        l_0x1015_3bfb:
            ii(0x1015_3bfb, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_3c00, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3c03, 5); call(0x1007_6d98, -0xd_ce70);           /* call 0x10076d98 */
            ii(0x1015_3c08, 2); test(al, al);                           /* test al, al */
            ii(0x1015_3c0a, 2); if(jz(0x1015_3c2b, 0x1f)) goto l_0x1015_3c2b; /* jz 0x10153c2b */
            ii(0x1015_3c0c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3c0f, 5); call(0x1010_094d, -0x5_32c7);           /* call 0x1010094d */
            ii(0x1015_3c14, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1015_3c19, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1015_3c1e, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_3c21, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_3c26, 5); call(0x1013_d5c0, -0x1_666b);           /* call 0x1013d5c0 */
        l_0x1015_3c2b:
            ii(0x1015_3c2b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3c2d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_3c30, 5); call(0x1007_5f2c, -0xd_dd09);           /* call 0x10075f2c */
            ii(0x1015_3c35, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3c37, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_3c3a, 5); call(0x1007_5f6c, -0xd_dcd3);           /* call 0x10075f6c */
        l_0x1015_3c3f:
            ii(0x1015_3c3f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_3c41, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_3c42, 1); pop(edi);                               /* pop edi */
            ii(0x1015_3c43, 1); pop(esi);                               /* pop esi */
            ii(0x1015_3c44, 1); pop(edx);                               /* pop edx */
            ii(0x1015_3c45, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_3c46, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_3c47, 1); ret();                                  /* ret */
        }
    }
}
