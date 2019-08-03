using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("db016754-3d93-443b-90c9-246eafe7853b")]
        public void Method_1011_05a5()
        {
            ii(0x1011_05a5, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x1011_05aa, 5); calld(Definitions.sys_check_available_stack_size, 0x557a3); /* call 0x10165d52 */
            ii(0x1011_05af, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_05b0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_05b1, 1); pushd(esi);                             /* push esi */
            ii(0x1011_05b2, 1); pushd(edi);                             /* push edi */
            ii(0x1011_05b3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_05b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_05b6, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1011_05bc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_05bf, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1011_05c2, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_05c6, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1011_05c9, 5); mov(edx, 0x101b_ad94);                  /* mov edx, 0x101bad94 */
            ii(0x1011_05ce, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_05d0, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_05d3, 4); cmp(memb_a32[ss, ebp - 0x4], 0x10);     /* cmp byte [ebp-0x4], 0x10 */
            ii(0x1011_05d7, 2); if(jld(0x1011_05e5, 0xc)) goto l_0x1011_05e5; /* jl 0x101105e5 */
            ii(0x1011_05d9, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_05de, 5); calld(/* sys */ 0x1016_a24c, 0x59c69);  /* call 0x1016a24c */
            ii(0x1011_05e3, 2); jmpd(0x1011_05ef, 0xa); goto l_0x1011_05ef; /* jmp 0x101105ef */
        l_0x1011_05e5:
            ii(0x1011_05e5, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1011_05ea, 5); calld(/* sys */ 0x1016_a24c, 0x59c5d);  /* call 0x1016a24c */
        l_0x1011_05ef:
            ii(0x1011_05ef, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_05f2, 5); cmp(memw_a32[ds, eax + 0x8], -0x1 /* 0xff */); /* cmp word [eax+0x8], 0xffff */
            ii(0x1011_05f7, 6); if(jnzd(0x1011_0692, 0x95)) goto l_0x1011_0692; /* jnz 0x10110692 */
            ii(0x1011_05fd, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_0601, 3); cmp(eax, 0xc);                          /* cmp eax, 0xc */
            ii(0x1011_0604, 6); if(jged(0x1011_080a, 0x200)) goto l_0x1011_080a; /* jge 0x1011080a */
            ii(0x1011_060a, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_060e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_0611, 10); mov(memd_a32[ds, eax + 0x101c_4df4], 0); /* mov dword [eax+0x101c4df4], 0x0 */
            ii(0x1011_061b, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1011_0620, 5); calld(Definitions.sys_new, 0x557db);    /* call 0x10165e00 */
            ii(0x1011_0625, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_0628, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_062b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_062e, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_0632, 2); if(jzd(0x1011_0675, 0x41)) goto l_0x1011_0675; /* jz 0x10110675 */
            ii(0x1011_0634, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_0637, 4); mov(ax, memw_a32[ds, eax + 0x6]);       /* mov ax, [eax+0x6] */
            ii(0x1011_063b, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_063e, 4); sub(ax, memw_a32[ds, edx + 0x2]);       /* sub ax, [edx+0x2] */
            ii(0x1011_0642, 1); cwde();                                 /* cwde */
            ii(0x1011_0643, 1); pushd(eax);                             /* push eax */
            ii(0x1011_0644, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_0647, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x1011_064b, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_064e, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x1011_0651, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1011_0654, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_0657, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1011_0659, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_065c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_065f, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1011_0662, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_0665, 5); calld(0x100c_e39d, -0x422cd);           /* call 0x100ce39d */
            ii(0x1011_066a, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_066d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_0670, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_0673, 2); jmpd(0x1011_067b, 0x6); goto l_0x1011_067b; /* jmp 0x1011067b */
        l_0x1011_0675:
            ii(0x1011_0675, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_0678, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1011_067b:
            ii(0x1011_067b, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_067f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_0682, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_0685, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_0687, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_068a, 3); mov(memd_a32[ds, edx + 0x10], eax);     /* mov [edx+0x10], eax */
            ii(0x1011_068d, 5); jmpd(0x1011_074c, 0xba); goto l_0x1011_074c; /* jmp 0x1011074c */
        l_0x1011_0692:
            ii(0x1011_0692, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1011_0697, 5); calld(Definitions.sys_new, 0x55764);    /* call 0x10165e00 */
            ii(0x1011_069c, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_069f, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1011_06a2, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1011_06a5, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1011_06a9, 2); if(jzd(0x1011_06e1, 0x36)) goto l_0x1011_06e1; /* jz 0x101106e1 */
            ii(0x1011_06ab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_06ae, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_06b0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_06b3, 1); pushd(eax);                             /* push eax */
            ii(0x1011_06b4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_06b7, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1011_06ba, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_06bd, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1011_06c1, 1); inc(eax);                               /* inc eax */
            ii(0x1011_06c2, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1011_06c5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_06c8, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1011_06cb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_06ce, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1011_06d1, 5); calld(Definitions.my_ctor_c17, -0x422c7); /* call 0x100ce40f */
            ii(0x1011_06d6, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1011_06d9, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1011_06dc, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1011_06df, 2); jmpd(0x1011_06e7, 0x6); goto l_0x1011_06e7; /* jmp 0x101106e7 */
        l_0x1011_06e1:
            ii(0x1011_06e1, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_06e4, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x1011_06e7:
            ii(0x1011_06e7, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x1011_06eb, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_06ee, 3); add(edx, memd_a32[ss, ebp - 0x8]);      /* add edx, [ebp-0x8] */
            ii(0x1011_06f1, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1011_06f4, 3); mov(memd_a32[ds, edx + 0x10], eax);     /* mov [edx+0x10], eax */
            ii(0x1011_06f7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_06fa, 4); cmp(memd_a32[ds, eax + 0xa], 0);        /* cmp dword [eax+0xa], 0x0 */
            ii(0x1011_06fe, 2); if(jzd(0x1011_074c, 0x4c)) goto l_0x1011_074c; /* jz 0x1011074c */
            ii(0x1011_0700, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1011_0703, 5); calld(0x100d_5224, -0x3b4e4);           /* call 0x100d5224 */
            ii(0x1011_0708, 1); pushd(eax);                             /* push eax */
            ii(0x1011_0709, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_070c, 5); calld(0x100d_5250, -0x3b4c1);           /* call 0x100d5250 */
            ii(0x1011_0711, 1); pushd(eax);                             /* push eax */
            ii(0x1011_0712, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1011_0715, 5); calld(0x100d_527c, -0x3b49e);           /* call 0x100d527c */
            ii(0x1011_071a, 1); pushd(eax);                             /* push eax */
            ii(0x1011_071b, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1011_071e, 5); calld(0x100d_52a8, -0x3b47b);           /* call 0x100d52a8 */
            ii(0x1011_0723, 1); pushd(eax);                             /* push eax */
            ii(0x1011_0724, 5); calld(0x100d_52d4, -0x3b455);           /* call 0x100d52d4 */
            ii(0x1011_0729, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1011_072c, 5); calld(0x100d_52f8, -0x3b439);           /* call 0x100d52f8 */
            ii(0x1011_0731, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1011_0734, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_0737, 3); mov(edx, memd_a32[ds, eax + 0xa]);      /* mov edx, [eax+0xa] */
            ii(0x1011_073a, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_073e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_0741, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_0744, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1011_0747, 5); calld(0x100c_ef64, -0x417e8);           /* call 0x100cef64 */
        l_0x1011_074c:
            ii(0x1011_074c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_074e, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_0752, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_0755, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_0758, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1011_075b, 5); calld(0x100d_5194, -0x3b5cc);           /* call 0x100d5194 */
            ii(0x1011_0760, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x1011_0764, 6); add(edx, 0x3e8);                        /* add edx, 0x3e8 */
            ii(0x1011_076a, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_076e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_0771, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_0774, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1011_0777, 5); calld(0x100d_5134, -0x3b648);           /* call 0x100d5134 */
            ii(0x1011_077c, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_0780, 6); lea(edx, eax + 0x7000);                 /* lea edx, [eax+0x7000] */
            ii(0x1011_0786, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_078a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_078d, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_0790, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1011_0793, 5); calld(0x100d_5164, -0x3b634);           /* call 0x100d5164 */
            ii(0x1011_0798, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_079b, 3); mov(edx, memd_a32[ds, edx + 0x14]);     /* mov edx, [edx+0x14] */
            ii(0x1011_079e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_07a1, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_07a5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_07a8, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_07ab, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1011_07ae, 5); calld(0x100d_50d4, -0x3b6df);           /* call 0x100d50d4 */
            ii(0x1011_07b3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_07b6, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_07b8, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x1011_07bb, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_07bf, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_07c2, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_07c5, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1011_07c8, 5); calld(0x100c_f85c, -0x40f71);           /* call 0x100cf85c */
            ii(0x1011_07cd, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x1011_07d1, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_07d5, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1011_07d8, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_07db, 6); add(edx, 0x3e8);                        /* add edx, 0x3e8 */
            ii(0x1011_07e1, 3); mov(memd_a32[ds, eax + 0x5c], edx);     /* mov [eax+0x5c], edx */
            ii(0x1011_07e4, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_07e8, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1011_07eb, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_07ee, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_07f1, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x1011_07f4, 3); mov(memd_a32[ds, eax + 0x60], edx);     /* mov [eax+0x60], edx */
            ii(0x1011_07f7, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_07fb, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1011_07fe, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_0801, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_0804, 3); mov(edx, memd_a32[ds, edx + 0x12]);     /* mov edx, [edx+0x12] */
            ii(0x1011_0807, 3); mov(memd_a32[ds, eax + 0x64], edx);     /* mov [eax+0x64], edx */
        l_0x1011_080a:
            ii(0x1011_080a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_080c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_080d, 1); popd(edi);                              /* pop edi */
            ii(0x1011_080e, 1); popd(esi);                              /* pop esi */
            ii(0x1011_080f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_0810, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_0811, 1); retd(); return;                         /* ret */
        }
    }
}