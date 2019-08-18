using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("055ff36c-e53d-4bdb-a544-32673f8f223c")]
        public void Method_100b_b2ef()
        {
            ii(0x100b_b2ef, 5); pushd(0x214);                           /* push 0x214 */
            ii(0x100b_b2f4, 5); calld(Definitions.sys_check_available_stack_size, 0xa_aa59); /* call 0x10165d52 */
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
            ii(0x100b_b311, 5); calld(0x1007_64fc, -0x4_4e1a);          /* call 0x100764fc */
            ii(0x100b_b316, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_b319, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100b_b31d, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100b_b321, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_b324, 5); calld(0x1008_a1e8, -0x3_1141);          /* call 0x1008a1e8 */
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
            ii(0x100b_b351, 5); calld(0x1008_8e4c, -0x3_250a);          /* call 0x10088e4c */
            ii(0x100b_b356, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b358, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_b35b, 5); calld(0x1007_5f6c, -0x4_53f4);          /* call 0x10075f6c */
            ii(0x100b_b360, 5); if(jmpd_func(0x100b_cbe0, 0x187b)) return; /* jmp 0x100bcbe0 */
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
            ii(0x100b_b39a, 5); calld(0x1013_a6f4, 0x7_f355);           /* call 0x1013a6f4 */
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
            ii(0x100b_b3d0, 5); calld(Definitions.sys_sprintf, 0xa_ab2c); /* call 0x10165f01 */
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
            ii(0x100b_b3f6, 5); calld(0x1011_5d23, 0x5_a928);           /* call 0x10115d23 */
        l_0x100b_b3fb:
            ii(0x100b_b3fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b3fe, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_b401, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x100b_b407, 5); calld(0x100b_aaec, -0x920);             /* call 0x100baaec */
            ii(0x100b_b40c, 6); lea(edx, ebp - 0x8c);                   /* lea edx, [ebp-0x8c] */
            ii(0x100b_b412, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x100b_b418, 5); calld(0x1007_5e64, -0x4_55b9);          /* call 0x10075e64 */
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
            ii(0x100b_b454, 5); calld(Definitions.sys_memset, 0xa_a987); /* call 0x10165de0 */
            ii(0x100b_b459, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_b45e, 5); calld(0x1007_6338, -0x4_512b);          /* call 0x10076338 */
            ii(0x100b_b463, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b465, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_b468, 5); calld(0x1007_643c, -0x4_5031);          /* call 0x1007643c */
            ii(0x100b_b46d, 2); jmpd(0x100b_b477, 0x8); goto l_0x100b_b477; /* jmp 0x100bb477 */
        l_0x100b_b46f:
            ii(0x100b_b46f, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_b472, 5); calld(0x1007_6bf8, -0x4_487f);          /* call 0x10076bf8 */
        l_0x100b_b477:
            ii(0x100b_b477, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b479, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_b47c, 5); calld(0x1013_ad71, 0x7_f8f0);           /* call 0x1013ad71 */
            ii(0x100b_b481, 2); test(al, al);                           /* test al, al */
            ii(0x100b_b483, 2); if(jzd(0x100b_b4a1, 0x1c)) goto l_0x100b_b4a1; /* jz 0x100bb4a1 */
            ii(0x100b_b485, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_b488, 5); calld(0x1007_63a0, -0x4_50ed);          /* call 0x100763a0 */
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
            ii(0x100b_b61a, 6); if(jzd_func(0x100b_c505, 0xee5)) return; /* jz 0x100bc505 */
            ii(0x100b_b620, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x100b_b625, 5); calld(Definitions.sys_new, 0xa_a7d6);   /* call 0x10165e00 */
            ii(0x100b_b62a, 6); mov(memd_a32[ss, ebp - 0xa4], eax);     /* mov [ebp-0xa4], eax */
            ii(0x100b_b630, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100b_b636, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
            ii(0x100b_b63c, 7); cmp(memd_a32[ss, ebp - 0xa8], 0);       /* cmp dword [ebp-0xa8], 0x0 */
            ii(0x100b_b643, 2); if(jzd(0x100b_b66a, 0x25)) goto l_0x100b_b66a; /* jz 0x100bb66a */
            ii(0x100b_b645, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b648, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_b64b, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100b_b651, 5); calld(0x1007_c9c6, -0x3_ec90);          /* call 0x1007c9c6 */
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
            ii(0x100b_b682, 5); calld(0x1008_afe4, -0x3_06a3);          /* call 0x1008afe4 */
            ii(0x100b_b687, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b68a, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_b68d, 5); calld(0x1008_af84, -0x3_070e);          /* call 0x1008af84 */
            ii(0x100b_b692, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b694, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_b699, 5); calld(0x100a_4d50, -0x1_694e);          /* call 0x100a4d50 */
            ii(0x100b_b69e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6a1, 4); cmp(memb_a32[ds, eax + 0x2], 0);        /* cmp byte [eax+0x2], 0x0 */
            ii(0x100b_b6a5, 6); if(jnzd_func(0x100b_b745, 0x9a)) return; /* jnz 0x100bb745 */
            ii(0x100b_b6ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6ae, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_b6b1, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_b6b7, 6); mov(al, memb_a32[ds, eax + 0x101c_a4ef]); /* mov al, [eax+0x101ca4ef] */
            ii(0x100b_b6bd, 6); mov(memb_a32[ss, ebp - 0xb4], al);      /* mov [ebp-0xb4], al */
            ii(0x100b_b6c3, 2); if(jmpd_func(0x100b_b71c, 0x57)) return; /* jmp 0x100bb71c */
            ii(0x100b_b6c5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6c8, 4); mov(memb_a32[ds, eax + 0x2], 0x3);      /* mov byte [eax+0x2], 0x3 */
            ii(0x100b_b6cc, 5); if(jmpd_func(0x100b_b745, 0x74)) return; /* jmp 0x100bb745 */
            ii(0x100b_b6d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6d4, 4); mov(memb_a32[ds, eax + 0x2], 0x4);      /* mov byte [eax+0x2], 0x4 */
            ii(0x100b_b6d8, 2); if(jmpd_func(0x100b_b745, 0x6b)) return; /* jmp 0x100bb745 */
            ii(0x100b_b6da, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6dd, 4); mov(memb_a32[ds, eax + 0x2], 0x2);      /* mov byte [eax+0x2], 0x2 */
            ii(0x100b_b6e1, 2); if(jmpd_func(0x100b_b745, 0x62)) return; /* jmp 0x100bb745 */
            ii(0x100b_b6e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6e6, 4); mov(memb_a32[ds, eax + 0x2], 0x7);      /* mov byte [eax+0x2], 0x7 */
            ii(0x100b_b6ea, 2); if(jmpd_func(0x100b_b745, 0x59)) return; /* jmp 0x100bb745 */
            ii(0x100b_b6ec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6ef, 4); mov(memb_a32[ds, eax + 0x2], 0x1);      /* mov byte [eax+0x2], 0x1 */
            ii(0x100b_b6f3, 2); if(jmpd_func(0x100b_b745, 0x50)) return; /* jmp 0x100bb745 */
        }
    }
}
