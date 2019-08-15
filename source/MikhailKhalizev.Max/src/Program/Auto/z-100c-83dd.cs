using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("99c59e8f-c781-489a-8f8f-be7122233332")]
        public void Method_100c_83dd()
        {
            ii(0x100c_83dd, 5); pushd(0x80);                            /* push 0x80 */
            ii(0x100c_83e2, 5); calld(Definitions.sys_check_available_stack_size, 0x9_d96b); /* call 0x10165d52 */
            ii(0x100c_83e7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_83e8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_83e9, 1); pushd(edx);                             /* push edx */
            ii(0x100c_83ea, 1); pushd(esi);                             /* push esi */
            ii(0x100c_83eb, 1); pushd(edi);                             /* push edi */
            ii(0x100c_83ec, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_83ed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_83ef, 6); sub(esp, 0x60);                         /* sub esp, 0x60 */
            ii(0x100c_83f5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_83f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_83fb, 5); calld(0x100c_8369, -0x97);              /* call 0x100c8369 */
            ii(0x100c_8400, 2); test(al, al);                           /* test al, al */
            ii(0x100c_8402, 6); if(jzd(0x100c_873d, 0x335)) goto l_0x100c_873d; /* jz 0x100c873d */
            ii(0x100c_8408, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100c_840c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_840f, 5); calld(0x1008_bbed, -0x3_c827);          /* call 0x1008bbed */
            ii(0x100c_8414, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_8417, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100c_841b, 3); lea(edi, ebp - 0x24);                   /* lea edi, [ebp-0x24] */
            ii(0x100c_841e, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x100c_8421, 3); lea(esi, esi + 0xb);                    /* lea esi, [esi+0xb] */
            ii(0x100c_8424, 1); movsd_a32();                            /* movsd */
            ii(0x100c_8425, 1); movsd_a32();                            /* movsd */
            ii(0x100c_8426, 1); movsd_a32();                            /* movsd */
            ii(0x100c_8427, 1); movsd_a32();                            /* movsd */
            ii(0x100c_8428, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100c_842b, 5); calld(Definitions.my_ctor_0x101b_4184, -0x5_1940); /* call 0x10076af0 */
            ii(0x100c_8430, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100c_8434, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_8437, 5); calld(0x100c_a068, 0x1c2c);             /* call 0x100ca068 */
            ii(0x100c_843c, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100c_843f, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100c_8443, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_8446, 3); sub(edx, 0x6);                          /* sub edx, 0x6 */
            ii(0x100c_8449, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_844b, 5); calld(0x1007_6e7c, -0x5_15d4);          /* call 0x10076e7c */
            ii(0x100c_8450, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100c_8453, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x100c_8456, 3); sub(edx, 0x6);                          /* sub edx, 0x6 */
            ii(0x100c_8459, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_845b, 5); calld(0x1007_6e7c, -0x5_15e4);          /* call 0x10076e7c */
            ii(0x100c_8460, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100c_8463, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100c_8466, 3); add(edx, 0x6);                          /* add edx, 0x6 */
            ii(0x100c_8469, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x100c_846e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_8471, 5); calld(Definitions.my_min, -0x3_ecf2);   /* call 0x10089784 */
            ii(0x100c_8476, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_8479, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100c_847c, 3); add(edx, 0x6);                          /* add edx, 0x6 */
            ii(0x100c_847f, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100c_8484, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_8487, 5); calld(Definitions.my_min, -0x3_ed08);   /* call 0x10089784 */
            ii(0x100c_848c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_848f, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_8492, 4); mov(memw_a32[ss, ebp - 0x28], ax);      /* mov [ebp-0x28], ax */
            ii(0x100c_8496, 2); jmpd(0x100c_849f, 0x7); goto l_0x100c_849f; /* jmp 0x100c849f */
        l_0x100c_8498:
            ii(0x100c_8498, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100c_849b, 4); inc(memw_a32[ss, ebp - 0x28]);          /* inc word [ebp-0x28] */
        l_0x100c_849f:
            ii(0x100c_849f, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100c_84a3, 3); cmp(eax, memd_a32[ss, ebp - 0x1c]);     /* cmp eax, [ebp-0x1c] */
            ii(0x100c_84a6, 6); if(jged(0x100c_852d, 0x81)) goto l_0x100c_852d; /* jge 0x100c852d */
            ii(0x100c_84ac, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100c_84af, 4); mov(memw_a32[ss, ebp - 0x26], ax);      /* mov [ebp-0x26], ax */
            ii(0x100c_84b3, 2); jmpd(0x100c_84bc, 0x7); goto l_0x100c_84bc; /* jmp 0x100c84bc */
        l_0x100c_84b5:
            ii(0x100c_84b5, 3); mov(eax, memd_a32[ss, ebp - 0x26]);     /* mov eax, [ebp-0x26] */
            ii(0x100c_84b8, 4); inc(memw_a32[ss, ebp - 0x26]);          /* inc word [ebp-0x26] */
        l_0x100c_84bc:
            ii(0x100c_84bc, 4); movsx(eax, memw_a32[ss, ebp - 0x26]);   /* movsx eax, word [ebp-0x26] */
            ii(0x100c_84c0, 3); cmp(eax, memd_a32[ss, ebp - 0x18]);     /* cmp eax, [ebp-0x18] */
            ii(0x100c_84c3, 2); if(jged(0x100c_8528, 0x63)) goto l_0x100c_8528; /* jge 0x100c8528 */
            ii(0x100c_84c5, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100c_84c9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_84cc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_84ce, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_84d1, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x100c_84d4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_84d6, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x100c_84da, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_84dc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_84de, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_84e0, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x100c_84e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_84e5, 3); mov(eax, memd_a32[ds, eax + 0x5]);      /* mov eax, [eax+0x5] */
            ii(0x100c_84e8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_84eb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_84ed, 2); if(jzd(0x100c_8506, 0x17)) goto l_0x100c_8506; /* jz 0x100c8506 */
            ii(0x100c_84ef, 4); movsx(ebx, memw_a32[ss, ebp - 0x26]);   /* movsx ebx, word [ebp-0x26] */
            ii(0x100c_84f3, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100c_84f7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_84fa, 5); calld(0x1008_a728, -0x3_ddd7);          /* call 0x1008a728 */
            ii(0x100c_84ff, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_8501, 3); mov(memb_a32[ds, eax], 0x7f);           /* mov byte [eax], 0x7f */
            ii(0x100c_8504, 2); jmpd(0x100c_8526, 0x20); goto l_0x100c_8526; /* jmp 0x100c8526 */
        l_0x100c_8506:
            ii(0x100c_8506, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100c_8509, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_850c, 5); calld(0x100a_aa64, -0x1_daad);          /* call 0x100aaa64 */
            ii(0x100c_8511, 4); movsx(ebx, memw_a32[ss, ebp - 0x26]);   /* movsx ebx, word [ebp-0x26] */
            ii(0x100c_8515, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100c_8519, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_851c, 5); calld(0x1008_a728, -0x3_ddf9);          /* call 0x1008a728 */
            ii(0x100c_8521, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_8523, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x100c_8526:
            ii(0x100c_8526, 2); jmpd(0x100c_84b5, -0x73); goto l_0x100c_84b5; /* jmp 0x100c84b5 */
        l_0x100c_8528:
            ii(0x100c_8528, 5); jmpd(0x100c_8498, -0x95); goto l_0x100c_8498; /* jmp 0x100c8498 */
        l_0x100c_852d:
            ii(0x100c_852d, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100c_8530, 5); calld(Definitions.my_ctor_0x101b_4184, -0x5_1a45); /* call 0x10076af0 */
            ii(0x100c_8535, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100c_853a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_853d, 1); pushd(eax);                             /* push eax */
            ii(0x100c_853e, 6); mov(ecx, memd_a32[ds, 0x101c_8170]);    /* mov ecx, [0x101c8170] */
            ii(0x100c_8544, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_8547, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_8549, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_854b, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100c_854e, 5); calld(0x1008_b148, -0x3_d40b);          /* call 0x1008b148 */
        l_0x100c_8553:
            ii(0x100c_8553, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_8556, 5); calld(Definitions.my_3_get_count, -0x3_d0db); /* call 0x1008b480 */
            ii(0x100c_855b, 1); cwde();                                 /* cwde */
            ii(0x100c_855c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_855e, 6); if(jled(0x100c_8722, 0x1be)) goto l_0x100c_8722; /* jle 0x100c8722 */
            ii(0x100c_8564, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_8567, 5); calld(Definitions.my_3_get_count, -0x3_d0ec); /* call 0x1008b480 */
            ii(0x100c_856c, 1); dec(eax);                               /* dec eax */
            ii(0x100c_856d, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100c_8570, 4); movsx(edx, memw_a32[ss, ebp - 0x54]);   /* movsx edx, word [ebp-0x54] */
            ii(0x100c_8574, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_8577, 5); calld(0x100a_aa28, -0x1_db54);          /* call 0x100aaa28 */
            ii(0x100c_857c, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x100c_857f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_8581, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_8583, 5); calld(0x1008_8b44, -0x3_fa44);          /* call 0x10088b44 */
            ii(0x100c_8588, 4); movsx(edx, memw_a32[ss, ebp - 0x54]);   /* movsx edx, word [ebp-0x54] */
            ii(0x100c_858c, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_858f, 5); calld(0x100c_db14, 0x5580);             /* call 0x100cdb14 */
            ii(0x100c_8594, 4); movsx(ebx, memw_a32[ss, ebp - 0x26]);   /* movsx ebx, word [ebp-0x26] */
            ii(0x100c_8598, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100c_859c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_859f, 5); calld(0x1008_a728, -0x3_de7c);          /* call 0x1008a728 */
            ii(0x100c_85a4, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_85a6, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100c_85a8, 2); or(al, 0x1);                            /* or al, 0x1 */
            ii(0x100c_85aa, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100c_85ac, 4); mov(memw_a32[ss, ebp - 0x58], ax);      /* mov [ebp-0x58], ax */
            ii(0x100c_85b0, 4); movsx(ebx, memw_a32[ss, ebp - 0x26]);   /* movsx ebx, word [ebp-0x26] */
            ii(0x100c_85b4, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100c_85b8, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_85bb, 5); calld(0x1008_a728, -0x3_de98);          /* call 0x1008a728 */
            ii(0x100c_85c0, 3); lea(edx, eax + ebx);                    /* lea edx, [eax+ebx] */
            ii(0x100c_85c3, 3); mov(al, memb_a32[ss, ebp - 0x58]);      /* mov al, [ebp-0x58] */
            ii(0x100c_85c6, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x100c_85c8, 7); mov(memd_a32[ss, ebp - 0x5c], 0);       /* mov dword [ebp-0x5c], 0x0 */
            ii(0x100c_85cf, 2); jmpd(0x100c_85d7, 0x6); goto l_0x100c_85d7; /* jmp 0x100c85d7 */
        l_0x100c_85d1:
            ii(0x100c_85d1, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x100c_85d4, 3); inc(memd_a32[ss, ebp - 0x5c]);          /* inc dword [ebp-0x5c] */
        l_0x100c_85d7:
            ii(0x100c_85d7, 4); movsx(eax, memw_a32[ss, ebp - 0x5c]);   /* movsx eax, word [ebp-0x5c] */
            ii(0x100c_85db, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_85de, 6); if(jged(0x100c_871d, 0x139)) goto l_0x100c_871d; /* jge 0x100c871d */
            ii(0x100c_85e4, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100c_85e7, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100c_85ea, 5); calld(0x1008_8b44, -0x3_faab);          /* call 0x10088b44 */
            ii(0x100c_85ef, 4); movsx(eax, memw_a32[ss, ebp - 0x5c]);   /* movsx eax, word [ebp-0x5c] */
            ii(0x100c_85f3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_85f6, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x100c_85fb, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_85fd, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100c_8600, 5); calld(0x1008_b1a4, -0x3_d461);          /* call 0x1008b1a4 */
            ii(0x100c_8605, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x100c_8608, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100c_860b, 5); calld(0x1010_82ce, 0x3_fcbe);           /* call 0x101082ce */
            ii(0x100c_8610, 2); test(al, al);                           /* test al, al */
            ii(0x100c_8612, 6); if(jzd(0x100c_8718, 0x100)) goto l_0x100c_8718; /* jz 0x100c8718 */
            ii(0x100c_8618, 6); test(memw_a32[ss, ebp - 0x5c], 0x1);    /* test word [ebp-0x5c], 0x1 */
            ii(0x100c_861e, 2); if(jzd(0x100c_862d, 0xd)) goto l_0x100c_862d; /* jz 0x100c862d */
            ii(0x100c_8620, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100c_8623, 5); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100c_8628, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x100c_862b, 2); jmpd(0x100c_8638, 0xb); goto l_0x100c_8638; /* jmp 0x100c8638 */
        l_0x100c_862d:
            ii(0x100c_862d, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100c_8630, 5); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_8635, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
        l_0x100c_8638:
            ii(0x100c_8638, 4); movsx(eax, memw_a32[ss, ebp - 0x60]);   /* movsx eax, word [ebp-0x60] */
            ii(0x100c_863c, 3); cmp(eax, 0x18);                         /* cmp eax, 0x18 */
            ii(0x100c_863f, 2); if(jgd(0x100c_8662, 0x21)) goto l_0x100c_8662; /* jg 0x100c8662 */
            ii(0x100c_8641, 4); movsx(ebx, memw_a32[ss, ebp - 0x3e]);   /* movsx ebx, word [ebp-0x3e] */
            ii(0x100c_8645, 4); movsx(edx, memw_a32[ss, ebp - 0x40]);   /* movsx edx, word [ebp-0x40] */
            ii(0x100c_8649, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_864c, 5); calld(0x1008_a728, -0x3_df29);          /* call 0x1008a728 */
            ii(0x100c_8651, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_8653, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100c_8655, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_865a, 4); movsx(edx, memw_a32[ss, ebp - 0x60]);   /* movsx edx, word [ebp-0x60] */
            ii(0x100c_865e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_8660, 2); if(jld(0x100c_8667, 0x5)) goto l_0x100c_8667; /* jl 0x100c8667 */
        l_0x100c_8662:
            ii(0x100c_8662, 5); jmpd(0x100c_8718, 0xb1); goto l_0x100c_8718; /* jmp 0x100c8718 */
        l_0x100c_8667:
            ii(0x100c_8667, 4); movsx(edx, memw_a32[ss, ebp - 0x40]);   /* movsx edx, word [ebp-0x40] */
            ii(0x100c_866b, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100c_866e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_8671, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x100c_8674, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_8676, 4); movsx(edx, memw_a32[ss, ebp - 0x3e]);   /* movsx edx, word [ebp-0x3e] */
            ii(0x100c_867a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_867c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_867e, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100c_8680, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_8685, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100c_8688, 2); if(jld(0x100c_86b4, 0x2a)) goto l_0x100c_86b4; /* jl 0x100c86b4 */
            ii(0x100c_868a, 4); movsx(eax, memw_a32[ss, ebp - 0x40]);   /* movsx eax, word [ebp-0x40] */
            ii(0x100c_868e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_8691, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_8693, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_8696, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x100c_8699, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_869b, 4); movsx(edx, memw_a32[ss, ebp - 0x3e]);   /* movsx edx, word [ebp-0x3e] */
            ii(0x100c_869f, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_86a1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_86a3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_86a5, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x100c_86a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_86aa, 3); mov(eax, memd_a32[ds, eax + 0x5]);      /* mov eax, [eax+0x5] */
            ii(0x100c_86ad, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_86b0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_86b2, 2); if(jnzd(0x100c_86b6, 0x2)) goto l_0x100c_86b6; /* jnz 0x100c86b6 */
        l_0x100c_86b4:
            ii(0x100c_86b4, 2); jmpd(0x100c_86cc, 0x16); goto l_0x100c_86cc; /* jmp 0x100c86cc */
        l_0x100c_86b6:
            ii(0x100c_86b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_86b8, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_86bb, 5); calld(0x100a_a3c0, -0x1_e300);          /* call 0x100aa3c0 */
            ii(0x100c_86c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_86c2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_86c5, 5); calld(0x1008_bc9f, -0x3_ca2b);          /* call 0x1008bc9f */
            ii(0x100c_86ca, 2); jmpd(0x100c_873d, 0x71); goto l_0x100c_873d; /* jmp 0x100c873d */
        l_0x100c_86cc:
            ii(0x100c_86cc, 7); and(memd_a32[ss, ebp - 0x60], 0xfe);    /* and dword [ebp-0x60], 0xfe */
            ii(0x100c_86d3, 4); movsx(ebx, memw_a32[ss, ebp - 0x3e]);   /* movsx ebx, word [ebp-0x3e] */
            ii(0x100c_86d7, 4); movsx(edx, memw_a32[ss, ebp - 0x40]);   /* movsx edx, word [ebp-0x40] */
            ii(0x100c_86db, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_86de, 5); calld(0x1008_a728, -0x3_dfbb);          /* call 0x1008a728 */
            ii(0x100c_86e3, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_86e5, 3); test(memb_a32[ds, eax], 0x1);           /* test byte [eax], 0x1 */
            ii(0x100c_86e8, 2); if(jzd(0x100c_86f3, 0x9)) goto l_0x100c_86f3; /* jz 0x100c86f3 */
            ii(0x100c_86ea, 4); movsx(eax, memw_a32[ss, ebp - 0x60]);   /* movsx eax, word [ebp-0x60] */
            ii(0x100c_86ee, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x100c_86f1, 2); if(jled(0x100c_86f5, 0x2)) goto l_0x100c_86f5; /* jle 0x100c86f5 */
        l_0x100c_86f3:
            ii(0x100c_86f3, 2); jmpd(0x100c_8700, 0xb); goto l_0x100c_8700; /* jmp 0x100c8700 */
        l_0x100c_86f5:
            ii(0x100c_86f5, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x100c_86f8, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_86fb, 5); calld(0x100a_aa64, -0x1_dc9c);          /* call 0x100aaa64 */
        l_0x100c_8700:
            ii(0x100c_8700, 4); movsx(ebx, memw_a32[ss, ebp - 0x3e]);   /* movsx ebx, word [ebp-0x3e] */
            ii(0x100c_8704, 4); movsx(edx, memw_a32[ss, ebp - 0x40]);   /* movsx edx, word [ebp-0x40] */
            ii(0x100c_8708, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_870b, 5); calld(0x1008_a728, -0x3_dfe8);          /* call 0x1008a728 */
            ii(0x100c_8710, 3); lea(edx, eax + ebx);                    /* lea edx, [eax+ebx] */
            ii(0x100c_8713, 3); mov(al, memb_a32[ss, ebp - 0x60]);      /* mov al, [ebp-0x60] */
            ii(0x100c_8716, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
        l_0x100c_8718:
            ii(0x100c_8718, 5); jmpd(0x100c_85d1, -0x14c); goto l_0x100c_85d1; /* jmp 0x100c85d1 */
        l_0x100c_871d:
            ii(0x100c_871d, 5); jmpd(0x100c_8553, -0x1cf); goto l_0x100c_8553; /* jmp 0x100c8553 */
        l_0x100c_8722:
            ii(0x100c_8722, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_8725, 4); mov(memb_a32[ds, eax + 0x6], 0x1);      /* mov byte [eax+0x6], 0x1 */
            ii(0x100c_8729, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_872b, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_872e, 5); calld(0x100a_a3c0, -0x1_e373);          /* call 0x100aa3c0 */
            ii(0x100c_8733, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_8735, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_8738, 5); calld(0x1008_bc9f, -0x3_ca9e);          /* call 0x1008bc9f */
        l_0x100c_873d:
            ii(0x100c_873d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_873f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_8740, 1); popd(edi);                              /* pop edi */
            ii(0x100c_8741, 1); popd(esi);                              /* pop esi */
            ii(0x100c_8742, 1); popd(edx);                              /* pop edx */
            ii(0x100c_8743, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_8744, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_8745, 1); retd(); return;                         /* ret */
        }
    }
}
