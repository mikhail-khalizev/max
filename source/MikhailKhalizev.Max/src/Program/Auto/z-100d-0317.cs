using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0317-3e6571e2")]
        public void Method_100d_0317()
        {
            ii(0x100d_0317, 5); push(0x4c);                             /* push 0x4c */
            ii(0x100d_031c, 5); call(Definitions.sys_check_available_stack_size, 0x9_5a31); /* call 0x10165d52 */
            ii(0x100d_0321, 1); push(ebx);                              /* push ebx */
            ii(0x100d_0322, 1); push(ecx);                              /* push ecx */
            ii(0x100d_0323, 1); push(esi);                              /* push esi */
            ii(0x100d_0324, 1); push(edi);                              /* push edi */
            ii(0x100d_0325, 1); push(ebp);                              /* push ebp */
            ii(0x100d_0326, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_0328, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100d_032e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_0331, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_0334, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0337, 3); mov(eax, memd[ds, eax + 0x2c]);         /* mov eax, [eax+0x2c] */
            ii(0x100d_033a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_033d, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100d_0340, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100d_0343, 2); if(jg(0x100d_0361, 0x1c)) goto l_0x100d_0361; /* jg 0x100d0361 */
            ii(0x100d_0345, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0348, 3); mov(edx, memd[ds, eax + 0x2c]);         /* mov edx, [eax+0x2c] */
            ii(0x100d_034b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_034e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0351, 3); mov(eax, memd[ds, eax + 0x26]);         /* mov eax, [eax+0x26] */
            ii(0x100d_0354, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0357, 3); add(edx, 0x2);                          /* add edx, 0x2 */
            ii(0x100d_035a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_035c, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100d_035f, 2); if(jg(0x100d_0366, 0x5)) goto l_0x100d_0366; /* jg 0x100d0366 */
        l_0x100d_0361:
            ii(0x100d_0361, 5); jmp(0x100d_03e5, 0x7f); goto l_0x100d_03e5; /* jmp 0x100d03e5 */
        l_0x100d_0366:
            ii(0x100d_0366, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0369, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_036c, 4); add(dx, memw[ds, eax + 0x24]);          /* add dx, [eax+0x24] */
            ii(0x100d_0370, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_0372, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100d_0375, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_0377, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_037a, 4); sub(dx, memw[ds, eax + 0x2e]);          /* sub dx, [eax+0x2e] */
            ii(0x100d_037e, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
            ii(0x100d_0381, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0384, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_0387, 5); call(Definitions.my_2_get_count, -0x4_5024); /* call 0x1008b368 */
            ii(0x100d_038c, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100d_0390, 2); if(jg(0x100d_039b, 0x9)) goto l_0x100d_039b; /* jg 0x100d039b */
            ii(0x100d_0392, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_0396, 5); jmp(0x100d_060c, 0x271); goto l_0x100d_060c; /* jmp 0x100d060c */
        l_0x100d_039b:
            ii(0x100d_039b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_039e, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_03a1, 4); cmp(ax, memw[ds, edx + 0x26]);          /* cmp ax, [edx+0x26] */
            ii(0x100d_03a5, 2); if(jnz(0x100d_03b6, 0xf)) goto l_0x100d_03b6; /* jnz 0x100d03b6 */
            ii(0x100d_03a7, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_03ac, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_03af, 5); call(0x100d_0617, 0x263);               /* call 0x100d0617 */
            ii(0x100d_03b4, 2); jmp(0x100d_03dc, 0x26); goto l_0x100d_03dc; /* jmp 0x100d03dc */
        l_0x100d_03b6:
            ii(0x100d_03b6, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_03b9, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_03bc, 4); mov(memw[ds, edx + 0x26], ax);          /* mov [edx+0x26], ax */
            ii(0x100d_03c0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_03c3, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_03c6, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_03c9, 3); mov(edx, memd[ds, eax + 0x40]);         /* mov edx, [eax+0x40] */
            ii(0x100d_03cc, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_03cf, 3); call_abs(memd[ds, edx + 0x10]);         /* call dword [edx+0x10] */
            ii(0x100d_03d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_03d4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_03d7, 5); call(0x100d_0617, 0x23b);               /* call 0x100d0617 */
        l_0x100d_03dc:
            ii(0x100d_03dc, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_03e0, 5); jmp(0x100d_060c, 0x227); goto l_0x100d_060c; /* jmp 0x100d060c */
        l_0x100d_03e5:
            ii(0x100d_03e5, 7); cmp(memd[ss, ebp - 0x4], 0x148);        /* cmp dword [ebp-0x4], 0x148 */
            ii(0x100d_03ec, 2); if(jnz(0x100d_0445, 0x57)) goto l_0x100d_0445; /* jnz 0x100d0445 */
            ii(0x100d_03ee, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_03f1, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x100d_03f4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_03f7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_03f9, 2); if(jle(0x100d_043c, 0x41)) goto l_0x100d_043c; /* jle 0x100d043c */
            ii(0x100d_03fb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_03fe, 4); dec(memw[ds, eax + 0x26]);              /* dec word [eax+0x26] */
            ii(0x100d_0402, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0405, 4); mov(dx, memw[ds, eax + 0x26]);          /* mov dx, [eax+0x26] */
            ii(0x100d_0409, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_040c, 4); cmp(dx, memw[ds, eax + 0x24]);          /* cmp dx, [eax+0x24] */
            ii(0x100d_0410, 2); if(jge(0x100d_0420, 0xe)) goto l_0x100d_0420; /* jge 0x100d0420 */
            ii(0x100d_0412, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0415, 4); mov(dx, memw[ds, eax + 0x26]);          /* mov dx, [eax+0x26] */
            ii(0x100d_0419, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_041c, 4); mov(memw[ds, eax + 0x24], dx);          /* mov [eax+0x24], dx */
        l_0x100d_0420:
            ii(0x100d_0420, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0423, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_0426, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_0429, 3); mov(edx, memd[ds, eax + 0x40]);         /* mov edx, [eax+0x40] */
            ii(0x100d_042c, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_042f, 3); call_abs(memd[ds, edx + 0x10]);         /* call dword [edx+0x10] */
            ii(0x100d_0432, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_0434, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0437, 5); call(0x100d_0617, 0x1db);               /* call 0x100d0617 */
        l_0x100d_043c:
            ii(0x100d_043c, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_0440, 5); jmp(0x100d_060c, 0x1c7); goto l_0x100d_060c; /* jmp 0x100d060c */
        l_0x100d_0445:
            ii(0x100d_0445, 7); cmp(memd[ss, ebp - 0x4], 0x150);        /* cmp dword [ebp-0x4], 0x150 */
            ii(0x100d_044c, 6); if(jnz(0x100d_04d4, 0x82)) goto l_0x100d_04d4; /* jnz 0x100d04d4 */
            ii(0x100d_0452, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0455, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_0458, 5); call(Definitions.my_2_get_count, -0x4_50f5); /* call 0x1008b368 */
            ii(0x100d_045d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_0460, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0463, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x100d_0466, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0469, 1); dec(edx);                               /* dec edx */
            ii(0x100d_046a, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100d_046c, 2); if(jge(0x100d_04cb, 0x5d)) goto l_0x100d_04cb; /* jge 0x100d04cb */
            ii(0x100d_046e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0471, 4); inc(memw[ds, eax + 0x26]);              /* inc word [eax+0x26] */
            ii(0x100d_0475, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0478, 3); mov(edx, memd[ds, eax + 0x22]);         /* mov edx, [eax+0x22] */
            ii(0x100d_047b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_047e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0481, 3); mov(eax, memd[ds, eax + 0x26]);         /* mov eax, [eax+0x26] */
            ii(0x100d_0484, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0487, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_0489, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_048c, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x100d_048f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0492, 1); dec(edx);                               /* dec edx */
            ii(0x100d_0493, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100d_0495, 2); if(jle(0x100d_04af, 0x18)) goto l_0x100d_04af; /* jle 0x100d04af */
            ii(0x100d_0497, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_049a, 4); mov(ax, memw[ds, eax + 0x26]);          /* mov ax, [eax+0x26] */
            ii(0x100d_049e, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_04a1, 4); sub(ax, memw[ds, edx + 0x28]);          /* sub ax, [edx+0x28] */
            ii(0x100d_04a5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_04a7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_04aa, 1); inc(edx);                               /* inc edx */
            ii(0x100d_04ab, 4); mov(memw[ds, eax + 0x24], dx);          /* mov [eax+0x24], dx */
        l_0x100d_04af:
            ii(0x100d_04af, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_04b2, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_04b5, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_04b8, 3); mov(edx, memd[ds, eax + 0x40]);         /* mov edx, [eax+0x40] */
            ii(0x100d_04bb, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_04be, 3); call_abs(memd[ds, edx + 0x10]);         /* call dword [edx+0x10] */
            ii(0x100d_04c1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_04c3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_04c6, 5); call(0x100d_0617, 0x14c);               /* call 0x100d0617 */
        l_0x100d_04cb:
            ii(0x100d_04cb, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_04cf, 5); jmp(0x100d_060c, 0x138); goto l_0x100d_060c; /* jmp 0x100d060c */
        l_0x100d_04d4:
            ii(0x100d_04d4, 7); cmp(memd[ss, ebp - 0x4], 0x151);        /* cmp dword [ebp-0x4], 0x151 */
            ii(0x100d_04db, 2); if(jz(0x100d_04f0, 0x13)) goto l_0x100d_04f0; /* jz 0x100d04f0 */
            ii(0x100d_04dd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_04e0, 3); mov(eax, memd[ds, eax + 0x2c]);         /* mov eax, [eax+0x2c] */
            ii(0x100d_04e3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_04e6, 1); inc(eax);                               /* inc eax */
            ii(0x100d_04e7, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100d_04ea, 6); if(jnz(0x100d_056c, 0x7c)) goto l_0x100d_056c; /* jnz 0x100d056c */
        l_0x100d_04f0:
            ii(0x100d_04f0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_04f3, 4); mov(ax, memw[ds, eax + 0x28]);          /* mov ax, [eax+0x28] */
            ii(0x100d_04f7, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100d_04fa:
            ii(0x100d_04fa, 3); dec(memd[ss, ebp - 0x20]);              /* dec dword [ebp-0x20] */
            ii(0x100d_04fd, 5); cmp(memw[ss, ebp - 0x20], -0x1 /* 0xff */); /* cmp word [ebp-0x20], 0xffff */
            ii(0x100d_0502, 2); if(jz(0x100d_0563, 0x5f)) goto l_0x100d_0563; /* jz 0x100d0563 */
            ii(0x100d_0504, 5); call(0x1014_82f4, 0x7_7deb);            /* call 0x101482f4 */
            ii(0x100d_0509, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_050c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_050f, 4); inc(memw[ds, eax + 0x24]);              /* inc word [eax+0x24] */
            ii(0x100d_0513, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0516, 3); mov(edx, memd[ds, eax + 0x22]);         /* mov edx, [eax+0x22] */
            ii(0x100d_0519, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_051c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_051f, 3); mov(eax, memd[ds, eax + 0x26]);         /* mov eax, [eax+0x26] */
            ii(0x100d_0522, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0525, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_0527, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_052a, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_052d, 5); call(Definitions.my_2_get_count, -0x4_51ca); /* call 0x1008b368 */
            ii(0x100d_0532, 1); cwde();                                 /* cwde */
            ii(0x100d_0533, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_0535, 2); if(jle(0x100d_0540, 0x9)) goto l_0x100d_0540; /* jle 0x100d0540 */
            ii(0x100d_0537, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_053a, 4); dec(memw[ds, eax + 0x24]);              /* dec word [eax+0x24] */
            ii(0x100d_053e, 2); jmp(0x100d_0563, 0x23); goto l_0x100d_0563; /* jmp 0x100d0563 */
        l_0x100d_0540:
            ii(0x100d_0540, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0543, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_0546, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100d_0549, 3); mov(edx, memd[ds, eax + 0x40]);         /* mov edx, [eax+0x40] */
            ii(0x100d_054c, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100d_054f, 3); call_abs(memd[ds, edx + 0x10]);         /* call dword [edx+0x10] */
        l_0x100d_0552:
            ii(0x100d_0552, 5); call(0x1014_82f4, 0x7_7d9d);            /* call 0x101482f4 */
            ii(0x100d_0557, 3); sub(eax, memd[ss, ebp - 0x24]);         /* sub eax, [ebp-0x24] */
            ii(0x100d_055a, 5); cmp(eax, 0x6119);                       /* cmp eax, 0x6119 */
            ii(0x100d_055f, 2); if(jb(0x100d_0552, -0xf)) goto l_0x100d_0552; /* jb 0x100d0552 */
            ii(0x100d_0561, 2); jmp(0x100d_04fa, -0x69); goto l_0x100d_04fa; /* jmp 0x100d04fa */
        l_0x100d_0563:
            ii(0x100d_0563, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_0567, 5); jmp(0x100d_060c, 0xa0); goto l_0x100d_060c; /* jmp 0x100d060c */
        l_0x100d_056c:
            ii(0x100d_056c, 7); cmp(memd[ss, ebp - 0x4], 0x149);        /* cmp dword [ebp-0x4], 0x149 */
            ii(0x100d_0573, 2); if(jz(0x100d_0583, 0xe)) goto l_0x100d_0583; /* jz 0x100d0583 */
            ii(0x100d_0575, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0578, 3); mov(eax, memd[ds, eax + 0x2c]);         /* mov eax, [eax+0x2c] */
            ii(0x100d_057b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_057e, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100d_0581, 2); if(jnz(0x100d_05db, 0x58)) goto l_0x100d_05db; /* jnz 0x100d05db */
        l_0x100d_0583:
            ii(0x100d_0583, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0586, 4); mov(ax, memw[ds, eax + 0x28]);          /* mov ax, [eax+0x28] */
            ii(0x100d_058a, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
        l_0x100d_058d:
            ii(0x100d_058d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0590, 5); cmp(memw[ds, eax + 0x24], 0);           /* cmp word [eax+0x24], 0x0 */
            ii(0x100d_0595, 2); if(jz(0x100d_05a1, 0xa)) goto l_0x100d_05a1; /* jz 0x100d05a1 */
            ii(0x100d_0597, 3); dec(memd[ss, ebp - 0x2c]);              /* dec dword [ebp-0x2c] */
            ii(0x100d_059a, 5); cmp(memw[ss, ebp - 0x2c], -0x1 /* 0xff */); /* cmp word [ebp-0x2c], 0xffff */
            ii(0x100d_059f, 2); if(jnz(0x100d_05a3, 0x2)) goto l_0x100d_05a3; /* jnz 0x100d05a3 */
        l_0x100d_05a1:
            ii(0x100d_05a1, 2); jmp(0x100d_05d5, 0x32); goto l_0x100d_05d5; /* jmp 0x100d05d5 */
        l_0x100d_05a3:
            ii(0x100d_05a3, 5); call(0x1014_82f4, 0x7_7d4c);            /* call 0x101482f4 */
            ii(0x100d_05a8, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100d_05ab, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_05ae, 4); dec(memw[ds, eax + 0x24]);              /* dec word [eax+0x24] */
            ii(0x100d_05b2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_05b5, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100d_05b8, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_05bb, 3); mov(edx, memd[ds, eax + 0x40]);         /* mov edx, [eax+0x40] */
            ii(0x100d_05be, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_05c1, 3); call_abs(memd[ds, edx + 0x10]);         /* call dword [edx+0x10] */
        l_0x100d_05c4:
            ii(0x100d_05c4, 5); call(0x1014_82f4, 0x7_7d2b);            /* call 0x101482f4 */
            ii(0x100d_05c9, 3); sub(eax, memd[ss, ebp - 0x30]);         /* sub eax, [ebp-0x30] */
            ii(0x100d_05cc, 5); cmp(eax, 0x6119);                       /* cmp eax, 0x6119 */
            ii(0x100d_05d1, 2); if(jb(0x100d_05c4, -0xf)) goto l_0x100d_05c4; /* jb 0x100d05c4 */
            ii(0x100d_05d3, 2); jmp(0x100d_058d, -0x48); goto l_0x100d_058d; /* jmp 0x100d058d */
        l_0x100d_05d5:
            ii(0x100d_05d5, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_05d9, 2); jmp(0x100d_060c, 0x31); goto l_0x100d_060c; /* jmp 0x100d060c */
        l_0x100d_05db:
            ii(0x100d_05db, 7); cmp(memd[ss, ebp - 0x4], 0x7000);       /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x100d_05e2, 2); if(jl(0x100d_0608, 0x24)) goto l_0x100d_0608; /* jl 0x100d0608 */
            ii(0x100d_05e4, 7); add(memd[ss, ebp - 0x4], 0xffff_9000);  /* add dword [ebp-0x4], 0xffff9000 */
            ii(0x100d_05eb, 4); cmp(memd[ss, ebp - 0x4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100d_05ef, 2); if(jz(0x100d_05f7, 0x6)) goto l_0x100d_05f7; /* jz 0x100d05f7 */
            ii(0x100d_05f1, 4); cmp(memd[ss, ebp - 0x4], 0x1);          /* cmp dword [ebp-0x4], 0x1 */
            ii(0x100d_05f5, 2); if(jnz(0x100d_0608, 0x11)) goto l_0x100d_0608; /* jnz 0x100d0608 */
        l_0x100d_05f7:
            ii(0x100d_05f7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_05fa, 3); mov(eax, memd[ds, eax + 0x38]);         /* mov eax, [eax+0x38] */
            ii(0x100d_05fd, 5); call(0x100c_fbbe, -0xa44);              /* call 0x100cfbbe */
            ii(0x100d_0602, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_0606, 2); jmp(0x100d_060c, 0x4); goto l_0x100d_060c; /* jmp 0x100d060c */
        l_0x100d_0608:
            ii(0x100d_0608, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x100d_060c:
            ii(0x100d_060c, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100d_060f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_0611, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_0612, 1); pop(edi);                               /* pop edi */
            ii(0x100d_0613, 1); pop(esi);                               /* pop esi */
            ii(0x100d_0614, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_0615, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_0616, 1); ret();                                  /* ret */
        }
    }
}
