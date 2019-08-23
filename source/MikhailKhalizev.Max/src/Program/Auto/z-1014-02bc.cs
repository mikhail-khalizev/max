using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_02bc-1e0656ff")]
        public void Method_1014_02bc()
        {
            ii(0x1014_02bc, 5); push(0x8c);                             /* push 0x8c */
            ii(0x1014_02c1, 5); call(Definitions.sys_check_available_stack_size, 0x2_5a8c); /* call 0x10165d52 */
            ii(0x1014_02c6, 1); push(esi);                              /* push esi */
            ii(0x1014_02c7, 1); push(edi);                              /* push edi */
            ii(0x1014_02c8, 1); push(ebp);                              /* push ebp */
            ii(0x1014_02c9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_02cb, 6); sub(esp, 0x58);                         /* sub esp, 0x58 */
            ii(0x1014_02d1, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_02d4, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1014_02d7, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1014_02da, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1014_02dd, 5); call(0x1014_1674, 0x1392);              /* call 0x10141674 */
            ii(0x1014_02e2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_02e5, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_02e8, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_02eb, 5); call(0x1014_160c, 0x131c);              /* call 0x1014160c */
            ii(0x1014_02f0, 3); sub(eax, 0x1c);                         /* sub eax, 0x1c */
            ii(0x1014_02f3, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_02f6, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1014_02f9, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_02fc, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_02ff, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1014_0302, 5); call(0x100e_9408, -0x5_6eff);           /* call 0x100e9408 */
            ii(0x1014_0307, 3); sub(eax, 0x3e);                         /* sub eax, 0x3e */
            ii(0x1014_030a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_030d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1014_0310, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_0313, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_0316, 7); mov(memd[ds, eax + 0x46], 0x101b_7030); /* mov dword [eax+0x46], 0x101b7030 */
            ii(0x1014_031d, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1014_0322, 5); call(/* sys */ 0x1016_a24c, 0x2_9f25);  /* call 0x1016a24c */
            ii(0x1014_0327, 5); mov(ecx, 0x6);                          /* mov ecx, 0x6 */
            ii(0x1014_032c, 3); mov(edi, memd[ss, ebp - 0x10]);         /* mov edi, [ebp-0x10] */
            ii(0x1014_032f, 3); mov(esi, memd[ss, ebp - 0xc]);          /* mov esi, [ebp-0xc] */
            ii(0x1014_0332, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x1014_0334, 2); movsw();                                /* movsw */
            ii(0x1014_0336, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0339, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_033c, 4); mov(memw[ds, edx + 0x3a], ax);          /* mov [edx+0x3a], ax */
            ii(0x1014_0340, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1014_0343, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_0346, 4); mov(memw[ds, edx + 0x3c], ax);          /* mov [edx+0x3c], ax */
            ii(0x1014_034a, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1014_034d, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_0350, 4); mov(memw[ds, edx + 0x38], ax);          /* mov [edx+0x38], ax */
            ii(0x1014_0354, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0357, 5); call(0x1008_ad90, -0xb_55cc);           /* call 0x1008ad90 */
            ii(0x1014_035c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_035e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_0361, 4); mov(memw[ds, eax + 0x1a], dx);          /* mov [eax+0x1a], dx */
            ii(0x1014_0365, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_0368, 3); mov(edx, memd[ds, edx + 0xc]);          /* mov edx, [edx+0xc] */
            ii(0x1014_036b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_036e, 3); sub(edx, memd[ds, eax + 0x4]);          /* sub edx, [eax+0x4] */
            ii(0x1014_0371, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1014_0377, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_0379, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_037b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_037d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_0380, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1014_0382, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0384, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_0387, 4); mov(memw[ds, eax + 0x2a], dx);          /* mov [eax+0x2a], dx */
            ii(0x1014_038b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_038e, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x1014_0392, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_0395, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x1014_0398, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1014_039b, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1014_03a1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_03a3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_03a6, 5); imul(dx, memw[ds, eax + 0x2a]);         /* imul dx, [eax+0x2a] */
            ii(0x1014_03ab, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1014_03ad, 3); mov(memd[ss, ebp - 0x20], edx);         /* mov [ebp-0x20], edx */
            ii(0x1014_03b0, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1014_03b5, 5); call(Definitions.sys_new, 0x2_5a46);    /* call 0x10165e00 */
            ii(0x1014_03ba, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_03bd, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1014_03c0, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1014_03c3, 4); cmp(memd[ss, ebp - 0x28], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1014_03c7, 2); if(jz(0x1014_03e9, 0x20)) goto l_0x1014_03e9; /* jz 0x101403e9 */
            ii(0x1014_03c9, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1014_03cd, 1); push(eax);                              /* push eax */
            ii(0x1014_03ce, 4); movsx(ecx, memw[ss, ebp - 0x1c]);       /* movsx ecx, word [ebp-0x1c] */
            ii(0x1014_03d2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_03d4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_03d6, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1014_03d9, 5); call(0x100d_7bdc, -0x6_8802);           /* call 0x100d7bdc */
            ii(0x1014_03de, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1014_03e1, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1014_03e4, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1014_03e7, 2); jmp(0x1014_03ef, 0x6); goto l_0x1014_03ef; /* jmp 0x101403ef */
        l_0x1014_03e9:
            ii(0x1014_03e9, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1014_03ec, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
        l_0x1014_03ef:
            ii(0x1014_03ef, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1014_03f2, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_03f5, 3); mov(memd[ds, edx + 0x2c], eax);         /* mov [edx+0x2c], eax */
            ii(0x1014_03f8, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_03fb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_03fe, 3); mov(eax, memd[ds, eax + 0x2c]);         /* mov eax, [eax+0x2c] */
            ii(0x1014_0401, 5); call(0x100d_7d74, -0x6_8692);           /* call 0x100d7d74 */
            ii(0x1014_0406, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1014_040b, 5); call(Definitions.sys_new, 0x2_59f0);    /* call 0x10165e00 */
            ii(0x1014_0410, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1014_0413, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1014_0416, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1014_0419, 4); cmp(memd[ss, ebp - 0x38], 0);           /* cmp dword [ebp-0x38], 0x0 */
            ii(0x1014_041d, 2); if(jz(0x1014_0447, 0x28)) goto l_0x1014_0447; /* jz 0x10140447 */
            ii(0x1014_041f, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1014_0424, 1); push(eax);                              /* push eax */
            ii(0x1014_0425, 5); mov(ecx, 0x150);                        /* mov ecx, 0x150 */
            ii(0x1014_042a, 5); mov(ebx, 0x11b);                        /* mov ebx, 0x11b */
            ii(0x1014_042f, 5); mov(edx, 0x11a);                        /* mov edx, 0x11a */
            ii(0x1014_0434, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1014_0437, 5); call(Definitions.my_ctor_c17, -0x7_202d); /* call 0x100ce40f */
            ii(0x1014_043c, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1014_043f, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1014_0442, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1014_0445, 2); jmp(0x1014_044d, 0x6); goto l_0x1014_044d; /* jmp 0x1014044d */
        l_0x1014_0447:
            ii(0x1014_0447, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1014_044a, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
        l_0x1014_044d:
            ii(0x1014_044d, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1014_0450, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_0453, 3); mov(memd[ds, edx + 0x30], eax);         /* mov [edx+0x30], eax */
            ii(0x1014_0456, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1014_045b, 5); call(Definitions.sys_new, 0x2_59a0);    /* call 0x10165e00 */
            ii(0x1014_0460, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1014_0463, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1014_0466, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1014_0469, 4); cmp(memd[ss, ebp - 0x48], 0);           /* cmp dword [ebp-0x48], 0x0 */
            ii(0x1014_046d, 2); if(jz(0x1014_0497, 0x28)) goto l_0x1014_0497; /* jz 0x10140497 */
            ii(0x1014_046f, 5); mov(eax, 0xe9);                         /* mov eax, 0xe9 */
            ii(0x1014_0474, 1); push(eax);                              /* push eax */
            ii(0x1014_0475, 5); mov(ecx, 0x150);                        /* mov ecx, 0x150 */
            ii(0x1014_047a, 5); mov(ebx, 0x11e);                        /* mov ebx, 0x11e */
            ii(0x1014_047f, 5); mov(edx, 0x11d);                        /* mov edx, 0x11d */
            ii(0x1014_0484, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1014_0487, 5); call(Definitions.my_ctor_c17, -0x7_207d); /* call 0x100ce40f */
            ii(0x1014_048c, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1014_048f, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1014_0492, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1014_0495, 2); jmp(0x1014_049d, 0x6); goto l_0x1014_049d; /* jmp 0x1014049d */
        l_0x1014_0497:
            ii(0x1014_0497, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1014_049a, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
        l_0x1014_049d:
            ii(0x1014_049d, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x1014_04a0, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_04a3, 3); mov(memd[ds, edx + 0x34], eax);         /* mov [edx+0x34], eax */
            ii(0x1014_04a6, 5); mov(edx, 0x11c);                        /* mov edx, 0x11c */
            ii(0x1014_04ab, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_04ae, 3); mov(eax, memd[ds, eax + 0x30]);         /* mov eax, [eax+0x30] */
            ii(0x1014_04b1, 5); call(0x100c_f2ba, -0x7_11fc);           /* call 0x100cf2ba */
            ii(0x1014_04b6, 5); mov(edx, 0x11f);                        /* mov edx, 0x11f */
            ii(0x1014_04bb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_04be, 3); mov(eax, memd[ds, eax + 0x34]);         /* mov eax, [eax+0x34] */
            ii(0x1014_04c1, 5); call(0x100c_f2ba, -0x7_120c);           /* call 0x100cf2ba */
            ii(0x1014_04c6, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_04c9, 3); mov(edx, memd[ds, eax + 0x38]);         /* mov edx, [eax+0x38] */
            ii(0x1014_04cc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_04cf, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_04d2, 3); mov(eax, memd[ds, eax + 0x30]);         /* mov eax, [eax+0x30] */
            ii(0x1014_04d5, 5); call(0x100d_5164, -0x6_b376);           /* call 0x100d5164 */
            ii(0x1014_04da, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_04dd, 3); mov(edx, memd[ds, eax + 0x3a]);         /* mov edx, [eax+0x3a] */
            ii(0x1014_04e0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_04e3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_04e6, 3); mov(eax, memd[ds, eax + 0x34]);         /* mov eax, [eax+0x34] */
            ii(0x1014_04e9, 5); call(0x100d_5164, -0x6_b38a);           /* call 0x100d5164 */
            ii(0x1014_04ee, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_04f1, 3); mov(edx, memd[ds, eax + 0x12]);         /* mov edx, [eax+0x12] */
            ii(0x1014_04f4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_04f7, 3); mov(eax, memd[ds, eax + 0x30]);         /* mov eax, [eax+0x30] */
            ii(0x1014_04fa, 5); call(0x100c_f85c, -0x7_0ca3);           /* call 0x100cf85c */
            ii(0x1014_04ff, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_0502, 3); mov(edx, memd[ds, eax + 0x12]);         /* mov edx, [eax+0x12] */
            ii(0x1014_0505, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_0508, 3); mov(eax, memd[ds, eax + 0x34]);         /* mov eax, [eax+0x34] */
            ii(0x1014_050b, 5); call(0x100c_f85c, -0x7_0cb4);           /* call 0x100cf85c */
            ii(0x1014_0510, 7); mov(memd[ss, ebp - 0x54], 0);           /* mov dword [ebp-0x54], 0x0 */
            ii(0x1014_0517, 2); jmp(0x1014_051f, 0x6); goto l_0x1014_051f; /* jmp 0x1014051f */
        l_0x1014_0519:
            ii(0x1014_0519, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1014_051c, 3); inc(memd[ss, ebp - 0x54]);              /* inc dword [ebp-0x54] */
        l_0x1014_051f:
            ii(0x1014_051f, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1014_0522, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_0525, 4); cmp(ax, memw[ds, edx + 0x2a]);          /* cmp ax, [edx+0x2a] */
            ii(0x1014_0529, 2); if(jge(0x1014_0587, 0x5c)) goto l_0x1014_0587; /* jge 0x10140587 */
            ii(0x1014_052b, 2); push(0);                                /* push 0x0 */
            ii(0x1014_052d, 2); push(0);                                /* push 0x0 */
            ii(0x1014_052f, 2); push(0);                                /* push 0x0 */
            ii(0x1014_0531, 2); push(0);                                /* push 0x0 */
            ii(0x1014_0533, 4); movsx(eax, memw[ss, ebp + 0x14]);       /* movsx eax, word [ebp+0x14] */
            ii(0x1014_0537, 4); movsx(edx, memw[ss, ebp - 0x54]);       /* movsx edx, word [ebp-0x54] */
            ii(0x1014_053b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_053d, 1); push(eax);                              /* push eax */
            ii(0x1014_053e, 2); push(-0x1 /* 0xff */);                  /* push 0xffffffff */
            ii(0x1014_0540, 2); push(-0x1 /* 0xff */);                  /* push 0xffffffff */
            ii(0x1014_0542, 2); push(-0x1 /* 0xff */);                  /* push 0xffffffff */
            ii(0x1014_0544, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1014_054a, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_054c, 1); push(eax);                              /* push eax */
            ii(0x1014_054d, 4); movsx(ecx, memw[ss, ebp - 0x1c]);       /* movsx ecx, word [ebp-0x1c] */
            ii(0x1014_0551, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1014_0557, 4); movsx(edx, memw[ss, ebp - 0x54]);       /* movsx edx, word [ebp-0x54] */
            ii(0x1014_055b, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1014_055e, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_0560, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_0562, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_0565, 3); add(ebx, memd[ds, eax + 0x4]);          /* add ebx, [eax+0x4] */
            ii(0x1014_0568, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_056b, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1014_056d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_0570, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1014_0573, 5); call(/* sys */ 0x1016_86b0, 0x2_8138);  /* call 0x101686b0 */
            ii(0x1014_0578, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_057a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_057d, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1014_0580, 5); call(0x100e_9450, -0x5_7135);           /* call 0x100e9450 */
            ii(0x1014_0585, 2); jmp(0x1014_0519, -0x6e); goto l_0x1014_0519; /* jmp 0x10140519 */
        l_0x1014_0587:
            ii(0x1014_0587, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_058a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_058d, 5); call(0x1014_0bcd, 0x63b);               /* call 0x10140bcd */
            ii(0x1014_0592, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_0595, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x1014_0598, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1014_059b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_059d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_059e, 1); pop(edi);                               /* pop edi */
            ii(0x1014_059f, 1); pop(esi);                               /* pop esi */
            ii(0x1014_05a0, 3); ret(0x8);                               /* ret 0x8 */
        }
    }
}
