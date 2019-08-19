using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_ce26-d2e64c15")]
        public void Method_1011_ce26()
        {
            ii(0x1011_ce26, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x1011_ce2b, 5); calld(Definitions.sys_check_available_stack_size, 0x4_8f22); /* call 0x10165d52 */
            ii(0x1011_ce30, 1); pushd(esi);                             /* push esi */
            ii(0x1011_ce31, 1); pushd(edi);                             /* push edi */
            ii(0x1011_ce32, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_ce33, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_ce35, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1011_ce3b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_ce3e, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_ce41, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_ce44, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1011_ce47, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x1011_ce4c, 5); calld(Definitions.sys_new, 0x4_8faf);   /* call 0x10165e00 */
            ii(0x1011_ce51, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1011_ce54, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1011_ce57, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1011_ce5a, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1011_ce5e, 2); if(jzd(0x1011_ce85, 0x25)) goto l_0x1011_ce85; /* jz 0x1011ce85 */
            ii(0x1011_ce60, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_ce63, 3); mov(ebx, memd_a32[ds, eax + 0x1e]);     /* mov ebx, [eax+0x1e] */
            ii(0x1011_ce66, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_ce69, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_ce6c, 3); mov(edx, memd_a32[ds, eax + 0x1c]);     /* mov edx, [eax+0x1c] */
            ii(0x1011_ce6f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_ce72, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1011_ce75, 5); calld(Definitions.my_ctor_c20, -0x2f24); /* call 0x10119f56 */
            ii(0x1011_ce7a, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1011_ce7d, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1011_ce80, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1011_ce83, 2); jmpd(0x1011_ce8b, 0x6); goto l_0x1011_ce8b; /* jmp 0x1011ce8b */
        l_0x1011_ce85:
            ii(0x1011_ce85, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1011_ce88, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x1011_ce8b:
            ii(0x1011_ce8b, 3); mov(edx, memd_a32[ss, ebp - 0x38]);     /* mov edx, [ebp-0x38] */
            ii(0x1011_ce8e, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1011_ce91, 5); calld(0x100a_b3b0, -0x7_1ae6);          /* call 0x100ab3b0 */
            ii(0x1011_ce96, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x1011_ce9a, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_ce9d, 5); calld(0x100c_a068, -0x5_2e3a);          /* call 0x100ca068 */
            ii(0x1011_cea2, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1011_cea5, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1011_cea9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_ceac, 4); mov(ax, memw_a32[ds, eax + 0x1e]);      /* mov ax, [eax+0x1e] */
            ii(0x1011_ceb0, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_ceb3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_ceb6, 4); mov(ax, memw_a32[ds, eax + 0x20]);      /* mov ax, [eax+0x20] */
            ii(0x1011_ceba, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
        l_0x1011_cebd:
            ii(0x1011_cebd, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_cec0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_cec3, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x1011_cec6, 2); if(jnzd(0x1011_ced8, 0x10)) goto l_0x1011_ced8; /* jnz 0x1011ced8 */
            ii(0x1011_cec8, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1011_cecb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_cece, 4); cmp(ax, memw_a32[ds, edx + 0x2]);       /* cmp ax, [edx+0x2] */
            ii(0x1011_ced2, 6); if(jzd(0x1011_cfae, 0xd6)) goto l_0x1011_cfae; /* jz 0x1011cfae */
        l_0x1011_ced8:
            ii(0x1011_ced8, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1011_cedc, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_cedf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_cee2, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1011_cee5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_cee7, 4); movsx(edx, memw_a32[ss, ebp - 0x54]);   /* movsx edx, word [ebp-0x54] */
            ii(0x1011_ceeb, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_ceed, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_ceef, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_cef1, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x1011_cef3, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_cef6, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_cefa, 3); cmp(eax, 0x7);                          /* cmp eax, 0x7 */
            ii(0x1011_cefd, 2); if(jled(0x1011_cf22, 0x23)) goto l_0x1011_cf22; /* jle 0x1011cf22 */
            ii(0x1011_ceff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_cf01, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_cf04, 5); calld(0x100a_b3b0, -0x7_1b59);          /* call 0x100ab3b0 */
            ii(0x1011_cf09, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_cf0b, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_cf0e, 5); calld(0x100a_a3c0, -0x7_2b53);          /* call 0x100aa3c0 */
            ii(0x1011_cf13, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_cf15, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1011_cf18, 5); calld(0x100a_9f38, -0x7_2fe5);          /* call 0x100a9f38 */
            ii(0x1011_cf1d, 5); jmpd(0x1011_d0df, 0x1bd); goto l_0x1011_d0df; /* jmp 0x1011d0df */
        l_0x1011_cf22:
            ii(0x1011_cf22, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1011_cf26, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_cf29, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x1011_cf2e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_cf30, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_cf33, 5); calld(0x100a_aa64, -0x7_24d4);          /* call 0x100aaa64 */
            ii(0x1011_cf38, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_cf3c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_cf3f, 7); mov(ax, memw_a32[ds, eax + 0x101c_5348]); /* mov ax, [eax+0x101c5348] */
            ii(0x1011_cf46, 3); sub(memd_a32[ss, ebp - 0x18], eax);     /* sub [ebp-0x18], eax */
            ii(0x1011_cf49, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_cf4d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_cf50, 7); mov(ax, memw_a32[ds, eax + 0x101c_534a]); /* mov ax, [eax+0x101c534a] */
            ii(0x1011_cf57, 3); sub(memd_a32[ss, ebp - 0x54], eax);     /* sub [ebp-0x54], eax */
            ii(0x1011_cf5a, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1011_cf5e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_cf60, 2); if(jld(0x1011_cf6e, 0xc)) goto l_0x1011_cf6e; /* jl 0x1011cf6e */
            ii(0x1011_cf62, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_cf65, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1011_cf6c, 2); if(jld(0x1011_cf70, 0x2)) goto l_0x1011_cf70; /* jl 0x1011cf70 */
        l_0x1011_cf6e:
            ii(0x1011_cf6e, 2); jmpd(0x1011_cf78, 0x8); goto l_0x1011_cf78; /* jmp 0x1011cf78 */
        l_0x1011_cf70:
            ii(0x1011_cf70, 4); movsx(eax, memw_a32[ss, ebp - 0x54]);   /* movsx eax, word [ebp-0x54] */
            ii(0x1011_cf74, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_cf76, 2); if(jged(0x1011_cf7a, 0x2)) goto l_0x1011_cf7a; /* jge 0x1011cf7a */
        l_0x1011_cf78:
            ii(0x1011_cf78, 2); jmpd(0x1011_cf86, 0xc); goto l_0x1011_cf86; /* jmp 0x1011cf86 */
        l_0x1011_cf7a:
            ii(0x1011_cf7a, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1011_cf7d, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1011_cf84, 2); if(jld(0x1011_cfa9, 0x23)) goto l_0x1011_cfa9; /* jl 0x1011cfa9 */
        l_0x1011_cf86:
            ii(0x1011_cf86, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_cf88, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_cf8b, 5); calld(0x100a_b3b0, -0x7_1be0);          /* call 0x100ab3b0 */
            ii(0x1011_cf90, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_cf92, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_cf95, 5); calld(0x100a_a3c0, -0x7_2bda);          /* call 0x100aa3c0 */
            ii(0x1011_cf9a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_cf9c, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1011_cf9f, 5); calld(0x100a_9f38, -0x7_306c);          /* call 0x100a9f38 */
            ii(0x1011_cfa4, 5); jmpd(0x1011_d0df, 0x136); goto l_0x1011_d0df; /* jmp 0x1011d0df */
        l_0x1011_cfa9:
            ii(0x1011_cfa9, 5); jmpd(0x1011_cebd, -0xf1); goto l_0x1011_cebd; /* jmp 0x1011cebd */
        l_0x1011_cfae:
            ii(0x1011_cfae, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_cfb1, 5); calld(Definitions.my_3_get_count, -0x9_1b36); /* call 0x1008b480 */
            ii(0x1011_cfb6, 1); cwde();                                 /* cwde */
            ii(0x1011_cfb7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_cfb9, 2); if(jnzd(0x1011_cfde, 0x23)) goto l_0x1011_cfde; /* jnz 0x1011cfde */
            ii(0x1011_cfbb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_cfbd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_cfc0, 5); calld(0x100a_b3b0, -0x7_1c15);          /* call 0x100ab3b0 */
            ii(0x1011_cfc5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_cfc7, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_cfca, 5); calld(0x100a_a3c0, -0x7_2c0f);          /* call 0x100aa3c0 */
            ii(0x1011_cfcf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_cfd1, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1011_cfd4, 5); calld(0x100a_9f38, -0x7_30a1);          /* call 0x100a9f38 */
            ii(0x1011_cfd9, 5); jmpd(0x1011_d0df, 0x101); goto l_0x1011_d0df; /* jmp 0x1011d0df */
        l_0x1011_cfde:
            ii(0x1011_cfde, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_cfe1, 5); calld(Definitions.my_3_get_count, -0x9_1b66); /* call 0x1008b480 */
            ii(0x1011_cfe6, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1011_cfe9, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
        l_0x1011_cff0:
            ii(0x1011_cff0, 3); dec(memd_a32[ss, ebp - 0x28]);          /* dec dword [ebp-0x28] */
            ii(0x1011_cff3, 5); cmp(memw_a32[ss, ebp - 0x28], -0x1 /* 0xff */); /* cmp word [ebp-0x28], 0xffff */
            ii(0x1011_cff8, 2); if(jzd(0x1011_d003, 0x9)) goto l_0x1011_d003; /* jz 0x1011d003 */
            ii(0x1011_cffa, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_cffd, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1011_d001, 2); if(jld(0x1011_d008, 0x5)) goto l_0x1011_d008; /* jl 0x1011d008 */
        l_0x1011_d003:
            ii(0x1011_d003, 5); jmpd(0x1011_d0aa, 0xa2); goto l_0x1011_d0aa; /* jmp 0x1011d0aa */
        l_0x1011_d008:
            ii(0x1011_d008, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1011_d00c, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_d00f, 5); calld(0x100a_aa28, -0x7_25ec);          /* call 0x100aaa28 */
            ii(0x1011_d014, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1011_d017, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
            ii(0x1011_d01a, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1011_d01e, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_d021, 5); calld(0x100a_aa28, -0x7_25fe);          /* call 0x100aaa28 */
            ii(0x1011_d026, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1011_d02a, 3); add(memd_a32[ss, ebp - 0x54], eax);     /* add [ebp-0x54], eax */
            ii(0x1011_d02d, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1011_d031, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_d034, 6); mov(edx, memd_a32[ds, 0x101c_5368]);    /* mov edx, [0x101c5368] */
            ii(0x1011_d03a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_d03c, 4); movsx(edx, memw_a32[ss, ebp - 0x54]);   /* movsx edx, word [ebp-0x54] */
            ii(0x1011_d040, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_d042, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_d044, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1011_d046, 2); and(al, 0x1f);                          /* and al, 0x1f */
            ii(0x1011_d048, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_d04a, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_d04d, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1011_d051, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_d053, 2); if(jzd(0x1011_d05d, 0x8)) goto l_0x1011_d05d; /* jz 0x1011d05d */
            ii(0x1011_d055, 4); movsx(eax, memw_a32[ss, ebp - 0x54]);   /* movsx eax, word [ebp-0x54] */
            ii(0x1011_d059, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_d05b, 2); if(jnzd(0x1011_d05f, 0x2)) goto l_0x1011_d05f; /* jnz 0x1011d05f */
        l_0x1011_d05d:
            ii(0x1011_d05d, 2); jmpd(0x1011_d072, 0x13); goto l_0x1011_d072; /* jmp 0x1011d072 */
        l_0x1011_d05f:
            ii(0x1011_d05f, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_d063, 3); lea(edx, edx + edx * 2);                /* lea edx, [edx+edx*2] */
            ii(0x1011_d066, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_d068, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_d06b, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_d06d, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_d06f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1011_d072:
            ii(0x1011_d072, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_d075, 3); add(memd_a32[ss, ebp - 0x24], eax);     /* add [ebp-0x24], eax */
            ii(0x1011_d078, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1011_d07c, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_d07f, 5); calld(0x100a_aa28, -0x7_265c);          /* call 0x100aaa28 */
            ii(0x1011_d084, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1011_d086, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_d089, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1011_d08d, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_d090, 5); calld(0x100a_aa28, -0x7_266d);          /* call 0x100aaa28 */
            ii(0x1011_d095, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1011_d098, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1011_d09b, 5); calld(0x100a_b2e0, -0x7_1dc0);          /* call 0x100ab2e0 */
            ii(0x1011_d0a0, 5); calld(0x1011_aca3, -0x2402);            /* call 0x1011aca3 */
            ii(0x1011_d0a5, 5); jmpd(0x1011_cff0, -0xba); goto l_0x1011_cff0; /* jmp 0x1011cff0 */
        l_0x1011_d0aa:
            ii(0x1011_d0aa, 3); lea(edx, ebp - 0x3c);                   /* lea edx, [ebp-0x3c] */
            ii(0x1011_d0ad, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_d0b0, 5); calld(0x100a_b36c, -0x7_1d49);          /* call 0x100ab36c */
            ii(0x1011_d0b5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_d0b7, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_d0ba, 5); calld(0x100a_a3c0, -0x7_2cff);          /* call 0x100aa3c0 */
            ii(0x1011_d0bf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_d0c1, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1011_d0c4, 5); calld(0x100a_9f38, -0x7_3191);          /* call 0x100a9f38 */
            ii(0x1011_d0c9, 2); jmpd(0x1011_d0df, 0x14); goto l_0x1011_d0df; /* jmp 0x1011d0df */
        //  ii(0x1011_d0cb, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1011_d0cd, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
        //  ii(0x1011_d0d0, 5); calld(0x100a_a3c0, -0x7_2d15);          /* call 0x100aa3c0 */
        //  ii(0x1011_d0d5, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1011_d0d7, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
        //  ii(0x1011_d0da, 5); calld(0x100a_9f38, -0x7_31a7);          /* call 0x100a9f38 */
        l_0x1011_d0df:
            ii(0x1011_d0df, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_d0e2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_d0e4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_d0e5, 1); popd(edi);                              /* pop edi */
            ii(0x1011_d0e6, 1); popd(esi);                              /* pop esi */
            ii(0x1011_d0e7, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
