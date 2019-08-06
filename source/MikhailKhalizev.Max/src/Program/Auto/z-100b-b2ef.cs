using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1f80bcfe-5141-4725-8d9a-c36820113c86")]
        public void Method_100b_b2ef()
        {
            ii(0x100b_b2ef, 5); pushd(0x214);                           /* push 0x214 */
            ii(0x100b_b2f4, 5); calld(Definitions.sys_check_available_stack_size, 0xaaa59); /* call 0x10165d52 */
            ii(0x100b_b2f9, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_b2fa, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_b2fb, 1); pushd(edx);                             /* push edx */
            ii(0x100b_b2fc, 1); pushd(esi);                             /* push esi */
            ii(0x100b_b2fd, 1); pushd(edi);                             /* push edi */
            ii(0x100b_b2fe, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_b2ff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_b301, 6); sub(esp, 0x1ec);                        /* sub esp, 0x1ec */
            ii(0x100b_b307, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_b30a, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100b_b30e, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_b311, 5); calld(0x1007_64fc, -0x44e1a);           /* call 0x100764fc */
            ii(0x100b_b316, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_b319, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100b_b31d, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100b_b321, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_b324, 5); calld(0x1008_a1e8, -0x31141);           /* call 0x1008a1e8 */
            ii(0x100b_b329, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100b_b32c, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100b_b330, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b333, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_b336, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_b33c, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100b_b342, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_b347, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100b_b34a, 2); if(jzd(0x100b_b365, 0x19)) goto l_0x100b_b365; /* jz 0x100bb365 */
            ii(0x100b_b34c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b34e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_b351, 5); calld(0x1008_8e4c, -0x3250a);           /* call 0x10088e4c */
            ii(0x100b_b356, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b358, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_b35b, 5); calld(0x1007_5f6c, -0x453f4);           /* call 0x10075f6c */
            ii(0x100b_b360, 5); jmpd(0x100b_cbe0, 0x187b); goto l_0x100b_cbe0; /* jmp 0x100bcbe0 */
        l_0x100b_b365:
            ii(0x100b_b365, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_b36c, 2); jmpd(0x100b_b374, 0x6); goto l_0x100b_b374; /* jmp 0x100bb374 */
        l_0x100b_b36e:
            ii(0x100b_b36e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_b371, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_b374:
            ii(0x100b_b374, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_b378, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100b_b37b, 2); if(jged(0x100b_b38d, 0x10)) goto l_0x100b_b38d; /* jge 0x100bb38d */
            ii(0x100b_b37d, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_b381, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100b_b384, 7); mov(memb_a32[ds, eax + 0x101c_34f4], 0); /* mov byte [eax+0x101c34f4], 0x0 */
            ii(0x100b_b38b, 2); jmpd(0x100b_b36e, -0x1f); goto l_0x100b_b36e; /* jmp 0x100bb36e */
        l_0x100b_b38d:
            ii(0x100b_b38d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b390, 4); mov(memb_a32[ds, eax + 0x10], 0);       /* mov byte [eax+0x10], 0x0 */
            ii(0x100b_b394, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b397, 3); add(eax, 0x6d);                         /* add eax, 0x6d */
            ii(0x100b_b39a, 5); calld(0x1013_a6f4, 0x7f355);            /* call 0x1013a6f4 */
            ii(0x100b_b39f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_b3a1, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100b_b3a6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_b3a8, 2); if(jnzd(0x100b_b3fb, 0x51)) goto l_0x100b_b3fb; /* jnz 0x100bb3fb */
            ii(0x100b_b3aa, 3); lea(edi, ebp - 0x38);                   /* lea edi, [ebp-0x38] */
            ii(0x100b_b3ad, 5); mov(esi, 0x101b_77cc);                  /* mov esi, 0x101b77cc */
            ii(0x100b_b3b2, 1); movsd_a32();                            /* movsd */
            ii(0x100b_b3b3, 1); movsd_a32();                            /* movsd */
            ii(0x100b_b3b4, 1); movsd_a32();                            /* movsd */
            ii(0x100b_b3b5, 1); movsd_a32();                            /* movsd */
            ii(0x100b_b3b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b3b9, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_b3bc, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_b3bf, 4); pushd(memd_a32[ds, eax + ebp - 0x38]);  /* push dword [eax+ebp-0x38] */
            ii(0x100b_b3c3, 5); mov(eax, StringDefinitions.SComputerTurn); /* mov eax, 0x101a12c6 */
            ii(0x100b_b3c8, 1); pushd(eax);                             /* push eax */
            ii(0x100b_b3c9, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x100b_b3cf, 1); pushd(eax);                             /* push eax */
            ii(0x100b_b3d0, 5); calld(Definitions.sys_sprintf, 0xaab2c); /* call 0x10165f01 */
            ii(0x100b_b3d5, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100b_b3d8, 5); calld(0x100c_aa00, 0xf623);             /* call 0x100caa00 */
            ii(0x100b_b3dd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_b3e2, 1); pushd(eax);                             /* push eax */
            ii(0x100b_b3e3, 5); calld(0x100c_aa20, 0xf638);             /* call 0x100caa20 */
            ii(0x100b_b3e8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_b3ea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b3ec, 6); lea(esi, ebp - 0x88);                   /* lea esi, [ebp-0x88] */
            ii(0x100b_b3f2, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_b3f4, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100b_b3f6, 5); calld(0x1011_5d23, 0x5a928);            /* call 0x10115d23 */
        l_0x100b_b3fb:
            ii(0x100b_b3fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b3fe, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_b401, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x100b_b407, 5); calld(0x100b_aaec, -0x920);             /* call 0x100baaec */
            ii(0x100b_b40c, 6); lea(edx, ebp - 0x8c);                   /* lea edx, [ebp-0x8c] */
            ii(0x100b_b412, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x100b_b418, 5); calld(0x1007_5e64, -0x455b9);           /* call 0x10075e64 */
            ii(0x100b_b41d, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_b420, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b422, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_b424, 5); calld(0x100b_af35, -0x4f4);             /* call 0x100baf35 */
            ii(0x100b_b429, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b42c, 5); calld(0x100b_ad49, -0x6e8);             /* call 0x100bad49 */
            ii(0x100b_b431, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b434, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_b437, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_b43d, 7); mov(ax, memw_a32[ds, eax + 0x101c_a550]); /* mov ax, [eax+0x101ca550] */
            ii(0x100b_b444, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_b447, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x100b_b44c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b44e, 6); lea(eax, ebp - 0x9c);                   /* lea eax, [ebp-0x9c] */
            ii(0x100b_b454, 5); calld(Definitions.sys_memset, 0xaa987); /* call 0x10165de0 */
            ii(0x100b_b459, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_b45e, 5); calld(0x1007_6338, -0x4512b);           /* call 0x10076338 */
            ii(0x100b_b463, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b465, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_b468, 5); calld(0x1007_643c, -0x45031);           /* call 0x1007643c */
            ii(0x100b_b46d, 2); jmpd(0x100b_b477, 0x8); goto l_0x100b_b477; /* jmp 0x100bb477 */
        l_0x100b_b46f:
            ii(0x100b_b46f, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_b472, 5); calld(0x1007_6bf8, -0x4487f);           /* call 0x10076bf8 */
        l_0x100b_b477:
            ii(0x100b_b477, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b479, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_b47c, 5); calld(0x1013_ad71, 0x7f8f0);            /* call 0x1013ad71 */
            ii(0x100b_b481, 2); test(al, al);                           /* test al, al */
            ii(0x100b_b483, 2); if(jzd(0x100b_b4a1, 0x1c)) goto l_0x100b_b4a1; /* jz 0x100bb4a1 */
            ii(0x100b_b485, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_b488, 5); calld(0x1007_63a0, -0x450ed);           /* call 0x100763a0 */
            ii(0x100b_b48d, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100b_b490, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_b495, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100b_b497, 8); inc(memw_a32[ds, eax + ebp - 0x9c]);    /* inc word [eax+ebp-0x9c] */
            ii(0x100b_b49f, 2); jmpd(0x100b_b46f, -0x32); goto l_0x100b_b46f; /* jmp 0x100bb46f */
        l_0x100b_b4a1:
            ii(0x100b_b4a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b4a4, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100b_b4a7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_b4aa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_b4ac, 2); if(jged(0x100b_b4b7, 0x9)) goto l_0x100b_b4b7; /* jge 0x100bb4b7 */
            ii(0x100b_b4ae, 7); mov(memd_a32[ss, ebp - 0xc], 0xffff_ffff); /* mov dword [ebp-0xc], 0xffffffff */
            ii(0x100b_b4b5, 2); jmpd(0x100b_b507, 0x50); goto l_0x100b_b507; /* jmp 0x100bb507 */
        l_0x100b_b4b7:
            ii(0x100b_b4b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b4ba, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100b_b4bd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_b4c0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_b4c6, 7); mov(ax, memw_a32[ds, eax + 0x101c_a550]); /* mov ax, [eax+0x101ca550] */
            ii(0x100b_b4cd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_b4d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b4d3, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100b_b4d6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_b4d9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_b4df, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100b_b4e5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_b4ea, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100b_b4ed, 2); if(jzd(0x100b_b507, 0x18)) goto l_0x100b_b507; /* jz 0x100bb507 */
            ii(0x100b_b4ef, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_b4f2, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100b_b4f6, 2); if(jld(0x100b_b501, 0x9)) goto l_0x100b_b501; /* jl 0x100bb501 */
            ii(0x100b_b4f8, 7); add(memd_a32[ss, ebp - 0xc], 0x3e8);    /* add dword [ebp-0xc], 0x3e8 */
            ii(0x100b_b4ff, 2); jmpd(0x100b_b507, 0x6); goto l_0x100b_b507; /* jmp 0x100bb507 */
        l_0x100b_b501:
            ii(0x100b_b501, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_b504, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100b_b507:
            ii(0x100b_b507, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_b50e, 2); jmpd(0x100b_b516, 0x6); goto l_0x100b_b516; /* jmp 0x100bb516 */
        l_0x100b_b510:
            ii(0x100b_b510, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_b513, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_b516:
            ii(0x100b_b516, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_b51a, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100b_b51d, 6); if(jged(0x100b_b613, 0xf0)) goto l_0x100b_b613; /* jge 0x100bb613 */
            ii(0x100b_b523, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_b527, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_b52d, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100b_b533, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_b538, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_b53a, 2); if(jzd(0x100b_b547, 0xb)) goto l_0x100b_b547; /* jz 0x100bb547 */
            ii(0x100b_b53c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_b53f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_b542, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x100b_b545, 2); if(jnzd(0x100b_b549, 0x2)) goto l_0x100b_b549; /* jnz 0x100bb549 */
        l_0x100b_b547:
            ii(0x100b_b547, 2); jmpd(0x100b_b555, 0xc); goto l_0x100b_b555; /* jmp 0x100bb555 */
        l_0x100b_b549:
            ii(0x100b_b549, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_b54c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_b54f, 4); cmp(ax, memw_a32[ds, edx + 0x7b]);      /* cmp ax, [edx+0x7b] */
            ii(0x100b_b553, 2); if(jnzd(0x100b_b55a, 0x5)) goto l_0x100b_b55a; /* jnz 0x100bb55a */
        l_0x100b_b555:
            ii(0x100b_b555, 5); jmpd(0x100b_b60e, 0xb4); goto l_0x100b_b60e; /* jmp 0x100bb60e */
        l_0x100b_b55a:
            ii(0x100b_b55a, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_b55e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_b564, 7); mov(ax, memw_a32[ds, eax + 0x101c_a550]); /* mov ax, [eax+0x101ca550] */
            ii(0x100b_b56b, 6); mov(memd_a32[ss, ebp - 0xa0], eax);     /* mov [ebp-0xa0], eax */
            ii(0x100b_b571, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_b575, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_b57b, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100b_b581, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_b586, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100b_b589, 2); if(jzd(0x100b_b5af, 0x24)) goto l_0x100b_b5af; /* jz 0x100bb5af */
            ii(0x100b_b58b, 6); mov(eax, memd_a32[ss, ebp - 0xa0]);     /* mov eax, [ebp-0xa0] */
            ii(0x100b_b591, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100b_b595, 2); if(jld(0x100b_b5a3, 0xc)) goto l_0x100b_b5a3; /* jl 0x100bb5a3 */
            ii(0x100b_b597, 10); add(memd_a32[ss, ebp - 0xa0], 0x3e8);  /* add dword [ebp-0xa0], 0x3e8 */
            ii(0x100b_b5a1, 2); jmpd(0x100b_b5af, 0xc); goto l_0x100b_b5af; /* jmp 0x100bb5af */
        l_0x100b_b5a3:
            ii(0x100b_b5a3, 6); mov(eax, memd_a32[ss, ebp - 0xa0]);     /* mov eax, [ebp-0xa0] */
            ii(0x100b_b5a9, 6); inc(memd_a32[ss, ebp - 0xa0]);          /* inc dword [ebp-0xa0] */
        l_0x100b_b5af:
            ii(0x100b_b5af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b5b2, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100b_b5b5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_b5b8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_b5ba, 2); if(jld(0x100b_b5c8, 0xc)) goto l_0x100b_b5c8; /* jl 0x100bb5c8 */
            ii(0x100b_b5bc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_b5bf, 7); cmp(ax, memw_a32[ss, ebp - 0xa0]);      /* cmp ax, [ebp-0xa0] */
            ii(0x100b_b5c6, 2); if(jged(0x100b_b5ca, 0x2)) goto l_0x100b_b5ca; /* jge 0x100bb5ca */
        l_0x100b_b5c8:
            ii(0x100b_b5c8, 2); jmpd(0x100b_b5fb, 0x31); goto l_0x100b_b5fb; /* jmp 0x100bb5fb */
        l_0x100b_b5ca:
            ii(0x100b_b5ca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_b5cd, 7); cmp(ax, memw_a32[ss, ebp - 0xa0]);      /* cmp ax, [ebp-0xa0] */
            ii(0x100b_b5d4, 2); if(jnzd(0x100b_b5f9, 0x23)) goto l_0x100b_b5f9; /* jnz 0x100bb5f9 */
            ii(0x100b_b5d6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b5d9, 3); mov(edx, memd_a32[ds, eax + 0x79]);     /* mov edx, [eax+0x79] */
            ii(0x100b_b5dc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_b5df, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100b_b5e1, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_b5e5, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100b_b5e7, 8); mov(dx, memw_a32[ds, edx + ebp - 0x9c]); /* mov dx, [edx+ebp-0x9c] */
            ii(0x100b_b5ef, 8); cmp(dx, memw_a32[ds, eax + ebp - 0x9c]); /* cmp dx, [eax+ebp-0x9c] */
            ii(0x100b_b5f7, 2); if(jld(0x100b_b5fb, 0x2)) goto l_0x100b_b5fb; /* jl 0x100bb5fb */
        l_0x100b_b5f9:
            ii(0x100b_b5f9, 2); jmpd(0x100b_b60e, 0x13); goto l_0x100b_b60e; /* jmp 0x100bb60e */
        l_0x100b_b5fb:
            ii(0x100b_b5fb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_b5fe, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_b601, 4); mov(memw_a32[ds, edx + 0x7b], ax);      /* mov [edx+0x7b], ax */
            ii(0x100b_b605, 6); mov(eax, memd_a32[ss, ebp - 0xa0]);     /* mov eax, [ebp-0xa0] */
            ii(0x100b_b60b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x100b_b60e:
            ii(0x100b_b60e, 5); jmpd(0x100b_b510, -0x103); goto l_0x100b_b510; /* jmp 0x100bb510 */
        l_0x100b_b613:
            ii(0x100b_b613, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b616, 4); cmp(memb_a32[ds, eax + 0xe], 0);        /* cmp byte [eax+0xe], 0x0 */
            ii(0x100b_b61a, 6); if(jzd(0x100b_c505, 0xee5)) goto l_0x100b_c505; /* jz 0x100bc505 */
            ii(0x100b_b620, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x100b_b625, 5); calld(Definitions.sys_new, 0xaa7d6);    /* call 0x10165e00 */
            ii(0x100b_b62a, 6); mov(memd_a32[ss, ebp - 0xa4], eax);     /* mov [ebp-0xa4], eax */
            ii(0x100b_b630, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100b_b636, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
            ii(0x100b_b63c, 7); cmp(memd_a32[ss, ebp - 0xa8], 0);       /* cmp dword [ebp-0xa8], 0x0 */
            ii(0x100b_b643, 2); if(jzd(0x100b_b66a, 0x25)) goto l_0x100b_b66a; /* jz 0x100bb66a */
            ii(0x100b_b645, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b648, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_b64b, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100b_b651, 5); calld(0x1007_c9c6, -0x3ec90);           /* call 0x1007c9c6 */
            ii(0x100b_b656, 6); mov(memd_a32[ss, ebp - 0xac], eax);     /* mov [ebp-0xac], eax */
            ii(0x100b_b65c, 6); mov(eax, memd_a32[ss, ebp - 0xac]);     /* mov eax, [ebp-0xac] */
            ii(0x100b_b662, 6); mov(memd_a32[ss, ebp - 0xb0], eax);     /* mov [ebp-0xb0], eax */
            ii(0x100b_b668, 2); jmpd(0x100b_b676, 0xc); goto l_0x100b_b676; /* jmp 0x100bb676 */
        l_0x100b_b66a:
            ii(0x100b_b66a, 6); mov(eax, memd_a32[ss, ebp - 0xa8]);     /* mov eax, [ebp-0xa8] */
            ii(0x100b_b670, 6); mov(memd_a32[ss, ebp - 0xb0], eax);     /* mov [ebp-0xb0], eax */
        l_0x100b_b676:
            ii(0x100b_b676, 6); mov(edx, memd_a32[ss, ebp - 0xb0]);     /* mov edx, [ebp-0xb0] */
            ii(0x100b_b67c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b67f, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_b682, 5); calld(0x1008_afe4, -0x306a3);           /* call 0x1008afe4 */
            ii(0x100b_b687, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b68a, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_b68d, 5); calld(0x1008_af84, -0x3070e);           /* call 0x1008af84 */
            ii(0x100b_b692, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b694, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_b699, 5); calld(0x100a_4d50, -0x1694e);           /* call 0x100a4d50 */
            ii(0x100b_b69e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6a1, 4); cmp(memb_a32[ds, eax + 0x2], 0);        /* cmp byte [eax+0x2], 0x0 */
            ii(0x100b_b6a5, 6); if(jnzd(0x100b_b745, 0x9a)) goto l_0x100b_b745; /* jnz 0x100bb745 */
            ii(0x100b_b6ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6ae, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_b6b1, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_b6b7, 6); mov(al, memb_a32[ds, eax + 0x101c_a4ef]); /* mov al, [eax+0x101ca4ef] */
            ii(0x100b_b6bd, 6); mov(memb_a32[ss, ebp - 0xb4], al);      /* mov [ebp-0xb4], al */
            ii(0x100b_b6c3, 2); jmpd(0x100b_b71c, 0x57); goto l_0x100b_b71c; /* jmp 0x100bb71c */
        //  ii(0x100b_b6c5, 48); Недостижимый код.
        l_0x100b_b6f5:
            ii(0x100b_b6f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6f8, 4); mov(memb_a32[ds, eax + 0x2], 0x8);      /* mov byte [eax+0x2], 0x8 */
            ii(0x100b_b6fc, 2); jmpd(0x100b_b745, 0x47); goto l_0x100b_b745; /* jmp 0x100bb745 */
        //  ii(0x100b_b6fe, 30); Недостижимый код.
        l_0x100b_b71c:
            ii(0x100b_b71c, 6); mov(al, memb_a32[ss, ebp - 0xb4]);      /* mov al, [ebp-0xb4] */
            ii(0x100b_b722, 2); dec(al);                                /* dec al */
            ii(0x100b_b724, 6); mov(memb_a32[ss, ebp - 0xb8], al);      /* mov [ebp-0xb8], al */
            ii(0x100b_b72a, 7); cmp(memb_a32[ss, ebp - 0xb8], 0x6);     /* cmp byte [ebp-0xb8], 0x6 */
            ii(0x100b_b731, 2); if(jad(0x100b_b6f5, -0x3e)) goto l_0x100b_b6f5; /* ja 0x100bb6f5 */
            ii(0x100b_b733, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_b735, 6); mov(al, memb_a32[ss, ebp - 0xb8]);      /* mov al, [ebp-0xb8] */
            ii(0x100b_b73b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_b73e, 7); jmpd_abs(memd_a32[cs, eax + 0x100b_b700]); return; /* jmp dword [cs:eax+0x100bb700] */
        l_0x100b_b745:
            ii(0x100b_b745, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b748, 3); mov(eax, memd_a32[ds, eax + 0x1]);      /* mov eax, [eax+0x1] */
            ii(0x100b_b74b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_b74e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_b750, 2); if(jnzd(0x100b_b75a, 0x8)) goto l_0x100b_b75a; /* jnz 0x100bb75a */
            ii(0x100b_b752, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b755, 5); calld(0x100c_4051, 0x88f7);             /* call 0x100c4051 */
        l_0x100b_b75a:
            ii(0x100b_b75a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b75d, 3); mov(eax, memd_a32[ds, eax + 0x3]);      /* mov eax, [eax+0x3] */
            ii(0x100b_b760, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_b763, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_b765, 2); if(jged(0x100b_b76f, 0x8)) goto l_0x100b_b76f; /* jge 0x100bb76f */
            ii(0x100b_b767, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b76a, 5); calld(0x100c_409c, 0x892d);             /* call 0x100c409c */
        l_0x100b_b76f:
            ii(0x100b_b76f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b772, 3); mov(eax, memd_a32[ds, eax + 0x5]);      /* mov eax, [eax+0x5] */
            ii(0x100b_b775, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_b778, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_b77a, 2); if(jged(0x100b_b784, 0x8)) goto l_0x100b_b784; /* jge 0x100bb784 */
            ii(0x100b_b77c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b77f, 5); calld(0x100c_4162, 0x89de);             /* call 0x100c4162 */
        l_0x100b_b784:
            ii(0x100b_b784, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b787, 5); calld(0x100b_a6d6, -0x10b6);            /* call 0x100ba6d6 */
            ii(0x100b_b78c, 7); mov(dx, memw_a32[ds, 0x101c_8172]);     /* mov dx, [0x101c8172] */
            ii(0x100b_b793, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b796, 4); mov(memw_a32[ds, eax + 0x61], dx);      /* mov [eax+0x61], dx */
            ii(0x100b_b79a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b79d, 4); cmp(memd_a32[ds, eax + 0x63], 0);       /* cmp dword [eax+0x63], 0x0 */
            ii(0x100b_b7a1, 6); if(jnzd(0x100b_b821, 0x7a)) goto l_0x100b_b821; /* jnz 0x100bb821 */
            ii(0x100b_b7a7, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x100b_b7ac, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_b7af, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_b7b2, 5); calld(Definitions.sys_new_arr, 0xaa859); /* call 0x10166010 */
            ii(0x100b_b7b7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b7b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b7bc, 3); mov(memd_a32[ds, eax + 0x63], edx);     /* mov [eax+0x63], edx */
            ii(0x100b_b7bf, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_b7c6, 2); jmpd(0x100b_b7ce, 0x6); goto l_0x100b_b7ce; /* jmp 0x100bb7ce */
        l_0x100b_b7c8:
            ii(0x100b_b7c8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_b7cb, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_b7ce:
            ii(0x100b_b7ce, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_b7d1, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100b_b7d8, 2); if(jged(0x100b_b821, 0x47)) goto l_0x100b_b821; /* jge 0x100bb821 */
            ii(0x100b_b7da, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100b_b7df, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_b7e2, 5); calld(Definitions.sys_new_arr, 0xaa829); /* call 0x10166010 */
            ii(0x100b_b7e7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_b7e9, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_b7ed, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_b7f0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b7f2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b7f5, 3); mov(eax, memd_a32[ds, eax + 0x63]);     /* mov eax, [eax+0x63] */
            ii(0x100b_b7f8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_b7fa, 2); mov(memd_a32[ds, eax], ebx);            /* mov [eax], ebx */
            ii(0x100b_b7fc, 6); mov(ebx, memd_a32[ds, 0x101c_8172]);    /* mov ebx, [0x101c8172] */
            ii(0x100b_b802, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_b805, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b807, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_b80b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_b80e, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_b810, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b813, 3); mov(eax, memd_a32[ds, eax + 0x63]);     /* mov eax, [eax+0x63] */
            ii(0x100b_b816, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100b_b818, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_b81a, 5); calld(Definitions.sys_memset, 0xaa5c1); /* call 0x10165de0 */
            ii(0x100b_b81f, 2); jmpd(0x100b_b7c8, -0x59); goto l_0x100b_b7c8; /* jmp 0x100bb7c8 */
        l_0x100b_b821:
            ii(0x100b_b821, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b824, 4); cmp(memd_a32[ds, eax + 0x67], 0);       /* cmp dword [eax+0x67], 0x0 */
            ii(0x100b_b828, 6); if(jnzd(0x100b_b8a8, 0x7a)) goto l_0x100b_b8a8; /* jnz 0x100bb8a8 */
            ii(0x100b_b82e, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x100b_b833, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_b836, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_b839, 5); calld(Definitions.sys_new_arr, 0xaa7d2); /* call 0x10166010 */
            ii(0x100b_b83e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b840, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b843, 3); mov(memd_a32[ds, eax + 0x67], edx);     /* mov [eax+0x67], edx */
            ii(0x100b_b846, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_b84d, 2); jmpd(0x100b_b855, 0x6); goto l_0x100b_b855; /* jmp 0x100bb855 */
        l_0x100b_b84f:
            ii(0x100b_b84f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_b852, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_b855:
            ii(0x100b_b855, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_b858, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100b_b85f, 2); if(jged(0x100b_b8a8, 0x47)) goto l_0x100b_b8a8; /* jge 0x100bb8a8 */
            ii(0x100b_b861, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100b_b866, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_b869, 5); calld(Definitions.sys_new_arr, 0xaa7a2); /* call 0x10166010 */
            ii(0x100b_b86e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_b870, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_b874, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_b877, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b879, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b87c, 3); mov(eax, memd_a32[ds, eax + 0x67]);     /* mov eax, [eax+0x67] */
            ii(0x100b_b87f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_b881, 2); mov(memd_a32[ds, eax], ebx);            /* mov [eax], ebx */
            ii(0x100b_b883, 6); mov(ebx, memd_a32[ds, 0x101c_8172]);    /* mov ebx, [0x101c8172] */
            ii(0x100b_b889, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_b88c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b88e, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_b892, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_b895, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_b897, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b89a, 3); mov(eax, memd_a32[ds, eax + 0x67]);     /* mov eax, [eax+0x67] */
            ii(0x100b_b89d, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100b_b89f, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_b8a1, 5); calld(Definitions.sys_memset, 0xaa53a); /* call 0x10165de0 */
            ii(0x100b_b8a6, 2); jmpd(0x100b_b84f, -0x59); goto l_0x100b_b84f; /* jmp 0x100bb84f */
        l_0x100b_b8a8:
            ii(0x100b_b8a8, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_b8af, 2); jmpd(0x100b_b8b7, 0x6); goto l_0x100b_b8b7; /* jmp 0x100bb8b7 */
        l_0x100b_b8b1:
            ii(0x100b_b8b1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_b8b4, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_b8b7:
            ii(0x100b_b8b7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_b8ba, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100b_b8c1, 6); if(jged(0x100b_b94a, 0x83)) goto l_0x100b_b94a; /* jge 0x100bb94a */
            ii(0x100b_b8c7, 10); mov(memd_a32[ss, ebp - 0xbc], 0);      /* mov dword [ebp-0xbc], 0x0 */
            ii(0x100b_b8d1, 2); jmpd(0x100b_b8df, 0xc); goto l_0x100b_b8df; /* jmp 0x100bb8df */
        l_0x100b_b8d3:
            ii(0x100b_b8d3, 6); mov(eax, memd_a32[ss, ebp - 0xbc]);     /* mov eax, [ebp-0xbc] */
            ii(0x100b_b8d9, 6); inc(memd_a32[ss, ebp - 0xbc]);          /* inc dword [ebp-0xbc] */
        l_0x100b_b8df:
            ii(0x100b_b8df, 6); mov(eax, memd_a32[ss, ebp - 0xbc]);     /* mov eax, [ebp-0xbc] */
            ii(0x100b_b8e5, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x100b_b8ec, 2); if(jged(0x100b_b945, 0x57)) goto l_0x100b_b945; /* jge 0x100bb945 */
            ii(0x100b_b8ee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b8f1, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_b8f4, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_b8fa, 7); movsx(ebx, memw_a32[ss, ebp - 0xbc]);   /* movsx ebx, word [ebp-0xbc] */
            ii(0x100b_b901, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100b_b907, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_b90a, 3); imul(ebx, edx);                         /* imul ebx, edx */
            ii(0x100b_b90d, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100b_b911, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100b_b913, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a3]); /* mov eax, [eax+0x101ca6a3] */
            ii(0x100b_b919, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_b91b, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100b_b91d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_b922, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_b924, 2); if(jzd(0x100b_b943, 0x1d)) goto l_0x100b_b943; /* jz 0x100bb943 */
            ii(0x100b_b926, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100b_b92a, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100b_b92d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b930, 3); mov(eax, memd_a32[ds, eax + 0x63]);     /* mov eax, [eax+0x63] */
            ii(0x100b_b933, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_b935, 7); movsx(edx, memw_a32[ss, ebp - 0xbc]);   /* movsx edx, word [ebp-0xbc] */
            ii(0x100b_b93c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_b93e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_b940, 3); mov(memb_a32[ds, eax], 0x1);            /* mov byte [eax], 0x1 */
        l_0x100b_b943:
            ii(0x100b_b943, 2); jmpd(0x100b_b8d3, -0x72); goto l_0x100b_b8d3; /* jmp 0x100bb8d3 */
        l_0x100b_b945:
            ii(0x100b_b945, 5); jmpd(0x100b_b8b1, -0x99); goto l_0x100b_b8b1; /* jmp 0x100bb8b1 */
        l_0x100b_b94a:
            ii(0x100b_b94a, 7); movsx(eax, memw_a32[ss, ebp - 0x8c]);   /* movsx eax, word [ebp-0x8c] */
            ii(0x100b_b951, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_b953, 2); if(jnzd(0x100b_b964, 0xf)) goto l_0x100b_b964; /* jnz 0x100bb964 */
            ii(0x100b_b955, 7); movsx(eax, memw_a32[ss, ebp - 0x8a]);   /* movsx eax, word [ebp-0x8a] */
            ii(0x100b_b95c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_b95e, 6); if(jzd(0x100b_bb37, 0x1d3)) goto l_0x100b_bb37; /* jz 0x100bbb37 */
        l_0x100b_b964:
            ii(0x100b_b964, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x100b_b969, 5); calld(Definitions.sys_new, 0xaa492);    /* call 0x10165e00 */
            ii(0x100b_b96e, 6); mov(memd_a32[ss, ebp - 0xc0], eax);     /* mov [ebp-0xc0], eax */
            ii(0x100b_b974, 6); mov(eax, memd_a32[ss, ebp - 0xc0]);     /* mov eax, [ebp-0xc0] */
            ii(0x100b_b97a, 6); mov(memd_a32[ss, ebp - 0xc4], eax);     /* mov [ebp-0xc4], eax */
            ii(0x100b_b980, 7); cmp(memd_a32[ss, ebp - 0xc4], 0);       /* cmp dword [ebp-0xc4], 0x0 */
            ii(0x100b_b987, 2); if(jzd(0x100b_b9c1, 0x38)) goto l_0x100b_b9c1; /* jz 0x100bb9c1 */
            ii(0x100b_b989, 6); lea(edx, ebp - 0x8c);                   /* lea edx, [ebp-0x8c] */
            ii(0x100b_b98f, 6); lea(eax, ebp - 0xc8);                   /* lea eax, [ebp-0xc8] */
            ii(0x100b_b995, 5); calld(0x1007_5e64, -0x45b36);           /* call 0x10075e64 */
            ii(0x100b_b99a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_b99c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b99f, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_b9a2, 6); mov(eax, memd_a32[ss, ebp - 0xc0]);     /* mov eax, [ebp-0xc0] */
            ii(0x100b_b9a8, 5); calld(0x1009_e3ec, -0x1d5c1);           /* call 0x1009e3ec */
            ii(0x100b_b9ad, 6); mov(memd_a32[ss, ebp - 0xcc], eax);     /* mov [ebp-0xcc], eax */
            ii(0x100b_b9b3, 6); mov(eax, memd_a32[ss, ebp - 0xcc]);     /* mov eax, [ebp-0xcc] */
            ii(0x100b_b9b9, 6); mov(memd_a32[ss, ebp - 0xd0], eax);     /* mov [ebp-0xd0], eax */
            ii(0x100b_b9bf, 2); jmpd(0x100b_b9cd, 0xc); goto l_0x100b_b9cd; /* jmp 0x100bb9cd */
        l_0x100b_b9c1:
            ii(0x100b_b9c1, 6); mov(eax, memd_a32[ss, ebp - 0xc4]);     /* mov eax, [ebp-0xc4] */
            ii(0x100b_b9c7, 6); mov(memd_a32[ss, ebp - 0xd0], eax);     /* mov [ebp-0xd0], eax */
        l_0x100b_b9cd:
            ii(0x100b_b9cd, 6); mov(edx, memd_a32[ss, ebp - 0xd0]);     /* mov edx, [ebp-0xd0] */
            ii(0x100b_b9d3, 6); lea(eax, ebp - 0xd4);                   /* lea eax, [ebp-0xd4] */
            ii(0x100b_b9d9, 5); calld(0x1008_b060, -0x3097e);           /* call 0x1008b060 */
            ii(0x100b_b9de, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_b9e3, 5); calld(0x1007_6338, -0x456b0);           /* call 0x10076338 */
            ii(0x100b_b9e8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b9ea, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x100b_b9f0, 5); calld(0x1007_64b8, -0x4553d);           /* call 0x100764b8 */
            ii(0x100b_b9f5, 2); jmpd(0x100b_ba02, 0xb); goto l_0x100b_ba02; /* jmp 0x100bba02 */
        l_0x100b_b9f7:
            ii(0x100b_b9f7, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x100b_b9fd, 5); calld(0x1007_6bf8, -0x44e0a);           /* call 0x10076bf8 */
        l_0x100b_ba02:
            ii(0x100b_ba02, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_ba04, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x100b_ba0a, 5); calld(0x1013_ad71, 0x7f362);            /* call 0x1013ad71 */
            ii(0x100b_ba0f, 2); test(al, al);                           /* test al, al */
            ii(0x100b_ba11, 2); if(jzd(0x100b_ba75, 0x62)) goto l_0x100b_ba75; /* jz 0x100bba75 */
            ii(0x100b_ba13, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x100b_ba19, 5); calld(0x1007_63a0, -0x4567e);           /* call 0x100763a0 */
            ii(0x100b_ba1e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_ba20, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_ba23, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_ba26, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_ba29, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_ba2b, 2); if(jnzd(0x100b_ba3f, 0x12)) goto l_0x100b_ba3f; /* jnz 0x100bba3f */
            ii(0x100b_ba2d, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x100b_ba33, 5); calld(0x1007_63a0, -0x45698);           /* call 0x100763a0 */
            ii(0x100b_ba38, 5); cmp(memw_a32[ds, eax + 0x8], 0x39);     /* cmp word [eax+0x8], 0x39 */
            ii(0x100b_ba3d, 2); if(jzd(0x100b_ba41, 0x2)) goto l_0x100b_ba41; /* jz 0x100bba41 */
        l_0x100b_ba3f:
            ii(0x100b_ba3f, 2); jmpd(0x100b_ba73, 0x32); goto l_0x100b_ba73; /* jmp 0x100bba73 */
        l_0x100b_ba41:
            ii(0x100b_ba41, 6); lea(eax, ebp - 0xd4);                   /* lea eax, [ebp-0xd4] */
            ii(0x100b_ba47, 5); calld(0x1008_af28, -0x30b24);           /* call 0x1008af28 */
            ii(0x100b_ba4c, 6); mov(memd_a32[ss, ebp - 0xdc], eax);     /* mov [ebp-0xdc], eax */
            ii(0x100b_ba52, 6); mov(eax, memd_a32[ss, ebp - 0xdc]);     /* mov eax, [ebp-0xdc] */
            ii(0x100b_ba58, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100b_ba5b, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x100b_ba61, 5); calld(0x1007_6408, -0x4565e);           /* call 0x10076408 */
            ii(0x100b_ba66, 6); mov(ecx, memd_a32[ss, ebp - 0xdc]);     /* mov ecx, [ebp-0xdc] */
            ii(0x100b_ba6c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_ba6e, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_ba70, 3); calld_abs(memd_a32[ds, ebx + 0x2c]);    /* call dword [ebx+0x2c] */
        l_0x100b_ba73:
            ii(0x100b_ba73, 2); jmpd(0x100b_b9f7, -0x7e); goto l_0x100b_b9f7; /* jmp 0x100bb9f7 */
        l_0x100b_ba75:
            ii(0x100b_ba75, 6); lea(eax, ebp - 0xd4);                   /* lea eax, [ebp-0xd4] */
            ii(0x100b_ba7b, 5); calld(0x1008_af84, -0x30afc);           /* call 0x1008af84 */
            ii(0x100b_ba80, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_ba82, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_ba87, 5); calld(0x100a_4d50, -0x16d3c);           /* call 0x100a4d50 */
            ii(0x100b_ba8c, 5); mov(eax, 0x85);                         /* mov eax, 0x85 */
            ii(0x100b_ba91, 5); calld(Definitions.sys_new, 0xaa36a);    /* call 0x10165e00 */
            ii(0x100b_ba96, 6); mov(memd_a32[ss, ebp - 0xe0], eax);     /* mov [ebp-0xe0], eax */
            ii(0x100b_ba9c, 6); mov(eax, memd_a32[ss, ebp - 0xe0]);     /* mov eax, [ebp-0xe0] */
            ii(0x100b_baa2, 6); mov(memd_a32[ss, ebp - 0xe4], eax);     /* mov [ebp-0xe4], eax */
            ii(0x100b_baa8, 7); cmp(memd_a32[ss, ebp - 0xe4], 0);       /* cmp dword [ebp-0xe4], 0x0 */
            ii(0x100b_baaf, 2); if(jzd(0x100b_bae9, 0x38)) goto l_0x100b_bae9; /* jz 0x100bbae9 */
            ii(0x100b_bab1, 6); lea(edx, ebp - 0x8c);                   /* lea edx, [ebp-0x8c] */
            ii(0x100b_bab7, 6); lea(eax, ebp - 0xe8);                   /* lea eax, [ebp-0xe8] */
            ii(0x100b_babd, 5); calld(0x1007_5e64, -0x45c5e);           /* call 0x10075e64 */
            ii(0x100b_bac2, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_bac4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_bac7, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_baca, 6); mov(eax, memd_a32[ss, ebp - 0xe0]);     /* mov eax, [ebp-0xe0] */
            ii(0x100b_bad0, 5); calld(0x1009_e9be, -0x1d117);           /* call 0x1009e9be */
            ii(0x100b_bad5, 6); mov(memd_a32[ss, ebp - 0xec], eax);     /* mov [ebp-0xec], eax */
            ii(0x100b_badb, 6); mov(eax, memd_a32[ss, ebp - 0xec]);     /* mov eax, [ebp-0xec] */
            ii(0x100b_bae1, 6); mov(memd_a32[ss, ebp - 0xf0], eax);     /* mov [ebp-0xf0], eax */
            ii(0x100b_bae7, 2); jmpd(0x100b_baf5, 0xc); goto l_0x100b_baf5; /* jmp 0x100bbaf5 */
        l_0x100b_bae9:
            ii(0x100b_bae9, 6); mov(eax, memd_a32[ss, ebp - 0xe4]);     /* mov eax, [ebp-0xe4] */
            ii(0x100b_baef, 6); mov(memd_a32[ss, ebp - 0xf0], eax);     /* mov [ebp-0xf0], eax */
        l_0x100b_baf5:
            ii(0x100b_baf5, 6); mov(edx, memd_a32[ss, ebp - 0xf0]);     /* mov edx, [ebp-0xf0] */
            ii(0x100b_bafb, 6); lea(eax, ebp - 0xd4);                   /* lea eax, [ebp-0xd4] */
            ii(0x100b_bb01, 5); calld(0x1008_afe4, -0x30b22);           /* call 0x1008afe4 */
            ii(0x100b_bb06, 6); lea(eax, ebp - 0xd4);                   /* lea eax, [ebp-0xd4] */
            ii(0x100b_bb0c, 5); calld(0x1008_af84, -0x30b8d);           /* call 0x1008af84 */
            ii(0x100b_bb11, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_bb13, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_bb18, 5); calld(0x100a_4d50, -0x16dcd);           /* call 0x100a4d50 */
            ii(0x100b_bb1d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_bb1f, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x100b_bb25, 5); calld(0x1007_5f6c, -0x45bbe);           /* call 0x10075f6c */
            ii(0x100b_bb2a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_bb2c, 6); lea(eax, ebp - 0xd4);                   /* lea eax, [ebp-0xd4] */
            ii(0x100b_bb32, 5); calld(0x1008_8b7c, -0x32fbb);           /* call 0x10088b7c */
        l_0x100b_bb37:
            ii(0x100b_bb37, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x100b_bb3c, 5); calld(0x1007_6338, -0x45809);           /* call 0x10076338 */
            ii(0x100b_bb41, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_bb44, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_bb46, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_bb48, 5); calld(0x1007_643c, -0x45711);           /* call 0x1007643c */
            ii(0x100b_bb4d, 2); jmpd(0x100b_bb57, 0x8); goto l_0x100b_bb57; /* jmp 0x100bbb57 */
        l_0x100b_bb4f:
            ii(0x100b_bb4f, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bb52, 5); calld(0x1007_6bf8, -0x44f5f);           /* call 0x10076bf8 */
        l_0x100b_bb57:
            ii(0x100b_bb57, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_bb59, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bb5c, 5); calld(0x1013_ad71, 0x7f210);            /* call 0x1013ad71 */
            ii(0x100b_bb61, 2); test(al, al);                           /* test al, al */
            ii(0x100b_bb63, 2); if(jzd(0x100b_bbc2, 0x5d)) goto l_0x100b_bbc2; /* jz 0x100bbbc2 */
            ii(0x100b_bb65, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bb68, 5); calld(0x1007_63a0, -0x457cd);           /* call 0x100763a0 */
            ii(0x100b_bb6d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_bb6f, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_bb72, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_bb75, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_bb78, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_bb7a, 2); if(jnzd(0x100b_bb8a, 0xe)) goto l_0x100b_bb8a; /* jnz 0x100bbb8a */
            ii(0x100b_bb7c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bb7f, 5); calld(0x1007_63a0, -0x457e4);           /* call 0x100763a0 */
            ii(0x100b_bb84, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_bb88, 2); if(jnzd(0x100b_bb8c, 0x2)) goto l_0x100b_bb8c; /* jnz 0x100bbb8c */
        l_0x100b_bb8a:
            ii(0x100b_bb8a, 2); jmpd(0x100b_bbac, 0x20); goto l_0x100b_bbac; /* jmp 0x100bbbac */
        l_0x100b_bb8c:
            ii(0x100b_bb8c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bb8f, 5); calld(0x1007_63a0, -0x457f4);           /* call 0x100763a0 */
            ii(0x100b_bb94, 5); cmp(memw_a32[ds, eax + 0x8], 0x21);     /* cmp word [eax+0x8], 0x21 */
            ii(0x100b_bb99, 2); if(jzd(0x100b_bbaa, 0xf)) goto l_0x100b_bbaa; /* jz 0x100bbbaa */
            ii(0x100b_bb9b, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bb9e, 5); calld(0x1007_63a0, -0x45803);           /* call 0x100763a0 */
            ii(0x100b_bba3, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x100b_bba8, 2); if(jnzd(0x100b_bbac, 0x2)) goto l_0x100b_bbac; /* jnz 0x100bbbac */
        l_0x100b_bbaa:
            ii(0x100b_bbaa, 2); jmpd(0x100b_bbae, 0x2); goto l_0x100b_bbae; /* jmp 0x100bbbae */
        l_0x100b_bbac:
            ii(0x100b_bbac, 2); jmpd(0x100b_bbc0, 0x12); goto l_0x100b_bbc0; /* jmp 0x100bbbc0 */
        l_0x100b_bbae:
            ii(0x100b_bbae, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bbb1, 5); calld(0x1007_6408, -0x457ae);           /* call 0x10076408 */
            ii(0x100b_bbb6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_bbb8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_bbbb, 5); calld(0x100b_a131, -0x1a8f);            /* call 0x100ba131 */
        l_0x100b_bbc0:
            ii(0x100b_bbc0, 2); jmpd(0x100b_bb4f, -0x73); goto l_0x100b_bb4f; /* jmp 0x100bbb4f */
        l_0x100b_bbc2:
            ii(0x100b_bbc2, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_bbc7, 5); calld(0x1007_6338, -0x45894);           /* call 0x10076338 */
            ii(0x100b_bbcc, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_bbcf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_bbd1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_bbd3, 5); calld(0x1007_643c, -0x4579c);           /* call 0x1007643c */
            ii(0x100b_bbd8, 2); jmpd(0x100b_bbe2, 0x8); goto l_0x100b_bbe2; /* jmp 0x100bbbe2 */
        l_0x100b_bbda:
            ii(0x100b_bbda, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bbdd, 5); calld(0x1007_6bf8, -0x44fea);           /* call 0x10076bf8 */
        l_0x100b_bbe2:
            ii(0x100b_bbe2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_bbe4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bbe7, 5); calld(0x1013_ad71, 0x7f185);            /* call 0x1013ad71 */
            ii(0x100b_bbec, 2); test(al, al);                           /* test al, al */
            ii(0x100b_bbee, 2); if(jzd(0x100b_bc2b, 0x3b)) goto l_0x100b_bc2b; /* jz 0x100bbc2b */
            ii(0x100b_bbf0, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bbf3, 5); calld(0x1007_63a0, -0x45858);           /* call 0x100763a0 */
            ii(0x100b_bbf8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_bbfa, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_bbfd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_bc00, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_bc03, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_bc05, 2); if(jnzd(0x100b_bc15, 0xe)) goto l_0x100b_bc15; /* jnz 0x100bbc15 */
            ii(0x100b_bc07, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bc0a, 5); calld(0x1007_63a0, -0x4586f);           /* call 0x100763a0 */
            ii(0x100b_bc0f, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_bc13, 2); if(jnzd(0x100b_bc17, 0x2)) goto l_0x100b_bc17; /* jnz 0x100bbc17 */
        l_0x100b_bc15:
            ii(0x100b_bc15, 2); jmpd(0x100b_bc29, 0x12); goto l_0x100b_bc29; /* jmp 0x100bbc29 */
        l_0x100b_bc17:
            ii(0x100b_bc17, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bc1a, 5); calld(0x1007_6408, -0x45817);           /* call 0x10076408 */
            ii(0x100b_bc1f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_bc21, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_bc24, 5); calld(0x100b_a131, -0x1af8);            /* call 0x100ba131 */
        l_0x100b_bc29:
            ii(0x100b_bc29, 2); jmpd(0x100b_bbda, -0x51); goto l_0x100b_bbda; /* jmp 0x100bbbda */
        l_0x100b_bc2b:
            ii(0x100b_bc2b, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_bc30, 5); calld(0x1007_6338, -0x458fd);           /* call 0x10076338 */
            ii(0x100b_bc35, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_bc38, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_bc3a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_bc3c, 5); calld(0x1007_643c, -0x45805);           /* call 0x1007643c */
            ii(0x100b_bc41, 2); jmpd(0x100b_bc4b, 0x8); goto l_0x100b_bc4b; /* jmp 0x100bbc4b */
        l_0x100b_bc43:
            ii(0x100b_bc43, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bc46, 5); calld(0x1007_6bf8, -0x45053);           /* call 0x10076bf8 */
        l_0x100b_bc4b:
            ii(0x100b_bc4b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_bc4d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bc50, 5); calld(0x1013_ad71, 0x7f11c);            /* call 0x1013ad71 */
            ii(0x100b_bc55, 2); test(al, al);                           /* test al, al */
            ii(0x100b_bc57, 2); if(jzd(0x100b_bc92, 0x39)) goto l_0x100b_bc92; /* jz 0x100bbc92 */
            ii(0x100b_bc59, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bc5c, 5); calld(0x1007_63a0, -0x458c1);           /* call 0x100763a0 */
            ii(0x100b_bc61, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_bc63, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_bc66, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_bc69, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_bc6c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_bc6e, 2); if(jnzd(0x100b_bc90, 0x20)) goto l_0x100b_bc90; /* jnz 0x100bbc90 */
            ii(0x100b_bc70, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bc73, 5); calld(0x1007_63a0, -0x458d8);           /* call 0x100763a0 */
            ii(0x100b_bc78, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100b_bc7c, 2); if(jnzd(0x100b_bc90, 0x12)) goto l_0x100b_bc90; /* jnz 0x100bbc90 */
            ii(0x100b_bc7e, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bc81, 5); calld(0x1007_6408, -0x4587e);           /* call 0x10076408 */
            ii(0x100b_bc86, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_bc88, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_bc8b, 5); calld(0x100b_a131, -0x1b5f);            /* call 0x100ba131 */
        l_0x100b_bc90:
            ii(0x100b_bc90, 2); jmpd(0x100b_bc43, -0x4f); goto l_0x100b_bc43; /* jmp 0x100bbc43 */
        l_0x100b_bc92:
            ii(0x100b_bc92, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_bc97, 5); calld(0x1007_6338, -0x45964);           /* call 0x10076338 */
            ii(0x100b_bc9c, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_bc9f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_bca1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_bca3, 5); calld(0x1007_643c, -0x4586c);           /* call 0x1007643c */
            ii(0x100b_bca8, 2); jmpd(0x100b_bcb2, 0x8); goto l_0x100b_bcb2; /* jmp 0x100bbcb2 */
        l_0x100b_bcaa:
            ii(0x100b_bcaa, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bcad, 5); calld(0x1007_6bf8, -0x450ba);           /* call 0x10076bf8 */
        l_0x100b_bcb2:
            ii(0x100b_bcb2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_bcb4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bcb7, 5); calld(0x1013_ad71, 0x7f0b5);            /* call 0x1013ad71 */
            ii(0x100b_bcbc, 2); test(al, al);                           /* test al, al */
            ii(0x100b_bcbe, 6); if(jzd(0x100b_bd6f, 0xab)) goto l_0x100b_bd6f; /* jz 0x100bbd6f */
            ii(0x100b_bcc4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bcc7, 5); calld(0x1007_63a0, -0x4592c);           /* call 0x100763a0 */
            ii(0x100b_bccc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_bcce, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_bcd1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_bcd4, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_bcd7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_bcd9, 2); if(jnzd(0x100b_bce9, 0xe)) goto l_0x100b_bce9; /* jnz 0x100bbce9 */
            ii(0x100b_bcdb, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bcde, 5); calld(0x1007_63a0, -0x45943);           /* call 0x100763a0 */
            ii(0x100b_bce3, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_bce7, 2); if(jzd(0x100b_bceb, 0x2)) goto l_0x100b_bceb; /* jz 0x100bbceb */
        l_0x100b_bce9:
            ii(0x100b_bce9, 2); jmpd(0x100b_bcf9, 0xe); goto l_0x100b_bcf9; /* jmp 0x100bbcf9 */
        l_0x100b_bceb:
            ii(0x100b_bceb, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bcee, 5); calld(0x1007_63a0, -0x45953);           /* call 0x100763a0 */
            ii(0x100b_bcf3, 4); cmp(memb_a32[ds, eax + 0x3e], 0x4);     /* cmp byte [eax+0x3e], 0x4 */
            ii(0x100b_bcf7, 2); if(jzd(0x100b_bcfb, 0x2)) goto l_0x100b_bcfb; /* jz 0x100bbcfb */
        l_0x100b_bcf9:
            ii(0x100b_bcf9, 2); jmpd(0x100b_bd6a, 0x6f); goto l_0x100b_bd6a; /* jmp 0x100bbd6a */
        l_0x100b_bcfb:
            ii(0x100b_bcfb, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100b_bd00, 5); calld(Definitions.sys_new, 0xaa0fb);    /* call 0x10165e00 */
            ii(0x100b_bd05, 6); mov(memd_a32[ss, ebp - 0xf4], eax);     /* mov [ebp-0xf4], eax */
            ii(0x100b_bd0b, 6); mov(eax, memd_a32[ss, ebp - 0xf4]);     /* mov eax, [ebp-0xf4] */
            ii(0x100b_bd11, 6); mov(memd_a32[ss, ebp - 0xf8], eax);     /* mov [ebp-0xf8], eax */
            ii(0x100b_bd17, 7); cmp(memd_a32[ss, ebp - 0xf8], 0);       /* cmp dword [ebp-0xf8], 0x0 */
            ii(0x100b_bd1e, 2); if(jzd(0x100b_bd4e, 0x2e)) goto l_0x100b_bd4e; /* jz 0x100bbd4e */
            ii(0x100b_bd20, 5); mov(ebx, 0x100b_a9c2);                  /* mov ebx, 0x100ba9c2 */
            ii(0x100b_bd25, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bd28, 5); calld(0x1007_63d4, -0x45959);           /* call 0x100763d4 */
            ii(0x100b_bd2d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_bd2f, 6); mov(eax, memd_a32[ss, ebp - 0xf4]);     /* mov eax, [ebp-0xf4] */
            ii(0x100b_bd35, 5); calld(0x100a_c45d, -0xf8dd);            /* call 0x100ac45d */
            ii(0x100b_bd3a, 6); mov(memd_a32[ss, ebp - 0xfc], eax);     /* mov [ebp-0xfc], eax */
            ii(0x100b_bd40, 6); mov(eax, memd_a32[ss, ebp - 0xfc]);     /* mov eax, [ebp-0xfc] */
            ii(0x100b_bd46, 6); mov(memd_a32[ss, ebp - 0x100], eax);    /* mov [ebp-0x100], eax */
            ii(0x100b_bd4c, 2); jmpd(0x100b_bd5a, 0xc); goto l_0x100b_bd5a; /* jmp 0x100bbd5a */
        l_0x100b_bd4e:
            ii(0x100b_bd4e, 6); mov(eax, memd_a32[ss, ebp - 0xf8]);     /* mov eax, [ebp-0xf8] */
            ii(0x100b_bd54, 6); mov(memd_a32[ss, ebp - 0x100], eax);    /* mov [ebp-0x100], eax */
        l_0x100b_bd5a:
            ii(0x100b_bd5a, 6); mov(edx, memd_a32[ss, ebp - 0x100]);    /* mov edx, [ebp-0x100] */
            ii(0x100b_bd60, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_bd65, 5); calld(0x100a_4d50, -0x1701a);           /* call 0x100a4d50 */
        l_0x100b_bd6a:
            ii(0x100b_bd6a, 5); jmpd(0x100b_bcaa, -0xc5); goto l_0x100b_bcaa; /* jmp 0x100bbcaa */
        l_0x100b_bd6f:
            ii(0x100b_bd6f, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100b_bd74, 5); calld(0x1007_6338, -0x45a41);           /* call 0x10076338 */
            ii(0x100b_bd79, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_bd7c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_bd7e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_bd80, 5); calld(0x1007_643c, -0x45949);           /* call 0x1007643c */
            ii(0x100b_bd85, 2); jmpd(0x100b_bd8f, 0x8); goto l_0x100b_bd8f; /* jmp 0x100bbd8f */
        l_0x100b_bd87:
            ii(0x100b_bd87, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bd8a, 5); calld(0x1007_6bf8, -0x45197);           /* call 0x10076bf8 */
        l_0x100b_bd8f:
            ii(0x100b_bd8f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_bd91, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bd94, 5); calld(0x1013_ad71, 0x7efd8);            /* call 0x1013ad71 */
            ii(0x100b_bd99, 2); test(al, al);                           /* test al, al */
            ii(0x100b_bd9b, 6); if(jzd(0x100b_be79, 0xd8)) goto l_0x100b_be79; /* jz 0x100bbe79 */
            ii(0x100b_bda1, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bda4, 5); calld(0x1007_63a0, -0x45a09);           /* call 0x100763a0 */
            ii(0x100b_bda9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_bdab, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_bdae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_bdb1, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_bdb4, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_bdb6, 6); if(jnzd(0x100b_be74, 0xb8)) goto l_0x100b_be74; /* jnz 0x100bbe74 */
            ii(0x100b_bdbc, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bdbf, 5); calld(0x1007_63a0, -0x45a24);           /* call 0x100763a0 */
            ii(0x100b_bdc4, 5); cmp(memw_a32[ds, eax + 0x8], 0x4f);     /* cmp word [eax+0x8], 0x4f */
            ii(0x100b_bdc9, 2); if(jzd(0x100b_bdda, 0xf)) goto l_0x100b_bdda; /* jz 0x100bbdda */
            ii(0x100b_bdcb, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bdce, 5); calld(0x1007_63a0, -0x45a33);           /* call 0x100763a0 */
            ii(0x100b_bdd3, 5); cmp(memw_a32[ds, eax + 0x8], 0x4d);     /* cmp word [eax+0x8], 0x4d */
            ii(0x100b_bdd8, 2); if(jnzd(0x100b_be4b, 0x71)) goto l_0x100b_be4b; /* jnz 0x100bbe4b */
        l_0x100b_bdda:
            ii(0x100b_bdda, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100b_bddf, 5); calld(Definitions.sys_new, 0xaa01c);    /* call 0x10165e00 */
            ii(0x100b_bde4, 6); mov(memd_a32[ss, ebp - 0x104], eax);    /* mov [ebp-0x104], eax */
            ii(0x100b_bdea, 6); mov(eax, memd_a32[ss, ebp - 0x104]);    /* mov eax, [ebp-0x104] */
            ii(0x100b_bdf0, 6); mov(memd_a32[ss, ebp - 0x108], eax);    /* mov [ebp-0x108], eax */
            ii(0x100b_bdf6, 7); cmp(memd_a32[ss, ebp - 0x108], 0);      /* cmp dword [ebp-0x108], 0x0 */
            ii(0x100b_bdfd, 2); if(jzd(0x100b_be2f, 0x30)) goto l_0x100b_be2f; /* jz 0x100bbe2f */
            ii(0x100b_bdff, 5); mov(ebx, 0x4c);                         /* mov ebx, 0x4c */
            ii(0x100b_be04, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_be07, 5); calld(0x1007_63d4, -0x45a38);           /* call 0x100763d4 */
            ii(0x100b_be0c, 6); mov(ecx, memd_a32[ss, ebp - 0x104]);    /* mov ecx, [ebp-0x104] */
            ii(0x100b_be12, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_be14, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_be16, 5); calld(0x1008_7abb, -0x34360);           /* call 0x10087abb */
            ii(0x100b_be1b, 6); mov(memd_a32[ss, ebp - 0x10c], eax);    /* mov [ebp-0x10c], eax */
            ii(0x100b_be21, 6); mov(eax, memd_a32[ss, ebp - 0x10c]);    /* mov eax, [ebp-0x10c] */
            ii(0x100b_be27, 6); mov(memd_a32[ss, ebp - 0x110], eax);    /* mov [ebp-0x110], eax */
            ii(0x100b_be2d, 2); jmpd(0x100b_be3b, 0xc); goto l_0x100b_be3b; /* jmp 0x100bbe3b */
        l_0x100b_be2f:
            ii(0x100b_be2f, 6); mov(eax, memd_a32[ss, ebp - 0x108]);    /* mov eax, [ebp-0x108] */
            ii(0x100b_be35, 6); mov(memd_a32[ss, ebp - 0x110], eax);    /* mov [ebp-0x110], eax */
        l_0x100b_be3b:
            ii(0x100b_be3b, 6); mov(edx, memd_a32[ss, ebp - 0x110]);    /* mov edx, [ebp-0x110] */
            ii(0x100b_be41, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_be46, 5); calld(0x100a_4d50, -0x170fb);           /* call 0x100a4d50 */
        l_0x100b_be4b:
            ii(0x100b_be4b, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_be4e, 5); calld(0x1007_63a0, -0x45ab3);           /* call 0x100763a0 */
            ii(0x100b_be53, 5); calld(0x1007_623c, -0x45c1c);           /* call 0x1007623c */
            ii(0x100b_be58, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x100b_be5b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_be5e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_be60, 2); if(jled(0x100b_be74, 0x12)) goto l_0x100b_be74; /* jle 0x100bbe74 */
            ii(0x100b_be62, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_be65, 5); calld(0x1007_63d4, -0x45a96);           /* call 0x100763d4 */
            ii(0x100b_be6a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_be6c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_be6f, 5); calld(0x100b_a18e, -0x1ce6);            /* call 0x100ba18e */
        l_0x100b_be74:
            ii(0x100b_be74, 5); jmpd(0x100b_bd87, -0xf2); goto l_0x100b_bd87; /* jmp 0x100bbd87 */
        l_0x100b_be79:
            ii(0x100b_be79, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_be7e, 5); calld(0x1007_6338, -0x45b4b);           /* call 0x10076338 */
            ii(0x100b_be83, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_be86, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_be88, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_be8a, 5); calld(0x1007_643c, -0x45a53);           /* call 0x1007643c */
            ii(0x100b_be8f, 2); jmpd(0x100b_be99, 0x8); goto l_0x100b_be99; /* jmp 0x100bbe99 */
        l_0x100b_be91:
            ii(0x100b_be91, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_be94, 5); calld(0x1007_6bf8, -0x452a1);           /* call 0x10076bf8 */
        l_0x100b_be99:
            ii(0x100b_be99, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_be9b, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_be9e, 5); calld(0x1013_ad71, 0x7eece);            /* call 0x1013ad71 */
            ii(0x100b_bea3, 2); test(al, al);                           /* test al, al */
            ii(0x100b_bea5, 6); if(jzd(0x100b_c087, 0x1dc)) goto l_0x100b_c087; /* jz 0x100bc087 */
            ii(0x100b_beab, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_beae, 5); calld(0x1007_63a0, -0x45b13);           /* call 0x100763a0 */
            ii(0x100b_beb3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_beb5, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_beb8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_bebb, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_bebe, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_bec0, 6); if(jnzd(0x100b_c082, 0x1bc)) goto l_0x100b_c082; /* jnz 0x100bc082 */
            ii(0x100b_bec6, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bec9, 5); calld(0x1007_63a0, -0x45b2e);           /* call 0x100763a0 */
            ii(0x100b_bece, 5); cmp(memw_a32[ds, eax + 0x8], 0x36);     /* cmp word [eax+0x8], 0x36 */
            ii(0x100b_bed3, 2); if(jzd(0x100b_bee8, 0x13)) goto l_0x100b_bee8; /* jz 0x100bbee8 */
            ii(0x100b_bed5, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bed8, 5); calld(0x1007_63a0, -0x45b3d);           /* call 0x100763a0 */
            ii(0x100b_bedd, 5); cmp(memw_a32[ds, eax + 0x8], 0x3a);     /* cmp word [eax+0x8], 0x3a */
            ii(0x100b_bee2, 6); if(jnzd(0x100b_bfca, 0xe2)) goto l_0x100b_bfca; /* jnz 0x100bbfca */
        l_0x100b_bee8:
            ii(0x100b_bee8, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100b_beed, 5); calld(Definitions.sys_new, 0xa9f0e);    /* call 0x10165e00 */
            ii(0x100b_bef2, 6); mov(memd_a32[ss, ebp - 0x114], eax);    /* mov [ebp-0x114], eax */
            ii(0x100b_bef8, 6); mov(eax, memd_a32[ss, ebp - 0x114]);    /* mov eax, [ebp-0x114] */
            ii(0x100b_befe, 6); mov(memd_a32[ss, ebp - 0x118], eax);    /* mov [ebp-0x118], eax */
            ii(0x100b_bf04, 7); cmp(memd_a32[ss, ebp - 0x118], 0);      /* cmp dword [ebp-0x118], 0x0 */
            ii(0x100b_bf0b, 2); if(jzd(0x100b_bf3d, 0x30)) goto l_0x100b_bf3d; /* jz 0x100bbf3d */
            ii(0x100b_bf0d, 5); mov(ebx, 0x33);                         /* mov ebx, 0x33 */
            ii(0x100b_bf12, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bf15, 5); calld(0x1007_63d4, -0x45b46);           /* call 0x100763d4 */
            ii(0x100b_bf1a, 6); mov(ecx, memd_a32[ss, ebp - 0x114]);    /* mov ecx, [ebp-0x114] */
            ii(0x100b_bf20, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_bf22, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_bf24, 5); calld(0x1008_7abb, -0x3446e);           /* call 0x10087abb */
            ii(0x100b_bf29, 6); mov(memd_a32[ss, ebp - 0x11c], eax);    /* mov [ebp-0x11c], eax */
            ii(0x100b_bf2f, 6); mov(eax, memd_a32[ss, ebp - 0x11c]);    /* mov eax, [ebp-0x11c] */
            ii(0x100b_bf35, 6); mov(memd_a32[ss, ebp - 0x120], eax);    /* mov [ebp-0x120], eax */
            ii(0x100b_bf3b, 2); jmpd(0x100b_bf49, 0xc); goto l_0x100b_bf49; /* jmp 0x100bbf49 */
        l_0x100b_bf3d:
            ii(0x100b_bf3d, 6); mov(eax, memd_a32[ss, ebp - 0x118]);    /* mov eax, [ebp-0x118] */
            ii(0x100b_bf43, 6); mov(memd_a32[ss, ebp - 0x120], eax);    /* mov [ebp-0x120], eax */
        l_0x100b_bf49:
            ii(0x100b_bf49, 6); mov(edx, memd_a32[ss, ebp - 0x120]);    /* mov edx, [ebp-0x120] */
            ii(0x100b_bf4f, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_bf54, 5); calld(0x100a_4d50, -0x17209);           /* call 0x100a4d50 */
            ii(0x100b_bf59, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100b_bf5e, 5); calld(Definitions.sys_new, 0xa9e9d);    /* call 0x10165e00 */
            ii(0x100b_bf63, 6); mov(memd_a32[ss, ebp - 0x124], eax);    /* mov [ebp-0x124], eax */
            ii(0x100b_bf69, 6); mov(eax, memd_a32[ss, ebp - 0x124]);    /* mov eax, [ebp-0x124] */
            ii(0x100b_bf6f, 6); mov(memd_a32[ss, ebp - 0x128], eax);    /* mov [ebp-0x128], eax */
            ii(0x100b_bf75, 7); cmp(memd_a32[ss, ebp - 0x128], 0);      /* cmp dword [ebp-0x128], 0x0 */
            ii(0x100b_bf7c, 2); if(jzd(0x100b_bfae, 0x30)) goto l_0x100b_bfae; /* jz 0x100bbfae */
            ii(0x100b_bf7e, 5); mov(ebx, 0x37);                         /* mov ebx, 0x37 */
            ii(0x100b_bf83, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bf86, 5); calld(0x1007_63d4, -0x45bb7);           /* call 0x100763d4 */
            ii(0x100b_bf8b, 6); mov(ecx, memd_a32[ss, ebp - 0x124]);    /* mov ecx, [ebp-0x124] */
            ii(0x100b_bf91, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_bf93, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_bf95, 5); calld(0x1008_7abb, -0x344df);           /* call 0x10087abb */
            ii(0x100b_bf9a, 6); mov(memd_a32[ss, ebp - 0x12c], eax);    /* mov [ebp-0x12c], eax */
            ii(0x100b_bfa0, 6); mov(eax, memd_a32[ss, ebp - 0x12c]);    /* mov eax, [ebp-0x12c] */
            ii(0x100b_bfa6, 6); mov(memd_a32[ss, ebp - 0x130], eax);    /* mov [ebp-0x130], eax */
            ii(0x100b_bfac, 2); jmpd(0x100b_bfba, 0xc); goto l_0x100b_bfba; /* jmp 0x100bbfba */
        l_0x100b_bfae:
            ii(0x100b_bfae, 6); mov(eax, memd_a32[ss, ebp - 0x128]);    /* mov eax, [ebp-0x128] */
            ii(0x100b_bfb4, 6); mov(memd_a32[ss, ebp - 0x130], eax);    /* mov [ebp-0x130], eax */
        l_0x100b_bfba:
            ii(0x100b_bfba, 6); mov(edx, memd_a32[ss, ebp - 0x130]);    /* mov edx, [ebp-0x130] */
            ii(0x100b_bfc0, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_bfc5, 5); calld(0x100a_4d50, -0x1727a);           /* call 0x100a4d50 */
        l_0x100b_bfca:
            ii(0x100b_bfca, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bfcd, 5); calld(0x1007_63a0, -0x45c32);           /* call 0x100763a0 */
            ii(0x100b_bfd2, 5); cmp(memw_a32[ds, eax + 0x8], 0x37);     /* cmp word [eax+0x8], 0x37 */
            ii(0x100b_bfd7, 2); if(jzd(0x100b_bfe8, 0xf)) goto l_0x100b_bfe8; /* jz 0x100bbfe8 */
            ii(0x100b_bfd9, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_bfdc, 5); calld(0x1007_63a0, -0x45c41);           /* call 0x100763a0 */
            ii(0x100b_bfe1, 5); cmp(memw_a32[ds, eax + 0x8], 0x44);     /* cmp word [eax+0x8], 0x44 */
            ii(0x100b_bfe6, 2); if(jnzd(0x100b_c059, 0x71)) goto l_0x100b_c059; /* jnz 0x100bc059 */
        l_0x100b_bfe8:
            ii(0x100b_bfe8, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100b_bfed, 5); calld(Definitions.sys_new, 0xa9e0e);    /* call 0x10165e00 */
            ii(0x100b_bff2, 6); mov(memd_a32[ss, ebp - 0x134], eax);    /* mov [ebp-0x134], eax */
            ii(0x100b_bff8, 6); mov(eax, memd_a32[ss, ebp - 0x134]);    /* mov eax, [ebp-0x134] */
            ii(0x100b_bffe, 6); mov(memd_a32[ss, ebp - 0x138], eax);    /* mov [ebp-0x138], eax */
            ii(0x100b_c004, 7); cmp(memd_a32[ss, ebp - 0x138], 0);      /* cmp dword [ebp-0x138], 0x0 */
            ii(0x100b_c00b, 2); if(jzd(0x100b_c03d, 0x30)) goto l_0x100b_c03d; /* jz 0x100bc03d */
            ii(0x100b_c00d, 5); mov(ebx, 0x4c);                         /* mov ebx, 0x4c */
            ii(0x100b_c012, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c015, 5); calld(0x1007_63d4, -0x45c46);           /* call 0x100763d4 */
            ii(0x100b_c01a, 6); mov(ecx, memd_a32[ss, ebp - 0x134]);    /* mov ecx, [ebp-0x134] */
            ii(0x100b_c020, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c022, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_c024, 5); calld(0x1008_7abb, -0x3456e);           /* call 0x10087abb */
            ii(0x100b_c029, 6); mov(memd_a32[ss, ebp - 0x13c], eax);    /* mov [ebp-0x13c], eax */
            ii(0x100b_c02f, 6); mov(eax, memd_a32[ss, ebp - 0x13c]);    /* mov eax, [ebp-0x13c] */
            ii(0x100b_c035, 6); mov(memd_a32[ss, ebp - 0x140], eax);    /* mov [ebp-0x140], eax */
            ii(0x100b_c03b, 2); jmpd(0x100b_c049, 0xc); goto l_0x100b_c049; /* jmp 0x100bc049 */
        l_0x100b_c03d:
            ii(0x100b_c03d, 6); mov(eax, memd_a32[ss, ebp - 0x138]);    /* mov eax, [ebp-0x138] */
            ii(0x100b_c043, 6); mov(memd_a32[ss, ebp - 0x140], eax);    /* mov [ebp-0x140], eax */
        l_0x100b_c049:
            ii(0x100b_c049, 6); mov(edx, memd_a32[ss, ebp - 0x140]);    /* mov edx, [ebp-0x140] */
            ii(0x100b_c04f, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_c054, 5); calld(0x100a_4d50, -0x17309);           /* call 0x100a4d50 */
        l_0x100b_c059:
            ii(0x100b_c059, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c05c, 5); calld(0x1007_63a0, -0x45cc1);           /* call 0x100763a0 */
            ii(0x100b_c061, 5); calld(0x1007_623c, -0x45e2a);           /* call 0x1007623c */
            ii(0x100b_c066, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x100b_c069, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_c06c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_c06e, 2); if(jled(0x100b_c082, 0x12)) goto l_0x100b_c082; /* jle 0x100bc082 */
            ii(0x100b_c070, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c073, 5); calld(0x1007_63d4, -0x45ca4);           /* call 0x100763d4 */
            ii(0x100b_c078, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c07a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c07d, 5); calld(0x100b_a18e, -0x1ef4);            /* call 0x100ba18e */
        l_0x100b_c082:
            ii(0x100b_c082, 5); jmpd(0x100b_be91, -0x1f6); goto l_0x100b_be91; /* jmp 0x100bbe91 */
        l_0x100b_c087:
            ii(0x100b_c087, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_c08c, 5); calld(0x1007_6338, -0x45d59);           /* call 0x10076338 */
            ii(0x100b_c091, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_c094, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c096, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_c098, 5); calld(0x1007_643c, -0x45c61);           /* call 0x1007643c */
            ii(0x100b_c09d, 2); jmpd(0x100b_c0a7, 0x8); goto l_0x100b_c0a7; /* jmp 0x100bc0a7 */
        l_0x100b_c09f:
            ii(0x100b_c09f, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c0a2, 5); calld(0x1007_6bf8, -0x454af);           /* call 0x10076bf8 */
        l_0x100b_c0a7:
            ii(0x100b_c0a7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c0a9, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c0ac, 5); calld(0x1013_ad71, 0x7ecc0);            /* call 0x1013ad71 */
            ii(0x100b_c0b1, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c0b3, 2); if(jzd(0x100b_c0f9, 0x44)) goto l_0x100b_c0f9; /* jz 0x100bc0f9 */
            ii(0x100b_c0b5, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c0b8, 5); calld(0x1007_63a0, -0x45d1d);           /* call 0x100763a0 */
            ii(0x100b_c0bd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c0bf, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c0c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c0c5, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c0c8, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c0ca, 2); if(jnzd(0x100b_c0e3, 0x17)) goto l_0x100b_c0e3; /* jnz 0x100bc0e3 */
            ii(0x100b_c0cc, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c0cf, 5); calld(0x1007_63a0, -0x45d34);           /* call 0x100763a0 */
            ii(0x100b_c0d4, 5); calld(0x1007_623c, -0x45e9d);           /* call 0x1007623c */
            ii(0x100b_c0d9, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x100b_c0dc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_c0df, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_c0e1, 2); if(jgd(0x100b_c0e5, 0x2)) goto l_0x100b_c0e5; /* jg 0x100bc0e5 */
        l_0x100b_c0e3:
            ii(0x100b_c0e3, 2); jmpd(0x100b_c0f7, 0x12); goto l_0x100b_c0f7; /* jmp 0x100bc0f7 */
        l_0x100b_c0e5:
            ii(0x100b_c0e5, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c0e8, 5); calld(0x1007_63d4, -0x45d19);           /* call 0x100763d4 */
            ii(0x100b_c0ed, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c0ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c0f2, 5); calld(0x100b_a18e, -0x1f69);            /* call 0x100ba18e */
        l_0x100b_c0f7:
            ii(0x100b_c0f7, 2); jmpd(0x100b_c09f, -0x5a); goto l_0x100b_c09f; /* jmp 0x100bc09f */
        l_0x100b_c0f9:
            ii(0x100b_c0f9, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100b_c0fe, 5); calld(0x1007_5fdc, -0x46127);           /* call 0x10075fdc */
            ii(0x100b_c103, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100b_c106, 6); if(jld(0x100b_c188, 0x7c)) goto l_0x100b_c188; /* jl 0x100bc188 */
            ii(0x100b_c10c, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_c111, 5); calld(0x1007_6338, -0x45dde);           /* call 0x10076338 */
            ii(0x100b_c116, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_c119, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c11b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_c11d, 5); calld(0x1007_643c, -0x45ce6);           /* call 0x1007643c */
            ii(0x100b_c122, 2); jmpd(0x100b_c12c, 0x8); goto l_0x100b_c12c; /* jmp 0x100bc12c */
        l_0x100b_c124:
            ii(0x100b_c124, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c127, 5); calld(0x1007_6bf8, -0x45534);           /* call 0x10076bf8 */
        l_0x100b_c12c:
            ii(0x100b_c12c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c12e, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c131, 5); calld(0x1013_ad71, 0x7ec3b);            /* call 0x1013ad71 */
            ii(0x100b_c136, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c138, 2); if(jzd(0x100b_c188, 0x4e)) goto l_0x100b_c188; /* jz 0x100bc188 */
            ii(0x100b_c13a, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c13d, 5); calld(0x1007_63a0, -0x45da2);           /* call 0x100763a0 */
            ii(0x100b_c142, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c144, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c147, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c14a, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c14d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c14f, 2); if(jzd(0x100b_c171, 0x20)) goto l_0x100b_c171; /* jz 0x100bc171 */
            ii(0x100b_c151, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c154, 5); calld(0x1007_63a0, -0x45db9);           /* call 0x100763a0 */
            ii(0x100b_c159, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100b_c15e, 2); if(jzd(0x100b_c16f, 0xf)) goto l_0x100b_c16f; /* jz 0x100bc16f */
            ii(0x100b_c160, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c163, 5); calld(0x1007_63a0, -0x45dc8);           /* call 0x100763a0 */
            ii(0x100b_c168, 5); cmp(memw_a32[ds, eax + 0x8], 0x1e);     /* cmp word [eax+0x8], 0x1e */
            ii(0x100b_c16d, 2); if(jnzd(0x100b_c171, 0x2)) goto l_0x100b_c171; /* jnz 0x100bc171 */
        l_0x100b_c16f:
            ii(0x100b_c16f, 2); jmpd(0x100b_c173, 0x2); goto l_0x100b_c173; /* jmp 0x100bc173 */
        l_0x100b_c171:
            ii(0x100b_c171, 2); jmpd(0x100b_c186, 0x13); goto l_0x100b_c186; /* jmp 0x100bc186 */
        l_0x100b_c173:
            ii(0x100b_c173, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c176, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_c179, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c17c, 5); calld(0x1007_63d4, -0x45dad);           /* call 0x100763d4 */
            ii(0x100b_c181, 5); calld(0x100a_9060, -0x13126);           /* call 0x100a9060 */
        l_0x100b_c186:
            ii(0x100b_c186, 2); jmpd(0x100b_c124, -0x64); goto l_0x100b_c124; /* jmp 0x100bc124 */
        l_0x100b_c188:
            ii(0x100b_c188, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c18b, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100b_c18e, 5); calld(0x100c_b000, 0xee6d);             /* call 0x100cb000 */
            ii(0x100b_c193, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x100b_c196, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c198, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_c19a, 5); calld(0x100c_af68, 0xedc9);             /* call 0x100caf68 */
            ii(0x100b_c19f, 2); jmpd(0x100b_c1a9, 0x8); goto l_0x100b_c1a9; /* jmp 0x100bc1a9 */
        l_0x100b_c1a1:
            ii(0x100b_c1a1, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c1a4, 5); calld(0x1007_6bf8, -0x455b1);           /* call 0x10076bf8 */
        l_0x100b_c1a9:
            ii(0x100b_c1a9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c1ab, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c1ae, 5); calld(0x1013_ad71, 0x7ebbe);            /* call 0x1013ad71 */
            ii(0x100b_c1b3, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c1b5, 2); if(jzd(0x100b_c210, 0x59)) goto l_0x100b_c210; /* jz 0x100bc210 */
            ii(0x100b_c1b7, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c1ba, 5); calld(0x1008_a0f8, -0x320c7);           /* call 0x1008a0f8 */
            ii(0x100b_c1bf, 5); calld(0x1008_a370, -0x31e54);           /* call 0x1008a370 */
            ii(0x100b_c1c4, 6); mov(memd_a32[ss, ebp - 0x144], eax);    /* mov [ebp-0x144], eax */
            ii(0x100b_c1ca, 6); mov(eax, memd_a32[ss, ebp - 0x144]);    /* mov eax, [ebp-0x144] */
            ii(0x100b_c1d0, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100b_c1d3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_c1d6, 5); calld(0x100b_b097, -0x1144);            /* call 0x100bb097 */
            ii(0x100b_c1db, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c1dd, 2); if(jzd(0x100b_c20e, 0x2f)) goto l_0x100b_c20e; /* jz 0x100bc20e */
            ii(0x100b_c1df, 6); mov(eax, memd_a32[ss, ebp - 0x144]);    /* mov eax, [ebp-0x144] */
            ii(0x100b_c1e5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c1e7, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c1ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c1ed, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100b_c1f0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_c1f3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c1f5, 2); if(jnzd(0x100b_c20e, 0x17)) goto l_0x100b_c20e; /* jnz 0x100bc20e */
            ii(0x100b_c1f7, 5); mov(ebx, 0x1f00);                       /* mov ebx, 0x1f00 */
            ii(0x100b_c1fc, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c1ff, 5); calld(0x1008_a12c, -0x320d8);           /* call 0x1008a12c */
            ii(0x100b_c204, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c206, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c209, 5); calld(0x100b_ab5d, -0x16b1);            /* call 0x100bab5d */
        l_0x100b_c20e:
            ii(0x100b_c20e, 2); jmpd(0x100b_c1a1, -0x6f); goto l_0x100b_c1a1; /* jmp 0x100bc1a1 */
        l_0x100b_c210:
            ii(0x100b_c210, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c212, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c215, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x100b_c218, 5); calld(0x1013_ad11, 0x7eaf4);            /* call 0x1013ad11 */
            ii(0x100b_c21d, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c21f, 6); if(jzd(0x100b_c353, 0x12e)) goto l_0x100b_c353; /* jz 0x100bc353 */
            ii(0x100b_c225, 7); mov(memb_a32[ss, ebp - 0x148], 0);      /* mov byte [ebp-0x148], 0x0 */
            ii(0x100b_c22c, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_c233, 2); jmpd(0x100b_c23b, 0x6); goto l_0x100b_c23b; /* jmp 0x100bc23b */
        l_0x100b_c235:
            ii(0x100b_c235, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_c238, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_c23b:
            ii(0x100b_c23b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_c23e, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100b_c245, 2); if(jged(0x100b_c250, 0x9)) goto l_0x100b_c250; /* jge 0x100bc250 */
            ii(0x100b_c247, 7); cmp(memb_a32[ss, ebp - 0x148], 0);      /* cmp byte [ebp-0x148], 0x0 */
            ii(0x100b_c24e, 2); if(jzd(0x100b_c252, 0x2)) goto l_0x100b_c252; /* jz 0x100bc252 */
        l_0x100b_c250:
            ii(0x100b_c250, 2); jmpd(0x100b_c2b0, 0x5e); goto l_0x100b_c2b0; /* jmp 0x100bc2b0 */
        l_0x100b_c252:
            ii(0x100b_c252, 10); mov(memd_a32[ss, ebp - 0xbc], 0);      /* mov dword [ebp-0xbc], 0x0 */
            ii(0x100b_c25c, 2); jmpd(0x100b_c26a, 0xc); goto l_0x100b_c26a; /* jmp 0x100bc26a */
        l_0x100b_c25e:
            ii(0x100b_c25e, 6); mov(eax, memd_a32[ss, ebp - 0xbc]);     /* mov eax, [ebp-0xbc] */
            ii(0x100b_c264, 6); inc(memd_a32[ss, ebp - 0xbc]);          /* inc dword [ebp-0xbc] */
        l_0x100b_c26a:
            ii(0x100b_c26a, 6); mov(eax, memd_a32[ss, ebp - 0xbc]);     /* mov eax, [ebp-0xbc] */
            ii(0x100b_c270, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x100b_c277, 2); if(jged(0x100b_c282, 0x9)) goto l_0x100b_c282; /* jge 0x100bc282 */
            ii(0x100b_c279, 7); cmp(memb_a32[ss, ebp - 0x148], 0);      /* cmp byte [ebp-0x148], 0x0 */
            ii(0x100b_c280, 2); if(jzd(0x100b_c284, 0x2)) goto l_0x100b_c284; /* jz 0x100bc284 */
        l_0x100b_c282:
            ii(0x100b_c282, 2); jmpd(0x100b_c2ae, 0x2a); goto l_0x100b_c2ae; /* jmp 0x100bc2ae */
        l_0x100b_c284:
            ii(0x100b_c284, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100b_c288, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100b_c28b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c28e, 3); mov(eax, memd_a32[ds, eax + 0x67]);     /* mov eax, [eax+0x67] */
            ii(0x100b_c291, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_c293, 7); movsx(edx, memw_a32[ss, ebp - 0xbc]);   /* movsx edx, word [ebp-0xbc] */
            ii(0x100b_c29a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_c29c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_c29e, 3); movsx(eax, memb_a32[ds, eax]);          /* movsx eax, byte [eax] */
            ii(0x100b_c2a1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_c2a3, 2); if(jled(0x100b_c2ac, 0x7)) goto l_0x100b_c2ac; /* jle 0x100bc2ac */
            ii(0x100b_c2a5, 7); mov(memb_a32[ss, ebp - 0x148], 0x1);    /* mov byte [ebp-0x148], 0x1 */
        l_0x100b_c2ac:
            ii(0x100b_c2ac, 2); jmpd(0x100b_c25e, -0x50); goto l_0x100b_c25e; /* jmp 0x100bc25e */
        l_0x100b_c2ae:
            ii(0x100b_c2ae, 2); jmpd(0x100b_c235, -0x7b); goto l_0x100b_c235; /* jmp 0x100bc235 */
        l_0x100b_c2b0:
            ii(0x100b_c2b0, 7); cmp(memb_a32[ss, ebp - 0x148], 0);      /* cmp byte [ebp-0x148], 0x0 */
            ii(0x100b_c2b7, 6); if(jzd(0x100b_c353, 0x96)) goto l_0x100b_c353; /* jz 0x100bc353 */
            ii(0x100b_c2bd, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x100b_c2c2, 5); calld(Definitions.sys_new, 0xa9b39);    /* call 0x10165e00 */
            ii(0x100b_c2c7, 6); mov(memd_a32[ss, ebp - 0x14c], eax);    /* mov [ebp-0x14c], eax */
            ii(0x100b_c2cd, 6); mov(eax, memd_a32[ss, ebp - 0x14c]);    /* mov eax, [ebp-0x14c] */
            ii(0x100b_c2d3, 6); mov(memd_a32[ss, ebp - 0x150], eax);    /* mov [ebp-0x150], eax */
            ii(0x100b_c2d9, 7); cmp(memd_a32[ss, ebp - 0x150], 0);      /* cmp dword [ebp-0x150], 0x0 */
            ii(0x100b_c2e0, 2); if(jzd(0x100b_c31f, 0x3d)) goto l_0x100b_c31f; /* jz 0x100bc31f */
            ii(0x100b_c2e2, 7); movsx(ebx, memw_a32[ss, ebp - 0xbc]);   /* movsx ebx, word [ebp-0xbc] */
            ii(0x100b_c2e9, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100b_c2ed, 6); lea(eax, ebp - 0x154);                  /* lea eax, [ebp-0x154] */
            ii(0x100b_c2f3, 5); calld(0x1007_6aac, -0x4584c);           /* call 0x10076aac */
            ii(0x100b_c2f8, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_c2fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c2fd, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_c300, 6); mov(eax, memd_a32[ss, ebp - 0x14c]);    /* mov eax, [ebp-0x14c] */
            ii(0x100b_c306, 5); calld(0x1009_ef13, -0x1d3f8);           /* call 0x1009ef13 */
            ii(0x100b_c30b, 6); mov(memd_a32[ss, ebp - 0x158], eax);    /* mov [ebp-0x158], eax */
            ii(0x100b_c311, 6); mov(eax, memd_a32[ss, ebp - 0x158]);    /* mov eax, [ebp-0x158] */
            ii(0x100b_c317, 6); mov(memd_a32[ss, ebp - 0x15c], eax);    /* mov [ebp-0x15c], eax */
            ii(0x100b_c31d, 2); jmpd(0x100b_c32b, 0xc); goto l_0x100b_c32b; /* jmp 0x100bc32b */
        l_0x100b_c31f:
            ii(0x100b_c31f, 6); mov(eax, memd_a32[ss, ebp - 0x150]);    /* mov eax, [ebp-0x150] */
            ii(0x100b_c325, 6); mov(memd_a32[ss, ebp - 0x15c], eax);    /* mov [ebp-0x15c], eax */
        l_0x100b_c32b:
            ii(0x100b_c32b, 6); mov(edx, memd_a32[ss, ebp - 0x15c]);    /* mov edx, [ebp-0x15c] */
            ii(0x100b_c331, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c334, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x100b_c337, 5); calld(0x1008_afe4, -0x31358);           /* call 0x1008afe4 */
            ii(0x100b_c33c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c33f, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x100b_c342, 5); calld(0x1008_af84, -0x313c3);           /* call 0x1008af84 */
            ii(0x100b_c347, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c349, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_c34e, 5); calld(0x100a_4d50, -0x17603);           /* call 0x100a4d50 */
        l_0x100b_c353:
            ii(0x100b_c353, 5); mov(eax, 0x13);                         /* mov eax, 0x13 */
            ii(0x100b_c358, 5); calld(Definitions.sys_new, 0xa9aa3);    /* call 0x10165e00 */
            ii(0x100b_c35d, 6); mov(memd_a32[ss, ebp - 0x160], eax);    /* mov [ebp-0x160], eax */
            ii(0x100b_c363, 6); mov(eax, memd_a32[ss, ebp - 0x160]);    /* mov eax, [ebp-0x160] */
            ii(0x100b_c369, 6); mov(memd_a32[ss, ebp - 0x164], eax);    /* mov [ebp-0x164], eax */
            ii(0x100b_c36f, 7); cmp(memd_a32[ss, ebp - 0x164], 0);      /* cmp dword [ebp-0x164], 0x0 */
            ii(0x100b_c376, 2); if(jzd(0x100b_c39d, 0x25)) goto l_0x100b_c39d; /* jz 0x100bc39d */
            ii(0x100b_c378, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c37b, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_c37e, 6); mov(eax, memd_a32[ss, ebp - 0x160]);    /* mov eax, [ebp-0x160] */
            ii(0x100b_c384, 5); calld(0x100c_8746, 0xc3bd);             /* call 0x100c8746 */
            ii(0x100b_c389, 6); mov(memd_a32[ss, ebp - 0x168], eax);    /* mov [ebp-0x168], eax */
            ii(0x100b_c38f, 6); mov(eax, memd_a32[ss, ebp - 0x168]);    /* mov eax, [ebp-0x168] */
            ii(0x100b_c395, 6); mov(memd_a32[ss, ebp - 0x16c], eax);    /* mov [ebp-0x16c], eax */
            ii(0x100b_c39b, 2); jmpd(0x100b_c3a9, 0xc); goto l_0x100b_c3a9; /* jmp 0x100bc3a9 */
        l_0x100b_c39d:
            ii(0x100b_c39d, 6); mov(eax, memd_a32[ss, ebp - 0x164]);    /* mov eax, [ebp-0x164] */
            ii(0x100b_c3a3, 6); mov(memd_a32[ss, ebp - 0x16c], eax);    /* mov [ebp-0x16c], eax */
        l_0x100b_c3a9:
            ii(0x100b_c3a9, 6); mov(edx, memd_a32[ss, ebp - 0x16c]);    /* mov edx, [ebp-0x16c] */
            ii(0x100b_c3af, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_c3b4, 5); calld(0x100a_4d50, -0x17669);           /* call 0x100a4d50 */
            ii(0x100b_c3b9, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x100b_c3be, 5); calld(Definitions.sys_new, 0xa9a3d);    /* call 0x10165e00 */
            ii(0x100b_c3c3, 6); mov(memd_a32[ss, ebp - 0x170], eax);    /* mov [ebp-0x170], eax */
            ii(0x100b_c3c9, 6); mov(eax, memd_a32[ss, ebp - 0x170]);    /* mov eax, [ebp-0x170] */
            ii(0x100b_c3cf, 6); mov(memd_a32[ss, ebp - 0x174], eax);    /* mov [ebp-0x174], eax */
            ii(0x100b_c3d5, 7); cmp(memd_a32[ss, ebp - 0x174], 0);      /* cmp dword [ebp-0x174], 0x0 */
            ii(0x100b_c3dc, 2); if(jzd(0x100b_c403, 0x25)) goto l_0x100b_c403; /* jz 0x100bc403 */
            ii(0x100b_c3de, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c3e1, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_c3e4, 6); mov(eax, memd_a32[ss, ebp - 0x170]);    /* mov eax, [ebp-0x170] */
            ii(0x100b_c3ea, 5); calld(0x100c_9677, 0xd288);             /* call 0x100c9677 */
            ii(0x100b_c3ef, 6); mov(memd_a32[ss, ebp - 0x178], eax);    /* mov [ebp-0x178], eax */
            ii(0x100b_c3f5, 6); mov(eax, memd_a32[ss, ebp - 0x178]);    /* mov eax, [ebp-0x178] */
            ii(0x100b_c3fb, 6); mov(memd_a32[ss, ebp - 0x17c], eax);    /* mov [ebp-0x17c], eax */
            ii(0x100b_c401, 2); jmpd(0x100b_c40f, 0xc); goto l_0x100b_c40f; /* jmp 0x100bc40f */
        l_0x100b_c403:
            ii(0x100b_c403, 6); mov(eax, memd_a32[ss, ebp - 0x174]);    /* mov eax, [ebp-0x174] */
            ii(0x100b_c409, 6); mov(memd_a32[ss, ebp - 0x17c], eax);    /* mov [ebp-0x17c], eax */
        l_0x100b_c40f:
            ii(0x100b_c40f, 6); mov(edx, memd_a32[ss, ebp - 0x17c]);    /* mov edx, [ebp-0x17c] */
            ii(0x100b_c415, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_c41a, 5); calld(0x100a_4d50, -0x176cf);           /* call 0x100a4d50 */
            ii(0x100b_c41f, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100b_c424, 5); calld(0x1007_5fdc, -0x4644d);           /* call 0x10075fdc */
            ii(0x100b_c429, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100b_c42c, 6); if(jld(0x100b_c4fe, 0xcc)) goto l_0x100b_c4fe; /* jl 0x100bc4fe */
            ii(0x100b_c432, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100b_c437, 5); calld(Definitions.sys_new, 0xa99c4);    /* call 0x10165e00 */
            ii(0x100b_c43c, 6); mov(memd_a32[ss, ebp - 0x180], eax);    /* mov [ebp-0x180], eax */
            ii(0x100b_c442, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x100b_c448, 6); mov(memd_a32[ss, ebp - 0x184], eax);    /* mov [ebp-0x184], eax */
            ii(0x100b_c44e, 7); cmp(memd_a32[ss, ebp - 0x184], 0);      /* cmp dword [ebp-0x184], 0x0 */
            ii(0x100b_c455, 2); if(jzd(0x100b_c47c, 0x25)) goto l_0x100b_c47c; /* jz 0x100bc47c */
            ii(0x100b_c457, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c45a, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_c45d, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x100b_c463, 5); calld(0x1009_aff9, -0x2146f);           /* call 0x1009aff9 */
            ii(0x100b_c468, 6); mov(memd_a32[ss, ebp - 0x188], eax);    /* mov [ebp-0x188], eax */
            ii(0x100b_c46e, 6); mov(eax, memd_a32[ss, ebp - 0x188]);    /* mov eax, [ebp-0x188] */
            ii(0x100b_c474, 6); mov(memd_a32[ss, ebp - 0x18c], eax);    /* mov [ebp-0x18c], eax */
            ii(0x100b_c47a, 2); jmpd(0x100b_c488, 0xc); goto l_0x100b_c488; /* jmp 0x100bc488 */
        l_0x100b_c47c:
            ii(0x100b_c47c, 6); mov(eax, memd_a32[ss, ebp - 0x184]);    /* mov eax, [ebp-0x184] */
            ii(0x100b_c482, 6); mov(memd_a32[ss, ebp - 0x18c], eax);    /* mov [ebp-0x18c], eax */
        l_0x100b_c488:
            ii(0x100b_c488, 6); mov(edx, memd_a32[ss, ebp - 0x18c]);    /* mov edx, [ebp-0x18c] */
            ii(0x100b_c48e, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_c493, 5); calld(0x100a_4d50, -0x17748);           /* call 0x100a4d50 */
            ii(0x100b_c498, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x100b_c49d, 5); calld(Definitions.sys_new, 0xa995e);    /* call 0x10165e00 */
            ii(0x100b_c4a2, 6); mov(memd_a32[ss, ebp - 0x190], eax);    /* mov [ebp-0x190], eax */
            ii(0x100b_c4a8, 6); mov(eax, memd_a32[ss, ebp - 0x190]);    /* mov eax, [ebp-0x190] */
            ii(0x100b_c4ae, 6); mov(memd_a32[ss, ebp - 0x194], eax);    /* mov [ebp-0x194], eax */
            ii(0x100b_c4b4, 7); cmp(memd_a32[ss, ebp - 0x194], 0);      /* cmp dword [ebp-0x194], 0x0 */
            ii(0x100b_c4bb, 2); if(jzd(0x100b_c4e2, 0x25)) goto l_0x100b_c4e2; /* jz 0x100bc4e2 */
            ii(0x100b_c4bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c4c0, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_c4c3, 6); mov(eax, memd_a32[ss, ebp - 0x190]);    /* mov eax, [ebp-0x190] */
            ii(0x100b_c4c9, 5); calld(0x100b_5d85, -0x6749);            /* call 0x100b5d85 */
            ii(0x100b_c4ce, 6); mov(memd_a32[ss, ebp - 0x198], eax);    /* mov [ebp-0x198], eax */
            ii(0x100b_c4d4, 6); mov(eax, memd_a32[ss, ebp - 0x198]);    /* mov eax, [ebp-0x198] */
            ii(0x100b_c4da, 6); mov(memd_a32[ss, ebp - 0x19c], eax);    /* mov [ebp-0x19c], eax */
            ii(0x100b_c4e0, 2); jmpd(0x100b_c4ee, 0xc); goto l_0x100b_c4ee; /* jmp 0x100bc4ee */
        l_0x100b_c4e2:
            ii(0x100b_c4e2, 6); mov(eax, memd_a32[ss, ebp - 0x194]);    /* mov eax, [ebp-0x194] */
            ii(0x100b_c4e8, 6); mov(memd_a32[ss, ebp - 0x19c], eax);    /* mov [ebp-0x19c], eax */
        l_0x100b_c4ee:
            ii(0x100b_c4ee, 6); mov(edx, memd_a32[ss, ebp - 0x19c]);    /* mov edx, [ebp-0x19c] */
            ii(0x100b_c4f4, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_c4f9, 5); calld(0x100a_4d50, -0x177ae);           /* call 0x100a4d50 */
        l_0x100b_c4fe:
            ii(0x100b_c4fe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c501, 4); mov(memb_a32[ds, eax + 0xe], 0);        /* mov byte [eax+0xe], 0x0 */
        l_0x100b_c505:
            ii(0x100b_c505, 6); lea(edx, ebp - 0x1a4);                  /* lea edx, [ebp-0x1a4] */
            ii(0x100b_c50b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c50e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c511, 5); calld(0x1007_8137, -0x443df);           /* call 0x10078137 */
            ii(0x100b_c516, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c519, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100b_c51c, 5); calld(0x100c_b000, 0xeadf);             /* call 0x100cb000 */
            ii(0x100b_c521, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c523, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c526, 5); calld(0x100c_af68, 0xea3d);             /* call 0x100caf68 */
            ii(0x100b_c52b, 2); jmpd(0x100b_c535, 0x8); goto l_0x100b_c535; /* jmp 0x100bc535 */
        l_0x100b_c52d:
            ii(0x100b_c52d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c530, 5); calld(0x1007_6bf8, -0x4593d);           /* call 0x10076bf8 */
        l_0x100b_c535:
            ii(0x100b_c535, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c537, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c53a, 5); calld(0x1013_ad71, 0x7e832);            /* call 0x1013ad71 */
            ii(0x100b_c53f, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c541, 6); if(jzd(0x100b_c644, 0xfd)) goto l_0x100b_c644; /* jz 0x100bc644 */
            ii(0x100b_c547, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c54a, 5); calld(0x1008_a0f8, -0x32457);           /* call 0x1008a0f8 */
            ii(0x100b_c54f, 5); calld(0x100b_8dfb, -0x3759);            /* call 0x100b8dfb */
            ii(0x100b_c554, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_c556, 6); if(jnzd(0x100b_c63f, 0xe3)) goto l_0x100b_c63f; /* jnz 0x100bc63f */
            ii(0x100b_c55c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c55f, 5); calld(0x1008_a0f8, -0x3246c);           /* call 0x1008a0f8 */
            ii(0x100b_c564, 5); calld(0x1008_a370, -0x321f9);           /* call 0x1008a370 */
            ii(0x100b_c569, 6); mov(memd_a32[ss, ebp - 0x1a8], eax);    /* mov [ebp-0x1a8], eax */
            ii(0x100b_c56f, 6); lea(ebx, ebp - 0x1a4);                  /* lea ebx, [ebp-0x1a4] */
            ii(0x100b_c575, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c578, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_c57b, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c581, 5); calld(0x1007_76f3, -0x44e93);           /* call 0x100776f3 */
            ii(0x100b_c586, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c588, 2); if(jzd(0x100b_c5a6, 0x1c)) goto l_0x100b_c5a6; /* jz 0x100bc5a6 */
            ii(0x100b_c58a, 5); mov(ebx, 0x1000);                       /* mov ebx, 0x1000 */
            ii(0x100b_c58f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c592, 5); calld(0x1008_a12c, -0x3246b);           /* call 0x1008a12c */
            ii(0x100b_c597, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c599, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c59c, 5); calld(0x100b_ab5d, -0x1a44);            /* call 0x100bab5d */
            ii(0x100b_c5a1, 5); jmpd(0x100b_c63f, 0x99); goto l_0x100b_c63f; /* jmp 0x100bc63f */
        l_0x100b_c5a6:
            ii(0x100b_c5a6, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c5ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c5ae, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c5b1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c5b4, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100b_c5b7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_c5ba, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c5bc, 2); if(jzd(0x100b_c5d5, 0x17)) goto l_0x100b_c5d5; /* jz 0x100bc5d5 */
            ii(0x100b_c5be, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c5c4, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100b_c5c7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_c5cc, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100b_c5cf, 6); if(jnzd(0x100b_c63f, 0x6a)) goto l_0x100b_c63f; /* jnz 0x100bc63f */
        l_0x100b_c5d5:
            ii(0x100b_c5d5, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c5db, 5); cmp(memw_a32[ds, eax + 0x8], 0x31);     /* cmp word [eax+0x8], 0x31 */
            ii(0x100b_c5e0, 2); if(jnzd(0x100b_c5ee, 0xc)) goto l_0x100b_c5ee; /* jnz 0x100bc5ee */
            ii(0x100b_c5e2, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c5e8, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100b_c5ec, 2); if(jzd(0x100b_c603, 0x15)) goto l_0x100b_c603; /* jz 0x100bc603 */
        l_0x100b_c5ee:
            ii(0x100b_c5ee, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c5f4, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100b_c5f7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_c5fa, 5); calld(0x100b_b097, -0x1568);            /* call 0x100bb097 */
            ii(0x100b_c5ff, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c601, 2); if(jzd(0x100b_c605, 0x2)) goto l_0x100b_c605; /* jz 0x100bc605 */
        l_0x100b_c603:
            ii(0x100b_c603, 2); jmpd(0x100b_c628, 0x23); goto l_0x100b_c628; /* jmp 0x100bc628 */
        l_0x100b_c605:
            ii(0x100b_c605, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c60b, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100b_c60e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_c613, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100b_c616, 2); if(jnzd(0x100b_c626, 0xe)) goto l_0x100b_c626; /* jnz 0x100bc626 */
            ii(0x100b_c618, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c61e, 6); test(memw_a32[ds, eax + 0x12], 0x1c0);  /* test word [eax+0x12], 0x1c0 */
            ii(0x100b_c624, 2); if(jnzd(0x100b_c628, 0x2)) goto l_0x100b_c628; /* jnz 0x100bc628 */
        l_0x100b_c626:
            ii(0x100b_c626, 2); jmpd(0x100b_c63f, 0x17); goto l_0x100b_c63f; /* jmp 0x100bc63f */
        l_0x100b_c628:
            ii(0x100b_c628, 5); mov(ebx, 0x1f00);                       /* mov ebx, 0x1f00 */
            ii(0x100b_c62d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c630, 5); calld(0x1008_a12c, -0x32509);           /* call 0x1008a12c */
            ii(0x100b_c635, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c637, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c63a, 5); calld(0x100b_ab5d, -0x1ae2);            /* call 0x100bab5d */
        l_0x100b_c63f:
            ii(0x100b_c63f, 5); jmpd(0x100b_c52d, -0x117); goto l_0x100b_c52d; /* jmp 0x100bc52d */
        l_0x100b_c644:
            ii(0x100b_c644, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100b_c64b, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_c650, 5); calld(0x1007_6338, -0x4631d);           /* call 0x10076338 */
            ii(0x100b_c655, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_c658, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c65a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_c65c, 5); calld(0x1007_643c, -0x46225);           /* call 0x1007643c */
            ii(0x100b_c661, 2); jmpd(0x100b_c66b, 0x8); goto l_0x100b_c66b; /* jmp 0x100bc66b */
        l_0x100b_c663:
            ii(0x100b_c663, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c666, 5); calld(0x1007_6bf8, -0x45a73);           /* call 0x10076bf8 */
        l_0x100b_c66b:
            ii(0x100b_c66b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c66d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c670, 5); calld(0x1013_ad71, 0x7e6fc);            /* call 0x1013ad71 */
            ii(0x100b_c675, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c677, 2); if(jzd(0x100b_c6b2, 0x39)) goto l_0x100b_c6b2; /* jz 0x100bc6b2 */
            ii(0x100b_c679, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c67c, 5); calld(0x1007_63a0, -0x462e1);           /* call 0x100763a0 */
            ii(0x100b_c681, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c683, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c686, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c689, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c68c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c68e, 2); if(jnzd(0x100b_c69f, 0xf)) goto l_0x100b_c69f; /* jnz 0x100bc69f */
            ii(0x100b_c690, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c693, 5); calld(0x1007_63a0, -0x462f8);           /* call 0x100763a0 */
            ii(0x100b_c698, 5); cmp(memw_a32[ds, eax + 0x8], 0x7);      /* cmp word [eax+0x8], 0x7 */
            ii(0x100b_c69d, 2); if(jzd(0x100b_c6a1, 0x2)) goto l_0x100b_c6a1; /* jz 0x100bc6a1 */
        l_0x100b_c69f:
            ii(0x100b_c69f, 2); jmpd(0x100b_c6b0, 0xf); goto l_0x100b_c6b0; /* jmp 0x100bc6b0 */
        l_0x100b_c6a1:
            ii(0x100b_c6a1, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c6a4, 5); calld(0x1007_63a0, -0x46309);           /* call 0x100763a0 */
            ii(0x100b_c6a9, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x100b_c6ad, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
        l_0x100b_c6b0:
            ii(0x100b_c6b0, 2); jmpd(0x100b_c663, -0x4f); goto l_0x100b_c663; /* jmp 0x100bc663 */
        l_0x100b_c6b2:
            ii(0x100b_c6b2, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_c6b7, 5); calld(0x1007_6338, -0x46384);           /* call 0x10076338 */
            ii(0x100b_c6bc, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_c6bf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c6c1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_c6c3, 5); calld(0x1007_643c, -0x4628c);           /* call 0x1007643c */
            ii(0x100b_c6c8, 2); jmpd(0x100b_c6d2, 0x8); goto l_0x100b_c6d2; /* jmp 0x100bc6d2 */
        l_0x100b_c6ca:
            ii(0x100b_c6ca, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c6cd, 5); calld(0x1007_6bf8, -0x45ada);           /* call 0x10076bf8 */
        l_0x100b_c6d2:
            ii(0x100b_c6d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c6d4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c6d7, 5); calld(0x1013_ad71, 0x7e695);            /* call 0x1013ad71 */
            ii(0x100b_c6dc, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c6de, 2); if(jzd(0x100b_c73e, 0x5e)) goto l_0x100b_c73e; /* jz 0x100bc73e */
            ii(0x100b_c6e0, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c6e3, 5); calld(0x1007_63a0, -0x46348);           /* call 0x100763a0 */
            ii(0x100b_c6e8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c6ea, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c6ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c6f0, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c6f3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c6f5, 2); if(jnzd(0x100b_c706, 0xf)) goto l_0x100b_c706; /* jnz 0x100bc706 */
            ii(0x100b_c6f7, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c6fa, 5); calld(0x1007_63a0, -0x4635f);           /* call 0x100763a0 */
            ii(0x100b_c6ff, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100b_c704, 2); if(jzd(0x100b_c708, 0x2)) goto l_0x100b_c708; /* jz 0x100bc708 */
        l_0x100b_c706:
            ii(0x100b_c706, 2); jmpd(0x100b_c716, 0xe); goto l_0x100b_c716; /* jmp 0x100bc716 */
        l_0x100b_c708:
            ii(0x100b_c708, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c70b, 5); calld(0x1007_63a0, -0x46370);           /* call 0x100763a0 */
            ii(0x100b_c710, 4); cmp(memb_a32[ds, eax + 0x3d], 0x7);     /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100b_c714, 2); if(jnzd(0x100b_c718, 0x2)) goto l_0x100b_c718; /* jnz 0x100bc718 */
        l_0x100b_c716:
            ii(0x100b_c716, 2); jmpd(0x100b_c726, 0xe); goto l_0x100b_c726; /* jmp 0x100bc726 */
        l_0x100b_c718:
            ii(0x100b_c718, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c71b, 5); calld(0x1007_63a0, -0x46380);           /* call 0x100763a0 */
            ii(0x100b_c720, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_c724, 2); if(jnzd(0x100b_c728, 0x2)) goto l_0x100b_c728; /* jnz 0x100bc728 */
        l_0x100b_c726:
            ii(0x100b_c726, 2); jmpd(0x100b_c73c, 0x14); goto l_0x100b_c73c; /* jmp 0x100bc73c */
        l_0x100b_c728:
            ii(0x100b_c728, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c72a, 5); mov(edx, 0x7);                          /* mov edx, 0x7 */
            ii(0x100b_c72f, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c732, 5); calld(0x1007_6408, -0x4632f);           /* call 0x10076408 */
            ii(0x100b_c737, 5); calld(0x1016_3053, 0xa6917);            /* call 0x10163053 */
        l_0x100b_c73c:
            ii(0x100b_c73c, 2); jmpd(0x100b_c6ca, -0x74); goto l_0x100b_c6ca; /* jmp 0x100bc6ca */
        l_0x100b_c73e:
            ii(0x100b_c73e, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100b_c742, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100b_c745, 6); if(jld(0x100b_c800, 0xb5)) goto l_0x100b_c800; /* jl 0x100bc800 */
            ii(0x100b_c74b, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_c750, 5); calld(0x1007_6338, -0x4641d);           /* call 0x10076338 */
            ii(0x100b_c755, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_c758, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c75a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_c75c, 5); calld(0x1007_643c, -0x46325);           /* call 0x1007643c */
            ii(0x100b_c761, 2); jmpd(0x100b_c76b, 0x8); goto l_0x100b_c76b; /* jmp 0x100bc76b */
        l_0x100b_c763:
            ii(0x100b_c763, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c766, 5); calld(0x1007_6bf8, -0x45b73);           /* call 0x10076bf8 */
        l_0x100b_c76b:
            ii(0x100b_c76b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c76d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c770, 5); calld(0x1013_ad71, 0x7e5fc);            /* call 0x1013ad71 */
            ii(0x100b_c775, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c777, 6); if(jzd(0x100b_c800, 0x83)) goto l_0x100b_c800; /* jz 0x100bc800 */
            ii(0x100b_c77d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c780, 5); calld(0x1007_63a0, -0x463e5);           /* call 0x100763a0 */
            ii(0x100b_c785, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c787, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c78a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c78d, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c790, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c792, 2); if(jnzd(0x100b_c7c5, 0x31)) goto l_0x100b_c7c5; /* jnz 0x100bc7c5 */
            ii(0x100b_c794, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c797, 5); calld(0x1007_63a0, -0x463fc);           /* call 0x100763a0 */
            ii(0x100b_c79c, 5); cmp(memw_a32[ds, eax + 0x8], 0);        /* cmp word [eax+0x8], 0x0 */
            ii(0x100b_c7a1, 2); if(jzd(0x100b_c7b2, 0xf)) goto l_0x100b_c7b2; /* jz 0x100bc7b2 */
            ii(0x100b_c7a3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c7a6, 5); calld(0x1007_63a0, -0x4640b);           /* call 0x100763a0 */
            ii(0x100b_c7ab, 5); cmp(memw_a32[ds, eax + 0x8], 0x1e);     /* cmp word [eax+0x8], 0x1e */
            ii(0x100b_c7b0, 2); if(jnzd(0x100b_c7b4, 0x2)) goto l_0x100b_c7b4; /* jnz 0x100bc7b4 */
        l_0x100b_c7b2:
            ii(0x100b_c7b2, 2); jmpd(0x100b_c7c3, 0xf); goto l_0x100b_c7c3; /* jmp 0x100bc7c3 */
        l_0x100b_c7b4:
            ii(0x100b_c7b4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c7b7, 5); calld(0x1007_63a0, -0x4641c);           /* call 0x100763a0 */
            ii(0x100b_c7bc, 5); cmp(memw_a32[ds, eax + 0x8], 0x1d);     /* cmp word [eax+0x8], 0x1d */
            ii(0x100b_c7c1, 2); if(jnzd(0x100b_c7c5, 0x2)) goto l_0x100b_c7c5; /* jnz 0x100bc7c5 */
        l_0x100b_c7c3:
            ii(0x100b_c7c3, 2); jmpd(0x100b_c7c7, 0x2); goto l_0x100b_c7c7; /* jmp 0x100bc7c7 */
        l_0x100b_c7c5:
            ii(0x100b_c7c5, 2); jmpd(0x100b_c7d5, 0xe); goto l_0x100b_c7d5; /* jmp 0x100bc7d5 */
        l_0x100b_c7c7:
            ii(0x100b_c7c7, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c7ca, 5); calld(0x1007_63a0, -0x4642f);           /* call 0x100763a0 */
            ii(0x100b_c7cf, 4); cmp(memb_a32[ds, eax + 0x3d], 0x7);     /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100b_c7d3, 2); if(jnzd(0x100b_c7d7, 0x2)) goto l_0x100b_c7d7; /* jnz 0x100bc7d7 */
        l_0x100b_c7d5:
            ii(0x100b_c7d5, 2); jmpd(0x100b_c7e5, 0xe); goto l_0x100b_c7e5; /* jmp 0x100bc7e5 */
        l_0x100b_c7d7:
            ii(0x100b_c7d7, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c7da, 5); calld(0x1007_63a0, -0x4643f);           /* call 0x100763a0 */
            ii(0x100b_c7df, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_c7e3, 2); if(jnzd(0x100b_c7e7, 0x2)) goto l_0x100b_c7e7; /* jnz 0x100bc7e7 */
        l_0x100b_c7e5:
            ii(0x100b_c7e5, 2); jmpd(0x100b_c7fb, 0x14); goto l_0x100b_c7fb; /* jmp 0x100bc7fb */
        l_0x100b_c7e7:
            ii(0x100b_c7e7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c7e9, 5); mov(edx, 0x7);                          /* mov edx, 0x7 */
            ii(0x100b_c7ee, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c7f1, 5); calld(0x1007_6408, -0x463ee);           /* call 0x10076408 */
            ii(0x100b_c7f6, 5); calld(0x1016_3053, 0xa6858);            /* call 0x10163053 */
        l_0x100b_c7fb:
            ii(0x100b_c7fb, 5); jmpd(0x100b_c763, -0x9d); goto l_0x100b_c763; /* jmp 0x100bc763 */
        l_0x100b_c800:
            ii(0x100b_c800, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c802, 6); lea(edx, ebp - 0x1ac);                  /* lea edx, [ebp-0x1ac] */
            ii(0x100b_c808, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c80b, 5); calld(0x100c_6677, 0x9e67);             /* call 0x100c6677 */
            ii(0x100b_c810, 6); lea(edx, ebp - 0x1b0);                  /* lea edx, [ebp-0x1b0] */
            ii(0x100b_c816, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c819, 5); calld(0x100c_735d, 0xab3f);             /* call 0x100c735d */
            ii(0x100b_c81e, 5); calld(0x100c_aef4, 0xe6d1);             /* call 0x100caef4 */
            ii(0x100b_c823, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c825, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_c827, 6); lea(edx, ebp - 0x1b0);                  /* lea edx, [ebp-0x1b0] */
            ii(0x100b_c82d, 6); lea(eax, ebp - 0x1b4);                  /* lea eax, [ebp-0x1b4] */
            ii(0x100b_c833, 5); calld(0x100c_ae64, 0xe62c);             /* call 0x100cae64 */
            ii(0x100b_c838, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_c83a, 5); calld(0x100c_aef4, 0xe6b5);             /* call 0x100caef4 */
            ii(0x100b_c83f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c841, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_c843, 6); lea(edx, ebp - 0x1ac);                  /* lea edx, [ebp-0x1ac] */
            ii(0x100b_c849, 6); lea(eax, ebp - 0x1b8);                  /* lea eax, [ebp-0x1b8] */
            ii(0x100b_c84f, 5); calld(0x100c_ae64, 0xe610);             /* call 0x100cae64 */
            ii(0x100b_c854, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x100b_c857, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100b_c859, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c85b, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100b_c85d, 5); calld(0x100c_63af, 0x9b4d);             /* call 0x100c63af */
            ii(0x100b_c862, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c864, 6); lea(eax, ebp - 0x1b8);                  /* lea eax, [ebp-0x1b8] */
            ii(0x100b_c86a, 5); calld(0x100c_a6a0, 0xde31);             /* call 0x100ca6a0 */
            ii(0x100b_c86f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c871, 6); lea(eax, ebp - 0x1b4);                  /* lea eax, [ebp-0x1b4] */
            ii(0x100b_c877, 5); calld(0x100c_a6a0, 0xde24);             /* call 0x100ca6a0 */
            ii(0x100b_c87c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c87f, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c882, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_c888, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x100b_c88e, 5); calld(0x100c_b67c, 0xede9);             /* call 0x100cb67c */
            ii(0x100b_c893, 6); mov(memd_a32[ss, ebp - 0x1bc], eax);    /* mov [ebp-0x1bc], eax */
        l_0x100b_c899:
            ii(0x100b_c899, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c89c, 5); cmp(memw_a32[ds, eax + 0xa], -0x1 /* 0xff */); /* cmp word [eax+0xa], 0xffff */
            ii(0x100b_c8a1, 2); if(jzd(0x100b_c8b3, 0x10)) goto l_0x100b_c8b3; /* jz 0x100bc8b3 */
            ii(0x100b_c8a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c8a6, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x100b_c8aa, 7); cmp(ax, memw_a32[ss, ebp - 0x1bc]);     /* cmp ax, [ebp-0x1bc] */
            ii(0x100b_c8b1, 2); if(jled(0x100b_c8b8, 0x5)) goto l_0x100b_c8b8; /* jle 0x100bc8b8 */
        l_0x100b_c8b3:
            ii(0x100b_c8b3, 5); jmpd(0x100b_c97c, 0xc4); goto l_0x100b_c97c; /* jmp 0x100bc97c */
        l_0x100b_c8b8:
            ii(0x100b_c8b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c8bb, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x100b_c8bf, 6); sub(memd_a32[ss, ebp - 0x1bc], eax);    /* sub [ebp-0x1bc], eax */
            ii(0x100b_c8c5, 7); movsx(edx, memw_a32[ss, ebp - 0x1bc]);  /* movsx edx, word [ebp-0x1bc] */
            ii(0x100b_c8cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c8cf, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c8d2, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_c8d8, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x100b_c8de, 5); calld(0x100c_b60c, 0xed29);             /* call 0x100cb60c */
            ii(0x100b_c8e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c8e6, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c8e9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_c8ef, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_c8f2, 4); mov(dx, memw_a32[ds, edx + 0xc]);       /* mov dx, [edx+0xc] */
            ii(0x100b_c8f6, 7); add(memw_a32[ds, eax + 0x101c_a583], dx); /* add [eax+0x101ca583], dx */
            ii(0x100b_c8fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c900, 5); calld(0x100c_79a0, 0xb09b);             /* call 0x100c79a0 */
            ii(0x100b_c905, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100b_c90c, 2); if(jzd(0x100b_c919, 0xb)) goto l_0x100b_c919; /* jz 0x100bc919 */
            ii(0x100b_c90e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c911, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c914, 5); calld(0x1012_894c, 0x6c033);            /* call 0x1012894c */
        l_0x100b_c919:
            ii(0x100b_c919, 5); calld(0x100c_aef4, 0xe5d6);             /* call 0x100caef4 */
            ii(0x100b_c91e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c920, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_c922, 6); lea(edx, ebp - 0x1b0);                  /* lea edx, [ebp-0x1b0] */
            ii(0x100b_c928, 6); lea(eax, ebp - 0x1c0);                  /* lea eax, [ebp-0x1c0] */
            ii(0x100b_c92e, 5); calld(0x100c_ae64, 0xe531);             /* call 0x100cae64 */
            ii(0x100b_c933, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100b_c935, 5); calld(0x100c_aef4, 0xe5ba);             /* call 0x100caef4 */
            ii(0x100b_c93a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c93c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_c93e, 6); lea(edx, ebp - 0x1ac);                  /* lea edx, [ebp-0x1ac] */
            ii(0x100b_c944, 6); lea(eax, ebp - 0x1c4);                  /* lea eax, [ebp-0x1c4] */
            ii(0x100b_c94a, 5); calld(0x100c_ae64, 0xe515);             /* call 0x100cae64 */
            ii(0x100b_c94f, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x100b_c952, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_c954, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c956, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_c958, 5); calld(0x100c_63af, 0x9a52);             /* call 0x100c63af */
            ii(0x100b_c95d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c95f, 6); lea(eax, ebp - 0x1c4);                  /* lea eax, [ebp-0x1c4] */
            ii(0x100b_c965, 5); calld(0x100c_a6a0, 0xdd36);             /* call 0x100ca6a0 */
            ii(0x100b_c96a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c96c, 6); lea(eax, ebp - 0x1c0);                  /* lea eax, [ebp-0x1c0] */
            ii(0x100b_c972, 5); calld(0x100c_a6a0, 0xdd29);             /* call 0x100ca6a0 */
            ii(0x100b_c977, 5); jmpd(0x100b_c899, -0xe3); goto l_0x100b_c899; /* jmp 0x100bc899 */
        l_0x100b_c97c:
            ii(0x100b_c97c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c97e, 6); lea(eax, ebp - 0x1b0);                  /* lea eax, [ebp-0x1b0] */
            ii(0x100b_c984, 5); calld(0x100c_a6a0, 0xdd17);             /* call 0x100ca6a0 */
            ii(0x100b_c989, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c98b, 6); lea(eax, ebp - 0x1ac);                  /* lea eax, [ebp-0x1ac] */
            ii(0x100b_c991, 5); calld(0x100c_a6a0, 0xdd0a);             /* call 0x100ca6a0 */
            ii(0x100b_c996, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c999, 5); calld(0x100b_e21a, 0x187c);             /* call 0x100be21a */
            ii(0x100b_c99e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c9a1, 5); calld(0x100b_b100, -0x18a6);            /* call 0x100bb100 */
            ii(0x100b_c9a6, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_c9ab, 5); calld(0x1007_6338, -0x46678);           /* call 0x10076338 */
            ii(0x100b_c9b0, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_c9b3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c9b5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_c9b7, 5); calld(0x1007_643c, -0x46580);           /* call 0x1007643c */
            ii(0x100b_c9bc, 2); jmpd(0x100b_c9c6, 0x8); goto l_0x100b_c9c6; /* jmp 0x100bc9c6 */
        l_0x100b_c9be:
            ii(0x100b_c9be, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c9c1, 5); calld(0x1007_6bf8, -0x45dce);           /* call 0x10076bf8 */
        l_0x100b_c9c6:
            ii(0x100b_c9c6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c9c8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c9cb, 5); calld(0x1013_ad71, 0x7e3a1);            /* call 0x1013ad71 */
            ii(0x100b_c9d0, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c9d2, 6); if(jzd(0x100b_cab1, 0xd9)) goto l_0x100b_cab1; /* jz 0x100bcab1 */
            ii(0x100b_c9d8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c9db, 5); calld(0x1007_63a0, -0x46640);           /* call 0x100763a0 */
            ii(0x100b_c9e0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c9e2, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c9e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c9e8, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c9eb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c9ed, 6); if(jnzd(0x100b_caac, 0xb9)) goto l_0x100b_caac; /* jnz 0x100bcaac */
            ii(0x100b_c9f3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c9f6, 5); calld(0x1007_63a0, -0x4665b);           /* call 0x100763a0 */
            ii(0x100b_c9fb, 5); calld(0x1015_26ac, 0x95cac);            /* call 0x101526ac */
            ii(0x100b_ca00, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_ca02, 2); if(jzd(0x100b_ca1a, 0x16)) goto l_0x100b_ca1a; /* jz 0x100bca1a */
            ii(0x100b_ca04, 5); calld(0x1008_b0e4, -0x31925);           /* call 0x1008b0e4 */
            ii(0x100b_ca09, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_ca0b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_ca0d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_ca10, 5); calld(0x1007_63d4, -0x46641);           /* call 0x100763d4 */
            ii(0x100b_ca15, 5); calld(0x100a_297d, -0x1a09d);           /* call 0x100a297d */
        l_0x100b_ca1a:
            ii(0x100b_ca1a, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_ca1d, 5); calld(0x1007_63a0, -0x46682);           /* call 0x100763a0 */
            ii(0x100b_ca22, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100b_ca25, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_ca2a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_ca2c, 6); if(jled(0x100b_caac, 0x7a)) goto l_0x100b_caac; /* jle 0x100bcaac */
            ii(0x100b_ca32, 10); mov(memd_a32[ss, ebp - 0x1c8], 0x1);   /* mov dword [ebp-0x1c8], 0x1 */
            ii(0x100b_ca3c, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100b_ca41, 5); calld(Definitions.sys_new, 0xa93ba);    /* call 0x10165e00 */
            ii(0x100b_ca46, 6); mov(memd_a32[ss, ebp - 0x1cc], eax);    /* mov [ebp-0x1cc], eax */
            ii(0x100b_ca4c, 6); mov(eax, memd_a32[ss, ebp - 0x1cc]);    /* mov eax, [ebp-0x1cc] */
            ii(0x100b_ca52, 6); mov(memd_a32[ss, ebp - 0x1d0], eax);    /* mov [ebp-0x1d0], eax */
            ii(0x100b_ca58, 7); cmp(memd_a32[ss, ebp - 0x1d0], 0);      /* cmp dword [ebp-0x1d0], 0x0 */
            ii(0x100b_ca5f, 2); if(jzd(0x100b_ca8a, 0x29)) goto l_0x100b_ca8a; /* jz 0x100bca8a */
            ii(0x100b_ca61, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_ca64, 5); calld(0x1007_63d4, -0x46695);           /* call 0x100763d4 */
            ii(0x100b_ca69, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_ca6b, 6); mov(eax, memd_a32[ss, ebp - 0x1cc]);    /* mov eax, [ebp-0x1cc] */
            ii(0x100b_ca71, 5); calld(0x100a_3d3a, -0x18d3c);           /* call 0x100a3d3a */
            ii(0x100b_ca76, 6); mov(memd_a32[ss, ebp - 0x1d4], eax);    /* mov [ebp-0x1d4], eax */
            ii(0x100b_ca7c, 6); mov(eax, memd_a32[ss, ebp - 0x1d4]);    /* mov eax, [ebp-0x1d4] */
            ii(0x100b_ca82, 6); mov(memd_a32[ss, ebp - 0x1d8], eax);    /* mov [ebp-0x1d8], eax */
            ii(0x100b_ca88, 2); jmpd(0x100b_ca96, 0xc); goto l_0x100b_ca96; /* jmp 0x100bca96 */
        l_0x100b_ca8a:
            ii(0x100b_ca8a, 6); mov(eax, memd_a32[ss, ebp - 0x1d0]);    /* mov eax, [ebp-0x1d0] */
            ii(0x100b_ca90, 6); mov(memd_a32[ss, ebp - 0x1d8], eax);    /* mov [ebp-0x1d8], eax */
        l_0x100b_ca96:
            ii(0x100b_ca96, 6); mov(edx, memd_a32[ss, ebp - 0x1d8]);    /* mov edx, [ebp-0x1d8] */
            ii(0x100b_ca9c, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_caa1, 6); mov(ebx, memd_a32[ss, ebp - 0x1c8]);    /* mov ebx, [ebp-0x1c8] */
            ii(0x100b_caa7, 5); calld(0x100a_4db6, -0x17cf6);           /* call 0x100a4db6 */
        l_0x100b_caac:
            ii(0x100b_caac, 5); jmpd(0x100b_c9be, -0xf3); goto l_0x100b_c9be; /* jmp 0x100bc9be */
        l_0x100b_cab1:
            ii(0x100b_cab1, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100b_cab6, 5); calld(0x1007_6338, -0x46783);           /* call 0x10076338 */
            ii(0x100b_cabb, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_cabe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_cac0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_cac2, 5); calld(0x1007_643c, -0x4668b);           /* call 0x1007643c */
            ii(0x100b_cac7, 2); jmpd(0x100b_cad1, 0x8); goto l_0x100b_cad1; /* jmp 0x100bcad1 */
        l_0x100b_cac9:
            ii(0x100b_cac9, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cacc, 5); calld(0x1007_6bf8, -0x45ed9);           /* call 0x10076bf8 */
        l_0x100b_cad1:
            ii(0x100b_cad1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cad3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cad6, 5); calld(0x1013_ad71, 0x7e296);            /* call 0x1013ad71 */
            ii(0x100b_cadb, 2); test(al, al);                           /* test al, al */
            ii(0x100b_cadd, 6); if(jzd(0x100b_cbbc, 0xd9)) goto l_0x100b_cbbc; /* jz 0x100bcbbc */
            ii(0x100b_cae3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cae6, 5); calld(0x1007_63a0, -0x4674b);           /* call 0x100763a0 */
            ii(0x100b_caeb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_caed, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_caf0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_caf3, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_caf6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_caf8, 6); if(jnzd(0x100b_cbb7, 0xb9)) goto l_0x100b_cbb7; /* jnz 0x100bcbb7 */
            ii(0x100b_cafe, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cb01, 5); calld(0x1007_63a0, -0x46766);           /* call 0x100763a0 */
            ii(0x100b_cb06, 5); calld(0x1015_26ac, 0x95ba1);            /* call 0x101526ac */
            ii(0x100b_cb0b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_cb0d, 2); if(jzd(0x100b_cb25, 0x16)) goto l_0x100b_cb25; /* jz 0x100bcb25 */
            ii(0x100b_cb0f, 5); calld(0x1008_b0e4, -0x31a30);           /* call 0x1008b0e4 */
            ii(0x100b_cb14, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cb16, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_cb18, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cb1b, 5); calld(0x1007_63d4, -0x4674c);           /* call 0x100763d4 */
            ii(0x100b_cb20, 5); calld(0x100a_297d, -0x1a1a8);           /* call 0x100a297d */
        l_0x100b_cb25:
            ii(0x100b_cb25, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cb28, 5); calld(0x1007_63a0, -0x4678d);           /* call 0x100763a0 */
            ii(0x100b_cb2d, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100b_cb30, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_cb35, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_cb37, 6); if(jled(0x100b_cbb7, 0x7a)) goto l_0x100b_cbb7; /* jle 0x100bcbb7 */
            ii(0x100b_cb3d, 10); mov(memd_a32[ss, ebp - 0x1dc], 0x1);   /* mov dword [ebp-0x1dc], 0x1 */
            ii(0x100b_cb47, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100b_cb4c, 5); calld(Definitions.sys_new, 0xa92af);    /* call 0x10165e00 */
            ii(0x100b_cb51, 6); mov(memd_a32[ss, ebp - 0x1e0], eax);    /* mov [ebp-0x1e0], eax */
            ii(0x100b_cb57, 6); mov(eax, memd_a32[ss, ebp - 0x1e0]);    /* mov eax, [ebp-0x1e0] */
            ii(0x100b_cb5d, 6); mov(memd_a32[ss, ebp - 0x1e4], eax);    /* mov [ebp-0x1e4], eax */
            ii(0x100b_cb63, 7); cmp(memd_a32[ss, ebp - 0x1e4], 0);      /* cmp dword [ebp-0x1e4], 0x0 */
            ii(0x100b_cb6a, 2); if(jzd(0x100b_cb95, 0x29)) goto l_0x100b_cb95; /* jz 0x100bcb95 */
            ii(0x100b_cb6c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cb6f, 5); calld(0x1007_63d4, -0x467a0);           /* call 0x100763d4 */
            ii(0x100b_cb74, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_cb76, 6); mov(eax, memd_a32[ss, ebp - 0x1e0]);    /* mov eax, [ebp-0x1e0] */
            ii(0x100b_cb7c, 5); calld(0x100a_3d3a, -0x18e47);           /* call 0x100a3d3a */
            ii(0x100b_cb81, 6); mov(memd_a32[ss, ebp - 0x1e8], eax);    /* mov [ebp-0x1e8], eax */
            ii(0x100b_cb87, 6); mov(eax, memd_a32[ss, ebp - 0x1e8]);    /* mov eax, [ebp-0x1e8] */
            ii(0x100b_cb8d, 6); mov(memd_a32[ss, ebp - 0x1ec], eax);    /* mov [ebp-0x1ec], eax */
            ii(0x100b_cb93, 2); jmpd(0x100b_cba1, 0xc); goto l_0x100b_cba1; /* jmp 0x100bcba1 */
        l_0x100b_cb95:
            ii(0x100b_cb95, 6); mov(eax, memd_a32[ss, ebp - 0x1e4]);    /* mov eax, [ebp-0x1e4] */
            ii(0x100b_cb9b, 6); mov(memd_a32[ss, ebp - 0x1ec], eax);    /* mov [ebp-0x1ec], eax */
        l_0x100b_cba1:
            ii(0x100b_cba1, 6); mov(edx, memd_a32[ss, ebp - 0x1ec]);    /* mov edx, [ebp-0x1ec] */
            ii(0x100b_cba7, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_cbac, 6); mov(ebx, memd_a32[ss, ebp - 0x1dc]);    /* mov ebx, [ebp-0x1dc] */
            ii(0x100b_cbb2, 5); calld(0x100a_4db6, -0x17e01);           /* call 0x100a4db6 */
        l_0x100b_cbb7:
            ii(0x100b_cbb7, 5); jmpd(0x100b_cac9, -0xf3); goto l_0x100b_cac9; /* jmp 0x100bcac9 */
        l_0x100b_cbbc:
            ii(0x100b_cbbc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_cbbf, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_cbc2, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_cbc7, 5); calld(0x100a_4fb5, -0x17c17);           /* call 0x100a4fb5 */
            ii(0x100b_cbcc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cbce, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_cbd1, 5); calld(0x1008_8e4c, -0x33d8a);           /* call 0x10088e4c */
            ii(0x100b_cbd6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cbd8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cbdb, 5); calld(0x1007_5f6c, -0x46c74);           /* call 0x10075f6c */
        l_0x100b_cbe0:
            ii(0x100b_cbe0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_cbe2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_cbe3, 1); popd(edi);                              /* pop edi */
            ii(0x100b_cbe4, 1); popd(esi);                              /* pop esi */
            ii(0x100b_cbe5, 1); popd(edx);                              /* pop edx */
            ii(0x100b_cbe6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_cbe7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_cbe8, 1); retd(); return;                         /* ret */
        }
    }
}
