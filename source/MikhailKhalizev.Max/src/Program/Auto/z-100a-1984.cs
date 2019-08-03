using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3e94a7b6-ded7-4c86-91b2-89c8499d6d48")]
        public void Method_100a_1984()
        {
            ii(0x100a_1984, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100a_1989, 5); calld(Definitions.sys_check_available_stack_size, 0xc43c4); /* call 0x10165d52 */
            ii(0x100a_198e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_198f, 1); pushd(esi);                             /* push esi */
            ii(0x100a_1990, 1); pushd(edi);                             /* push edi */
            ii(0x100a_1991, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_1992, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_1994, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100a_199a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_199d, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_19a0, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100a_19a3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_19a6, 5); calld(0x1007_6204, -0x2b7a7);           /* call 0x10076204 */
            ii(0x100a_19ab, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100a_19ae, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x100a_19b1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_19b3, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_19b5, 5); calld(0x1007_6e00, -0x2abba);           /* call 0x10076e00 */
            ii(0x100a_19ba, 2); test(al, al);                           /* test al, al */
            ii(0x100a_19bc, 2); if(jzd(0x100a_19c7, 0x9)) goto l_0x100a_19c7; /* jz 0x100a19c7 */
            ii(0x100a_19be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_19c1, 4); cmp(memb_a32[ds, eax + 0x3d], 0x8);     /* cmp byte [eax+0x3d], 0x8 */
            ii(0x100a_19c5, 2); if(jnzd(0x100a_19c9, 0x2)) goto l_0x100a_19c9; /* jnz 0x100a19c9 */
        l_0x100a_19c7:
            ii(0x100a_19c7, 2); jmpd(0x100a_19d2, 0x9); goto l_0x100a_19d2; /* jmp 0x100a19d2 */
        l_0x100a_19c9:
            ii(0x100a_19c9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_19cc, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100a_19d0, 2); if(jnzd(0x100a_19d4, 0x2)) goto l_0x100a_19d4; /* jnz 0x100a19d4 */
        l_0x100a_19d2:
            ii(0x100a_19d2, 2); jmpd(0x100a_19dd, 0x9); goto l_0x100a_19dd; /* jmp 0x100a19dd */
        l_0x100a_19d4:
            ii(0x100a_19d4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_19d7, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100a_19db, 2); if(jnzd(0x100a_19e2, 0x5)) goto l_0x100a_19e2; /* jnz 0x100a19e2 */
        l_0x100a_19dd:
            ii(0x100a_19dd, 5); jmpd(0x100a_1c05, 0x223); goto l_0x100a_1c05; /* jmp 0x100a1c05 */
        l_0x100a_19e2:
            ii(0x100a_19e2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_19e5, 5); calld(0x1007_20b1, -0x2f939);           /* call 0x100720b1 */
            ii(0x100a_19ea, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_19ef, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100a_19f2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_19f5, 5); calld(0x1007_2388, -0x2f672);           /* call 0x10072388 */
            ii(0x100a_19fa, 4); movsx(eax, memw_a32[ss, ebp - 0x16]);   /* movsx eax, word [ebp-0x16] */
            ii(0x100a_19fe, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1a00, 2); if(jld(0x100a_1a0a, 0x8)) goto l_0x100a_1a0a; /* jl 0x100a1a0a */
            ii(0x100a_1a02, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100a_1a06, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1a08, 2); if(jged(0x100a_1a0c, 0x2)) goto l_0x100a_1a0c; /* jge 0x100a1a0c */
        l_0x100a_1a0a:
            ii(0x100a_1a0a, 2); jmpd(0x100a_1a14, 0x8); goto l_0x100a_1a14; /* jmp 0x100a1a14 */
        l_0x100a_1a0c:
            ii(0x100a_1a0c, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100a_1a10, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1a12, 2); if(jged(0x100a_1a16, 0x2)) goto l_0x100a_1a16; /* jge 0x100a1a16 */
        l_0x100a_1a14:
            ii(0x100a_1a14, 2); jmpd(0x100a_1a1e, 0x8); goto l_0x100a_1a1e; /* jmp 0x100a1a1e */
        l_0x100a_1a16:
            ii(0x100a_1a16, 4); movsx(eax, memw_a32[ss, ebp - 0x12]);   /* movsx eax, word [ebp-0x12] */
            ii(0x100a_1a1a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1a1c, 2); if(jged(0x100a_1a20, 0x2)) goto l_0x100a_1a20; /* jge 0x100a1a20 */
        l_0x100a_1a1e:
            ii(0x100a_1a1e, 2); jmpd(0x100a_1a28, 0x8); goto l_0x100a_1a28; /* jmp 0x100a1a28 */
        l_0x100a_1a20:
            ii(0x100a_1a20, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100a_1a24, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1a26, 2); if(jged(0x100a_1a2a, 0x2)) goto l_0x100a_1a2a; /* jge 0x100a1a2a */
        l_0x100a_1a28:
            ii(0x100a_1a28, 2); jmpd(0x100a_1a36, 0xc); goto l_0x100a_1a36; /* jmp 0x100a1a36 */
        l_0x100a_1a2a:
            ii(0x100a_1a2a, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100a_1a31, 5); jmpd(0x100a_1c0c, 0x1d6); goto l_0x100a_1c0c; /* jmp 0x100a1c0c */
        l_0x100a_1a36:
            ii(0x100a_1a36, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_1a3a, 2); if(jnzd(0x100a_1a53, 0x17)) goto l_0x100a_1a53; /* jnz 0x100a1a53 */
            ii(0x100a_1a3c, 4); movsx(eax, memw_a32[ss, ebp - 0x16]);   /* movsx eax, word [ebp-0x16] */
            ii(0x100a_1a40, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1a42, 2); if(jged(0x100a_1a51, 0xd)) goto l_0x100a_1a51; /* jge 0x100a1a51 */
            ii(0x100a_1a44, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1a47, 3); mov(eax, memd_a32[ds, eax + 0x2a]);     /* mov eax, [eax+0x2a] */
            ii(0x100a_1a4a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_1a4d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1a4f, 2); if(jld(0x100a_1a53, 0x2)) goto l_0x100a_1a53; /* jl 0x100a1a53 */
        l_0x100a_1a51:
            ii(0x100a_1a51, 2); jmpd(0x100a_1a55, 0x2); goto l_0x100a_1a55; /* jmp 0x100a1a55 */
        l_0x100a_1a53:
            ii(0x100a_1a53, 2); jmpd(0x100a_1a6c, 0x17); goto l_0x100a_1a6c; /* jmp 0x100a1a6c */
        l_0x100a_1a55:
            ii(0x100a_1a55, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100a_1a59, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1a5b, 2); if(jged(0x100a_1a6a, 0xd)) goto l_0x100a_1a6a; /* jge 0x100a1a6a */
            ii(0x100a_1a5d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1a60, 3); mov(eax, memd_a32[ds, eax + 0x2c]);     /* mov eax, [eax+0x2c] */
            ii(0x100a_1a63, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_1a66, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1a68, 2); if(jld(0x100a_1a6c, 0x2)) goto l_0x100a_1a6c; /* jl 0x100a1a6c */
        l_0x100a_1a6a:
            ii(0x100a_1a6a, 2); jmpd(0x100a_1a6e, 0x2); goto l_0x100a_1a6e; /* jmp 0x100a1a6e */
        l_0x100a_1a6c:
            ii(0x100a_1a6c, 2); jmpd(0x100a_1a88, 0x1a); goto l_0x100a_1a88; /* jmp 0x100a1a88 */
        l_0x100a_1a6e:
            ii(0x100a_1a6e, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100a_1a72, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1a74, 2); if(jged(0x100a_1a83, 0xd)) goto l_0x100a_1a83; /* jge 0x100a1a83 */
            ii(0x100a_1a76, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1a79, 3); mov(eax, memd_a32[ds, eax + 0x28]);     /* mov eax, [eax+0x28] */
            ii(0x100a_1a7c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_1a7f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1a81, 2); if(jld(0x100a_1a88, 0x5)) goto l_0x100a_1a88; /* jl 0x100a1a88 */
        l_0x100a_1a83:
            ii(0x100a_1a83, 5); jmpd(0x100a_1c05, 0x17d); goto l_0x100a_1c05; /* jmp 0x100a1c05 */
        l_0x100a_1a88:
            ii(0x100a_1a88, 4); mov(memb_a32[ss, ebp - 0x20], 0);       /* mov byte [ebp-0x20], 0x0 */
            ii(0x100a_1a8c, 4); mov(memb_a32[ss, ebp - 0x24], 0);       /* mov byte [ebp-0x24], 0x0 */
            ii(0x100a_1a90, 4); movsx(eax, memw_a32[ss, ebp - 0x16]);   /* movsx eax, word [ebp-0x16] */
            ii(0x100a_1a94, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1a96, 2); if(jged(0x100a_1aa5, 0xd)) goto l_0x100a_1aa5; /* jge 0x100a1aa5 */
            ii(0x100a_1a98, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1a9b, 3); mov(eax, memd_a32[ds, eax + 0x2a]);     /* mov eax, [eax+0x2a] */
            ii(0x100a_1a9e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_1aa1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1aa3, 2); if(jld(0x100a_1aa7, 0x2)) goto l_0x100a_1aa7; /* jl 0x100a1aa7 */
        l_0x100a_1aa5:
            ii(0x100a_1aa5, 2); jmpd(0x100a_1ab3, 0xc); goto l_0x100a_1ab3; /* jmp 0x100a1ab3 */
        l_0x100a_1aa7:
            ii(0x100a_1aa7, 7); mov(memd_a32[ss, ebp - 0x28], 0x101a_0ab8); /* mov dword [ebp-0x28], 0x101a0ab8 */ /* "raw material" */
            ii(0x100a_1aae, 5); jmpd(0x100a_1ba2, 0xef); goto l_0x100a_1ba2; /* jmp 0x100a1ba2 */
        l_0x100a_1ab3:
            ii(0x100a_1ab3, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100a_1ab7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1ab9, 2); if(jged(0x100a_1ac8, 0xd)) goto l_0x100a_1ac8; /* jge 0x100a1ac8 */
            ii(0x100a_1abb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1abe, 3); mov(eax, memd_a32[ds, eax + 0x2c]);     /* mov eax, [eax+0x2c] */
            ii(0x100a_1ac1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_1ac4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1ac6, 2); if(jld(0x100a_1aca, 0x2)) goto l_0x100a_1aca; /* jl 0x100a1aca */
        l_0x100a_1ac8:
            ii(0x100a_1ac8, 2); jmpd(0x100a_1ad6, 0xc); goto l_0x100a_1ad6; /* jmp 0x100a1ad6 */
        l_0x100a_1aca:
            ii(0x100a_1aca, 7); mov(memd_a32[ss, ebp - 0x28], 0x101a_0ac5); /* mov dword [ebp-0x28], 0x101a0ac5 */ /* "fuel" */
            ii(0x100a_1ad1, 5); jmpd(0x100a_1ba2, 0xcc); goto l_0x100a_1ba2; /* jmp 0x100a1ba2 */
        l_0x100a_1ad6:
            ii(0x100a_1ad6, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100a_1ada, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1adc, 2); if(jged(0x100a_1aeb, 0xd)) goto l_0x100a_1aeb; /* jge 0x100a1aeb */
            ii(0x100a_1ade, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1ae1, 3); mov(eax, memd_a32[ds, eax + 0x28]);     /* mov eax, [eax+0x28] */
            ii(0x100a_1ae4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_1ae7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1ae9, 2); if(jld(0x100a_1aed, 0x2)) goto l_0x100a_1aed; /* jl 0x100a1aed */
        l_0x100a_1aeb:
            ii(0x100a_1aeb, 2); jmpd(0x100a_1af9, 0xc); goto l_0x100a_1af9; /* jmp 0x100a1af9 */
        l_0x100a_1aed:
            ii(0x100a_1aed, 7); mov(memd_a32[ss, ebp - 0x28], 0x101a_0aca); /* mov dword [ebp-0x28], 0x101a0aca */ /* "gold" */
            ii(0x100a_1af4, 5); jmpd(0x100a_1ba2, 0xa9); goto l_0x100a_1ba2; /* jmp 0x100a1ba2 */
        l_0x100a_1af9:
            ii(0x100a_1af9, 4); movsx(eax, memw_a32[ss, ebp - 0x12]);   /* movsx eax, word [ebp-0x12] */
            ii(0x100a_1afd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1aff, 2); if(jged(0x100a_1b1d, 0x1c)) goto l_0x100a_1b1d; /* jge 0x100a1b1d */
            ii(0x100a_1b01, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1b04, 3); mov(eax, memd_a32[ds, eax + 0x2e]);     /* mov eax, [eax+0x2e] */
            ii(0x100a_1b07, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_1b0a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1b0c, 2); if(jld(0x100a_1b1b, 0xd)) goto l_0x100a_1b1b; /* jl 0x100a1b1b */
            ii(0x100a_1b0e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1b11, 3); mov(eax, memd_a32[ds, eax + 0x2c]);     /* mov eax, [eax+0x2c] */
            ii(0x100a_1b14, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_1b17, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1b19, 2); if(jged(0x100a_1b1d, 0x2)) goto l_0x100a_1b1d; /* jge 0x100a1b1d */
        l_0x100a_1b1b:
            ii(0x100a_1b1b, 2); jmpd(0x100a_1b1f, 0x2); goto l_0x100a_1b1f; /* jmp 0x100a1b1f */
        l_0x100a_1b1d:
            ii(0x100a_1b1d, 2); jmpd(0x100a_1b2f, 0x10); goto l_0x100a_1b2f; /* jmp 0x100a1b2f */
        l_0x100a_1b1f:
            ii(0x100a_1b1f, 7); mov(memd_a32[ss, ebp - 0x28], 0x101a_0acf); /* mov dword [ebp-0x28], 0x101a0acf */ /* "power" */
            ii(0x100a_1b26, 4); mov(memb_a32[ss, ebp - 0x20], 0x1);     /* mov byte [ebp-0x20], 0x1 */
            ii(0x100a_1b2a, 5); jmpd(0x100a_1ba2, 0x73); goto l_0x100a_1ba2; /* jmp 0x100a1ba2 */
        l_0x100a_1b2f:
            ii(0x100a_1b2f, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100a_1b33, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1b35, 2); if(jged(0x100a_1b44, 0xd)) goto l_0x100a_1b44; /* jge 0x100a1b44 */
            ii(0x100a_1b37, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1b3a, 3); mov(eax, memd_a32[ds, eax + 0x30]);     /* mov eax, [eax+0x30] */
            ii(0x100a_1b3d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_1b40, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1b42, 2); if(jld(0x100a_1b46, 0x2)) goto l_0x100a_1b46; /* jl 0x100a1b46 */
        l_0x100a_1b44:
            ii(0x100a_1b44, 2); jmpd(0x100a_1b53, 0xd); goto l_0x100a_1b53; /* jmp 0x100a1b53 */
        l_0x100a_1b46:
            ii(0x100a_1b46, 4); mov(memb_a32[ss, ebp - 0x24], 0x1);     /* mov byte [ebp-0x24], 0x1 */
            ii(0x100a_1b4a, 7); mov(memd_a32[ss, ebp - 0x28], 0x101a_0ad5); /* mov dword [ebp-0x28], 0x101a0ad5 */ /* "workers" */
            ii(0x100a_1b51, 2); jmpd(0x100a_1ba2, 0x4f); goto l_0x100a_1ba2; /* jmp 0x100a1ba2 */
        l_0x100a_1b53:
            ii(0x100a_1b53, 4); movsx(eax, memw_a32[ss, ebp - 0x16]);   /* movsx eax, word [ebp-0x16] */
            ii(0x100a_1b57, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1b59, 2); if(jged(0x100a_1b64, 0x9)) goto l_0x100a_1b64; /* jge 0x100a1b64 */
            ii(0x100a_1b5b, 7); mov(memd_a32[ss, ebp - 0x28], 0x101a_0add); /* mov dword [ebp-0x28], 0x101a0add */ /* "raw material" */
            ii(0x100a_1b62, 2); jmpd(0x100a_1ba2, 0x3e); goto l_0x100a_1ba2; /* jmp 0x100a1ba2 */
        l_0x100a_1b64:
            ii(0x100a_1b64, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100a_1b68, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1b6a, 2); if(jged(0x100a_1b75, 0x9)) goto l_0x100a_1b75; /* jge 0x100a1b75 */
            ii(0x100a_1b6c, 7); mov(memd_a32[ss, ebp - 0x28], 0x101a_0aea); /* mov dword [ebp-0x28], 0x101a0aea */ /* "fuel" */
            ii(0x100a_1b73, 2); jmpd(0x100a_1ba2, 0x2d); goto l_0x100a_1ba2; /* jmp 0x100a1ba2 */
        l_0x100a_1b75:
            ii(0x100a_1b75, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100a_1b79, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1b7b, 2); if(jged(0x100a_1b86, 0x9)) goto l_0x100a_1b86; /* jge 0x100a1b86 */
            ii(0x100a_1b7d, 7); mov(memd_a32[ss, ebp - 0x28], 0x101a_0aef); /* mov dword [ebp-0x28], 0x101a0aef */ /* "gold" */
            ii(0x100a_1b84, 2); jmpd(0x100a_1ba2, 0x1c); goto l_0x100a_1ba2; /* jmp 0x100a1ba2 */
        l_0x100a_1b86:
            ii(0x100a_1b86, 4); movsx(eax, memw_a32[ss, ebp - 0x12]);   /* movsx eax, word [ebp-0x12] */
            ii(0x100a_1b8a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1b8c, 2); if(jged(0x100a_1b9b, 0xd)) goto l_0x100a_1b9b; /* jge 0x100a1b9b */
            ii(0x100a_1b8e, 7); mov(memd_a32[ss, ebp - 0x28], 0x101a_0af4); /* mov dword [ebp-0x28], 0x101a0af4 */ /* "power" */
            ii(0x100a_1b95, 4); mov(memb_a32[ss, ebp - 0x20], 0x1);     /* mov byte [ebp-0x20], 0x1 */
            ii(0x100a_1b99, 2); jmpd(0x100a_1ba2, 0x7); goto l_0x100a_1ba2; /* jmp 0x100a1ba2 */
        l_0x100a_1b9b:
            ii(0x100a_1b9b, 7); mov(memd_a32[ss, ebp - 0x28], 0x101a_0afa); /* mov dword [ebp-0x28], 0x101a0afa */ /* "debugging :P" */
        l_0x100a_1ba2:
            ii(0x100a_1ba2, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100a_1ba5, 1); pushd(eax);                             /* push eax */
            ii(0x100a_1ba6, 5); mov(ecx, 0x101a_0b07);                  /* mov ecx, 0x101a0b07 */ /* "More %s needed, %s turned off.\n" */
            ii(0x100a_1bab, 5); mov(ebx, 0x101a_0b27);                  /* mov ebx, 0x101a0b27 */ /* "Cannot turn %s on, %s needed.\n" */
            ii(0x100a_1bb0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_1bb3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1bb6, 5); calld(0x100a_0f77, -0xc44);             /* call 0x100a0f77 */
            ii(0x100a_1bbb, 4); cmp(memb_a32[ss, ebp - 0x24], 0);       /* cmp byte [ebp-0x24], 0x0 */
            ii(0x100a_1bbf, 2); if(jzd(0x100a_1bc9, 0x8)) goto l_0x100a_1bc9; /* jz 0x100a1bc9 */
            ii(0x100a_1bc1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1bc4, 5); calld(0x100a_11a0, -0xa29);             /* call 0x100a11a0 */
        l_0x100a_1bc9:
            ii(0x100a_1bc9, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100a_1bcc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1bcf, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x100a_1bd2, 5); calld(0x100a_13f7, -0x7e0);             /* call 0x100a13f7 */
            ii(0x100a_1bd7, 4); cmp(memb_a32[ss, ebp - 0x20], 0);       /* cmp byte [ebp-0x20], 0x0 */
            ii(0x100a_1bdb, 2); if(jzd(0x100a_1bed, 0x10)) goto l_0x100a_1bed; /* jz 0x100a1bed */
            ii(0x100a_1bdd, 3); mov(eax, memd_a32[ss, ebp - 0x12]);     /* mov eax, [ebp-0x12] */
            ii(0x100a_1be0, 2); neg(eax);                               /* neg eax */
            ii(0x100a_1be2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_1be5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1be8, 5); calld(0x100a_110d, -0xae0);             /* call 0x100a110d */
        l_0x100a_1bed:
            ii(0x100a_1bed, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_1bef, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x100a_1bf4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1bf7, 5); calld(0x1016_3053, 0xc1457);            /* call 0x10163053 */
            ii(0x100a_1bfc, 7); mov(memd_a32[ss, ebp - 0x1c], 0x1);     /* mov dword [ebp-0x1c], 0x1 */
            ii(0x100a_1c03, 2); jmpd(0x100a_1c0c, 0x7); goto l_0x100a_1c0c; /* jmp 0x100a1c0c */
        l_0x100a_1c05:
            ii(0x100a_1c05, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
        l_0x100a_1c0c:
            ii(0x100a_1c0c, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100a_1c0f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_1c11, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_1c12, 1); popd(edi);                              /* pop edi */
            ii(0x100a_1c13, 1); popd(esi);                              /* pop esi */
            ii(0x100a_1c14, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_1c15, 1); retd(); return;                         /* ret */
        }
    }
}